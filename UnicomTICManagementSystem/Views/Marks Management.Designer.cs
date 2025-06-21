namespace UnicomTICManagementSystem.Views
{
    partial class Marks_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marks_Management));
            this.marksdataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.dateTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.date = new System.Windows.Forms.Label();
            this.studentname = new System.Windows.Forms.Label();
            this.subjectname = new System.Windows.Forms.Label();
            this.tittle = new System.Windows.Forms.Label();
            this.marks = new System.Windows.Forms.Label();
            this.marks1 = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.studentname1 = new System.Windows.Forms.ComboBox();
            this.subjectname1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.marksdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // marksdataGridView1
            // 
            this.marksdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.marksdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksdataGridView1.Location = new System.Drawing.Point(262, 340);
            this.marksdataGridView1.Name = "marksdataGridView1";
            this.marksdataGridView1.RowHeadersWidth = 51;
            this.marksdataGridView1.Size = new System.Drawing.Size(680, 317);
            this.marksdataGridView1.TabIndex = 27;
            this.marksdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marksdataGridView1_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebtn.Location = new System.Drawing.Point(836, 253);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(106, 28);
            this.deletebtn.TabIndex = 24;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatebtn.Location = new System.Drawing.Point(546, 253);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(106, 28);
            this.updatebtn.TabIndex = 25;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbtn.Location = new System.Drawing.Point(246, 253);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(106, 28);
            this.addbtn.TabIndex = 26;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox1.Location = new System.Drawing.Point(975, 179);
            this.dateTextBox1.Mask = "00/00/0000";
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.Size = new System.Drawing.Size(199, 24);
            this.dateTextBox1.TabIndex = 23;
            this.dateTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.date.Location = new System.Drawing.Point(1012, 151);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(64, 25);
            this.date.TabIndex = 20;
            this.date.Text = "Date";
            // 
            // studentname
            // 
            this.studentname.AutoSize = true;
            this.studentname.BackColor = System.Drawing.Color.Transparent;
            this.studentname.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.studentname.Location = new System.Drawing.Point(46, 147);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(171, 25);
            this.studentname.TabIndex = 21;
            this.studentname.Text = "Student Name";
            // 
            // subjectname
            // 
            this.subjectname.AutoSize = true;
            this.subjectname.BackColor = System.Drawing.Color.Transparent;
            this.subjectname.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.subjectname.Location = new System.Drawing.Point(326, 147);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(166, 25);
            this.subjectname.TabIndex = 22;
            this.subjectname.Text = "Subject Name";
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.Color.Transparent;
            this.tittle.Font = new System.Drawing.Font("Cooper Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tittle.Location = new System.Drawing.Point(496, 37);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(323, 55);
            this.tittle.TabIndex = 19;
            this.tittle.Text = "Marks Table";
            this.tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // marks
            // 
            this.marks.AutoSize = true;
            this.marks.BackColor = System.Drawing.Color.Transparent;
            this.marks.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marks.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.marks.Location = new System.Drawing.Point(688, 147);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(81, 25);
            this.marks.TabIndex = 21;
            this.marks.Text = "Marks";
            // 
            // marks1
            // 
            this.marks1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marks1.Location = new System.Drawing.Point(646, 176);
            this.marks1.Name = "marks1";
            this.marks1.Size = new System.Drawing.Size(179, 26);
            this.marks1.TabIndex = 29;
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Location = new System.Drawing.Point(16, 652);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 30;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // studentname1
            // 
            this.studentname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname1.FormattingEnabled = true;
            this.studentname1.Location = new System.Drawing.Point(27, 176);
            this.studentname1.Name = "studentname1";
            this.studentname1.Size = new System.Drawing.Size(156, 25);
            this.studentname1.TabIndex = 31;
            // 
            // subjectname1
            // 
            this.subjectname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectname1.FormattingEnabled = true;
            this.subjectname1.Location = new System.Drawing.Point(313, 176);
            this.subjectname1.Name = "subjectname1";
            this.subjectname1.Size = new System.Drawing.Size(151, 25);
            this.subjectname1.TabIndex = 31;
            // 
            // Marks_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.subjectname1);
            this.Controls.Add(this.studentname1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.marks1);
            this.Controls.Add(this.marksdataGridView1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.dateTextBox1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.tittle);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Marks_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marks_Management";
            this.Load += new System.EventHandler(this.Marks_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marksdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView marksdataGridView1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.MaskedTextBox dateTextBox1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label studentname;
        private System.Windows.Forms.Label subjectname;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label marks;
        private System.Windows.Forms.TextBox marks1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ComboBox studentname1;
        private System.Windows.Forms.ComboBox subjectname1;
    }
}