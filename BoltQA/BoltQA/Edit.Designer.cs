namespace BoltQA
{
    partial class Edit
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_GetAccessToken = new System.Windows.Forms.Button();
            this.txt_Token = new System.Windows.Forms.RichTextBox();
            this.lbl_PlayerID = new System.Windows.Forms.Label();
            this.txt_PlayerID = new System.Windows.Forms.TextBox();
            this.btn_GetInfo = new System.Windows.Forms.Button();
            this.groupPlayerInfo = new System.Windows.Forms.GroupBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_AddressLine1 = new System.Windows.Forms.Label();
            this.lbl_AddressLine2 = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Town = new System.Windows.Forms.Label();
            this.lbl_County = new System.Windows.Forms.Label();
            this.lbl_Postcode = new System.Windows.Forms.Label();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.txt_DOB = new System.Windows.Forms.TextBox();
            this.txt_AddressLine1 = new System.Windows.Forms.TextBox();
            this.txt_AddressLine2 = new System.Windows.Forms.TextBox();
            this.txt_Town = new System.Windows.Forms.TextBox();
            this.txt_County = new System.Windows.Forms.TextBox();
            this.txt_Postcode = new System.Windows.Forms.TextBox();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_IDStatus = new System.Windows.Forms.Label();
            this.txt_IDStatus = new System.Windows.Forms.TextBox();
            this.lbl_EmailMarketing = new System.Windows.Forms.Label();
            this.lbl_SmsMarketing = new System.Windows.Forms.Label();
            this.lbl_PushMarketing = new System.Windows.Forms.Label();
            this.lbl_PhoneMarketing = new System.Windows.Forms.Label();
            this.lbl_PostMarketing = new System.Windows.Forms.Label();
            this.groupMarketing = new System.Windows.Forms.GroupBox();
            this.txt_EmailMarketing = new System.Windows.Forms.TextBox();
            this.txt_SMSMarketing = new System.Windows.Forms.TextBox();
            this.txt_PushMarketing = new System.Windows.Forms.TextBox();
            this.txt_PhoneMarketing = new System.Windows.Forms.TextBox();
            this.txt_PostMarketing = new System.Windows.Forms.TextBox();
            this.lbl_CountryCode = new System.Windows.Forms.Label();
            this.txt_CountryCode = new System.Windows.Forms.TextBox();
            this.groupPlayerInfo.SuspendLayout();
            this.groupMarketing.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(12, 9);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(73, 6);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(129, 20);
            this.txt_Username.TabIndex = 1;
            // 
            // btn_GetAccessToken
            // 
            this.btn_GetAccessToken.Location = new System.Drawing.Point(208, 4);
            this.btn_GetAccessToken.Name = "btn_GetAccessToken";
            this.btn_GetAccessToken.Size = new System.Drawing.Size(75, 23);
            this.btn_GetAccessToken.TabIndex = 2;
            this.btn_GetAccessToken.Text = "Get Token";
            this.btn_GetAccessToken.UseVisualStyleBackColor = true;
            this.btn_GetAccessToken.Click += new System.EventHandler(this.btn_GetAccessToken_Click);
            // 
            // txt_Token
            // 
            this.txt_Token.Location = new System.Drawing.Point(15, 32);
            this.txt_Token.Name = "txt_Token";
            this.txt_Token.ReadOnly = true;
            this.txt_Token.Size = new System.Drawing.Size(268, 96);
            this.txt_Token.TabIndex = 3;
            this.txt_Token.Text = "";
            // 
            // lbl_PlayerID
            // 
            this.lbl_PlayerID.AutoSize = true;
            this.lbl_PlayerID.Location = new System.Drawing.Point(12, 131);
            this.lbl_PlayerID.Name = "lbl_PlayerID";
            this.lbl_PlayerID.Size = new System.Drawing.Size(50, 13);
            this.lbl_PlayerID.TabIndex = 4;
            this.lbl_PlayerID.Text = "Player ID";
            // 
            // txt_PlayerID
            // 
            this.txt_PlayerID.Location = new System.Drawing.Point(73, 128);
            this.txt_PlayerID.Name = "txt_PlayerID";
            this.txt_PlayerID.ReadOnly = true;
            this.txt_PlayerID.Size = new System.Drawing.Size(210, 20);
            this.txt_PlayerID.TabIndex = 5;
            // 
            // btn_GetInfo
            // 
            this.btn_GetInfo.Location = new System.Drawing.Point(15, 154);
            this.btn_GetInfo.Name = "btn_GetInfo";
            this.btn_GetInfo.Size = new System.Drawing.Size(268, 23);
            this.btn_GetInfo.TabIndex = 6;
            this.btn_GetInfo.Text = "Get Info";
            this.btn_GetInfo.UseVisualStyleBackColor = true;
            this.btn_GetInfo.Click += new System.EventHandler(this.btn_GetInfo_Click);
            // 
            // groupPlayerInfo
            // 
            this.groupPlayerInfo.Controls.Add(this.txt_CountryCode);
            this.groupPlayerInfo.Controls.Add(this.lbl_CountryCode);
            this.groupPlayerInfo.Controls.Add(this.groupMarketing);
            this.groupPlayerInfo.Controls.Add(this.txt_IDStatus);
            this.groupPlayerInfo.Controls.Add(this.lbl_IDStatus);
            this.groupPlayerInfo.Controls.Add(this.btn_Save);
            this.groupPlayerInfo.Controls.Add(this.txt_Telephone);
            this.groupPlayerInfo.Controls.Add(this.txt_Postcode);
            this.groupPlayerInfo.Controls.Add(this.txt_County);
            this.groupPlayerInfo.Controls.Add(this.txt_Town);
            this.groupPlayerInfo.Controls.Add(this.txt_AddressLine2);
            this.groupPlayerInfo.Controls.Add(this.txt_AddressLine1);
            this.groupPlayerInfo.Controls.Add(this.txt_DOB);
            this.groupPlayerInfo.Controls.Add(this.txt_Gender);
            this.groupPlayerInfo.Controls.Add(this.txt_LastName);
            this.groupPlayerInfo.Controls.Add(this.txt_FirstName);
            this.groupPlayerInfo.Controls.Add(this.txt_Email);
            this.groupPlayerInfo.Controls.Add(this.lbl_Telephone);
            this.groupPlayerInfo.Controls.Add(this.lbl_Postcode);
            this.groupPlayerInfo.Controls.Add(this.lbl_County);
            this.groupPlayerInfo.Controls.Add(this.lbl_Town);
            this.groupPlayerInfo.Controls.Add(this.lbl_DOB);
            this.groupPlayerInfo.Controls.Add(this.lbl_AddressLine2);
            this.groupPlayerInfo.Controls.Add(this.lbl_AddressLine1);
            this.groupPlayerInfo.Controls.Add(this.lbl_Gender);
            this.groupPlayerInfo.Controls.Add(this.lbl_LastName);
            this.groupPlayerInfo.Controls.Add(this.lbl_FirstName);
            this.groupPlayerInfo.Controls.Add(this.lbl_Email);
            this.groupPlayerInfo.Location = new System.Drawing.Point(289, 6);
            this.groupPlayerInfo.Name = "groupPlayerInfo";
            this.groupPlayerInfo.Size = new System.Drawing.Size(205, 581);
            this.groupPlayerInfo.TabIndex = 7;
            this.groupPlayerInfo.TabStop = false;
            this.groupPlayerInfo.Text = "Player Information";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(6, 22);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(6, 48);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 3;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(6, 74);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 4;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(6, 100);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_Gender.TabIndex = 5;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_AddressLine1
            // 
            this.lbl_AddressLine1.AutoSize = true;
            this.lbl_AddressLine1.Location = new System.Drawing.Point(6, 154);
            this.lbl_AddressLine1.Name = "lbl_AddressLine1";
            this.lbl_AddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lbl_AddressLine1.TabIndex = 6;
            this.lbl_AddressLine1.Text = "Address Line 1";
            // 
            // lbl_AddressLine2
            // 
            this.lbl_AddressLine2.AutoSize = true;
            this.lbl_AddressLine2.Location = new System.Drawing.Point(6, 180);
            this.lbl_AddressLine2.Name = "lbl_AddressLine2";
            this.lbl_AddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lbl_AddressLine2.TabIndex = 7;
            this.lbl_AddressLine2.Text = "Address Line 2";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Location = new System.Drawing.Point(6, 128);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(30, 13);
            this.lbl_DOB.TabIndex = 8;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Town
            // 
            this.lbl_Town.AutoSize = true;
            this.lbl_Town.Location = new System.Drawing.Point(6, 206);
            this.lbl_Town.Name = "lbl_Town";
            this.lbl_Town.Size = new System.Drawing.Size(34, 13);
            this.lbl_Town.TabIndex = 9;
            this.lbl_Town.Text = "Town";
            // 
            // lbl_County
            // 
            this.lbl_County.AutoSize = true;
            this.lbl_County.Location = new System.Drawing.Point(6, 232);
            this.lbl_County.Name = "lbl_County";
            this.lbl_County.Size = new System.Drawing.Size(40, 13);
            this.lbl_County.TabIndex = 10;
            this.lbl_County.Text = "County";
            // 
            // lbl_Postcode
            // 
            this.lbl_Postcode.AutoSize = true;
            this.lbl_Postcode.Location = new System.Drawing.Point(6, 258);
            this.lbl_Postcode.Name = "lbl_Postcode";
            this.lbl_Postcode.Size = new System.Drawing.Size(52, 13);
            this.lbl_Postcode.TabIndex = 11;
            this.lbl_Postcode.Text = "Postcode";
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Location = new System.Drawing.Point(5, 341);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(58, 13);
            this.lbl_Telephone.TabIndex = 12;
            this.lbl_Telephone.Text = "Telephone";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(89, 19);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(110, 20);
            this.txt_Email.TabIndex = 14;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(89, 45);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(110, 20);
            this.txt_FirstName.TabIndex = 16;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(89, 71);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(110, 20);
            this.txt_LastName.TabIndex = 17;
            // 
            // txt_Gender
            // 
            this.txt_Gender.Location = new System.Drawing.Point(89, 97);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(110, 20);
            this.txt_Gender.TabIndex = 18;
            // 
            // txt_DOB
            // 
            this.txt_DOB.Location = new System.Drawing.Point(89, 125);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.Size = new System.Drawing.Size(110, 20);
            this.txt_DOB.TabIndex = 19;
            // 
            // txt_AddressLine1
            // 
            this.txt_AddressLine1.Location = new System.Drawing.Point(89, 151);
            this.txt_AddressLine1.Name = "txt_AddressLine1";
            this.txt_AddressLine1.Size = new System.Drawing.Size(110, 20);
            this.txt_AddressLine1.TabIndex = 20;
            // 
            // txt_AddressLine2
            // 
            this.txt_AddressLine2.Location = new System.Drawing.Point(89, 177);
            this.txt_AddressLine2.Name = "txt_AddressLine2";
            this.txt_AddressLine2.Size = new System.Drawing.Size(110, 20);
            this.txt_AddressLine2.TabIndex = 21;
            // 
            // txt_Town
            // 
            this.txt_Town.Location = new System.Drawing.Point(89, 203);
            this.txt_Town.Name = "txt_Town";
            this.txt_Town.Size = new System.Drawing.Size(110, 20);
            this.txt_Town.TabIndex = 22;
            // 
            // txt_County
            // 
            this.txt_County.Location = new System.Drawing.Point(89, 229);
            this.txt_County.Name = "txt_County";
            this.txt_County.Size = new System.Drawing.Size(110, 20);
            this.txt_County.TabIndex = 23;
            // 
            // txt_Postcode
            // 
            this.txt_Postcode.Location = new System.Drawing.Point(89, 255);
            this.txt_Postcode.Name = "txt_Postcode";
            this.txt_Postcode.Size = new System.Drawing.Size(110, 20);
            this.txt_Postcode.TabIndex = 24;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(89, 341);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(110, 20);
            this.txt_Telephone.TabIndex = 25;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(0, 552);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(193, 23);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_IDStatus
            // 
            this.lbl_IDStatus.AutoSize = true;
            this.lbl_IDStatus.Location = new System.Drawing.Point(6, 370);
            this.lbl_IDStatus.Name = "lbl_IDStatus";
            this.lbl_IDStatus.Size = new System.Drawing.Size(51, 13);
            this.lbl_IDStatus.TabIndex = 27;
            this.lbl_IDStatus.Text = "ID Status";
            // 
            // txt_IDStatus
            // 
            this.txt_IDStatus.Location = new System.Drawing.Point(89, 367);
            this.txt_IDStatus.Name = "txt_IDStatus";
            this.txt_IDStatus.Size = new System.Drawing.Size(110, 20);
            this.txt_IDStatus.TabIndex = 28;
            // 
            // lbl_EmailMarketing
            // 
            this.lbl_EmailMarketing.AutoSize = true;
            this.lbl_EmailMarketing.Location = new System.Drawing.Point(6, 16);
            this.lbl_EmailMarketing.Name = "lbl_EmailMarketing";
            this.lbl_EmailMarketing.Size = new System.Drawing.Size(32, 13);
            this.lbl_EmailMarketing.TabIndex = 29;
            this.lbl_EmailMarketing.Text = "Email";
            // 
            // lbl_SmsMarketing
            // 
            this.lbl_SmsMarketing.AutoSize = true;
            this.lbl_SmsMarketing.Location = new System.Drawing.Point(6, 42);
            this.lbl_SmsMarketing.Name = "lbl_SmsMarketing";
            this.lbl_SmsMarketing.Size = new System.Drawing.Size(30, 13);
            this.lbl_SmsMarketing.TabIndex = 30;
            this.lbl_SmsMarketing.Text = "SMS";
            // 
            // lbl_PushMarketing
            // 
            this.lbl_PushMarketing.AutoSize = true;
            this.lbl_PushMarketing.Location = new System.Drawing.Point(6, 68);
            this.lbl_PushMarketing.Name = "lbl_PushMarketing";
            this.lbl_PushMarketing.Size = new System.Drawing.Size(31, 13);
            this.lbl_PushMarketing.TabIndex = 31;
            this.lbl_PushMarketing.Text = "Push";
            // 
            // lbl_PhoneMarketing
            // 
            this.lbl_PhoneMarketing.AutoSize = true;
            this.lbl_PhoneMarketing.Location = new System.Drawing.Point(6, 94);
            this.lbl_PhoneMarketing.Name = "lbl_PhoneMarketing";
            this.lbl_PhoneMarketing.Size = new System.Drawing.Size(38, 13);
            this.lbl_PhoneMarketing.TabIndex = 32;
            this.lbl_PhoneMarketing.Text = "Phone";
            // 
            // lbl_PostMarketing
            // 
            this.lbl_PostMarketing.AutoSize = true;
            this.lbl_PostMarketing.Location = new System.Drawing.Point(6, 120);
            this.lbl_PostMarketing.Name = "lbl_PostMarketing";
            this.lbl_PostMarketing.Size = new System.Drawing.Size(28, 13);
            this.lbl_PostMarketing.TabIndex = 33;
            this.lbl_PostMarketing.Text = "Post";
            // 
            // groupMarketing
            // 
            this.groupMarketing.Controls.Add(this.lbl_PostMarketing);
            this.groupMarketing.Controls.Add(this.txt_PostMarketing);
            this.groupMarketing.Controls.Add(this.lbl_PhoneMarketing);
            this.groupMarketing.Controls.Add(this.txt_PhoneMarketing);
            this.groupMarketing.Controls.Add(this.lbl_PushMarketing);
            this.groupMarketing.Controls.Add(this.txt_PushMarketing);
            this.groupMarketing.Controls.Add(this.txt_SMSMarketing);
            this.groupMarketing.Controls.Add(this.txt_EmailMarketing);
            this.groupMarketing.Controls.Add(this.lbl_EmailMarketing);
            this.groupMarketing.Controls.Add(this.lbl_SmsMarketing);
            this.groupMarketing.Location = new System.Drawing.Point(8, 393);
            this.groupMarketing.Name = "groupMarketing";
            this.groupMarketing.Size = new System.Drawing.Size(190, 153);
            this.groupMarketing.TabIndex = 34;
            this.groupMarketing.TabStop = false;
            this.groupMarketing.Text = "Marketing";
            // 
            // txt_EmailMarketing
            // 
            this.txt_EmailMarketing.Location = new System.Drawing.Point(74, 13);
            this.txt_EmailMarketing.Name = "txt_EmailMarketing";
            this.txt_EmailMarketing.Size = new System.Drawing.Size(110, 20);
            this.txt_EmailMarketing.TabIndex = 31;
            // 
            // txt_SMSMarketing
            // 
            this.txt_SMSMarketing.Location = new System.Drawing.Point(74, 39);
            this.txt_SMSMarketing.Name = "txt_SMSMarketing";
            this.txt_SMSMarketing.Size = new System.Drawing.Size(110, 20);
            this.txt_SMSMarketing.TabIndex = 32;
            // 
            // txt_PushMarketing
            // 
            this.txt_PushMarketing.Location = new System.Drawing.Point(74, 65);
            this.txt_PushMarketing.Name = "txt_PushMarketing";
            this.txt_PushMarketing.Size = new System.Drawing.Size(110, 20);
            this.txt_PushMarketing.TabIndex = 33;
            // 
            // txt_PhoneMarketing
            // 
            this.txt_PhoneMarketing.Location = new System.Drawing.Point(74, 91);
            this.txt_PhoneMarketing.Name = "txt_PhoneMarketing";
            this.txt_PhoneMarketing.Size = new System.Drawing.Size(110, 20);
            this.txt_PhoneMarketing.TabIndex = 34;
            // 
            // txt_PostMarketing
            // 
            this.txt_PostMarketing.Location = new System.Drawing.Point(74, 117);
            this.txt_PostMarketing.Name = "txt_PostMarketing";
            this.txt_PostMarketing.Size = new System.Drawing.Size(110, 20);
            this.txt_PostMarketing.TabIndex = 35;
            // 
            // lbl_CountryCode
            // 
            this.lbl_CountryCode.AutoSize = true;
            this.lbl_CountryCode.Location = new System.Drawing.Point(6, 284);
            this.lbl_CountryCode.Name = "lbl_CountryCode";
            this.lbl_CountryCode.Size = new System.Drawing.Size(71, 13);
            this.lbl_CountryCode.TabIndex = 35;
            this.lbl_CountryCode.Text = "Country Code";
            // 
            // txt_CountryCode
            // 
            this.txt_CountryCode.Location = new System.Drawing.Point(89, 281);
            this.txt_CountryCode.Name = "txt_CountryCode";
            this.txt_CountryCode.Size = new System.Drawing.Size(109, 20);
            this.txt_CountryCode.TabIndex = 36;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 599);
            this.Controls.Add(this.groupPlayerInfo);
            this.Controls.Add(this.btn_GetInfo);
            this.Controls.Add(this.txt_PlayerID);
            this.Controls.Add(this.lbl_PlayerID);
            this.Controls.Add(this.txt_Token);
            this.Controls.Add(this.btn_GetAccessToken);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.Name = "Edit";
            this.Text = "Edit";
            this.groupPlayerInfo.ResumeLayout(false);
            this.groupPlayerInfo.PerformLayout();
            this.groupMarketing.ResumeLayout(false);
            this.groupMarketing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_GetAccessToken;
        private System.Windows.Forms.RichTextBox txt_Token;
        private System.Windows.Forms.Label lbl_PlayerID;
        private System.Windows.Forms.TextBox txt_PlayerID;
        private System.Windows.Forms.Button btn_GetInfo;
        private System.Windows.Forms.GroupBox groupPlayerInfo;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_AddressLine2;
        private System.Windows.Forms.Label lbl_AddressLine1;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.TextBox txt_Postcode;
        private System.Windows.Forms.TextBox txt_County;
        private System.Windows.Forms.TextBox txt_Town;
        private System.Windows.Forms.TextBox txt_AddressLine2;
        private System.Windows.Forms.TextBox txt_AddressLine1;
        private System.Windows.Forms.TextBox txt_DOB;
        private System.Windows.Forms.TextBox txt_Gender;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.Label lbl_Postcode;
        private System.Windows.Forms.Label lbl_County;
        private System.Windows.Forms.Label lbl_Town;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupMarketing;
        private System.Windows.Forms.Label lbl_PostMarketing;
        private System.Windows.Forms.TextBox txt_PostMarketing;
        private System.Windows.Forms.Label lbl_PhoneMarketing;
        private System.Windows.Forms.TextBox txt_PhoneMarketing;
        private System.Windows.Forms.Label lbl_PushMarketing;
        private System.Windows.Forms.TextBox txt_PushMarketing;
        private System.Windows.Forms.TextBox txt_SMSMarketing;
        private System.Windows.Forms.TextBox txt_EmailMarketing;
        private System.Windows.Forms.Label lbl_EmailMarketing;
        private System.Windows.Forms.Label lbl_SmsMarketing;
        private System.Windows.Forms.TextBox txt_IDStatus;
        private System.Windows.Forms.Label lbl_IDStatus;
        private System.Windows.Forms.TextBox txt_CountryCode;
        private System.Windows.Forms.Label lbl_CountryCode;
    }
}