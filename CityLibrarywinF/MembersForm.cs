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
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
            RefreshMemberList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_AddMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MemberID.Text) ||
                string.IsNullOrWhiteSpace(txt_MemberName.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Members.members.Any(m => m.MemberID == txt_MemberID.Text.Trim()))
            {
                MessageBox.Show("A member with this ID already exists.", "Duplicate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var member = new Members
            {
                MemberID = txt_MemberID.Text.Trim(),
                MemberName = txt_MemberName.Text.Trim(),
            };

            Members.members.Add(member);
            RefreshMemberList();
            ClearInputs();
        }

        private void btn_RemoveMember_Click(object sender, EventArgs e)
        {
            if (lst_Members.SelectedItem == null)
            {
                MessageBox.Show("Please select a member to remove.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedMember = (Members)lst_Members.SelectedItem;

            bool hasActiveIssue = Transaction.Transactions.Any(
                t => t.MemberID == selectedMember.MemberID && !t.ReturnDate.HasValue);

            if (hasActiveIssue)
            {
                MessageBox.Show("Cannot remove a member who has books issued.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Remove \"{selectedMember.MemberName}\"?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Members.members.Remove(selectedMember);
                RefreshMemberList();
            }
        }

        private void RefreshMemberList()
        {
            lst_Members.Items.Clear();
            foreach (var m in Members.members)
            {
                lst_Members.Items.Add(m);
            }
        }

        private void ClearInputs()
        {
            txt_MemberID.Clear();
            txt_MemberName.Clear();
            txt_MemberID.Focus();
        }
    }
}
