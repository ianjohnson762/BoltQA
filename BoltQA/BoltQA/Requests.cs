using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;

namespace BoltQA
{
    static class Requests
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> getAccessToken(string username, string password)
        {
            try
            {
                var user = new List<KeyValuePair<string, string>>();
                user.Add(new KeyValuePair<string, string>("username", username));
                user.Add(new KeyValuePair<string, string>("password", password));
                user.Add(new KeyValuePair<string, string>("grant_type", "password"));
                user.Add(new KeyValuePair<string, string>("scope", "spine"));
                user.Add(new KeyValuePair<string, string>("client_id", "ukcasino_web"));

                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://qa02-spine.bedegaming.net/api/v5/players/sessions"),
                    Method = HttpMethod.Post,
                };

                request.Headers.Add("ContentType", "application/json");
                request.Headers.Add("X-Correlation-Token", Guid.NewGuid().ToString());
                request.Headers.Add("X-Site-Code", "ukcasino.com");
                request.Content = new FormUrlEncodedContent(user);

                var response = await client.SendAsync(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ArgumentException(response.ToString());
                }

                JObject parsedResponse = JObject.Parse(await response.Content.ReadAsStringAsync());

                return parsedResponse.SelectToken("access_token").ToString();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static JwtSecurityToken DecodeToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var decodedToken = handler.ReadToken(token) as JwtSecurityToken;

            return decodedToken;
        }

        public static async Task<JObject> getPlayerInformation(string playerid, string token)
        {
            string url = string.Format("https://qa02-spine.bedegaming.net/api/v5/players/{0}/profile", playerid);

            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };

            request.Headers.Add("ContentType", "application/json");
            request.Headers.Add("X-Correlation-Token", Guid.NewGuid().ToString());
            request.Headers.Add("X-Site-Code", "ukcasino.com");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.SendAsync(request);
            MessageBox.Show(response.ToString());

            JObject parsedResponse = JObject.Parse(await response.Content.ReadAsStringAsync());

            return parsedResponse;
        }

        public static void updatePlayerInformation(string json)
        {
            string url = "https://qa02-spine.bedegaming.net/api/v5/players/sessions";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "PATCH";
            request.ContentType = "application/json";
            request.Headers.Add("X-Correlation-Token", "f9780325-d315-4e9a-9115-ac858c695538");
            request.Headers.Add("X-Site-Code", "ukcasino.com");
            using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }
    }
}