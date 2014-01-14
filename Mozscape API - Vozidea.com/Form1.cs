using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;

namespace Mozscape_API___Vozidea.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var access_id = textBox_access.Text;
            var secret_key = textBox_secret.Text;
            var url = textBox_url.Text;

            //Para el parametro cols se suman los valores PA = 34359738368 y DA = 68719476736
            //http://apiwiki.moz.com/url-metrics#cols
            var cols = (34359738368 + 68719476736).ToString();
            var expire = CreateExpiryTimestamp();
            string signature = SignRequest(access_id, secret_key, expire);

            var resource_url = "http://lsapi.seomoz.com/linkscape/url-metrics/" + Uri.EscapeDataString(url) +
                "?AccessID=" + Uri.EscapeDataString(access_id) +
                "&Expires=" + expire + "&Signature=" + signature + "&Cols=" + cols;
            
            //Request HTTP GET
            ServicePointManager.Expect100Continue = false;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(resource_url);
            request.Method = "GET";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string json = sr.ReadToEnd();
            sr.Close();
            response.Close();

            textBox_res.Text = json;

            string DA = ParseDA(json);
            string PA = ParsePA(json);
            if (DA != "" && PA != "")
            {
                DA = Math.Round(double.Parse(DA, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                PA = Math.Round(double.Parse(PA, System.Globalization.CultureInfo.InvariantCulture)).ToString();
                label_result.Text = "DA: " + DA + "       " + "PA: " + PA;
                label_result.Visible = true;
            }
        }

        public string SignRequest(string access_id, string secret_key, string expire)
        {
            string stringToSign = access_id + "\n" + expire;
            
            string signature;
            using (HMACSHA1 hasher = new HMACSHA1(ASCIIEncoding.ASCII.GetBytes(secret_key)))
            {
                signature = Convert.ToBase64String(hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(stringToSign)));
            }

            return Uri.EscapeDataString(signature);
        }

        public string CreateExpiryTimestamp()
        {
            var timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            // Añadir 5 minutos del futuro
            TimeSpan tsEnd = TimeSpan.FromMinutes(5);
            timeSpan = timeSpan.Add(tsEnd);
            var expiry_timestamp = Convert.ToInt64(timeSpan.TotalSeconds).ToString();

            return expiry_timestamp;
        }

        public string ParseDA(string json)
        {
            string DA = "";
            Regex search = new Regex(@"(?i)""pda"":(\d+\.*\d*)");
            Match find = search.Match(json);
            if (find.Success == true)
            {
                DA = find.Groups[1].Captures[0].Value;
            }
            return DA;
        }

        public string ParsePA(string json)
        {
            string PA = "";
            Regex search = new Regex(@"(?i)""upa"":(\d+\.*\d*)");
            Match find = search.Match(json);
            if (find.Success == true)
            {
                PA = find.Groups[1].Captures[0].Value;
            }
            return PA;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vozidea.com");
        }
    }
}
