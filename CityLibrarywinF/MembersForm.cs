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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_AddMember_Click(object sender, EventArgs e)
        {
            var member = new Members
            {
                MemberID = txt_MemberID.Text,
                MemberName = txt_MemberName.Text,
            };

            Members.members.Add(member);
            lst_Members.Items.Add(member);
        }
    }
}
