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
            cmb_ChooseBooks = new ComboBox();
            cmb_ChooseMembers = new ComboBox();
            btn_IssueBooks = new Button();
            btn_ReturnBooks = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // cmb_ChooseBooks
            // 
            cmb_ChooseBooks.FormattingEnabled = true;
            cmb_ChooseBooks.Location = new Point(81, 33);
            cmb_ChooseBooks.Name = "cmb_ChooseBooks";
            cmb_ChooseBooks.Size = new Size(154, 23);
            cmb_ChooseBooks.TabIndex = 0;
            cmb_ChooseBooks.Text = "Choose Books";
            // 
            // cmb_ChooseMembers
            // 
            cmb_ChooseMembers.FormattingEnabled = true;
            cmb_ChooseMembers.Location = new Point(81, 98);
            cmb_ChooseMembers.Name = "cmb_ChooseMembers";
            cmb_ChooseMembers.Size = new Size(154, 23);
            cmb_ChooseMembers.TabIndex = 1;
            cmb_ChooseMembers.Text = "Choose Members";
            // 
            // btn_IssueBooks
            // 
            btn_IssueBooks.Location = new Point(81, 164);
            btn_IssueBooks.Name = "btn_IssueBooks";
            btn_IssueBooks.Size = new Size(154, 23);
            btn_IssueBooks.TabIndex = 2;
            btn_IssueBooks.Text = "Issue Books";
            btn_IssueBooks.UseVisualStyleBackColor = true;
            btn_IssueBooks.Click += btn_IssueBooks_Click;
            // 
            // btn_ReturnBooks
            // 
            btn_ReturnBooks.Location = new Point(81, 228);
            btn_ReturnBooks.Name = "btn_ReturnBooks";
            btn_ReturnBooks.Size = new Size(154, 23);
            btn_ReturnBooks.TabIndex = 3;
            btn_ReturnBooks.Text = "Return Books";
            btn_ReturnBooks.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(81, 293);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(154, 94);
            listBox1.TabIndex = 4;
            // 
            // IssuesReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(listBox1);
            Controls.Add(btn_ReturnBooks);
            Controls.Add(btn_IssueBooks);
            Controls.Add(cmb_ChooseMembers);
            Controls.Add(cmb_ChooseBooks);
            Name = "IssuesReturnForm";
            Text = "IssuesReturnForm";
            Load += IssuesReturnForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmb_ChooseBooks;
        private ComboBox cmb_ChooseMembers;
        private Button btn_IssueBooks;
        private Button btn_ReturnBooks;
        private ListBox listBox1;
    }
}