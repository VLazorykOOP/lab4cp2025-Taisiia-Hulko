namespace BookStoreApp
{
    partial class AddBookForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.nudPageCount = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.nudStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Назва книги";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(149, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(120, 22);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 61);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 16);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Автор";
            this.lblAuthor.Click += new System.EventHandler(this.lblAuthor_Click);
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(149, 53);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(121, 24);
            this.cmbAuthor.TabIndex = 3;
            this.cmbAuthor.SelectedIndexChanged += new System.EventHandler(this.cmbAuthor_SelectedIndexChanged);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(12, 102);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(95, 16);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "Видавництво\t";
            this.lblPublisher.Click += new System.EventHandler(this.lblPublisher_Click);
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(149, 94);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(121, 24);
            this.cmbPublisher.TabIndex = 5;
            this.cmbPublisher.SelectedIndexChanged += new System.EventHandler(this.cmbPublisher_SelectedIndexChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(15, 145);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(44, 16);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Жанр";
            this.lblGenre.Click += new System.EventHandler(this.lblGenre_Click);
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(149, 137);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(121, 24);
            this.cmbGenre.TabIndex = 7;
            this.cmbGenre.SelectedIndexChanged += new System.EventHandler(this.cmbGenre_SelectedIndexChanged);
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(12, 181);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(123, 16);
            this.lblPageCount.TabIndex = 8;
            this.lblPageCount.Text = "Кількість сторінок";
            this.lblPageCount.Click += new System.EventHandler(this.lblPageCount_Click);
            // 
            // nudPageCount
            // 
            this.nudPageCount.Location = new System.Drawing.Point(149, 181);
            this.nudPageCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPageCount.Name = "nudPageCount";
            this.nudPageCount.Size = new System.Drawing.Size(120, 22);
            this.nudPageCount.TabIndex = 9;
            this.nudPageCount.ValueChanged += new System.EventHandler(this.nudPageCount_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 221);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 16);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Ціна";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(149, 219);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 22);
            this.nudPrice.TabIndex = 11;
            this.nudPrice.ValueChanged += new System.EventHandler(this.nudPrice_ValueChanged);
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(15, 255);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(127, 16);
            this.lblStockQuantity.TabIndex = 12;
            this.lblStockQuantity.Text = "Кількість на складі";
            this.lblStockQuantity.Click += new System.EventHandler(this.lblStockQuantity_Click);
            // 
            // nudStockQuantity
            // 
            this.nudStockQuantity.Location = new System.Drawing.Point(150, 255);
            this.nudStockQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStockQuantity.Name = "nudStockQuantity";
            this.nudStockQuantity.Size = new System.Drawing.Size(120, 22);
            this.nudStockQuantity.TabIndex = 13;
            this.nudStockQuantity.ValueChanged += new System.EventHandler(this.nudStockQuantity_ValueChanged);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(156, 294);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(114, 23);
            this.btnAddBook.TabIndex = 14;
            this.btnAddBook.Text = "Додати книгу";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.nudStockQuantity);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.nudPageCount);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbPublisher);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddBookForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ComboBox cmbPublisher;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.NumericUpDown nudPageCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.NumericUpDown nudStockQuantity;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancel;
    }
}

