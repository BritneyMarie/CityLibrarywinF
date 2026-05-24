namespace CityLibrarywinF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblFooter = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.FromArgb(173, 216, 230);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblSubtitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 90);
            panel1.TabIndex = 10;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "City Library";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(22, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(175, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Management System";
            //
            // button1
            //
            button1.BackColor = Color.FromArgb(255, 182, 193);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(55, 120);
            button1.Name = "button1";
            button1.Size = new Size(310, 55);
            button1.TabIndex = 0;
            button1.Text = "Manage Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btm_ManageBooks_Click;
            //
            // button2
            //
            button2.BackColor = Color.FromArgb(255, 182, 193);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(55, 195);
            button2.Name = "button2";
            button2.Size = new Size(310, 55);
            button2.TabIndex = 1;
            button2.Text = "Manage Members";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btn_ManageMembers_Click;
            //
            // button3
            //
            button3.BackColor = Color.FromArgb(255, 182, 193);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(55, 270);
            button3.Name = "button3";
            button3.Size = new Size(310, 55);
            button3.TabIndex = 2;
            button3.Text = "Issues / Returns";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btn_Returns_Click;
            //
            // lblFooter
            //
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = Color.FromArgb(160, 160, 160);
            lblFooter.Location = new Point(120, 355);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(175, 13);
            lblFooter.TabIndex = 11;
            lblFooter.Text = "City Library Management v1.0";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 400);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(lblFooter);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "City Library";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblFooter;
    }
}
