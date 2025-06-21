namespace UnicomTICManagementSystem.Views
{
    partial class UserLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.Label();
            this.loginbtn1 = new System.Windows.Forms.Button();
            this.User_password = new System.Windows.Forms.TextBox();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.UsersCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select For Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tittle
            // 
            this.Tittle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Tittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.Location = new System.Drawing.Point(387, 64);
            this.Tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(292, 110);
            this.Tittle.TabIndex = 11;
            this.Tittle.Text = "Users Login\r\n\r\n";
            // 
            // loginbtn1
            // 
            this.loginbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginbtn1.Location = new System.Drawing.Point(623, 297);
            this.loginbtn1.Margin = new System.Windows.Forms.Padding(2);
            this.loginbtn1.Name = "loginbtn1";
            this.loginbtn1.Size = new System.Drawing.Size(56, 21);
            this.loginbtn1.TabIndex = 10;
            this.loginbtn1.Text = "Login";
            this.loginbtn1.UseVisualStyleBackColor = true;
            this.loginbtn1.Click += new System.EventHandler(this.loginbtn1_Click);
            // 
            // User_password
            // 
            this.User_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_password.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_password.Location = new System.Drawing.Point(393, 244);
            this.User_password.Margin = new System.Windows.Forms.Padding(2);
            this.User_password.Name = "User_password";
            this.User_password.Size = new System.Drawing.Size(280, 36);
            this.User_password.TabIndex = 9;
            this.User_password.Text = "\r\n";
            this.User_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.User_password.TextChanged += new System.EventHandler(this.User_password_TextChanged);
            // 
            // User_Name
            // 
            this.User_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_Name.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name.Location = new System.Drawing.Point(393, 176);
            this.User_Name.Margin = new System.Windows.Forms.Padding(2);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(280, 36);
            this.User_Name.TabIndex = 8;
            this.User_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.User_Name.TextChanged += new System.EventHandler(this.User_Name_TextChanged);
            // 
            // UsersCombobox
            // 
            this.UsersCombobox.AutoCompleteCustomSource.AddRange(new string[] {
            "Lecturers , Staff, Students"});
            this.UsersCombobox.FormattingEnabled = true;
            this.UsersCombobox.Location = new System.Drawing.Point(11, 42);
            this.UsersCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.UsersCombobox.Name = "UsersCombobox";
            this.UsersCombobox.Size = new System.Drawing.Size(134, 21);
            this.UsersCombobox.TabIndex = 7;
            this.UsersCombobox.SelectedIndexChanged += new System.EventHandler(this.UsersCombobox_SelectedIndexChanged);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.loginbtn1);
            this.Controls.Add(this.User_password);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.UsersCombobox);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Button loginbtn1;
        private System.Windows.Forms.TextBox User_password;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.ComboBox UsersCombobox;
    }
}