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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management_login));
            this.loginbtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginbtn1
            // 
            this.loginbtn1.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbtn1.BackgroundImage")));
            this.loginbtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn1.Location = new System.Drawing.Point(-8, -16);
            this.loginbtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbtn1.Name = "loginbtn1";
            this.loginbtn1.Size = new System.Drawing.Size(1600, 916);
            this.loginbtn1.TabIndex = 4;
            this.loginbtn1.UseVisualStyleBackColor = false;
            this.loginbtn1.Click += new System.EventHandler(this.loginbtn1_Click);
            // 
            // Management_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 853);
            this.Controls.Add(this.loginbtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Management_login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management_login";
            this.Load += new System.EventHandler(this.Management_login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loginbtn1;
    }
}