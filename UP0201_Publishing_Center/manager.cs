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
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        public string search_id_writer(string name_writer) // Метод для нахождения id писателя по его имени
        {
            //id писателя
            string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
            SqlConnection myConnection = new SqlConnection(MyConString);
            string checkID = "select id from Писатели where ФИО=@Name_writer";
            SqlParameter name_from_tb = new SqlParameter("@Name_writer", name_writer);
            SqlCommand cmdCheck = new SqlCommand(checkID, myConnection);
            cmdCheck.Parameters.Add(name_from_tb);
            myConnection.Open();
            string result_writer_id;
            result_writer_id = cmdCheck.ExecuteScalar().ToString();
            myConnection.Close();

            return result_writer_id;
        }

        public string search_id_contract(string writer_id) // Метод для нахождения id контракта по id писателя
        {

            string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
            SqlConnection myConnection = new SqlConnection(MyConString);
            //ID контракта по ID писателя
            string check_id_contract = "select ID_контракта from Писатели where ID=@id_writer";
            SqlParameter p_id_writer = new SqlParameter("@id_writer", writer_id);
            SqlCommand contract_check = new SqlCommand(check_id_contract, myConnection);
            contract_check.Parameters.Add(p_id_writer);
            myConnection.Open();
            string result_id_contract = contract_check.ExecuteScalar().ToString(); //сумма общего гонорара за книгу
            myConnection.Close();

            return result_id_contract;
        }

        public string search_id_book(string book_name) // Метод для нахождения id контракта по id писателя
        {
            string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
            SqlConnection myConnection = new SqlConnection(MyConString);

            string check_id_book = "select id from Книги where название=@book_name";
            SqlParameter p_book_name2 = new SqlParameter("@book_name", book_name);
            SqlCommand book_check2 = new SqlCommand(check_id_book, myConnection);
            book_check2.Parameters.Add(p_book_name2);
            myConnection.Open();
            string result_id_book = book_check2.ExecuteScalar().ToString(); //id книги
            myConnection.Close();

            return result_id_book;
        }


        public string search_fee(string book_name) // Метод для нахождения id контракта по id писателя
        {
            string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
            SqlConnection myConnection = new SqlConnection(MyConString);

            //общий гонорар по названию книги
            string check_fee = "select общий_гонорар from Книги where название=@book_name";
            SqlParameter p_book_name = new SqlParameter("@book_name", book_name);
            SqlCommand book_check = new SqlCommand(check_fee, myConnection);
            book_check.Parameters.Add(p_book_name);
            myConnection.Open();
            string result_fee = book_check.ExecuteScalar().ToString(); //сумма общего гонорара за книгу
            myConnection.Close();

            return result_fee;
        }


        public string quantity_authors(string id_book) // Метод для нахождения количества авторов по книге и автору 
        {
            string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
            SqlConnection myConnection = new SqlConnection(MyConString);
           
            //количество авторов 
            string check_count = "select count(id_автора) from Книга_авторы where id_книги=@id_book";
            SqlParameter p_count_authors = new SqlParameter("@id_book", id_book);
            //SqlParameter p_id_a = new SqlParameter("@id_authors", writer_id);
            SqlCommand authors_check = new SqlCommand(check_count, myConnection);
            authors_check.Parameters.Add(p_count_authors);
            //authors_check.Parameters.Add(p_id_a);
            myConnection.Open();
            string result_count = authors_check.ExecuteScalar().ToString();
            myConnection.Close();
            
            return result_count;
        }

        public string calculate_fee()
        {
            try
            {
                string result_writer_id = search_id_writer(comboBox_Name_writer.Text);

                string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
                SqlConnection myConnection = new SqlConnection(MyConString);

                string all_fee_book = search_fee(comboBox_book.Text);
                string id_book = search_id_book(comboBox_book.Text);
                string count_auth = quantity_authors(id_book);


                Decimal fee = Decimal.Parse(all_fee_book);
                Decimal count = Decimal.Parse(count_auth);
                Decimal fee_particular_authors = fee / count;
                return string.Format("{0:C2}", fee_particular_authors); // форматирование валюты через C
            }
            catch
            {
                MessageBox.Show("Возникло исключение!");
                return "";
            }
        }

        public string calculate_contract()
        {
            try
            {
                string result_writer_id = search_id_writer(comboBox_Name_writer.Text);

                string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
                SqlConnection myConnection = new SqlConnection(MyConString);

                string result_id_contract = search_id_contract(result_writer_id);

                string check_term = "select срок from Контракты where номер_контракта=@id_contract";
                SqlParameter p_id_contract= new SqlParameter("@id_contract", result_id_contract);
                SqlCommand term_check = new SqlCommand(check_term, myConnection);
                term_check.Parameters.Add(p_id_contract);
                myConnection.Open();
                string result_term_contract = term_check.ExecuteScalar().ToString(); //сумма общего гонорара за книгу
                myConnection.Close();


                return result_term_contract;
            }

            catch
            {
                MessageBox.Show("Возникло исключение!");
                return "";
            }
        }

        public string terminated_y_or_n()
        {
            try
            {
                string result_writer_id = search_id_writer(comboBox_Name_writer.Text);

                string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
                SqlConnection myConnection = new SqlConnection(MyConString);

                string result_id_contract = search_id_contract(result_writer_id);

                string check_year = "select расторгнут from Контракты where номер_контракта=@id_contract";
                SqlParameter p_id_contract = new SqlParameter("@id_contract", result_id_contract);
                SqlCommand year_check = new SqlCommand(check_year, myConnection);
                year_check.Parameters.Add(p_id_contract);
                myConnection.Open();
                string result_year_contract = year_check.ExecuteScalar().ToString(); //сумма общего гонорара за книгу
                myConnection.Close();

                return result_year_contract;
            }

            catch
            {
                MessageBox.Show("Возникло исключение!");
                return "";
            }
        }

        public string count_ended_books()
        {
            try
            {
                string result_writer_id = search_id_writer(comboBox_Name_writer.Text);

                string MyConString = @"Data Source = DESKTOP-SQIJLCI; Initial Catalog = Издательский_центр; Integrated Security = true";
                SqlConnection myConnection = new SqlConnection(MyConString);

                string checkCountBooks = "select count(id_книги) from Книга_авторы where id_автора=@id_writer";
                SqlParameter p_id_writer = new SqlParameter("@id_writer", result_writer_id);
                SqlCommand count_check = new SqlCommand(checkCountBooks, myConnection);
                count_check.Parameters.Add(p_id_writer);
                myConnection.Open();
                string result_count = count_check.ExecuteScalar().ToString(); //сумма общего гонорара за книгу
                myConnection.Close();

               
                return result_count;
            }

            catch
            {
                MessageBox.Show("Возникло исключение!");
                return "";
            }
        }

        private void manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательский_центрDataSet4.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.издательский_центрDataSet4.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательский_центрDataSet3.Писатели". При необходимости она может быть перемещена или удалена.
            this.писателиTableAdapter.Fill(this.издательский_центрDataSet3.Писатели);

        }

        private void button_fee_Click(object sender, EventArgs e)
        {
           label_fee.Text = calculate_fee();
        }

        private void button_contract_term_Click(object sender, EventArgs e)
        {

            label_contract.Text = calculate_contract() + " лет";
            string ter = terminated_y_or_n();

            if (ter == "False")
            {
                label_terminated.Text = "☒";
            }
            else
            {
                label_terminated.Text = "✔";
            }
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            label_count_ended_books.Text = count_ended_books() + " шт.";
        }
    }
}
