namespace CityLibrarywinF
{
    partial class IssuesReturnForm
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
            panel1 = new Panel();
            label1 = new Label();
            lblChooseBook = new Label();
            lblChooseMember = new Label();
            cmb_ChooseBooks = new ComboBox();
            cmb_ChooseMembers = new ComboBox();
            btn_IssueBooks = new Button();
            btn_ReturnBooks = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
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
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Issues && Returns";
            //
            // lblChooseBook
            //
            lblChooseBook.AutoSize = true;
            lblChooseBook.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChooseBook.ForeColor = Color.FromArgb(64, 64, 64);
            lblChooseBook.Location = new Point(89, 100);
            lblChooseBook.Name = "lblChooseBook";
            lblChooseBook.Size = new Size(38, 17);
            lblChooseBook.TabIndex = 11;
            lblChooseBook.Text = "Book";
            //
            // lblChooseMember
            //
            lblChooseMember.AutoSize = true;
            lblChooseMember.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChooseMember.ForeColor = Color.FromArgb(64, 64, 64);
            lblChooseMember.Location = new Point(89, 150);
            lblChooseMember.Name = "lblChooseMember";
            lblChooseMember.Size = new Size(55, 17);
            lblChooseMember.TabIndex = 12;
            lblChooseMember.Text = "Member";
            //
            // cmb_ChooseBooks
            //
            cmb_ChooseBooks.BackColor = Color.White;
            cmb_ChooseBooks.Font = new Font("Segoe UI", 9.75F);
            cmb_ChooseBooks.ForeColor = Color.FromArgb(64, 64, 64);
            cmb_ChooseBooks.FormattingEnabled = true;
            cmb_ChooseBooks.Location = new Point(200, 97);
            cmb_ChooseBooks.Name = "cmb_ChooseBooks";
            cmb_ChooseBooks.Size = new Size(200, 25);
            cmb_ChooseBooks.TabIndex = 0;
            cmb_ChooseBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // cmb_ChooseMembers
            //
            cmb_ChooseMembers.BackColor = Color.White;
            cmb_ChooseMembers.Font = new Font("Segoe UI", 9.75F);
            cmb_ChooseMembers.ForeColor = Color.FromArgb(64, 64, 64);
            cmb_ChooseMembers.FormattingEnabled = true;
            cmb_ChooseMembers.Location = new Point(200, 147);
            cmb_ChooseMembers.Name = "cmb_ChooseMembers";
            cmb_ChooseMembers.Size = new Size(200, 25);
            cmb_ChooseMembers.TabIndex = 1;
            cmb_ChooseMembers.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // btn_IssueBooks
            //
            btn_IssueBooks.BackColor = Color.FromArgb(255, 182, 193);
            btn_IssueBooks.FlatAppearance.BorderSize = 0;
            btn_IssueBooks.FlatStyle = FlatStyle.Flat;
            btn_IssueBooks.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_IssueBooks.ForeColor = Color.White;
            btn_IssueBooks.Location = new Point(89, 200);
            btn_IssueBooks.Name = "btn_IssueBooks";
            btn_IssueBooks.Size = new Size(150, 45);
            btn_IssueBooks.TabIndex = 2;
            btn_IssueBooks.Text = "Issue Book";
            btn_IssueBooks.UseVisualStyleBackColor = false;
            btn_IssueBooks.Click += btn_IssueBooks_Click;
            //
            // btn_ReturnBooks
            //
            btn_ReturnBooks.BackColor = Color.FromArgb(144, 202, 144);
            btn_ReturnBooks.FlatAppearance.BorderSize = 0;
            btn_ReturnBooks.FlatStyle = FlatStyle.Flat;
            btn_ReturnBooks.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ReturnBooks.ForeColor = Color.White;
            btn_ReturnBooks.Location = new Point(250, 200);
            btn_ReturnBooks.Name = "btn_ReturnBooks";
            btn_ReturnBooks.Size = new Size(150, 45);
            btn_ReturnBooks.TabIndex = 3;
            btn_ReturnBooks.Text = "Return Book";
            btn_ReturnBooks.UseVisualStyleBackColor = false;
            btn_ReturnBooks.Click += btn_ReturnBooks_Click;
            //
            // listBox1
            //
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Segoe UI", 9.75F);
            listBox1.ForeColor = Color.FromArgb(64, 64, 64);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(89, 270);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(311, 155);
            listBox1.TabIndex = 4;
            //
            // IssuesReturnForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 460);
            Controls.Add(panel1);
            Controls.Add(lblChooseBook);
            Controls.Add(lblChooseMember);
            Controls.Add(listBox1);
            Controls.Add(btn_ReturnBooks);
            Controls.Add(btn_IssueBooks);
            Controls.Add(cmb_ChooseMembers);
            Controls.Add(cmb_ChooseBooks);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "IssuesReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "City Library - Issues & Returns";
            Load += IssuesReturnForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblChooseBook;
        private Label lblChooseMember;
        private ComboBox cmb_ChooseBooks;
        private ComboBox cmb_ChooseMembers;
        private Button btn_IssueBooks;
        private Button btn_ReturnBooks;
        private ListBox listBox1;
    }
}
