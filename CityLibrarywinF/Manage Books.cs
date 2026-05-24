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
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            var newBook = new books
            {
                ISBN = txt_ISBN.Text,
                Title = txt_Title.Text,
                Authour = txt_Authour.Text,
                Edition = txt_Edition.Text,
            };

            book.Add(newBook);
            lstShowBooks.Items.Add(newBook);
            ClearInputs();
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
