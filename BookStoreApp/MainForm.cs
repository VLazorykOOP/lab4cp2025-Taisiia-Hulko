using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BookStoreApp;

namespace BookStoreApp
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DB db = new DB();

            try
            {
                db.OpenConnection();
                MessageBox.Show("З'єднання з базою даних успішне!", "Успіх");
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення: " + ex.Message, "Помилка");
            }
        }

       

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            ViewBooksForm viewBooksForm = new ViewBooksForm();
            viewBooksForm.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
                }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SellBookForm sellBookForm = new SellBookForm();
            sellBookForm.ShowDialog();
        }
    }
}
