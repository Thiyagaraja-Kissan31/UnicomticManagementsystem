namespace UnicomTICManagementSystem.Views
{
    partial class Mainlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainlogin));
            this.rolecomboBox1 = new System.Windows.Forms.ComboBox();
            this.role = new System.Windows.Forms.Label();
            this.cancelbtn1 = new System.Windows.Forms.Button();
            this.loginbtn1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.Label();
            this.username1 = new System.Windows.Forms.Label();
            this.managementlogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rolecomboBox1
            // 
            this.rolecomboBox1.FormattingEnabled = true;
            this.rolecomboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.rolecomboBox1.Location = new System.Drawing.Point(686, 256);
            this.rolecomboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rolecomboBox1.Name = "rolecomboBox1";
            this.rolecomboBox1.Size = new System.Drawing.Size(300, 24);
            this.rolecomboBox1.TabIndex = 1;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.BackColor = System.Drawing.Color.Transparent;
            this.role.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.ForeColor = System.Drawing.Color.White;
            this.role.Location = new System.Drawing.Point(595, 249);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(72, 31);
            this.role.TabIndex = 2;
            this.role.Text = "Role:";
            // 
            // cancelbtn1
            // 
            this.cancelbtn1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cancelbtn1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn1.Location = new System.Drawing.Point(871, 489);
            this.cancelbtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelbtn1.Name = "cancelbtn1";
            this.cancelbtn1.Size = new System.Drawing.Size(116, 39);
            this.cancelbtn1.TabIndex = 9;
            this.cancelbtn1.Text = "Cancel";
            this.cancelbtn1.UseVisualStyleBackColor = false;
            this.cancelbtn1.Click += new System.EventHandler(this.cancelbtn1_Click);
            // 
            // loginbtn1
            // 
            this.loginbtn1.BackColor = System.Drawing.Color.Silver;
            this.loginbtn1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn1.Location = new System.Drawing.Point(640, 489);
            this.loginbtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbtn1.Name = "loginbtn1";
            this.loginbtn1.Size = new System.Drawing.Size(155, 39);
            this.loginbtn1.TabIndex = 10;
            this.loginbtn1.Text = "Login";
            this.loginbtn1.UseVisualStyleBackColor = false;
            this.loginbtn1.Click += new System.EventHandler(this.loginbtn1_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(640, 439);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(345, 27);
            this.password.TabIndex = 7;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(640, 370);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(345, 27);
            this.username.TabIndex = 8;
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.BackColor = System.Drawing.Color.Transparent;
            this.password1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.password1.Location = new System.Drawing.Point(597, 417);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(78, 20);
            this.password1.TabIndex = 5;
            this.password1.Text = "Password";
            // 
            // username1
            // 
            this.username1.AutoSize = true;
            this.username1.BackColor = System.Drawing.Color.Transparent;
            this.username1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.username1.Location = new System.Drawing.Point(597, 348);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(82, 20);
            this.username1.TabIndex = 6;
            this.username1.Text = "Username";
            // 
            // managementlogin
            // 
            this.managementlogin.AutoSize = true;
            this.managementlogin.BackColor = System.Drawing.Color.Transparent;
            this.managementlogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.managementlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementlogin.ForeColor = System.Drawing.Color.White;
            this.managementlogin.Location = new System.Drawing.Point(606, 23);
            this.managementlogin.Name = "managementlogin";
            this.managementlogin.Size = new System.Drawing.Size(412, 54);
            this.managementlogin.TabIndex = 11;
            this.managementlogin.Text = "Management Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::UnicomTICManagementSystem.Properties.Resources._34_349693_circled_user_icon_transparent_background_username_icon_hd;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::UnicomTICManagementSystem.Properties.Resources._34_349693_circled_user_icon_transparent_background_username_icon_hd;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(640, 439);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Mainlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.managementlogin);
            this.Controls.Add(this.cancelbtn1);
            this.Controls.Add(this.loginbtn1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.role);
            this.Controls.Add(this.rolecomboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mainlogin";
            this.Text = "Mainlogin";
            this.Load += new System.EventHandler(this.Mainlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox rolecomboBox1;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Button cancelbtn1;
        private System.Windows.Forms.Button loginbtn1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label password1;
        private System.Windows.Forms.Label username1;
        private System.Windows.Forms.Label managementlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}