using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookStoreApp
{
    public partial class ViewBooksForm : Form
    {
        private DB db = new DB();

        public ViewBooksForm()
        {
            InitializeComponent();
            LoadBooks(); // Завантаження книг при відкритті форми
        }

        private void LoadBooks()
        {
            try
            {
                db.OpenConnection();

                string query = @"
                    SELECT 
                        Books.Title AS 'Назва',
                        CONCAT(Authors.FirstName, ' ', Authors.LastName) AS 'Автор',
                        Publishers.Name AS 'Видавництво',
                        Genres.Name AS 'Жанр',
                        Books.PageCount AS 'Сторінки',
                        Books.Price AS 'Ціна',
                        Books.StockQuantity AS 'У наявності'
                    FROM Books
                    INNER JOIN Authors ON Books.AuthorID = Authors.AuthorID
                    INNER JOIN Publishers ON Books.PublisherID = Publishers.PublisherID
                    INNER JOIN Genres ON Books.GenreID = Genres.GenreID;";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBooks.DataSource = dt;

                dgvBooks.ReadOnly = true;
                dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження книг: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Тут нічого поки не треба, просто заглушка
        }
    }
}
