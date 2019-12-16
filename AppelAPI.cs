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

        public string Commandes(string client)
        {
            string url = MainUrl + "/commandes";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("client", client);

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string Factures(string client)
        {
            string url = MainUrl + "/factures";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("client", client);

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string FacturesPaye(string client)
        {
            string url = MainUrl + "/facturespaye";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("client", client);
            wclient.QueryString.Add("paye", "1");

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string Planprod(string prod, string plan)
        {
            string url = MainUrl + "/planprod";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("prod", prod);
            wclient.QueryString.Add("plan", plan);

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string Startprod(string prod)
        {
            string url = MainUrl + "/startprod";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("prod", prod);
            wclient.QueryString.Add("date", DateTime.Now.ToString());


            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }

        public string Endprod(string prod)
        {
            string url = MainUrl + "/endprod";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("token", Properties.Settings.Default.Token);
            wclient.QueryString.Add("prod", prod);
            wclient.QueryString.Add("date", DateTime.Now.ToString());

            var data = wclient.UploadValues(url, "POST", wclient.QueryString);
            var responseString = UnicodeEncoding.UTF8.GetString(data);

            return responseString;
        }
    }
}
