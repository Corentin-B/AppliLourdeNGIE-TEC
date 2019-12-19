using Newtonsoft.Json.Linq;
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
            textBox_plan.Enabled = false;
            Btn_facturepaye.Enabled = false;
        }

        //LOGIN
        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (textBox_user.Text != "" && textBox_password.Text != "")
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
            label_sql.Visible = false;
            textBox_plan.Enabled = false;
            Btn_facturepaye.Enabled = false;


            var response = JArray.Parse(CallMenu.Client());

            listBox_donnees.Items.Clear();

            foreach (object i in response)
            {
                var replace = i.ToString().Replace('{', ' ').Replace('"', ' ').Replace('}', ' ');
                listBox_donnees.Items.Add(replace);
            }

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
            label_sql.Visible = false;
            Btn_facturepaye.Enabled = false;


            var response = JArray.Parse(CallMenu.Listplan());

            listBox_donnees.Items.Clear();

            foreach (object i in response)
            {
                var replace = i.ToString().Replace('{', ' ').Replace('"', ' ').Replace('}', ' ');
                listBox_donnees.Items.Add(replace);
            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            Btn_Changeplanprod.Enabled = true;
            textBox_plan.Enabled = true;
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
            label_sql.Visible = false;
            textBox_plan.Enabled = false;
            textBox_plan.Enabled = false;
            Btn_facturepaye.Enabled = false;


            var response = JArray.Parse(CallMenu.Ordoprod());

            listBox_donnees.Items.Clear();

            foreach (object i in response)
            {
                var replace = i.ToString().Replace('{', ' ').Replace('"', ' ').Replace('}', ' ');
                listBox_donnees.Items.Add(replace);
            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            Btn_Startprod.Enabled = true;
            Btn_Endprod.Enabled = true;
        }

        //CLIENT - COMMANDES
        private void Btn_commandesclient_Click(object sender, EventArgs e)
        {
            if (listBox_donnees.SelectedIndex != -1)
            {
                Btn_gestionclientcom.Enabled = false;
                Btn_ordonnancementprod.Enabled = false;
                Btn_planprod.Enabled = false;
                Btn_commandesclient.Enabled = false;
                Btn_gestionclientfacturation.Enabled = false;
                Btn_Changeplanprod.Enabled = false;
                Btn_Startprod.Enabled = false;
                Btn_Endprod.Enabled = false;
                label_sql.Visible = false;
                textBox_plan.Enabled = false;
                Btn_facturepaye.Enabled = false;


                int index = listBox_donnees.SelectedIndex + 1;
                var response = JArray.Parse(CallMenu.Commandes(index));

                listBox_donnees.Items.Clear();

                foreach (object i in response)
                {
                    var replace = i.ToString().Replace('{', ' ').Replace('"', ' ').Replace('}', ' ');
                    listBox_donnees.Items.Add(replace);
                }

                Btn_gestionclientcom.Enabled = true;
                Btn_planprod.Enabled = true;
                Btn_ordonnancementprod.Enabled = true;
            }
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
            label_sql.Visible = false;
            textBox_plan.Enabled = false;
            Btn_facturepaye.Enabled = false;


            var response = JArray.Parse(CallMenu.Factures());

            listBox_donnees.Items.Clear();

            foreach (object i in response)
            {
                var replace = i.ToString().Replace('{', ' ').Replace('"', ' ').Replace('}', ' ');
                replace = replace.Replace("EstPaye : 1", "EstPaye: Oui").Replace("EstPaye : 0", "EstPaye: Non");

                listBox_donnees.Items.Add(replace);
            }

            Btn_gestionclientcom.Enabled = true;
            Btn_planprod.Enabled = true;
            Btn_ordonnancementprod.Enabled = true;
            textBox_plan.Enabled = true;
            Btn_facturepaye.Enabled = true;
        }

        //CLIENT - FACTURE PAYEE
        private void Btn_facturepaye_Click(object sender, EventArgs e)
        {
            if (listBox_donnees.SelectedIndex != -1)
            {
                Btn_gestionclientcom.Enabled = false;
                Btn_ordonnancementprod.Enabled = false;
                Btn_planprod.Enabled = false;
                Btn_commandesclient.Enabled = false;
                Btn_gestionclientfacturation.Enabled = false;
                Btn_Changeplanprod.Enabled = false;
                Btn_Startprod.Enabled = false;
                Btn_Endprod.Enabled = false;
                label_sql.Visible = false;
                textBox_plan.Enabled = false;


                int index = listBox_donnees.SelectedIndex + 1;
                string response = CallMenu.FacturesPaye(index);

                if (response == "Success")
                {
                    label_sql.Visible = true;
                    label_sql.Text = "Success";
                    label_sql.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    label_sql.Visible = true;
                    label_sql.Text = "Error";
                    label_sql.ForeColor = System.Drawing.Color.Red;
                }

                Btn_gestionclientcom.Enabled = true;
                Btn_planprod.Enabled = true;
                Btn_ordonnancementprod.Enabled = true;
            }
        }

        //PLAN - CHANGEMENT PROD
        private void Btn_Changeplanprod_Click(object sender, EventArgs e)
        {
            if (listBox_donnees.SelectedIndex != -1)
            {
                Btn_gestionclientcom.Enabled = false;
                Btn_ordonnancementprod.Enabled = false;
                Btn_planprod.Enabled = false;
                Btn_commandesclient.Enabled = false;
                Btn_gestionclientfacturation.Enabled = false;
                Btn_Changeplanprod.Enabled = false;
                Btn_Startprod.Enabled = false;
                Btn_Endprod.Enabled = false;
                label_sql.Visible = false;
                textBox_plan.Enabled = false;
                Btn_facturepaye.Enabled = false;


                int index = listBox_donnees.SelectedIndex + 1;
                var response = CallMenu.ChangePlanprod(index, textBox_plan.Text);

                if (response == "Success")
                {
                    label_sql.Visible = true;
                    label_sql.Text = "Success";
                    label_sql.ForeColor = System.Drawing.Color.Green;

                    var response2 = JArray.Parse(CallMenu.Listplan());

                    listBox_donnees.Items.Clear();

                    foreach (object i in response2)
                    {
                        var replace2 = i.ToString().Replace('{', ' ').Replace('"', ' ').Replace('}', ' ');
                        listBox_donnees.Items.Add(replace2);
                    }
                }
                else
                {
                    label_sql.Visible = true;
                    label_sql.Text = "Error";
                    label_sql.ForeColor = System.Drawing.Color.Red;
                }

                Btn_gestionclientcom.Enabled = true;
                Btn_planprod.Enabled = true;
                Btn_ordonnancementprod.Enabled = true;
                Btn_Changeplanprod.Enabled = true;
                textBox_plan.Enabled = true;
            }
        }

        //ORDENANCEMENT - START
        private void Btn_Startprod_Click(object sender, EventArgs e)
        {
            if (listBox_donnees.SelectedIndex != -1)
            {
                Btn_gestionclientcom.Enabled = false;
                Btn_ordonnancementprod.Enabled = false;
                Btn_planprod.Enabled = false;
                Btn_commandesclient.Enabled = false;
                Btn_gestionclientfacturation.Enabled = false;
                Btn_Changeplanprod.Enabled = false;
                Btn_Startprod.Enabled = false;
                Btn_Endprod.Enabled = false;
                label_sql.Visible = false;
                textBox_plan.Enabled = false;
                Btn_facturepaye.Enabled = false;


                int index = listBox_donnees.SelectedIndex + 1;
                string response = CallMenu.StartProd(index);

                if (response == "Success")
                {
                    label_sql.Visible = true;
                    label_sql.Text = "Success";
                    label_sql.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    label_sql.Visible = true;
                    label_sql.Text = "Error";
                    label_sql.ForeColor = System.Drawing.Color.Red;
                }

                Btn_gestionclientcom.Enabled = true;
                Btn_planprod.Enabled = true;
                Btn_ordonnancementprod.Enabled = true;
                Btn_Startprod.Enabled = true;
                Btn_Endprod.Enabled = true;
            }
        }

        //ORDENANCEMENT - STOP
        private void Btn_Endprod_Click(object sender, EventArgs e)
        {
            if (listBox_donnees.SelectedIndex != -1)
            {
                Btn_gestionclientcom.Enabled = false;
                Btn_ordonnancementprod.Enabled = false;
                Btn_planprod.Enabled = false;
                Btn_commandesclient.Enabled = false;
                Btn_gestionclientfacturation.Enabled = false;
                Btn_Changeplanprod.Enabled = false;
                Btn_Startprod.Enabled = false;
                Btn_Endprod.Enabled = false;
                label_sql.Visible = false;
                textBox_plan.Enabled = false;
                Btn_facturepaye.Enabled = false;


                int index = listBox_donnees.SelectedIndex + 1;
                string response = CallMenu.StopProd(index);

                if (response == "Success")
                {
                    label_sql.Visible = true;
                    label_sql.Text = "Success";
                    label_sql.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    label_sql.Visible = true;
                    label_sql.Text = "Error";
                    label_sql.ForeColor = System.Drawing.Color.Red;
                }

                Btn_gestionclientcom.Enabled = true;
                Btn_planprod.Enabled = true;
                Btn_ordonnancementprod.Enabled = true;
                Btn_Startprod.Enabled = true;
                Btn_Endprod.Enabled = true;
            }
        }
    }
}
