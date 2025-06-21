    namespace UnicomTICManagementSystem
{
    partial class Adminloginform
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
                this.Admin_Name = new System.Windows.Forms.TextBox();
                this.Admin_password = new System.Windows.Forms.TextBox();
                this.loginbtn1 = new System.Windows.Forms.Button();
                this.Tittle = new System.Windows.Forms.Label();
                this.SuspendLayout();
                // 
                // Admin_Name
                // 
                this.Admin_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
                this.Admin_Name.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Admin_Name.Location = new System.Drawing.Point(534, 235);
                this.Admin_Name.Multiline = true;
                this.Admin_Name.Name = "Admin_Name";
                this.Admin_Name.Size = new System.Drawing.Size(318, 56);
                this.Admin_Name.TabIndex = 1;
                this.Admin_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.Admin_Name.TextChanged += new System.EventHandler(this.Admin_Name_TextChanged);
                // 
                // Admin_password
                // 
                this.Admin_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
                this.Admin_password.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Admin_password.Location = new System.Drawing.Point(534, 336);
                this.Admin_password.Multiline = true;
                this.Admin_password.Name = "Admin_password";
                this.Admin_password.Size = new System.Drawing.Size(318, 56);
                this.Admin_password.TabIndex = 1;
                this.Admin_password.Text = "\r\n";
                this.Admin_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.Admin_password.TextChanged += new System.EventHandler(this.Admin_password_TextChanged);
                // 
                // loginbtn1
                // 
                this.loginbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.loginbtn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.loginbtn1.Location = new System.Drawing.Point(777, 416);
                this.loginbtn1.Name = "loginbtn1";
                this.loginbtn1.Size = new System.Drawing.Size(75, 26);
                this.loginbtn1.TabIndex = 2;
                this.loginbtn1.Text = "Login";
                this.loginbtn1.UseVisualStyleBackColor = true;
                this.loginbtn1.Click += new System.EventHandler(this.loginbtn1_Click);
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
                this.Tittle.Location = new System.Drawing.Point(132, 118);
                this.Tittle.Name = "Tittle";
                this.Tittle.Size = new System.Drawing.Size(1123, 69);
                this.Tittle.TabIndex = 4;
                this.Tittle.Text = "UNICOM TIC MANAGEMENT SYSTEM";
                this.Tittle.Click += new System.EventHandler(this.Tittle_Click);
                // 
                // Adminloginform
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(1386, 725);
                this.Controls.Add(this.Admin_Name);
                this.Controls.Add(this.Tittle);
                this.Controls.Add(this.loginbtn1);
                this.Controls.Add(this.Admin_password);
                this.Name = "Adminloginform";
                this.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.Text = "Unicom TIC Management System - Login";
                this.Load += new System.EventHandler(this.Mainform_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion
        private System.Windows.Forms.TextBox Admin_Name;
        private System.Windows.Forms.TextBox Admin_password;
        private System.Windows.Forms.Button loginbtn1;
        private System.Windows.Forms.Label Tittle;
    }
}

