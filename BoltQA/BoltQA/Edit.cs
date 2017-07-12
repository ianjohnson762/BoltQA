using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BoltQA
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private async void btn_GetAccessToken_Click(object sender, EventArgs e)
        {
            try
            {
                var token = await Requests.getAccessToken(txt_Username.Text, txt_Password.Text);

                txt_Token.Text = token;
                var playerID = Requests.DecodeToken(token);
                txt_PlayerID.Text = playerID.Subject;
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to get access token.");
            }
        }

        private async void btn_GetInfo_Click(object sender, EventArgs e)
        {
            var playerInfo = await Requests.getPlayerInformation(txt_PlayerID.Text, txt_Token.Text);
            txt_Email.Text = playerInfo.SelectToken("player.email").ToString();
            txt_FirstName.Text = playerInfo.SelectToken("player.profile.personal.firstName").ToString();
            txt_LastName.Text = playerInfo.SelectToken("player.profile.personal.lastName").ToString();
            txt_Gender.Text = playerInfo.SelectToken("player.profile.personal.gender").ToString();
            txt_DOB.Text = playerInfo.SelectToken("player.profile.personal.dateOfBirth").ToString();
            txt_AddressLine1.Text = playerInfo.SelectToken("player.profile.personal.address.line1").ToString();
            txt_AddressLine2.Text = playerInfo.SelectToken("player.profile.personal.address.line2").ToString();
            txt_Town.Text = playerInfo.SelectToken("player.profile.personal.address.town").ToString();
            txt_County.Text = playerInfo.SelectToken("player.profile.personal.address.county").ToString();
            txt_Postcode.Text = playerInfo.SelectToken("player.profile.personal.address.postCode").ToString();
            txt_CountryCode.Text = playerInfo.SelectToken("player.profile.personal.address.countryCode").ToString();
            txt_Telephone.Text = playerInfo.SelectToken("player.profile.personal.telephone").ToString();
            txt_IDStatus.Text = playerInfo.SelectToken("player.profile.playerStatuses.identityDocumentationStatus").ToString();
            txt_EmailMarketing.Text = playerInfo.SelectToken("player.profile.marketing.marketingOptInEmail").ToString();
            txt_SMSMarketing.Text = playerInfo.SelectToken("player.profile.marketing.marketingOptInSms").ToString();
            txt_PostMarketing.Text = playerInfo.SelectToken("player.profile.marketing.marketingOptInPost").ToString();
            txt_PhoneMarketing.Text = playerInfo.SelectToken("player.profile.marketing.marketingOptInTelephone").ToString();
            txt_PushMarketing.Text = playerInfo.SelectToken("player.profile.marketing.marketingOptInPush").ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                firstName = txt_FirstName.Text,
                lastName = txt_LastName.Text,
                dateOfBirth = txt_DOB.Text,
                gender = txt_Gender.Text,
                address = new
                {
                    line1 = txt_AddressLine1.Text,
                    line2 = txt_AddressLine2.Text,
                    town = txt_Town.Text,
                    county = txt_County.Text,
                    postCode = txt_Postcode.Text,
                    countryCode = txt_CountryCode.Text
                },
                identityDocumentationStatus = txt_IDStatus.Text,
                telephone = txt_Telephone.Text,
                email = txt_Email.Text,
                marketing = new
                {
                    email = Boolean.Parse(txt_EmailMarketing.Text),
                    sms = Boolean.Parse(txt_SMSMarketing.Text),
                    push = Boolean.Parse(txt_PushMarketing.Text),
                    telephone = Boolean.Parse(txt_PhoneMarketing.Text),
                    post = Boolean.Parse(txt_PostMarketing.Text)
                }
            });
            Requests.updatePlayerInformation(json);
            MessageBox.Show("Saved!");
        }
    }
}
