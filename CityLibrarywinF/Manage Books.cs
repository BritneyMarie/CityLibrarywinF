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
        public Manage_Books()
        {
            InitializeComponent();
        }

        private void btnAddBooks_Click(object sender, EventArgs e, books books)
        {
            var book = new books
            {
                ISBN = txt_ISBN.Text,
                Title = txt_Title.Text,
                Authour = txt_Authour.Text,
                Edition = txt_Edition.Text,
            };

            books.Add(book);
            lstShowBooks.Items.Add(book);
        }


            private void ClearInputs()
            { 
            txt_ISBN.Clear();
            txt_Title.Clear();
            txt_Authour.Clear();
            txt_Edition.Clear();
        }
    }
}
