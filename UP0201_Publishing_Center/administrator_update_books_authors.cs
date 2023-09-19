using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UP0201_Publishing_Center
{
    public partial class administrator_update_books_authors : Form
    {
        public administrator_update_books_authors()
        {
            InitializeComponent();
        }

        private void manager_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "издательский_центрDataSet5.Книга_авторы". При необходимости она может быть перемещена или удалена.
                this.книга_авторыTableAdapter.Fill(this.издательский_центрDataSet5.Книга_авторы);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "издательский_центрDataSet2.Контракты". При необходимости она может быть перемещена или удалена.
                this.контрактыTableAdapter.Fill(this.издательский_центрDataSet2.Контракты);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "издательский_центрDataSet1.Писатели". При необходимости она может быть перемещена или удалена.
                this.писателиTableAdapter.Fill(this.издательский_центрDataSet1.Писатели);
            }
            catch
            {
                MessageBox.Show("Возникло исключение!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.писателиTableAdapter.Update(this.издательский_центрDataSet1.Писатели);
            }
            catch
            {
                MessageBox.Show("Возникло исключение!");
            }
        }

        private void button_update_contract_Click(object sender, EventArgs e)
        {
            try
            {
                this.контрактыTableAdapter.Update(this.издательский_центрDataSet2.Контракты);
            }
            catch
            {
                MessageBox.Show("Возникло исключение!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_out_Click(object sender, EventArgs e)
        {
          
        }
    }
}
