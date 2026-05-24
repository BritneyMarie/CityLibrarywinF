namespace CityLibrarywinF
{
    partial class Manage_Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Books));
            ISBN = new Label();
            Title = new Label();
            Author = new Label();
            Edition = new Label();
            txt_ISBN = new TextBox();
            txt_Title = new TextBox();
            txt_Authour = new TextBox();
            txt_Edition = new TextBox();
            lstShowBooks = new ListBox();
            btnAddBooks = new Button();
            btnRemoveBook = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ISBN.ForeColor = Color.FromArgb(64, 64, 64);
            ISBN.Location = new Point(89, 100);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(35, 17);
            ISBN.TabIndex = 0;
            ISBN.Text = "ISBN";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(64, 64, 64);
            Title.Location = new Point(89, 150);
            Title.Name = "Title";
            Title.Size = new Size(32, 17);
            Title.TabIndex = 1;
            Title.Text = "Title";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Author.ForeColor = Color.FromArgb(64, 64, 64);
            Author.Location = new Point(89, 200);
            Author.Name = "Author";
            Author.Size = new Size(47, 17);
            Author.TabIndex = 2;
            Author.Text = "Author";
            // 
            // Edition
            // 
            Edition.AutoSize = true;
            Edition.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edition.ForeColor = Color.FromArgb(64, 64, 64);
            Edition.Location = new Point(89, 250);
            Edition.Name = "Edition";
            Edition.Size = new Size(47, 17);
            Edition.TabIndex = 3;
            Edition.Text = "Edition";
            // 
            // txt_ISBN
            // 
            txt_ISBN.BackColor = Color.White;
            txt_ISBN.BorderStyle = BorderStyle.FixedSingle;
            txt_ISBN.Font = new Font("Segoe UI", 9.75F);
            txt_ISBN.ForeColor = Color.FromArgb(64, 64, 64);
            txt_ISBN.Location = new Point(200, 97);
            txt_ISBN.Name = "txt_ISBN";
            txt_ISBN.Size = new Size(200, 25);
            txt_ISBN.TabIndex = 4;
            // 
            // txt_Title
            // 
            txt_Title.BackColor = Color.White;
            txt_Title.BorderStyle = BorderStyle.FixedSingle;
            txt_Title.Font = new Font("Segoe UI", 9.75F);
            txt_Title.ForeColor = Color.FromArgb(64, 64, 64);
            txt_Title.Location = new Point(200, 147);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size(200, 25);
            txt_Title.TabIndex = 5;
            // 
            // txt_Authour
            // 
            txt_Authour.BackColor = Color.White;
            txt_Authour.BorderStyle = BorderStyle.FixedSingle;
            txt_Authour.Font = new Font("Segoe UI", 9.75F);
            txt_Authour.ForeColor = Color.FromArgb(64, 64, 64);
            txt_Authour.Location = new Point(200, 197);
            txt_Authour.Name = "txt_Authour";
            txt_Authour.Size = new Size(200, 25);
            txt_Authour.TabIndex = 6;
            // 
            // txt_Edition
            // 
            txt_Edition.BackColor = Color.White;
            txt_Edition.BorderStyle = BorderStyle.FixedSingle;
            txt_Edition.Font = new Font("Segoe UI", 9.75F);
            txt_Edition.ForeColor = Color.FromArgb(64, 64, 64);
            txt_Edition.Location = new Point(200, 247);
            txt_Edition.Name = "txt_Edition";
            txt_Edition.Size = new Size(200, 25);
            txt_Edition.TabIndex = 7;
            // 
            // lstShowBooks
            // 
            lstShowBooks.BackColor = Color.White;
            lstShowBooks.BorderStyle = BorderStyle.FixedSingle;
            lstShowBooks.Font = new Font("Segoe UI", 9.75F);
            lstShowBooks.ForeColor = Color.FromArgb(64, 64, 64);
            lstShowBooks.FormattingEnabled = true;
            lstShowBooks.ItemHeight = 17;
            lstShowBooks.Location = new Point(89, 300);
            lstShowBooks.Name = "lstShowBooks";
            lstShowBooks.Size = new Size(311, 121);
            lstShowBooks.TabIndex = 8;
            // 
            // btnAddBooks
            // 
            btnAddBooks.BackColor = Color.FromArgb(255, 182, 193);
            btnAddBooks.FlatAppearance.BorderSize = 0;
            btnAddBooks.FlatStyle = FlatStyle.Flat;
            btnAddBooks.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBooks.ForeColor = Color.White;
            btnAddBooks.Location = new Point(89, 450);
            btnAddBooks.Name = "btnAddBooks";
            btnAddBooks.Size = new Size(150, 45);
            btnAddBooks.TabIndex = 9;
            btnAddBooks.Text = "Add Book";
            btnAddBooks.UseVisualStyleBackColor = false;
            btnAddBooks.Click += btnAddBooks_Click;
            //
            // btnRemoveBook
            //
            btnRemoveBook.BackColor = Color.FromArgb(220, 120, 120);
            btnRemoveBook.FlatAppearance.BorderSize = 0;
            btnRemoveBook.FlatStyle = FlatStyle.Flat;
            btnRemoveBook.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveBook.ForeColor = Color.White;
            btnRemoveBook.Location = new Point(250, 450);
            btnRemoveBook.Name = "btnRemoveBook";
            btnRemoveBook.Size = new Size(150, 45);
            btnRemoveBook.TabIndex = 11;
            btnRemoveBook.Text = "Remove";
            btnRemoveBook.UseVisualStyleBackColor = false;
            btnRemoveBook.Click += btnRemoveBook_Click;
            //
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(173, 216, 230);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 60);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Book Management";
            // 
            // Manage_Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 530);
            Controls.Add(panel1);
            Controls.Add(btnRemoveBook);
            Controls.Add(btnAddBooks);
            Controls.Add(lstShowBooks);
            Controls.Add(txt_Edition);
            Controls.Add(txt_Authour);
            Controls.Add(txt_Title);
            Controls.Add(txt_ISBN);
            Controls.Add(Edition);
            Controls.Add(Author);
            Controls.Add(Title);
            Controls.Add(ISBN);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Manage_Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "City Library - Manage Books";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ISBN;
        private Label Title;
        private Label Author;
        private Label Edition;
        private TextBox txt_ISBN;
        private TextBox txt_Title;
        private TextBox txt_Authour;
        private TextBox txt_Edition;
        private ListBox lstShowBooks;
        private Button btnAddBooks;
        private Button btnRemoveBook;
        private Panel panel1;
        private Label label1;
    }
}