using System;
using System.Net;
using System.Text;

namespace ApplicationLourde
{
    class AppelAPI
    {

        private static string MainUrl = "http://localhost:3000";

        public string Login(string user, string password)
        {
            string url = MainUrl + "/Login";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("user", user);
            wclient.QueryString.Add("password", password);

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            Console.WriteLine(responseString);
            Properties.Settings.Default.Token = responseString;

            return responseString;
        }

        public string Client()
        {
            string url = MainUrl + "/clients";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);            

            return responseString;
        }

        public string Listplanprod()
        {
            string url = MainUrl + "/listplan";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string Ordoprod()
        {
            string url = MainUrl + "/ordoprod";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string Commandes(int client)
        {
            string url = MainUrl + "/commandes";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("client", client.ToString());

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string Factures()
        {
            string url = MainUrl + "/factures";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);

            Console.WriteLine(wclient.ToString());

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string FacturesPaye(int client)
        {
            Console.WriteLine("FacturesPaye");
            string url = MainUrl + "/facturespaye";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("client", client.ToString());
            wclient.QueryString.Add("paye", "1");

            Console.WriteLine(client);

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string ChangePlanprod(int prod, string plan)
        {
            string url = MainUrl + "/changeplanprod";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("produit", prod.ToString());
            wclient.QueryString.Add("plan", plan);

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string StartProd(int prod)
        {
            string url = MainUrl + "/startprod";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("prod", prod.ToString());
            wclient.QueryString.Add("date", DateTime.Now.ToString());

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string StopProd(int prod)
        {
            string url = MainUrl + "/endprod";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("prod", prod.ToString());
            wclient.QueryString.Add("date", DateTime.Now.ToString());

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }
    }
}
