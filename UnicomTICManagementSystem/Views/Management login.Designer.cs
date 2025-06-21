namespace UnicomTICManagementSystem.Views
{
    partial class Management_login
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
            this.loginbtn1 = new System.Windows.Forms.Button();
            this.Tittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbtn1
            // 
            this.loginbtn1.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn1.Location = new System.Drawing.Point(-9, -37);
            this.loginbtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbtn1.Name = "loginbtn1";
            this.loginbtn1.Size = new System.Drawing.Size(1600, 900);
            this.loginbtn1.TabIndex = 4;
            this.loginbtn1.UseVisualStyleBackColor = false;
            this.loginbtn1.Click += new System.EventHandler(this.loginbtn1_Click);
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.BackColor = System.Drawing.Color.Transparent;
            this.Tittle.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.Location = new System.Drawing.Point(76, 45);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(1428, 83);
            this.Tittle.TabIndex = 5;
            this.Tittle.Text = "UNICOMTIC MANAGEMENT SYSTEM";
            this.Tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Management_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 853);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.loginbtn1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Management_login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Management_login";
            this.Load += new System.EventHandler(this.Management_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginbtn1;
        private System.Windows.Forms.Label Tittle;
    }
}