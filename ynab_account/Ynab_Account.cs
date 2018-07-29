using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YNAB_Desktop.ynab_account
{
    class Ynab_Account
    {
        private string accessToken;
        private frm_Main ui;
        public Ynab_Account(frm_Main ui, string accessToken, bool writeFile)
        {
            this.accessToken = accessToken;
            this.ui = ui;
            if (writeFile)
            {
                writeTokenToFile();
            }
        }

        private void writeTokenToFile()
        {
            System.IO.File.WriteAllText("access.token", this.accessToken);
        }

        public void getBudgetsData()
        {
            string data = httpRequest("");
            JObject json = JObject.Parse(data);
            foreach (JObject b in json["data"]["budgets"])
            {
                ui.addObjectsToGrid((string)b["id"], (string)b["name"]);
            }
        }

        private string httpRequest(string endpoint)
        {
            string uri = "https://api.youneedabudget.com/v1/budgets" + endpoint;
            HttpClient client = new HttpClient();
            var authHeader = new AuthenticationHeaderValue("Bearer", this.accessToken);
            client.DefaultRequestHeaders.Authorization = authHeader;
            var response = client.GetStringAsync(uri).Result;
            return response;
        }
    }
}
