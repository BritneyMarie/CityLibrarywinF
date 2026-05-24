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
    public partial class IssuesReturnForm : Form
    {
        public IssuesReturnForm()
        {
            InitializeComponent();
        }


        private void IssuesReturnForm_Load(object sender, EventArgs e)
        {
            cmb_ChooseBooks.DataSource = null;
            cmb_ChooseBooks.DataSource = Manage_Books.book;
            cmb_ChooseMembers.DataSource = null;
            cmb_ChooseMembers.DataSource = Members.members;



        }

        private void btn_IssueBooks_Click(object sender, EventArgs e)
        {
            var book = (books)cmb_ChooseBooks.SelectedItem;
            var member = (Members)cmb_ChooseMembers.SelectedItem;

            book.IsAvailabe = false;
            Transaction.Add(new Transaction {

                ISBN = book.ISBN,
                MemberID = member.MemberID,
                IssueDate = DateTime.Now,
            });

            listBox1.Items.Add($"Issued: {book.Title} to {member.MemberName}");
            IssuesReturnForm_Load(null, null); // refresh
        }
    }
}
