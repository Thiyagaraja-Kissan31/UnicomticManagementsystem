namespace UnicomTICManagementSystem.Views
{
    partial class Student_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Management));
            this.tittle = new System.Windows.Forms.Label();
            this.studentname = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.gendercombobox = new System.Windows.Forms.ComboBox();
            this.dateofbirthTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.subjectcombobox = new System.Windows.Forms.ComboBox();
            this.phonenumberTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.studentdetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.Color.Transparent;
            this.tittle.Font = new System.Drawing.Font("Cooper Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tittle.Location = new System.Drawing.Point(272, 7);
            this.tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(682, 55);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Student Registration Form";
            // 
            // studentname
            // 
            this.studentname.AutoSize = true;
            this.studentname.BackColor = System.Drawing.Color.Transparent;
            this.studentname.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.studentname.Location = new System.Drawing.Point(56, 81);
            this.studentname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(178, 25);
            this.studentname.TabIndex = 1;
            this.studentname.Text = "Student Name:";
            this.studentname.Click += new System.EventHandler(this.studentname_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.address.Location = new System.Drawing.Point(56, 159);
            this.address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(109, 25);
            this.address.TabIndex = 2;
            this.address.Text = "Address:";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.BackColor = System.Drawing.Color.Transparent;
            this.dateofbirth.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateofbirth.Location = new System.Drawing.Point(56, 322);
            this.dateofbirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(166, 25);
            this.dateofbirth.TabIndex = 2;
            this.dateofbirth.Text = "Date of Birth:";
            this.dateofbirth.Click += new System.EventHandler(this.dateofbirth_Click);
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSize = true;
            this.phonenumber.BackColor = System.Drawing.Color.Transparent;
            this.phonenumber.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.phonenumber.Location = new System.Drawing.Point(56, 443);
            this.phonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(130, 25);
            this.phonenumber.TabIndex = 2;
            this.phonenumber.Text = "Mobile No:";
            this.phonenumber.Click += new System.EventHandler(this.phonenumber_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.email.Location = new System.Drawing.Point(56, 494);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(112, 25);
            this.email.TabIndex = 2;
            this.email.Text = "Email Id:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gender.Location = new System.Drawing.Point(56, 231);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(101, 25);
            this.gender.TabIndex = 2;
            this.gender.Text = "Gender:";
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.BackColor = System.Drawing.Color.Transparent;
            this.subject.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.subject.Location = new System.Drawing.Point(56, 384);
            this.subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(173, 25);
            this.subject.TabIndex = 2;
            this.subject.Text = "Subject Name:";
            this.subject.Click += new System.EventHandler(this.subject_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(9, 718);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(76, 26);
            this.Backbtn.TabIndex = 3;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(244, 84);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(318, 26);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // addresstextbox
            // 
            this.addresstextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstextbox.Location = new System.Drawing.Point(244, 157);
            this.addresstextbox.Margin = new System.Windows.Forms.Padding(2);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(318, 26);
            this.addresstextbox.TabIndex = 4;
            this.addresstextbox.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // gendercombobox
            // 
            this.gendercombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendercombobox.FormattingEnabled = true;
            this.gendercombobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercombobox.Location = new System.Drawing.Point(244, 231);
            this.gendercombobox.Margin = new System.Windows.Forms.Padding(2);
            this.gendercombobox.Name = "gendercombobox";
            this.gendercombobox.Size = new System.Drawing.Size(318, 25);
            this.gendercombobox.TabIndex = 5;
            this.gendercombobox.SelectedIndexChanged += new System.EventHandler(this.gendercombobox_SelectedIndexChanged);
            // 
            // dateofbirthTextBox1
            // 
            this.dateofbirthTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirthTextBox1.Location = new System.Drawing.Point(244, 322);
            this.dateofbirthTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.dateofbirthTextBox1.Mask = "00/00/0000 ";
            this.dateofbirthTextBox1.Name = "dateofbirthTextBox1";
            this.dateofbirthTextBox1.Size = new System.Drawing.Size(318, 24);
            this.dateofbirthTextBox1.TabIndex = 7;
            this.dateofbirthTextBox1.ValidatingType = typeof(System.DateTime);
            this.dateofbirthTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dateofbirthTextBox1_MaskInputRejected);
            // 
            // subjectcombobox
            // 
            this.subjectcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectcombobox.FormattingEnabled = true;
            this.subjectcombobox.Location = new System.Drawing.Point(244, 384);
            this.subjectcombobox.Margin = new System.Windows.Forms.Padding(2);
            this.subjectcombobox.Name = "subjectcombobox";
            this.subjectcombobox.Size = new System.Drawing.Size(318, 25);
            this.subjectcombobox.TabIndex = 5;
            this.subjectcombobox.SelectedIndexChanged += new System.EventHandler(this.subjectcombobox_SelectedIndexChanged);
            // 
            // phonenumberTextBox2
            // 
            this.phonenumberTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumberTextBox2.Location = new System.Drawing.Point(305, 441);
            this.phonenumberTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.phonenumberTextBox2.Mask = " 00-000-000";
            this.phonenumberTextBox2.Name = "phonenumberTextBox2";
            this.phonenumberTextBox2.Size = new System.Drawing.Size(257, 24);
            this.phonenumberTextBox2.TabIndex = 8;
            this.phonenumberTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(244, 441);
            this.number.Margin = new System.Windows.Forms.Padding(2);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(50, 24);
            this.number.TabIndex = 9;
            this.number.Text = "+94";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // emailtextbox
            // 
            this.emailtextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextbox.Location = new System.Drawing.Point(244, 494);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(318, 26);
            this.emailtextbox.TabIndex = 4;
            this.emailtextbox.TextChanged += new System.EventHandler(this.emailtextbox_TextChanged);
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(509, 554);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(63, 25);
            this.submitbtn.TabIndex = 31;
            this.submitbtn.Text = "Add";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 650);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 40;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(343, 554);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(81, 25);
            this.Deletebtn.TabIndex = 31;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(428, 554);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(76, 25);
            this.updatebtn.TabIndex = 31;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // studentdetails
            // 
            this.studentdetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdetails.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentdetails.Location = new System.Drawing.Point(597, 84);
            this.studentdetails.Margin = new System.Windows.Forms.Padding(2);
            this.studentdetails.Name = "studentdetails";
            this.studentdetails.RowHeadersWidth = 51;
            this.studentdetails.RowTemplate.Height = 24;
            this.studentdetails.Size = new System.Drawing.Size(580, 495);
            this.studentdetails.TabIndex = 41;
            this.studentdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentdetails_CellContentClick);
            // 
            // Student_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.studentdetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.number);
            this.Controls.Add(this.phonenumberTextBox2);
            this.Controls.Add(this.dateofbirthTextBox1);
            this.Controls.Add(this.subjectcombobox);
            this.Controls.Add(this.gendercombobox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.addresstextbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.email);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.address);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Management";
            this.Load += new System.EventHandler(this.Student_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label studentname;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Label phonenumber;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.ComboBox gendercombobox;
        private System.Windows.Forms.MaskedTextBox dateofbirthTextBox1;
        private System.Windows.Forms.ComboBox subjectcombobox;
        private System.Windows.Forms.MaskedTextBox phonenumberTextBox2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.DataGridView studentdetails;
    }
}