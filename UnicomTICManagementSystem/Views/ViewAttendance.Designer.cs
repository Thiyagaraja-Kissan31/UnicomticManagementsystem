﻿namespace UnicomTICManagementSystem.Views
{
    partial class VIewAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIewAttendance));
            this.tittle = new System.Windows.Forms.Label();
            this.viewattendancedata2 = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewattendancedata2)).BeginInit();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.Color.Transparent;
            this.tittle.Font = new System.Drawing.Font("Cooper Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tittle.Location = new System.Drawing.Point(382, 44);
            this.tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(445, 55);
            this.tittle.TabIndex = 7;
            this.tittle.Text = "View Attendance";
            // 
            // viewattendancedata2
            // 
            this.viewattendancedata2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewattendancedata2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewattendancedata2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewattendancedata2.Location = new System.Drawing.Point(367, 147);
            this.viewattendancedata2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewattendancedata2.Name = "viewattendancedata2";
            this.viewattendancedata2.RowHeadersWidth = 51;
            this.viewattendancedata2.RowTemplate.Height = 24;
            this.viewattendancedata2.Size = new System.Drawing.Size(452, 349);
            this.viewattendancedata2.TabIndex = 6;
            this.viewattendancedata2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewattendancedata2_CellContentClick);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(10, 652);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // VIewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.viewattendancedata2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VIewAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAttendance";
            this.Load += new System.EventHandler(this.ViewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewattendancedata2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.DataGridView viewattendancedata2;
        private System.Windows.Forms.Button backbtn;
    }
}