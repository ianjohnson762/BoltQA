namespace BoltQA
{
    partial class Registration
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_UsernameValidation = new System.Windows.Forms.Label();
            this.lbl_PasswordValidation = new System.Windows.Forms.Label();
            this.lbl_EmailValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(169, 55);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(157, 20);
            this.txt_Email.TabIndex = 0;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(169, 102);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(157, 20);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(169, 150);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(157, 20);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(49, 54);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(48, 20);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(49, 100);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(83, 20);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(49, 148);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 20);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(136, 210);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(89, 38);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(31, 210);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 38);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_UsernameValidation
            // 
            this.lbl_UsernameValidation.AutoSize = true;
            this.lbl_UsernameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsernameValidation.ForeColor = System.Drawing.Color.Red;
            this.lbl_UsernameValidation.Location = new System.Drawing.Point(167, 125);
            this.lbl_UsernameValidation.Name = "lbl_UsernameValidation";
            this.lbl_UsernameValidation.Size = new System.Drawing.Size(29, 12);
            this.lbl_UsernameValidation.TabIndex = 8;
            this.lbl_UsernameValidation.Text = "label1";
            // 
            // lbl_PasswordValidation
            // 
            this.lbl_PasswordValidation.AutoSize = true;
            this.lbl_PasswordValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.lbl_PasswordValidation.Location = new System.Drawing.Point(167, 173);
            this.lbl_PasswordValidation.Name = "lbl_PasswordValidation";
            this.lbl_PasswordValidation.Size = new System.Drawing.Size(29, 12);
            this.lbl_PasswordValidation.TabIndex = 9;
            this.lbl_PasswordValidation.Text = "label1";
            // 
            // lbl_EmailValidation
            // 
            this.lbl_EmailValidation.AutoSize = true;
            this.lbl_EmailValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailValidation.ForeColor = System.Drawing.Color.Red;
            this.lbl_EmailValidation.Location = new System.Drawing.Point(167, 78);
            this.lbl_EmailValidation.Name = "lbl_EmailValidation";
            this.lbl_EmailValidation.Size = new System.Drawing.Size(29, 12);
            this.lbl_EmailValidation.TabIndex = 10;
            this.lbl_EmailValidation.Text = "label1";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 420);
            this.Controls.Add(this.lbl_EmailValidation);
            this.Controls.Add(this.lbl_PasswordValidation);
            this.Controls.Add(this.lbl_UsernameValidation);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Email);
            this.Name = "Registration";
            this.Text = "Registrationcs";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_UsernameValidation;
        private System.Windows.Forms.Label lbl_PasswordValidation;
        private System.Windows.Forms.Label lbl_EmailValidation;
    }
}