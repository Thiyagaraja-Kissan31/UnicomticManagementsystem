namespace UnicomTICManagementSystem.Views
{
    partial class Lecturer_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturer_Management));
            this.number = new System.Windows.Forms.TextBox();
            this.mobilenum = new System.Windows.Forms.MaskedTextBox();
            this.dateofbirthTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.subjectcombobox = new System.Windows.Forms.ComboBox();
            this.gendercombobox = new System.Windows.Forms.ComboBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.lecturername = new System.Windows.Forms.Label();
            this.tittle = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.lecturerdataGridView = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(244, 344);
            this.number.Margin = new System.Windows.Forms.Padding(2);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(50, 24);
            this.number.TabIndex = 29;
            this.number.Text = "+94";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mobilenum
            // 
            this.mobilenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilenum.Location = new System.Drawing.Point(306, 344);
            this.mobilenum.Margin = new System.Windows.Forms.Padding(2);
            this.mobilenum.Mask = " 00-000-000";
            this.mobilenum.Name = "mobilenum";
            this.mobilenum.Size = new System.Drawing.Size(257, 24);
            this.mobilenum.TabIndex = 28;
            // 
            // dateofbirthTextBox1
            // 
            this.dateofbirthTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirthTextBox1.Location = new System.Drawing.Point(244, 297);
            this.dateofbirthTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.dateofbirthTextBox1.Mask = "00/00/0000 ";
            this.dateofbirthTextBox1.Name = "dateofbirthTextBox1";
            this.dateofbirthTextBox1.Size = new System.Drawing.Size(318, 24);
            this.dateofbirthTextBox1.TabIndex = 27;
            this.dateofbirthTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // subjectcombobox
            // 
            this.subjectcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectcombobox.FormattingEnabled = true;
            this.subjectcombobox.Location = new System.Drawing.Point(244, 149);
            this.subjectcombobox.Margin = new System.Windows.Forms.Padding(2);
            this.subjectcombobox.Name = "subjectcombobox";
            this.subjectcombobox.Size = new System.Drawing.Size(318, 25);
            this.subjectcombobox.TabIndex = 26;
            // 
            // gendercombobox
            // 
            this.gendercombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendercombobox.FormattingEnabled = true;
            this.gendercombobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercombobox.Location = new System.Drawing.Point(244, 230);
            this.gendercombobox.Margin = new System.Windows.Forms.Padding(2);
            this.gendercombobox.Name = "gendercombobox";
            this.gendercombobox.Size = new System.Drawing.Size(318, 25);
            this.gendercombobox.TabIndex = 25;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextbox.Location = new System.Drawing.Point(244, 392);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(318, 24);
            this.emailtextbox.TabIndex = 23;
            // 
            // addresstextbox
            // 
            this.addresstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstextbox.Location = new System.Drawing.Point(244, 190);
            this.addresstextbox.Margin = new System.Windows.Forms.Padding(2);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(318, 24);
            this.addresstextbox.TabIndex = 24;
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Backbtn.Location = new System.Drawing.Point(9, 711);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(97, 33);
            this.Backbtn.TabIndex = 21;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gender.Location = new System.Drawing.Point(49, 230);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(101, 25);
            this.gender.TabIndex = 19;
            this.gender.Text = "Gender:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.email.Location = new System.Drawing.Point(49, 392);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(112, 25);
            this.email.TabIndex = 18;
            this.email.Text = "Email Id:";
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.BackColor = System.Drawing.Color.Transparent;
            this.subject.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.subject.Location = new System.Drawing.Point(49, 149);
            this.subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(173, 25);
            this.subject.TabIndex = 17;
            this.subject.Text = "Subject Name:";
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSize = true;
            this.phonenumber.BackColor = System.Drawing.Color.Transparent;
            this.phonenumber.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.phonenumber.Location = new System.Drawing.Point(49, 344);
            this.phonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(130, 25);
            this.phonenumber.TabIndex = 16;
            this.phonenumber.Text = "Mobile No:";
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.BackColor = System.Drawing.Color.Transparent;
            this.dateofbirth.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateofbirth.Location = new System.Drawing.Point(49, 297);
            this.dateofbirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(166, 25);
            this.dateofbirth.TabIndex = 15;
            this.dateofbirth.Text = "Date of Birth:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.address.Location = new System.Drawing.Point(49, 190);
            this.address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(109, 25);
            this.address.TabIndex = 14;
            this.address.Text = "Address:";
            // 
            // lecturername
            // 
            this.lecturername.AutoSize = true;
            this.lecturername.BackColor = System.Drawing.Color.Transparent;
            this.lecturername.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturername.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lecturername.Location = new System.Drawing.Point(49, 109);
            this.lecturername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lecturername.Name = "lecturername";
            this.lecturername.Size = new System.Drawing.Size(187, 25);
            this.lecturername.TabIndex = 13;
            this.lecturername.Text = "Lecturer Name:";
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.Color.Transparent;
            this.tittle.Font = new System.Drawing.Font("Cooper Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tittle.Location = new System.Drawing.Point(312, 9);
            this.tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(698, 55);
            this.tittle.TabIndex = 12;
            this.tittle.Text = "Lecturer Registration Form";
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitbtn.Location = new System.Drawing.Point(518, 433);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(79, 25);
            this.submitbtn.TabIndex = 30;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(244, 109);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(318, 24);
            this.name.TabIndex = 32;
            // 
            // lecturerdataGridView
            // 
            this.lecturerdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lecturerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturerdataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lecturerdataGridView.Location = new System.Drawing.Point(663, 109);
            this.lecturerdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.lecturerdataGridView.Name = "lecturerdataGridView";
            this.lecturerdataGridView.RowHeadersWidth = 51;
            this.lecturerdataGridView.RowTemplate.Height = 24;
            this.lecturerdataGridView.Size = new System.Drawing.Size(517, 301);
            this.lecturerdataGridView.TabIndex = 33;
            this.lecturerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lecturerdataGridView_click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Deletebtn.Location = new System.Drawing.Point(420, 433);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(85, 25);
            this.Deletebtn.TabIndex = 34;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Lecturer_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.lecturerdataGridView);
            this.Controls.Add(this.name);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.number);
            this.Controls.Add(this.mobilenum);
            this.Controls.Add(this.dateofbirthTextBox1);
            this.Controls.Add(this.subjectcombobox);
            this.Controls.Add(this.gendercombobox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.addresstextbox);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.email);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lecturername);
            this.Controls.Add(this.tittle);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lecturer_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture_Management";
            this.Load += new System.EventHandler(this.Lecturer_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.MaskedTextBox mobilenum;
        private System.Windows.Forms.MaskedTextBox dateofbirthTextBox1;
        private System.Windows.Forms.ComboBox subjectcombobox;
        private System.Windows.Forms.ComboBox gendercombobox;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.Label phonenumber;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label lecturername;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView lecturerdataGridView;
        private System.Windows.Forms.Button Deletebtn;
    }
}