using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace BoltQA
{
    public partial class Registration : Form
    {
        private static readonly HttpClient client = new HttpClient();

        //Bool variables used in order to check whether all fields are filled in correctly (accessed by multiple methods)
        public bool checkEmail = false;
        public bool checkUsername = false;
        public bool checkPassword = false;

        public Registration()
        {
            InitializeComponent();
            // on form load submit button is disabled, labels are assigned string values and labesl are set to invisible
            btn_Submit.Enabled = false;
            lbl_EmailValidation.Text = "Please enter valid email";
            lbl_UsernameValidation.Text = "Username must be between 5 and 15 characters";
            lbl_PasswordValidation.Text = "Password must be between 5 and 50 characters";
            lbl_EmailValidation.Visible = false;
            lbl_UsernameValidation.Visible = false;
            lbl_PasswordValidation.Visible = false;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Closes the dialog with registration form
            Close();
        }

        private async void btn_Submit_Click(object sender, EventArgs e)
        {
            var user = new Dictionary<string, string>
            {
                {"username", txt_Username.Text},
                {"password", txt_Password.Text},
                {"email", txt_Email.Text},
                {"firstname", "Michael"},
                {"lastname", "Tait"},
                {"dateOfBirth", "1998-06-21"},
                {"gender", "male"},
            };
            var address = new Dictionary<string, string>
            {
                {"line1", "Home"},
                {"postCode", "NE1 1AA"},
                {"countryCode", "GB"}
            };

            user.Add("address", JsonConvert.SerializeObject(address));

            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://qa02-spine.bedegaming.net/api/v5/players"),
                Method = HttpMethod.Post,
            };

            request.Headers.Add("X-Correlation-Token", Guid.NewGuid().ToString());
            request.Headers.Add("X-Site-Code", "ukcasino.com");
            request.Content = new StringContent(JsonConvert.SerializeObject(user));

            var response = await client.SendAsync(request);
            MessageBox.Show(response.ToString());
          }
          
        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            //IsValidEmail method is used to check whether email foramt is valid
            if (IsValidEmail(txt_Email.Text))
            {
                //If email format is valid then public bool checkEmail is set to true
                checkEmail = true;
                lbl_EmailValidation.Visible = false;
            }
            else {
                //if email format is invalid then checkEmail will be set to false
                checkEmail = false;
                lbl_EmailValidation.Visible = true;
            }
            //check submit method checks if all three check variables are true if so then submit button is enabled
            checkSubmit();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[a-zA-Z0-9_]+$");
            //Firstly we are checking if there are no invalid characters in the username field
            if (reg.Match(txt_Username.Text).Success)
            {
                //if there are no invalid characters we are checking that the length is between 5 and 15 characters
                //if it is then we set checkUsername to visible and call lblUsernameValidationPass which hides error
                //message for invalid username if it was visible
                if ((txt_Username.Text.Length > 4) && (txt_Username.Text.Length < 16))
                {
                    checkUsername = true;
                    lblUsernameValidationPass();
                }
                else if ((txt_Username.Text.Length < 5) || (txt_Username.Text.Length > 15))
                {
                    //if username is shorter than 5 characters or longer than 15 characters we set checkUsername to false which
                    //makes submit button disabled.
                    //lblUsernameValidationFail shows the validation error.
                    checkUsername = false;
                    lblUsernameValidationFail();
                }
            }
            //I've used this branch to make sure that nothing in the field shows error message for not having enough characters
            else if (txt_Username.Text.Length == 0)
            {
                checkUsername = false;
                lblUsernameValidationFail();
            }
            else {
                //here we display validation message when invalid characters are entered into username
                lbl_UsernameValidation.Text = "Username can only contain letters, numbers nad underscores";
                lbl_UsernameValidation.Visible = true;
                checkUsername = false;
            }
            checkSubmit();

        }

        //Methods to call when validation of username passes or fails just changes lblUsernameValidation text
        //and shows or hides it depending on outcome
        private void lblUsernameValidationFail()
        {
            lbl_UsernameValidation.Text = "Username must be between 5 and 15 characters";
            lbl_UsernameValidation.Visible = true;
        }
        private void lblUsernameValidationPass()
        {
            lbl_UsernameValidation.Text = "Username must be between 5 and 15 characters";
            lbl_UsernameValidation.Visible = false;
        }


        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            

            if ((txt_Password.Text.Length > 4)&&(txt_Password.Text.Length < 51))
            {
                    checkPassword = true;
                    lbl_PasswordValidation.Visible = false;
            }
            else if ((txt_Password.Text.Length < 5)||(txt_Password.Text.Length > 50))
            {
                checkPassword = false;
                lbl_PasswordValidation.Visible = true;
            }
            checkSubmit();
        }

        private static bool isValid(String str)
        {
            bool valid = false;

            Regex reg = new Regex("^[a-zA-Z0-9_]+$");

            if (reg.Match(str).Success)
                valid = false;
            else
                valid = true;

            return valid;
        }

        private void checkSubmit()
        {
            if ((checkEmail == true) && (checkUsername == true) && (checkPassword == true))
            {
                btn_Submit.Enabled = true;
            }
            else { btn_Submit.Enabled = false; }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;  
            }
        }
    }
}