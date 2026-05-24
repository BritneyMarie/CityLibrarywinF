namespace CityLibrarywinF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_ManageBooks_Click(object sender, EventArgs e)
        {
            Manage_Books books = new Manage_Books();
            books.ShowDialog();
        }

        private void btn_ManageMembers_Click(object sender, EventArgs e)
        {
            MembersForm members = new MembersForm();
            members.ShowDialog();
        }

        private void btn_Returns_Click(object sender, EventArgs e)
        {
            IssuesReturnForm issuesReturn = new IssuesReturnForm();
            issuesReturn.ShowDialog();
        }
    }
}
