using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace BoltQA
{
    static class Requests
    {

        public static string getAccessToken(string username)
        {
            string url = "https://qa02-spine.bedegaming.net/api/v5/players/sessions";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("X-Correlation-Token", "f9780325-d315-4e9a-9115-ac858c695538");
            request.Headers.Add("X-Site-Code", "ukcasino.com");
            using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    username = "godzgamer",
                    password = "password",
                    client_id = "ukcasino_web",
                    scope = "spine",
                    grant_type = "password"
                });
                    
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                var json = streamReader.ReadToEnd();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                dynamic jsonObject = jss.Deserialize<dynamic>(json);

                return jsonObject["access_token"];
            }
        }

        public static long getPlayerID(string username)
        {
            string url = string.Format("http://en1bdeqa02501-ilb.qa02.bde.bedegaming.com:1737/api/profiles/summary?sitecode=ukcasino.com&username={0}", username);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Headers.Add("X-Correlation-Token", "17372d18-6f29-4e04-b726-f7d8f463062b");
            request.Headers.Add("X-Site-Code", "ukcasino.com");
            

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                var json = streamReader.ReadToEnd();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                dynamic jsonObject = jss.Deserialize<dynamic>(json);

                return jsonObject["Id"];
            }
        }

        public static dynamic getPlayerInformation(string playerid, string token)
        {
            string url = string.Format("https://qa02-spine.bedegaming.net/api/v5/players/{0}/profile", playerid);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers.Add("X-Correlation-Token", "17372d18-6f29-4e04-b726-f7d8f463062b");
            request.Headers.Add("X-Site-Code", "ukcasino.com");
            request.Headers.Add("Authorization", string.Format("Bearer {0}", token));


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                var json = streamReader.ReadToEnd();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                dynamic jsonObject = jss.Deserialize<dynamic>(json);

                return jsonObject;
            }
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
