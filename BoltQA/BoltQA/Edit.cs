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

        private void btn_GetAccessToken_Click(object sender, EventArgs e)
        {
            txt_Token.Text = Requests.getAccessToken(txt_Username.Text);
            txt_PlayerID.Text = Requests.getPlayerID(txt_Username.Text).ToString();
        }

        private void btn_GetInfo_Click(object sender, EventArgs e)
        {
            dynamic jsonObject = Requests.getPlayerInformation(txt_PlayerID.Text, txt_Token.Text);
            txt_Email.Text = jsonObject["player"]["email"];
            txt_FirstName.Text = jsonObject["player"]["profile"]["personal"]["firstName"];
            txt_LastName.Text = jsonObject["player"]["profile"]["personal"]["lastName"];
            txt_Gender.Text = jsonObject["player"]["profile"]["personal"]["gender"];
            txt_DOB.Text = jsonObject["player"]["profile"]["personal"]["dateOfBirth"];
            txt_AddressLine1.Text = jsonObject["player"]["profile"]["personal"]["address"]["line1"];
            txt_AddressLine2.Text = jsonObject["player"]["profile"]["personal"]["address"]["line2"];
            txt_Town.Text = jsonObject["player"]["profile"]["personal"]["address"]["town"];
            txt_County.Text = jsonObject["player"]["profile"]["personal"]["address"]["county"];
            txt_Postcode.Text = jsonObject["player"]["profile"]["personal"]["address"]["postCode"];
            txt_CountryCode.Text = jsonObject["player"]["profile"]["personal"]["address"]["countryCode"];
            txt_Telephone.Text = jsonObject["player"]["profile"]["personal"]["telephone"];
            txt_IDStatus.Text = jsonObject["player"]["profile"]["playerStatuses"]["identityDocumentationStatus"];
            txt_EmailMarketing.Text = jsonObject["player"]["profile"]["marketing"]["marketingOptInEmail"].ToString();
            txt_SMSMarketing.Text = jsonObject["player"]["profile"]["marketing"]["marketingOptInSms"].ToString();
            txt_PostMarketing.Text = jsonObject["player"]["profile"]["marketing"]["marketingOptInPost"].ToString();
            txt_PhoneMarketing.Text = jsonObject["player"]["profile"]["marketing"]["marketingOptInTelephone"].ToString();
            txt_PushMarketing.Text = jsonObject["player"]["profile"]["marketing"]["marketingOptInPush"].ToString();

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
