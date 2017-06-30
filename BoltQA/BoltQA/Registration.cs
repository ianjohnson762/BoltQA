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
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace BoltQA
{
    public partial class Registration : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
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
    }
}