using System;
using System.Net;
using System.Text;

namespace ApplicationLourde
{

    class AppelAPI
    {
        private String[] Logs = new String[2];

        private static string MainUrl = "http://api.ngie-tec.local";

        public string Login(string user, string password)
        {
            string url = MainUrl + "/login";
            WebClient wclient = new WebClient();

            wclient.QueryString.Add("user", user);
            wclient.QueryString.Add("password", password);

            try
            {
                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                //Properties.Settings.Default.user = responseString;

                if (responseString == "Success")
                {
                    // Properties.Settings.Default.token = responseString;
                }
                return responseString;
            }
            catch (WebException e)
            {
                return "Error";
            }
        }

        public string Client()
        {
            try
            {
                string url = MainUrl + "/clients";
                WebClient wclient = new WebClient();

                wclient.QueryString.Add("token", Properties.Settings.Default.user);

                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                return responseString;
            }
            catch (WebException)
            {
                return "Error";
            }
        }

        public string Listplanprod()
        {
            try
            {
                string url = MainUrl + "/listplan";
                WebClient wclient = new WebClient();

                wclient.QueryString.Add("token", Properties.Settings.Default.user);

                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                return responseString;
            }
            catch (WebException)
            {
                return "Error";
            }
        }

        public string Ordoprod()
        {
            try
            {
                string url = MainUrl + "/ordoprod";
                WebClient wclient = new WebClient();

                wclient.QueryString.Add("token", Properties.Settings.Default.user);

                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                return responseString;
            }
            catch (WebException)
            {
                return "Error";
            }
        }

        public string Commandes(int client)
        {
            try
            {
                string url = MainUrl + "/commandes";
                WebClient wclient = new WebClient();

                wclient.QueryString.Add("token", Properties.Settings.Default.user);
                wclient.QueryString.Add("client", client.ToString());

                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                return responseString;
            }
            catch (WebException)
            {
                return "Error";
            }
        }

        public string Factures()
        {
            try
            {
                string url = MainUrl + "/factures";
                WebClient wclient = new WebClient();

                wclient.QueryString.Add("token", Properties.Settings.Default.user);

                Console.WriteLine(wclient.ToString());

                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                return responseString;
            }
            catch (WebException)
            {
                return "Error";
            }
        }

        public string FacturesPaye(int client)
        {
            try
            {
                Console.WriteLine("FacturesPaye");
                string url = MainUrl + "/facturespaye";
                WebClient wclient = new WebClient();

                wclient.QueryString.Add("token", Properties.Settings.Default.user);
                wclient.QueryString.Add("client", client.ToString());
                wclient.QueryString.Add("paye", "1");

                Console.WriteLine(client);

                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                return responseString;
            }
            catch (WebException)
            {
                return "Error";
            }
        }

        public string ChangePlanprod(int prod, string plan)
        {
            try
            {
                string url = MainUrl + "/changeplanprod";
                WebClient wclient = new WebClient();

                wclient.QueryString.Add("token", Properties.Settings.Default.user);
                wclient.QueryString.Add("produit", prod.ToString());
                wclient.QueryString.Add("plan", plan);

                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                return responseString;
            }
            catch (WebException)
            {
                return "Error";
            }
        }

        public string StartProd(int prod)
        {
            try
            {
                string url = MainUrl + "/startprod";
                WebClient wclient = new WebClient();

                wclient.QueryString.Add("token", Properties.Settings.Default.user);
                wclient.QueryString.Add("prod", prod.ToString());
                wclient.QueryString.Add("date", DateTime.Now.ToString());

                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                return responseString;
            }
            catch (WebException)
            {
                return "Error";
            }
        }

        public string StopProd(int prod)
        {
            try
            {
                string url = MainUrl + "/endprod";
                WebClient wclient = new WebClient();

                wclient.QueryString.Add("token", Properties.Settings.Default.user);
                wclient.QueryString.Add("prod", prod.ToString());
                wclient.QueryString.Add("date", DateTime.Now.ToString());

                var data = wclient.UploadValues(url, "POST", wclient.QueryString);
                var responseString = UnicodeEncoding.UTF8.GetString(data);

                return responseString;
            }
            catch (WebException)
            {
                return "Error";
            }
        }
    }
}
