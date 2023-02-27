namespace WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Company = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.ComboBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.TermsAndCondition = new System.Windows.Forms.CheckBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ZipCode = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.AdditionalInformation = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BusinessArena = new System.Windows.Forms.TextBox();
            this.Designation = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Title);
            this.splitContainer1.Panel1.Controls.Add(this.Designation);
            this.splitContainer1.Panel1.Controls.Add(this.BusinessArena);
            this.splitContainer1.Panel1.Controls.Add(this.Company);
            this.splitContainer1.Panel1.Controls.Add(this.Position);
            this.splitContainer1.Panel1.Controls.Add(this.LastName);
            this.splitContainer1.Panel1.Controls.Add(this.FirstName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(53)))), ((int)(((byte)(212)))));
            this.splitContainer1.Panel2.Controls.Add(this.Register);
            this.splitContainer1.Panel2.Controls.Add(this.TermsAndCondition);
            this.splitContainer1.Panel2.Controls.Add(this.Code);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.ZipCode);
            this.splitContainer1.Panel2.Controls.Add(this.PhoneNumber);
            this.splitContainer1.Panel2.Controls.Add(this.Email);
            this.splitContainer1.Panel2.Controls.Add(this.AdditionalInformation);
            this.splitContainer1.Panel2.Controls.Add(this.Street);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(869, 436);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 0;
            // 
            // Company
            // 
            this.Company.Location = new System.Drawing.Point(29, 197);
            this.Company.Name = "Company";
            this.Company.PlaceholderText = "Company";
            this.Company.Size = new System.Drawing.Size(361, 23);
            this.Company.TabIndex = 5;
            this.Company.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Position
            // 
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "Director",
            "Manager",
            "Employee"});
            this.Position.Location = new System.Drawing.Point(29, 155);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(361, 23);
            this.Position.TabIndex = 4;
            this.Position.Tag = "Title";
            this.Position.Text = "Position";
            this.Position.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(215, 114);
            this.LastName.Name = "LastName";
            this.LastName.PlaceholderText = "Last Name";
            this.LastName.Size = new System.Drawing.Size(175, 23);
            this.LastName.TabIndex = 3;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(29, 114);
            this.FirstName.Name = "FirstName";
            this.FirstName.PlaceholderText = "First Name";
            this.FirstName.Size = new System.Drawing.Size(175, 23);
            this.FirstName.TabIndex = 2;
            this.FirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(53)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Register
            // 
            this.Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Register.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register.Location = new System.Drawing.Point(31, 343);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(128, 37);
            this.Register.TabIndex = 15;
            this.Register.Tag = "";
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.RegisterBadge_Click);
            // 
            // TermsAndCondition
            // 
            this.TermsAndCondition.AutoSize = true;
            this.TermsAndCondition.ForeColor = System.Drawing.Color.White;
            this.TermsAndCondition.Location = new System.Drawing.Point(31, 318);
            this.TermsAndCondition.Name = "TermsAndCondition";
            this.TermsAndCondition.Size = new System.Drawing.Size(284, 19);
            this.TermsAndCondition.TabIndex = 14;
            this.TermsAndCondition.Text = "I do accept the Terms and Conditions of your site";
            this.TermsAndCondition.UseVisualStyleBackColor = true;
            this.TermsAndCondition.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(31, 238);
            this.Code.Name = "Code";
            this.Code.PlaceholderText = "Code +";
            this.Code.Size = new System.Drawing.Size(119, 23);
            this.Code.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nepal",
            "India",
            "China"});
            this.comboBox2.Location = new System.Drawing.Point(31, 197);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(361, 23);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Country";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Street",
            "District",
            "City"});
            this.comboBox1.Location = new System.Drawing.Point(156, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Place";
            // 
            // ZipCode
            // 
            this.ZipCode.Location = new System.Drawing.Point(31, 155);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.PlaceholderText = "Zip Code";
            this.ZipCode.Size = new System.Drawing.Size(119, 23);
            this.ZipCode.TabIndex = 10;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(156, 238);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.PlaceholderText = "Phone Number";
            this.PhoneNumber.Size = new System.Drawing.Size(236, 23);
            this.PhoneNumber.TabIndex = 9;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(31, 279);
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "Your Email";
            this.Email.Size = new System.Drawing.Size(361, 23);
            this.Email.TabIndex = 8;
            // 
            // AdditionalInformation
            // 
            this.AdditionalInformation.Location = new System.Drawing.Point(31, 114);
            this.AdditionalInformation.Name = "AdditionalInformation";
            this.AdditionalInformation.PlaceholderText = "Additional Information";
            this.AdditionalInformation.Size = new System.Drawing.Size(361, 23);
            this.AdditionalInformation.TabIndex = 7;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(31, 76);
            this.Street.Name = "Street";
            this.Street.PlaceholderText = " Streeet + Nr";
            this.Street.Size = new System.Drawing.Size(361, 23);
            this.Street.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Details";
            // 
            // BusinessArena
            // 
            this.BusinessArena.Location = new System.Drawing.Point(29, 238);
            this.BusinessArena.Name = "BusinessArena";
            this.BusinessArena.PlaceholderText = "Business Arena";
            this.BusinessArena.Size = new System.Drawing.Size(175, 23);
            this.BusinessArena.TabIndex = 6;
            // 
            // Designation
            // 
            this.Designation.FormattingEnabled = true;
            this.Designation.Items.AddRange(new object[] {
            "Trainee",
            "Colleague",
            "Associate"});
            this.Designation.Location = new System.Drawing.Point(215, 238);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(175, 23);
            this.Designation.TabIndex = 7;
            this.Designation.Text = "Designation";
            // 
            // Title
            // 
            this.Title.FormattingEnabled = true;
            this.Title.Items.AddRange(new object[] {
            "Businessman",
            "Reporter",
            "Secretary"});
            this.Title.Location = new System.Drawing.Point(29, 76);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(361, 23);
            this.Title.TabIndex = 8;
            this.Title.Tag = "Title";
            this.Title.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 436);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private ComboBox Position;
        private TextBox LastName;
        private TextBox FirstName;
        private TextBox Company;
        private CheckBox TermsAndCondition;
        private TextBox Code;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox ZipCode;
        private TextBox PhoneNumber;
        private TextBox Email;
        private TextBox AdditionalInformation;
        private TextBox Street;
        private Button Register;
        private ComboBox Title;
        private ComboBox Designation;
        private TextBox BusinessArena;
    }
}