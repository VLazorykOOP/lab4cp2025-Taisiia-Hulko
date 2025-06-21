using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BookStoreApp;

namespace BookStoreApp
{
    public partial class SearchForm : Form
    {
        private DB db = new DB();

        public SearchForm()
        {
            InitializeComponent();
            LoadFilters();
        }

        private void LoadFilters()
        {
            try
            {
                db.OpenConnection();

                // ===== Автори =====
                var cmdAuthors = new MySqlCommand("SELECT CONCAT(FirstName, ' ', LastName) AS FullName FROM Authors", db.GetConnection());
                var readerAuthors = cmdAuthors.ExecuteReader();
                cmbAuthor.Items.Clear();
                cmbAuthor.Items.Add("Усі");
                while (readerAuthors.Read())
                    cmbAuthor.Items.Add(readerAuthors["FullName"].ToString());
                readerAuthors.Close();

                // ===== Видавництва =====
                var cmdPublishers = new MySqlCommand("SELECT Name FROM Publishers", db.GetConnection());
                var readerPublishers = cmdPublishers.ExecuteReader();
                cmbPublisher.Items.Clear();
                cmbPublisher.Items.Add("Усі");
                while (readerPublishers.Read())
                    cmbPublisher.Items.Add(readerPublishers["Name"].ToString());
                readerPublishers.Close();

                // ===== Жанри =====
                var cmdGenres = new MySqlCommand("SELECT Name FROM Genres", db.GetConnection());
                var readerGenres = cmdGenres.ExecuteReader();
                cmbGenre.Items.Clear();
                cmbGenre.Items.Add("Усі");
                while (readerGenres.Read())
                    cmbGenre.Items.Add(readerGenres["Name"].ToString());
                readerGenres.Close();

                db.CloseConnection();

                // Встановлюємо значення за замовчуванням
                cmbAuthor.SelectedIndex = 0;
                cmbPublisher.SelectedIndex = 0;
                cmbGenre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження фільтрів: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                    INNER JOIN Genres ON Books.GenreID = Genres.GenreID
                    WHERE (@title = '' OR Books.Title LIKE CONCAT('%', @title, '%'))
                      AND (@author = 'Усі' OR CONCAT(Authors.FirstName, ' ', Authors.LastName) = @author)
                      AND (@publisher = 'Усі' OR Publishers.Name = @publisher)
                      AND (@genre = 'Усі' OR Genres.Name = @genre);";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@author", cmbAuthor.Text);
                cmd.Parameters.AddWithValue("@publisher", cmbPublisher.Text);
                cmd.Parameters.AddWithValue("@genre", cmbGenre.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvResults.DataSource = dt;

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час пошуку: " + ex.Message);
            }
        }

        // Ці обробники подій можеш залишити порожніми або видалити, якщо не потрібні
        private void lblSearchTitle_Click(object sender, EventArgs e) { }
        private void txtTitle_TextChanged(object sender, EventArgs e) { }
        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbPublisher_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
