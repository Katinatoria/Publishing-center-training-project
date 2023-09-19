using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UP0201_Publishing_Center
{
    public partial class authorization : Form
    {
        string text;
        int counter = 0;
        public authorization()
        {
            InitializeComponent();
        }

        private Bitmap CreateImage(int Width, int Height) //Метод для генерации капчи
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = 10;
            int Ypos = 10;

            //Добавим различные цвета ддя текста
            Brush[] colors = {
             Brushes.Black,
             Brushes.Red,
             Brushes.RoyalBlue,
             Brushes.Green,
             Brushes.Yellow,
             Brushes.White,
             Brushes.Tomato,
             Brushes.Sienna,
             Brushes.Pink };

            //Добавим различные цвета линий
            Pen[] colorpens = {
             Pens.Black,
             Pens.Red,
             Pens.RoyalBlue,
             Pens.Green,
             Pens.Yellow,
             Pens.White,
             Pens.Tomato,
             Pens.Sienna,
             Pens.Pink };

            //Делаем случайный стиль текста
            FontStyle[] fontstyle = {
             FontStyle.Bold,
             FontStyle.Italic,
             FontStyle.Regular,
             FontStyle.Strikeout,
             FontStyle.Underline};

            //Добавим различные углы поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Делаем случайный угол поворота текста
            g.RotateTransform(rnd.Next(rotate.Length));

            //Генерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            //Линии из углов
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            //Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        public string check_role(string log, string pas) // Метод для определения роли пользователя
        {
            string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
            SqlConnection myConnection = new SqlConnection(MyConString);

            // узнаём, какая роль присвоена пользователю в БД, чтобф перекинуть на нужную форму 
            string checkCommand2 = "SELECT id_тип_пользователя FROM Пользователи WHERE Логин = @login AND Пароль = @password";
            SqlParameter plog2 = new SqlParameter("@login", log);
            SqlParameter pPass2 = new SqlParameter("@password", pas);
            SqlCommand cmdCheck2 = new SqlCommand(checkCommand2, myConnection);
            cmdCheck2.Parameters.Add(plog2);
            cmdCheck2.Parameters.Add(pPass2);
            myConnection.Open();
            string result_type;
            result_type = cmdCheck2.ExecuteScalar().ToString();
            myConnection.Close();

            return result_type; 
        }

        public string check_existence_user(string log, string pas) // Метод для определения роли пользователя
        {
            string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
            SqlConnection myConnection = new SqlConnection(MyConString);

            string checkCommand = "select count(*) from Пользователи where Логин=@login and Пароль=@password";
            SqlParameter plog = new SqlParameter("@login", log);
            SqlParameter pPass = new SqlParameter("@password", pas);
            SqlCommand cmdCheck = new SqlCommand(checkCommand, myConnection);
            cmdCheck.Parameters.Add(plog);
            cmdCheck.Parameters.Add(pPass);
            myConnection.Open();
            string result;
            result = cmdCheck.ExecuteScalar().ToString();
            myConnection.Close();

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '\0';

            button1.Visible = true;
            button2.Visible = false;
        }

        public void btn_log_in_Click(object sender, EventArgs e)
        {

            string result = check_existence_user(textBox_login.Text, textBox_password.Text);


            if (result == "1")
            {
                authorization authorization = new authorization();
                authorization.Close();

                string result_type = check_role(textBox_login.Text, textBox_password.Text);

                switch (result_type)
                {

                    case "1": //Администратор
                        administrator administrator = new administrator();
                        administrator.Show(); //форма пользователя, делать закаp
                        break;
                    case "2": //Менеджер
                        manager manager = new manager();
                        manager.Show(); //форма пользователя, делать закаp
                        break;
                }

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                btn_log_in.Enabled = false;
                pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);

            }

        }

        private void button_capcha_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter < 2)
            {
                if (textBox_capcha.Text == this.text)
                    MessageBox.Show("Верно!");

                else
                    pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
            }
            else
            {
                MessageBox.Show("Превышено максимальное количество попыток входа в систему.");
                btn_log_in.Enabled = false;
                button_capcha.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '●';

            button1.Visible = false;
            button2.Visible = true;
        }
    }
}
