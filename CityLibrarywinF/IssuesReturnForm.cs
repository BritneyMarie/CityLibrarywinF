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

        private void IssuesReturnForm_Load(object? sender, EventArgs? e)
        {
            // Show only available books for issuing
            var availableBooks = Manage_Books.book.Where(b => b.IsAvailabe).ToList();
            cmb_ChooseBooks.DataSource = null;
            cmb_ChooseBooks.DataSource = availableBooks;

            cmb_ChooseMembers.DataSource = null;
            cmb_ChooseMembers.DataSource = Members.members;

            // Refresh the transaction log
            RefreshTransactionLog();
        }

        private void btn_IssueBooks_Click(object sender, EventArgs e)
        {
            if (cmb_ChooseBooks.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to issue.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_ChooseMembers.SelectedItem == null)
            {
                MessageBox.Show("Please select a member.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var book = (books)cmb_ChooseBooks.SelectedItem;
            var member = (Members)cmb_ChooseMembers.SelectedItem;

            book.IsAvailabe = false;
            Transaction.Add(new Transaction
            {
                ISBN = book.ISBN,
                MemberID = member.MemberID,
                IssueDate = DateTime.Now,
            });

            MessageBox.Show($"'{book.Title}' issued to {member.MemberName}.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            IssuesReturnForm_Load(null, null);
        }

        private void btn_ReturnBooks_Click(object sender, EventArgs e)
        {
            // Find all open (unreturned) transactions
            var openTransactions = Transaction.Transactions
                .Where(t => !t.ReturnDate.HasValue)
                .ToList();

            if (openTransactions.Count == 0)
            {
                MessageBox.Show("No books are currently issued.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an issued transaction from the log to return.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find the matching open transaction from the selected log entry
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= Transaction.Transactions.Count)
            {
                MessageBox.Show("Invalid selection.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var transaction = Transaction.Transactions[selectedIndex];

            if (transaction.ReturnDate.HasValue)
            {
                MessageBox.Show("This book has already been returned.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mark the transaction as returned
            transaction.ReturnDate = DateTime.Now;

            // Mark the book as available again
            var book = Manage_Books.book.FirstOrDefault(b => b.ISBN == transaction.ISBN);
            if (book != null)
            {
                book.IsAvailabe = true;
            }

            var member = Members.members.FirstOrDefault(m => m.MemberID == transaction.MemberID);
            string memberName = member != null ? member.MemberName : transaction.MemberID;
            string bookTitle = book != null ? book.Title : transaction.ISBN;

            MessageBox.Show($"'{bookTitle}' returned by {memberName}.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            IssuesReturnForm_Load(null, null);
        }

        private void RefreshTransactionLog()
        {
            listBox1.Items.Clear();
            foreach (var t in Transaction.Transactions)
            {
                var book = Manage_Books.book.FirstOrDefault(b => b.ISBN == t.ISBN);
                var member = Members.members.FirstOrDefault(m => m.MemberID == t.MemberID);
                string bookTitle = book != null ? book.Title : t.ISBN;
                string memberName = member != null ? member.MemberName : t.MemberID;

                if (t.ReturnDate.HasValue)
                    listBox1.Items.Add($"Returned: {bookTitle} by {memberName} on {t.ReturnDate.Value:dd/MM/yyyy}");
                else
                    listBox1.Items.Add($"Issued: {bookTitle} to {memberName} on {t.IssueDate:dd/MM/yyyy}");
            }
        }
    }
}
