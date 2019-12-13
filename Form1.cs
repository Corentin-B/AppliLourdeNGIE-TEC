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
            Btn_login.Enabled = false;
            textBox_user.Enabled = false;
            textBox_password.Enabled = false;

            if (Login.Testco(textBox_user.Text, textBox_password.Text))
            {
                label_connexion.Text = "En Ligne";
                label_connexion.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label_connexion.Text = "Erreur";
                label_connexion.ForeColor = System.Drawing.Color.Red;
                textBox_user.Clear();
                textBox_password.Clear();
                Btn_login.Enabled = true;
                textBox_user.Enabled = true;
                textBox_password.Enabled = true;
            }
            label_connexion.Refresh();
        }

        private void Btn_gestionclientcom_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;

            if (true /*CallApi*/)
            {
                //AppelAPI
            }
            else
            {

            }
            Btn_gestionclientcom.Enabled = true;
            Btn_gestionclientfacturation.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
        }

        private void Btn_gestionclientfacturation_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;

            if (true /*CallApi*/)
            {
                //AppelAPI
            }
            else
            {

            }
            Btn_gestionclientcom.Enabled = true;
            Btn_gestionclientfacturation.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
        }

        private void Btn_planprod_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;

            if (true /*CallApi*/)
            {
                //AppelAPI
            }
            else
            {

            }
            Btn_gestionclientcom.Enabled = true;
            Btn_gestionclientfacturation.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
        }

        private void Btn_ordonnancementprod_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;

            if (false /*CallApi*/)
            {
                //AppelAPI
            }
            else
            {

            }
            Btn_gestionclientcom.Enabled = true;
            Btn_gestionclientfacturation.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
        }
    }
}
