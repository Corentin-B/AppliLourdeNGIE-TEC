using System.Windows.Forms;

namespace ApplicationLourde
{
    class Login
    {
        static public bool Testco(string user, string psw)
        {
            //Try co
            try
            {
                string responseAPI = "test";
                AppelAPI.Testc(user, psw);
                if (responseAPI != null)
                {
                    MessageBox.Show(responseAPI);
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
