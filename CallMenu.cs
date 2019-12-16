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

        public static string Commandes(int client)
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

        public static string Factures()
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.Factures();

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string FacturesPaye(int client)
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

        public static string ChangePlanprod(int prod, string plan)
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.ChangePlanprod(prod, plan);

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string StartProd(int prod)
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.StartProd(prod);

            if (responseAPI != null)
            {
                return responseAPI;
            }
            else
            {
                return "Error";
            }
        }

        public static string StopProd(int prod)
        {
            AppelAPI AppelAPI = new AppelAPI();

            string responseAPI = AppelAPI.StopProd(prod);

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
