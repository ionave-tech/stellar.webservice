using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROKUWEBAPI
{
    public partial class gettoken : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    //string baseUrl = "https://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";
                    string baseUrl = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";


                    client.BaseAddress = new Uri(baseUrl);

                    var content = new FormUrlEncodedContent(new[] 
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", TextBox1.Text),
                    new KeyValuePair<string, string>("password", TextBox2.Text)
                });
                    var responseMessage = client.PostAsync("/token", content).Result;

                    string result = "";
                    result = responseMessage.Content.ReadAsStringAsync().Result;

                    JObject joResponse = JObject.Parse(result);

                    try
                    {
                        Label1.Text = "Access Token: <br /><textarea rows='5' cols='70' readonly>" + joResponse.Root["access_token"].ToString() + "</textarea>";
                        Label1.Text += "<br />Token Type: <br /><input type='text' value='" + joResponse.Root["token_type"].ToString() + "' readonly></input>";
                        Label1.Text += "<br />Expires In: <br /><input type='text' value='" + joResponse.Root["expires_in"].ToString() + "' readonly></input>";
                        TextBox1.Text = "";
                    }
                    catch (Exception)
                    {
                        Label1.Text = joResponse.Root["error_description"].ToString();
                    }
                }
            }
            catch (Exception ex) { }
        }

    }
}