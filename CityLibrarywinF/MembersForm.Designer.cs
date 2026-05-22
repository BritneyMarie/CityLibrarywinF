namespace CityLibrarywinF
{
    partial class MembersForm
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
            MemberID = new Label();
            MemberName = new Label();
            txt_MemberID = new TextBox();
            txt_MemberName = new TextBox();
            lst_Members = new ListBox();
            btn_AddMember = new Button();
            SuspendLayout();
            // 
            // MemberID
            // 
            MemberID.AutoSize = true;
            MemberID.Location = new Point(85, 46);
            MemberID.Name = "MemberID";
            MemberID.Size = new Size(63, 15);
            MemberID.TabIndex = 0;
            MemberID.Text = "MemberID";
            // 
            // MemberName
            // 
            MemberName.AutoSize = true;
            MemberName.Location = new Point(85, 123);
            MemberName.Name = "MemberName";
            MemberName.Size = new Size(87, 15);
            MemberName.TabIndex = 1;
            MemberName.Text = "Member Name";
            // 
            // txt_MemberID
            // 
            txt_MemberID.Location = new Point(207, 46);
            txt_MemberID.Name = "txt_MemberID";
            txt_MemberID.Size = new Size(100, 23);
            txt_MemberID.TabIndex = 2;
            txt_MemberID.TextChanged += textBox1_TextChanged;
            // 
            // txt_MemberName
            // 
            txt_MemberName.Location = new Point(207, 115);
            txt_MemberName.Name = "txt_MemberName";
            txt_MemberName.Size = new Size(100, 23);
            txt_MemberName.TabIndex = 3;
            // 
            // lst_Members
            // 
            lst_Members.FormattingEnabled = true;
            lst_Members.ItemHeight = 15;
            lst_Members.Location = new Point(85, 201);
            lst_Members.Name = "lst_Members";
            lst_Members.Size = new Size(222, 94);
            lst_Members.TabIndex = 4;
            // 
            // btn_AddMember
            // 
            btn_AddMember.Location = new Point(85, 339);
            btn_AddMember.Name = "btn_AddMember";
            btn_AddMember.Size = new Size(222, 23);
            btn_AddMember.TabIndex = 5;
            btn_AddMember.Text = "Add Members";
            btn_AddMember.UseVisualStyleBackColor = true;
            btn_AddMember.Click += btn_AddMember_Click;
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(btn_AddMember);
            Controls.Add(lst_Members);
            Controls.Add(txt_MemberName);
            Controls.Add(txt_MemberID);
            Controls.Add(MemberName);
            Controls.Add(MemberID);
            Name = "MembersForm";
            Text = "MembersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MemberID;
        private Label MemberName;
        private TextBox txt_MemberID;
        private TextBox txt_MemberName;
        private ListBox lst_Members;
        private Button btn_AddMember;
    }
}