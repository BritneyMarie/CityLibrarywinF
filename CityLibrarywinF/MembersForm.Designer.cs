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
            panel1 = new Panel();
            label1 = new Label();
            MemberID = new Label();
            MemberName = new Label();
            txt_MemberID = new TextBox();
            txt_MemberName = new TextBox();
            lst_Members = new ListBox();
            btn_AddMember = new Button();
            btn_RemoveMember = new Button();
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
            label1.Size = new Size(210, 25);
            label1.TabIndex = 0;
            label1.Text = "Member Management";
            //
            // MemberID
            //
            MemberID.AutoSize = true;
            MemberID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MemberID.ForeColor = Color.FromArgb(64, 64, 64);
            MemberID.Location = new Point(89, 100);
            MemberID.Name = "MemberID";
            MemberID.Size = new Size(73, 17);
            MemberID.TabIndex = 0;
            MemberID.Text = "Member ID";
            //
            // MemberName
            //
            MemberName.AutoSize = true;
            MemberName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MemberName.ForeColor = Color.FromArgb(64, 64, 64);
            MemberName.Location = new Point(89, 150);
            MemberName.Name = "MemberName";
            MemberName.Size = new Size(95, 17);
            MemberName.TabIndex = 1;
            MemberName.Text = "Member Name";
            //
            // txt_MemberID
            //
            txt_MemberID.BackColor = Color.White;
            txt_MemberID.BorderStyle = BorderStyle.FixedSingle;
            txt_MemberID.Font = new Font("Segoe UI", 9.75F);
            txt_MemberID.ForeColor = Color.FromArgb(64, 64, 64);
            txt_MemberID.Location = new Point(200, 97);
            txt_MemberID.Name = "txt_MemberID";
            txt_MemberID.Size = new Size(200, 25);
            txt_MemberID.TabIndex = 2;
            txt_MemberID.TextChanged += textBox1_TextChanged;
            //
            // txt_MemberName
            //
            txt_MemberName.BackColor = Color.White;
            txt_MemberName.BorderStyle = BorderStyle.FixedSingle;
            txt_MemberName.Font = new Font("Segoe UI", 9.75F);
            txt_MemberName.ForeColor = Color.FromArgb(64, 64, 64);
            txt_MemberName.Location = new Point(200, 147);
            txt_MemberName.Name = "txt_MemberName";
            txt_MemberName.Size = new Size(200, 25);
            txt_MemberName.TabIndex = 3;
            //
            // lst_Members
            //
            lst_Members.BackColor = Color.White;
            lst_Members.BorderStyle = BorderStyle.FixedSingle;
            lst_Members.Font = new Font("Segoe UI", 9.75F);
            lst_Members.ForeColor = Color.FromArgb(64, 64, 64);
            lst_Members.FormattingEnabled = true;
            lst_Members.ItemHeight = 17;
            lst_Members.Location = new Point(89, 210);
            lst_Members.Name = "lst_Members";
            lst_Members.Size = new Size(311, 121);
            lst_Members.TabIndex = 4;
            //
            // btn_AddMember
            //
            btn_AddMember.BackColor = Color.FromArgb(255, 182, 193);
            btn_AddMember.FlatAppearance.BorderSize = 0;
            btn_AddMember.FlatStyle = FlatStyle.Flat;
            btn_AddMember.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddMember.ForeColor = Color.White;
            btn_AddMember.Location = new Point(89, 360);
            btn_AddMember.Name = "btn_AddMember";
            btn_AddMember.Size = new Size(150, 45);
            btn_AddMember.TabIndex = 5;
            btn_AddMember.Text = "Add Member";
            btn_AddMember.UseVisualStyleBackColor = false;
            btn_AddMember.Click += btn_AddMember_Click;
            //
            // btn_RemoveMember
            //
            btn_RemoveMember.BackColor = Color.FromArgb(220, 120, 120);
            btn_RemoveMember.FlatAppearance.BorderSize = 0;
            btn_RemoveMember.FlatStyle = FlatStyle.Flat;
            btn_RemoveMember.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RemoveMember.ForeColor = Color.White;
            btn_RemoveMember.Location = new Point(250, 360);
            btn_RemoveMember.Name = "btn_RemoveMember";
            btn_RemoveMember.Size = new Size(150, 45);
            btn_RemoveMember.TabIndex = 6;
            btn_RemoveMember.Text = "Remove";
            btn_RemoveMember.UseVisualStyleBackColor = false;
            btn_RemoveMember.Click += btn_RemoveMember_Click;
            //
            // MembersForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 440);
            Controls.Add(panel1);
            Controls.Add(btn_RemoveMember);
            Controls.Add(btn_AddMember);
            Controls.Add(lst_Members);
            Controls.Add(txt_MemberName);
            Controls.Add(txt_MemberID);
            Controls.Add(MemberName);
            Controls.Add(MemberID);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MembersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "City Library - Manage Members";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label MemberID;
        private Label MemberName;
        private TextBox txt_MemberID;
        private TextBox txt_MemberName;
        private ListBox lst_Members;
        private Button btn_AddMember;
        private Button btn_RemoveMember;
    }
}
