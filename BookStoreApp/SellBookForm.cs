using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BookStoreApp;

namespace BookStoreApp
{
    public partial class SellBookForm : Form
    {
        private DB db = new DB();

        public SellBookForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                db.OpenConnection();

                string query = @"SELECT BookID, Title, StockQuantity FROM Books WHERE StockQuantity > 0";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbBooks.Items.Clear();

                while (reader.Read())
                {
                    cmbBooks.Items.Add(new BookDisplayItem
                    {
                        Id = reader.GetInt32("BookID"),
                        Title = reader.GetString("Title"),
                        Stock = reader.GetInt32("StockQuantity")
                    });
                }

                reader.Close();
                db.CloseConnection();

                if (cmbBooks.Items.Count > 0)
                    cmbBooks.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження книг: " + ex.Message);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedItem == null)
            {
                MessageBox.Show("Оберіть книгу для продажу");
                return;
            }

            var selectedBook = cmbBooks.SelectedItem as BookDisplayItem;
            if (selectedBook == null)
            {
                MessageBox.Show("Помилка з вибором книги");
                return;
            }

            int bookId = selectedBook.Id;
            decimal salePrice = nudSalePrice.Value;

            if (salePrice <= 0)
            {
                MessageBox.Show("Ціна продажу має бути більшою за нуль");
                return;
            }

            try
            {
                db.OpenConnection();

                int quantity = 1; // або зроби це змінним, якщо в тебе є поле для кількості
                decimal totalPrice = salePrice * quantity;

                MySqlCommand cmdInsertSale = new MySqlCommand(@"
    INSERT INTO Sales (BookID, SalePrice, SaleDate, Quantity, TotalPrice) 
    VALUES (@bookId, @salePrice, NOW(), @quantity, @totalPrice)", db.GetConnection());
                cmdInsertSale.Parameters.AddWithValue("@bookId", bookId);
                cmdInsertSale.Parameters.AddWithValue("@salePrice", salePrice);
                cmdInsertSale.Parameters.AddWithValue("@quantity", quantity);
                cmdInsertSale.Parameters.AddWithValue("@totalPrice", totalPrice);

                cmdInsertSale.ExecuteNonQuery();

                MySqlCommand cmdUpdateStock = new MySqlCommand(@"
                    UPDATE Books 
                    SET StockQuantity = StockQuantity - 1 
                    WHERE BookID = @bookId", db.GetConnection());
                cmdUpdateStock.Parameters.AddWithValue("@bookId", bookId);
                cmdUpdateStock.ExecuteNonQuery();

                db.CloseConnection();

                MessageBox.Show("Книга продана успішно!");

                LoadBooks(); // Оновлення після продажу
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час продажу: " + ex.Message);
            }
        }
    }
}
