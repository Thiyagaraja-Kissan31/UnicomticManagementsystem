namespace UnicomTICManagementSystem.Views
{
    partial class Exam_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam_Management));
            this.examdataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.timeTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.dateTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.subjectname = new System.Windows.Forms.Label();
            this.tittle = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.subjectextBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.examdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // examdataGridView1
            // 
            this.examdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.examdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examdataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.examdataGridView1.Location = new System.Drawing.Point(288, 281);
            this.examdataGridView1.Name = "examdataGridView1";
            this.examdataGridView1.RowHeadersWidth = 51;
            this.examdataGridView1.Size = new System.Drawing.Size(611, 298);
            this.examdataGridView1.TabIndex = 17;
            this.examdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examdataGridView1_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebtn.Location = new System.Drawing.Point(844, 228);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(106, 28);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatebtn.Location = new System.Drawing.Point(536, 228);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(106, 28);
            this.updatebtn.TabIndex = 15;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbtn.Location = new System.Drawing.Point(198, 228);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(106, 28);
            this.addbtn.TabIndex = 16;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // timeTextBox2
            // 
            this.timeTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox2.Location = new System.Drawing.Point(825, 159);
            this.timeTextBox2.Mask = "90:00";
            this.timeTextBox2.Name = "timeTextBox2";
            this.timeTextBox2.Size = new System.Drawing.Size(175, 24);
            this.timeTextBox2.TabIndex = 13;
            this.timeTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox1.Location = new System.Drawing.Point(521, 159);
            this.dateTextBox1.Mask = "00/00/0000";
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.Size = new System.Drawing.Size(199, 24);
            this.dateTextBox1.TabIndex = 12;
            this.dateTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.CausesValidation = false;
            this.time.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.time.Location = new System.Drawing.Point(854, 128);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(74, 27);
            this.time.TabIndex = 8;
            this.time.Text = "Time";
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.CausesValidation = false;
            this.date.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.date.Location = new System.Drawing.Point(578, 128);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(69, 27);
            this.date.TabIndex = 9;
            this.date.Text = "Date";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // subjectname
            // 
            this.subjectname.AutoSize = true;
            this.subjectname.BackColor = System.Drawing.Color.Transparent;
            this.subjectname.CausesValidation = false;
            this.subjectname.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.subjectname.Location = new System.Drawing.Point(186, 128);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(180, 27);
            this.subjectname.TabIndex = 10;
            this.subjectname.Text = "Subject Name";
            this.subjectname.Click += new System.EventHandler(this.subjectname_Click);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.Color.Transparent;
            this.tittle.CausesValidation = false;
            this.tittle.Font = new System.Drawing.Font("Cooper Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tittle.Location = new System.Drawing.Point(500, 20);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(342, 55);
            this.tittle.TabIndex = 7;
            this.tittle.Text = "Exam Details";
            this.tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tittle.Click += new System.EventHandler(this.tittle_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Location = new System.Drawing.Point(12, 650);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 18;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // subjectextBox2
            // 
            this.subjectextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectextBox2.FormattingEnabled = true;
            this.subjectextBox2.Location = new System.Drawing.Point(166, 159);
            this.subjectextBox2.Name = "subjectextBox2";
            this.subjectextBox2.Size = new System.Drawing.Size(181, 25);
            this.subjectextBox2.TabIndex = 19;
            // 
            // Exam_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.subjectextBox2);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.timeTextBox2);
            this.Controls.Add(this.dateTextBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.examdataGridView1);
            this.Controls.Add(this.tittle);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exam_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam_Management";
            this.Load += new System.EventHandler(this.Exam_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView examdataGridView1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.MaskedTextBox timeTextBox2;
        private System.Windows.Forms.MaskedTextBox dateTextBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label subjectname;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ComboBox subjectextBox2;
    }
}