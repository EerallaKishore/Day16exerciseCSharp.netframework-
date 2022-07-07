namespace Day16exercise
{
    partial class Form1
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
            this.LabRegistration = new System.Windows.Forms.Label();
            this.LabDob = new System.Windows.Forms.Label();
            this.LabFName = new System.Windows.Forms.Label();
            this.TxtFName = new System.Windows.Forms.TextBox();
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.LabLName = new System.Windows.Forms.Label();
            this.DtpDob = new System.Windows.Forms.DateTimePicker();
            this.LabGender = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LabEmailId = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LabPassword = new System.Windows.Forms.Label();
            this.TxtConPassword = new System.Windows.Forms.TextBox();
            this.LabConPassword = new System.Windows.Forms.Label();
            this.TxtGender = new System.Windows.Forms.ComboBox();
            this.BtnSignup = new System.Windows.Forms.Button();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.LabClickhere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabRegistration
            // 
            this.LabRegistration.AutoSize = true;
            this.LabRegistration.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LabRegistration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRegistration.Location = new System.Drawing.Point(262, 29);
            this.LabRegistration.Name = "LabRegistration";
            this.LabRegistration.Size = new System.Drawing.Size(169, 34);
            this.LabRegistration.TabIndex = 0;
            this.LabRegistration.Text = "Registration";
            // 
            // LabDob
            // 
            this.LabDob.AutoSize = true;
            this.LabDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDob.Location = new System.Drawing.Point(97, 223);
            this.LabDob.Name = "LabDob";
            this.LabDob.Size = new System.Drawing.Size(109, 26);
            this.LabDob.TabIndex = 1;
            this.LabDob.Text = "Birth Date";
            // 
            // LabFName
            // 
            this.LabFName.AutoSize = true;
            this.LabFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFName.Location = new System.Drawing.Point(97, 119);
            this.LabFName.Name = "LabFName";
            this.LabFName.Size = new System.Drawing.Size(119, 26);
            this.LabFName.TabIndex = 2;
            this.LabFName.Text = "First Name";
            // 
            // TxtFName
            // 
            this.TxtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFName.Location = new System.Drawing.Point(331, 113);
            this.TxtFName.Name = "TxtFName";
            this.TxtFName.Size = new System.Drawing.Size(213, 32);
            this.TxtFName.TabIndex = 3;
            // 
            // TxtLName
            // 
            this.TxtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLName.Location = new System.Drawing.Point(331, 172);
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.Size = new System.Drawing.Size(213, 32);
            this.TxtLName.TabIndex = 5;
            // 
            // LabLName
            // 
            this.LabLName.AutoSize = true;
            this.LabLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLName.Location = new System.Drawing.Point(97, 172);
            this.LabLName.Name = "LabLName";
            this.LabLName.Size = new System.Drawing.Size(118, 26);
            this.LabLName.TabIndex = 4;
            this.LabLName.Text = "Last Name";
            // 
            // DtpDob
            // 
            this.DtpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDob.Location = new System.Drawing.Point(331, 223);
            this.DtpDob.Name = "DtpDob";
            this.DtpDob.Size = new System.Drawing.Size(213, 32);
            this.DtpDob.TabIndex = 6;
            // 
            // LabGender
            // 
            this.LabGender.AutoSize = true;
            this.LabGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGender.Location = new System.Drawing.Point(97, 274);
            this.LabGender.Name = "LabGender";
            this.LabGender.Size = new System.Drawing.Size(84, 26);
            this.LabGender.TabIndex = 7;
            this.LabGender.Text = "Gender";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(331, 326);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(213, 32);
            this.TxtEmail.TabIndex = 10;
            // 
            // LabEmailId
            // 
            this.LabEmailId.AutoSize = true;
            this.LabEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabEmailId.Location = new System.Drawing.Point(97, 326);
            this.LabEmailId.Name = "LabEmailId";
            this.LabEmailId.Size = new System.Drawing.Size(92, 26);
            this.LabEmailId.TabIndex = 9;
            this.LabEmailId.Text = "Email Id";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(331, 386);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(213, 32);
            this.TxtPassword.TabIndex = 12;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LabPassword
            // 
            this.LabPassword.AutoSize = true;
            this.LabPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPassword.Location = new System.Drawing.Point(97, 386);
            this.LabPassword.Name = "LabPassword";
            this.LabPassword.Size = new System.Drawing.Size(108, 26);
            this.LabPassword.TabIndex = 11;
            this.LabPassword.Text = "Password";
            // 
            // TxtConPassword
            // 
            this.TxtConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConPassword.Location = new System.Drawing.Point(331, 444);
            this.TxtConPassword.Name = "TxtConPassword";
            this.TxtConPassword.Size = new System.Drawing.Size(213, 32);
            this.TxtConPassword.TabIndex = 14;
            this.TxtConPassword.UseSystemPasswordChar = true;
            // 
            // LabConPassword
            // 
            this.LabConPassword.AutoSize = true;
            this.LabConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabConPassword.Location = new System.Drawing.Point(97, 444);
            this.LabConPassword.Name = "LabConPassword";
            this.LabConPassword.Size = new System.Drawing.Size(191, 26);
            this.LabConPassword.TabIndex = 13;
            this.LabConPassword.Text = "Confirm Password";
            // 
            // TxtGender
            // 
            this.TxtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGender.FormattingEnabled = true;
            this.TxtGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.TxtGender.Location = new System.Drawing.Point(331, 271);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(213, 34);
            this.TxtGender.TabIndex = 15;
            // 
            // BtnSignup
            // 
            this.BtnSignup.AutoSize = true;
            this.BtnSignup.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignup.Location = new System.Drawing.Point(102, 547);
            this.BtnSignup.Name = "BtnSignup";
            this.BtnSignup.Size = new System.Drawing.Size(100, 36);
            this.BtnSignup.TabIndex = 16;
            this.BtnSignup.Text = "Sign Up";
            this.BtnSignup.UseVisualStyleBackColor = false;
            this.BtnSignup.Click += new System.EventHandler(this.BtnSignup_Click);
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.AutoSize = true;
            this.BtnSignIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.Location = new System.Drawing.Point(493, 547);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(100, 36);
            this.BtnSignIn.TabIndex = 17;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // LabClickhere
            // 
            this.LabClickhere.AutoSize = true;
            this.LabClickhere.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabClickhere.Location = new System.Drawing.Point(436, 524);
            this.LabClickhere.Name = "LabClickhere";
            this.LabClickhere.Size = new System.Drawing.Size(232, 20);
            this.LabClickhere.TabIndex = 18;
            this.LabClickhere.Text = "Click here already have account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.LabClickhere);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.BtnSignup);
            this.Controls.Add(this.TxtGender);
            this.Controls.Add(this.TxtConPassword);
            this.Controls.Add(this.LabConPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LabPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LabEmailId);
            this.Controls.Add(this.LabGender);
            this.Controls.Add(this.DtpDob);
            this.Controls.Add(this.TxtLName);
            this.Controls.Add(this.LabLName);
            this.Controls.Add(this.TxtFName);
            this.Controls.Add(this.LabFName);
            this.Controls.Add(this.LabDob);
            this.Controls.Add(this.LabRegistration);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabRegistration;
        private System.Windows.Forms.Label LabDob;
        private System.Windows.Forms.Label LabFName;
        private System.Windows.Forms.TextBox TxtFName;
        private System.Windows.Forms.TextBox TxtLName;
        private System.Windows.Forms.Label LabLName;
        private System.Windows.Forms.DateTimePicker DtpDob;
        private System.Windows.Forms.Label LabGender;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LabEmailId;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LabPassword;
        private System.Windows.Forms.TextBox TxtConPassword;
        private System.Windows.Forms.Label LabConPassword;
        private System.Windows.Forms.ComboBox TxtGender;
        private System.Windows.Forms.Button BtnSignup;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label LabClickhere;
    }
}

