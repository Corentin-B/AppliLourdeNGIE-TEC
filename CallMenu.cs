namespace ApplicationLourde
{
    class CallMenu
    {
        public static string Client()
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.Client();

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string Listplan()
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.Listplanprod();

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string Ordoprod()
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.Ordoprod();

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string Commandes(string client)
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.Commandes(client);

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string Factures(string client)
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.Factures(client);

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string FacturesPaye(string client)
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.FacturesPaye(client);

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string Planprod(string prod, string plan)
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.Planprod(prod, plan);

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string StartProd(string prod)
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.Startprod(prod);

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string Stopprod(string prod)
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.Endprod(prod);

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }
    }
}
