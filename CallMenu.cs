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

    }
}
