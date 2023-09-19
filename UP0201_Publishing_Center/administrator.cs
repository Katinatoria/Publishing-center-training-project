using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UP0201_Publishing_Center
{
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
        }

        private void button_update_table_Click(object sender, EventArgs e)
        {
            administrator_update_books_authors administrator_update_books_authors = new administrator_update_books_authors();
            administrator_update_books_authors.Show();
        }
    }
}
