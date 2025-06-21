namespace UnicomTICManagementSystem.Views
{
    partial class Attendance_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance_Management));
            this.tittle = new System.Windows.Forms.Label();
            this.dateofbirthTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.statuscombobox = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.subjectname = new System.Windows.Forms.Label();
            this.studentname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.ComboBox();
            this.subjectnametextbox = new System.Windows.Forms.ComboBox();
            this.Deletebtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.Color.Transparent;
            this.tittle.Font = new System.Drawing.Font("Cooper Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tittle.Location = new System.Drawing.Point(448, 20);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(305, 55);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Attendance";
            // 
            // dateofbirthTextBox1
            // 
            this.dateofbirthTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirthTextBox1.Location = new System.Drawing.Point(276, 316);
            this.dateofbirthTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateofbirthTextBox1.Mask = "00/00/0000 ";
            this.dateofbirthTextBox1.Name = "dateofbirthTextBox1";
            this.dateofbirthTextBox1.Size = new System.Drawing.Size(318, 24);
            this.dateofbirthTextBox1.TabIndex = 15;
            this.dateofbirthTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // statuscombobox
            // 
            this.statuscombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuscombobox.FormattingEnabled = true;
            this.statuscombobox.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Late",
            "Excused"});
            this.statuscombobox.Location = new System.Drawing.Point(275, 384);
            this.statuscombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statuscombobox.Name = "statuscombobox";
            this.statuscombobox.Size = new System.Drawing.Size(318, 25);
            this.statuscombobox.TabIndex = 14;
            // 
            // status
            // 
            this.status.AllowDrop = true;
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Cursor = System.Windows.Forms.Cursors.Default;
            this.status.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.status.Location = new System.Drawing.Point(87, 384);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(97, 27);
            this.status.TabIndex = 9;
            this.status.Text = "Status:";
            // 
            // dateofbirth
            // 
            this.dateofbirth.AllowDrop = true;
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.BackColor = System.Drawing.Color.Transparent;
            this.dateofbirth.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateofbirth.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateofbirth.Location = new System.Drawing.Point(88, 316);
            this.dateofbirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(76, 27);
            this.dateofbirth.TabIndex = 10;
            this.dateofbirth.Text = "Date:";
            // 
            // subjectname
            // 
            this.subjectname.AllowDrop = true;
            this.subjectname.AutoSize = true;
            this.subjectname.BackColor = System.Drawing.Color.Transparent;
            this.subjectname.Cursor = System.Windows.Forms.Cursors.Default;
            this.subjectname.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.subjectname.Location = new System.Drawing.Point(87, 237);
            this.subjectname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(187, 27);
            this.subjectname.TabIndex = 11;
            this.subjectname.Text = "Subject Name:";
            // 
            // studentname
            // 
            this.studentname.AllowDrop = true;
            this.studentname.AutoSize = true;
            this.studentname.BackColor = System.Drawing.Color.Transparent;
            this.studentname.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentname.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.studentname.Location = new System.Drawing.Point(88, 171);
            this.studentname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(193, 27);
            this.studentname.TabIndex = 8;
            this.studentname.Text = "Student Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(666, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(478, 487);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 650);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 19;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(530, 439);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 25);
            this.submitbtn.TabIndex = 31;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(275, 174);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(318, 25);
            this.name.TabIndex = 32;
            // 
            // subjectnametextbox
            // 
            this.subjectnametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectnametextbox.FormattingEnabled = true;
            this.subjectnametextbox.Location = new System.Drawing.Point(275, 237);
            this.subjectnametextbox.Name = "subjectnametextbox";
            this.subjectnametextbox.Size = new System.Drawing.Size(318, 25);
            this.subjectnametextbox.TabIndex = 32;
            // 
            // Deletebtn1
            // 
            this.Deletebtn1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn1.Location = new System.Drawing.Point(443, 439);
            this.Deletebtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Deletebtn1.Name = "Deletebtn1";
            this.Deletebtn1.Size = new System.Drawing.Size(78, 25);
            this.Deletebtn1.TabIndex = 35;
            this.Deletebtn1.Text = "Delete";
            this.Deletebtn1.UseVisualStyleBackColor = true;
            this.Deletebtn1.Click += new System.EventHandler(this.Deletebtn1_Click);
            // 
            // Attendance_Management
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.Deletebtn1);
            this.Controls.Add(this.subjectnametextbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateofbirthTextBox1);
            this.Controls.Add(this.statuscombobox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.tittle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance_Management";
            this.Load += new System.EventHandler(this.Attendance_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.MaskedTextBox dateofbirthTextBox1;
        private System.Windows.Forms.ComboBox statuscombobox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Label subjectname;
        private System.Windows.Forms.Label studentname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.ComboBox subjectnametextbox;
        private System.Windows.Forms.Button Deletebtn1;
    }
}