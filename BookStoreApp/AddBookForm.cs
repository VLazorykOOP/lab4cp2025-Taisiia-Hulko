using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BookStoreApp;

namespace BookStoreApp
{
    public partial class AddBookForm : Form
    {
        private DB db = new DB();

        public AddBookForm()
        {
            InitializeComponent();

            LoadAuthors();
            LoadPublishers();
            LoadGenres();
        }

        private void LoadAuthors()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT AuthorID, CONCAT(FirstName, ' ', LastName) AS FullName FROM Authors";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbAuthor.Items.Clear();

                while (reader.Read())
                {
                    cmbAuthor.Items.Add(new ComboboxItem
                    {
                        Id = reader.GetInt32("AuthorID"),
                        Name = reader.GetString("FullName")
                    });
                }
                reader.Close();
                db.CloseConnection();

                cmbAuthor.DisplayMember = "Name";
                cmbAuthor.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження авторів: " + ex.Message);
            }
        }

        private void LoadPublishers()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT PublisherID, Name FROM Publishers";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbPublisher.Items.Clear();

                while (reader.Read())
                {
                    cmbPublisher.Items.Add(new ComboboxItem
                    {
                        Id = reader.GetInt32("PublisherID"),
                        Name = reader.GetString("Name")
                    });
                }
                reader.Close();
                db.CloseConnection();

                cmbPublisher.DisplayMember = "Name";
                cmbPublisher.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження видавництв: " + ex.Message);
            }
        }

        private void LoadGenres()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT GenreID, Name FROM Genres";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbGenre.Items.Clear();

                while (reader.Read())
                {
                    cmbGenre.Items.Add(new ComboboxItem
                    {
                        Id = reader.GetInt32("GenreID"),
                        Name = reader.GetString("Name")
                    });
                }
                reader.Close();
                db.CloseConnection();

                cmbGenre.DisplayMember = "Name";
                cmbGenre.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження жанрів: " + ex.Message);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                cmbAuthor.SelectedItem == null ||
                cmbPublisher.SelectedItem == null ||
                cmbGenre.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.OpenConnection();

                string query = @"INSERT INTO Books (Title, AuthorID, PublisherID, GenreID, PageCount, Price, StockQuantity)
                                 VALUES (@title, @author, @publisher, @genre, @pageCount, @price, @stockQty)"
                ;
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@author", ((ComboboxItem)cmbAuthor.SelectedItem).Id);
                cmd.Parameters.AddWithValue("@publisher", ((ComboboxItem)cmbPublisher.SelectedItem).Id);
                cmd.Parameters.AddWithValue("@genre", ((ComboboxItem)cmbGenre.SelectedItem).Id);
                cmd.Parameters.AddWithValue("@pageCount", (int)nudPageCount.Value);
                cmd.Parameters.AddWithValue("@price", nudPrice.Value);
                cmd.Parameters.AddWithValue("@stockQty", (int)nudStockQuantity.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Книгу додано успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.CloseConnection();

                this.Close(); // Закриваємо форму після додавання
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка додавання книги: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Порожні обробники подій (щоб не було помилок)
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void txtTitle_TextChanged(object sender, EventArgs e) { }
        private void lblAuthor_Click(object sender, EventArgs e) { }
        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblPublisher_Click(object sender, EventArgs e) { }
        private void cmbPublisher_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblGenre_Click(object sender, EventArgs e) { }
        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblPageCount_Click(object sender, EventArgs e) { }
        private void nudPageCount_ValueChanged(object sender, EventArgs e) { }
        private void lblPrice_Click(object sender, EventArgs e) { }
        private void nudPrice_ValueChanged(object sender, EventArgs e) { }
        private void lblStockQuantity_Click(object sender, EventArgs e) { }
        private void nudStockQuantity_ValueChanged(object sender, EventArgs e) { }

    }

    // Допоміжний клас для зручності зберігання елементів ComboBox з Id та Name
    public class ComboboxItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}
