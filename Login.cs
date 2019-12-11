using System.Windows.Forms;

namespace ApplicationLourde
{
    class Login
    {
        static public bool Testco(string user, string psw)
        {
            //Test co
            if (!user.Contains(psw)) {

                return true;
            }
            else {
                return false;
            }
        }
    }
}
