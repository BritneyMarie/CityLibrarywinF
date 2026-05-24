using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibrarywinF
{
    public partial class Manage_Books : Form
    {
        public static List<books> book = new List<books>();

        public Manage_Books()
        {
            InitializeComponent();
            RefreshBookList();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ISBN.Text) ||
                string.IsNullOrWhiteSpace(txt_Title.Text) ||
                string.IsNullOrWhiteSpace(txt_Authour.Text) ||
                string.IsNullOrWhiteSpace(txt_Edition.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (book.Any(b => b.ISBN == txt_ISBN.Text.Trim()))
            {
                MessageBox.Show("A book with this ISBN already exists.", "Duplicate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newBook = new books
            {
                ISBN = txt_ISBN.Text.Trim(),
                Title = txt_Title.Text.Trim(),
                Authour = txt_Authour.Text.Trim(),
                Edition = txt_Edition.Text.Trim(),
            };

            book.Add(newBook);
            RefreshBookList();
            ClearInputs();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (lstShowBooks.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to remove.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedBook = (books)lstShowBooks.SelectedItem;

            if (!selectedBook.IsAvailabe)
            {
                MessageBox.Show("Cannot remove a book that is currently issued.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Remove \"{selectedBook.Title}\"?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                book.Remove(selectedBook);
                RefreshBookList();
            }
        }

        private void RefreshBookList()
        {
            lstShowBooks.Items.Clear();
            foreach (var b in book)
            {
                lstShowBooks.Items.Add(b);
            }
        }

        private void ClearInputs()
        {
            txt_ISBN.Clear();
            txt_Title.Clear();
            txt_Authour.Clear();
            txt_Edition.Clear();
            txt_ISBN.Focus();
        }
    }
}
