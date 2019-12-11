using System;
using System.Windows.Forms;


namespace ApplicationLourde
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Test connection serveur ?
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Login.Testco(textBox_user.Text, textBox_password.Text);   
        }
    }
}
