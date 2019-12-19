namespace ApplicationLourde
{
    class Login
    {
        static public bool TryLogin(string user, string psw)
        {
            //Try connexion
            try
            {
                AppelAPI AppelAPI = new AppelAPI();
                string responseAPI = AppelAPI.Login(user, psw);

                if (responseAPI == "Success")
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
