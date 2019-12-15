using System;
using System.Windows.Forms;


namespace ApplicationLourde
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Test connection serveur 
            Btn_gestionclientcom.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;
            Btn_planprod.Enabled = false;

            Btn_commandesclient.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_Changeplanprod.Enabled = false;
            Btn_Startprod.Enabled = false;
            Btn_Endprod.Enabled = false;
        }

        //LOGIN
        private void Btn_login_Click(object sender, EventArgs e)
        {
            Btn_login.Enabled = false;
            textBox_user.Enabled = false;
            textBox_password.Enabled = false;

            if (Login.TryLogin(textBox_user.Text, textBox_password.Text))
            {
                label_connexion.Text = "En Ligne";
                label_connexion.ForeColor = System.Drawing.Color.Green;
                Btn_gestionclientcom.Enabled = true;
                Btn_ordonnancementprod.Enabled = true;
                Btn_planprod.Enabled = true;
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

        //CLIENT
        private void Btn_gestionclientcom_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_commandesclient.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_Changeplanprod.Enabled = false;
            Btn_Startprod.Enabled = false;
            Btn_Endprod.Enabled = false;

            listBox_donnees.Items.Clear();

            listBox_donnees.Items.Add(CallMenu.Client());

            Btn_commandesclient.Enabled = true;
            Btn_gestionclientfacturation.Enabled = true;

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
        }

        //PLAN DE PRODUCTION
        private void Btn_planprod_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_commandesclient.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_Changeplanprod.Enabled = false;
            Btn_Startprod.Enabled = false;
            Btn_Endprod.Enabled = false;

            if (true /*CallApi*/)
            {
                //AppelAPI
                Btn_planprod.Enabled = true;
            }
            else
            {

            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            Btn_Changeplanprod.Enabled = true;
        }

        //ORDENANCEMENT DE PRODUTCION
        private void Btn_ordonnancementprod_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_commandesclient.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_Changeplanprod.Enabled = false;
            Btn_Startprod.Enabled = false;
            Btn_Endprod.Enabled = false;

            if (true /*CallApi*/)
            {
                //AppelAPI
                Btn_Startprod.Enabled = true;
                Btn_Endprod.Enabled = true;
            }
            else
            {

            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            Btn_Startprod.Enabled = true;
            Btn_Endprod.Enabled = true;
        }

        //CLIENT - FACTURATION
        private void Btn_gestionclientfacturation_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_commandesclient.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_Changeplanprod.Enabled = false;
            Btn_Startprod.Enabled = false;
            Btn_Endprod.Enabled = false;


            if (true /*CallApi*/)
            {
                //AppelAPI
            }
            else
            {

            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            Btn_commandesclient.Enabled = true;
            Btn_gestionclientfacturation.Enabled = true;
        }

        //CLIENT - COMMANDES
        private void Btn_commandesclient_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_commandesclient.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_Changeplanprod.Enabled = false;
            Btn_Startprod.Enabled = false;
            Btn_Endprod.Enabled = false;


            if (true /*CallApi*/)
            {
                //AppelAPI
            }
            else
            {

            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            Btn_commandesclient.Enabled = true;
            Btn_gestionclientfacturation.Enabled = true;
        }

        //PLAN - CHANGEMENT PROD
        private void Btn_Changeplanprod_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_commandesclient.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_Changeplanprod.Enabled = false;
            Btn_Startprod.Enabled = false;
            Btn_Endprod.Enabled = false;

            if (true /*CallApi*/)
            {
                //AppelAPI
                Btn_planprod.Enabled = true;
            }
            else
            {

            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            Btn_planprod.Enabled = true;
        }

        //ORDENANCEMENT - START
        private void Btn_Startprod_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_commandesclient.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_Changeplanprod.Enabled = false;
            Btn_Startprod.Enabled = false;
            Btn_Endprod.Enabled = false;

            if (true /*CallApi*/)
            {
                //AppelAPI
                Btn_Startprod.Enabled = true;
                Btn_Endprod.Enabled = true;
            }
            else
            {

            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            Btn_Startprod.Enabled = true;
            Btn_Endprod.Enabled = true;
        }

        //ORDENANCEMENT - STOP
        private void Btn_Endprod_Click(object sender, EventArgs e)
        {
            Btn_gestionclientcom.Enabled = false;
            Btn_ordonnancementprod.Enabled = false;
            Btn_planprod.Enabled = false;
            Btn_commandesclient.Enabled = false;
            Btn_gestionclientfacturation.Enabled = false;
            Btn_Changeplanprod.Enabled = false;
            Btn_Startprod.Enabled = false;
            Btn_Endprod.Enabled = false;

            if (true /*CallApi*/)
            {
                //AppelAPI
                Btn_Startprod.Enabled = true;
                Btn_Endprod.Enabled = true;
            }
            else
            {

            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            Btn_Startprod.Enabled = true;
            Btn_Endprod.Enabled = true;
        }
    }
}
