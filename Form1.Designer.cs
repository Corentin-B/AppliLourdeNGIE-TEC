namespace ApplicationLourde
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_utilisateur = new System.Windows.Forms.Label();
            this.label_motdepasse = new System.Windows.Forms.Label();
            this.listBox_donnees = new System.Windows.Forms.ListBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.label_connexion = new System.Windows.Forms.Label();
            this.Btn_ordonnancementprod = new System.Windows.Forms.Button();
            this.Btn_planprod = new System.Windows.Forms.Button();
            this.Btn_gestionclientcom = new System.Windows.Forms.Button();
            this.Btn_gestionclientfacturation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Endprod = new System.Windows.Forms.Button();
            this.Btn_Startprod = new System.Windows.Forms.Button();
            this.Btn_Changeplanprod = new System.Windows.Forms.Button();
            this.Btn_commandesclient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel_login.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(800, 79);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // Btn_login
            // 
            this.Btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_login.Location = new System.Drawing.Point(91, 92);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(75, 23);
            this.Btn_login.TabIndex = 2;
            this.Btn_login.Text = "Connexion";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(12, 27);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(154, 20);
            this.textBox_user.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(12, 66);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(154, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // label_utilisateur
            // 
            this.label_utilisateur.AutoSize = true;
            this.label_utilisateur.Location = new System.Drawing.Point(12, 11);
            this.label_utilisateur.Name = "label_utilisateur";
            this.label_utilisateur.Size = new System.Drawing.Size(53, 13);
            this.label_utilisateur.TabIndex = 4;
            this.label_utilisateur.Text = "Utilisateur";
            // 
            // label_motdepasse
            // 
            this.label_motdepasse.AutoSize = true;
            this.label_motdepasse.Location = new System.Drawing.Point(12, 50);
            this.label_motdepasse.Name = "label_motdepasse";
            this.label_motdepasse.Size = new System.Drawing.Size(74, 13);
            this.label_motdepasse.TabIndex = 5;
            this.label_motdepasse.Text = "Mot De Passe";
            // 
            // listBox_donnees
            // 
            this.listBox_donnees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_donnees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_donnees.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_donnees.FormattingEnabled = true;
            this.listBox_donnees.Location = new System.Drawing.Point(0, 79);
            this.listBox_donnees.Name = "listBox_donnees";
            this.listBox_donnees.Size = new System.Drawing.Size(413, 371);
            this.listBox_donnees.TabIndex = 6;
            // 
            // panel_login
            // 
            this.panel_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_login.Controls.Add(this.label_connexion);
            this.panel_login.Controls.Add(this.Btn_ordonnancementprod);
            this.panel_login.Controls.Add(this.Btn_planprod);
            this.panel_login.Controls.Add(this.Btn_gestionclientcom);
            this.panel_login.Controls.Add(this.textBox_password);
            this.panel_login.Controls.Add(this.Btn_login);
            this.panel_login.Controls.Add(this.textBox_user);
            this.panel_login.Controls.Add(this.label_motdepasse);
            this.panel_login.Controls.Add(this.label_utilisateur);
            this.panel_login.Location = new System.Drawing.Point(621, 79);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(179, 371);
            this.panel_login.TabIndex = 7;
            // 
            // label_connexion
            // 
            this.label_connexion.AutoSize = true;
            this.label_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connexion.ForeColor = System.Drawing.Color.Gray;
            this.label_connexion.Location = new System.Drawing.Point(12, 97);
            this.label_connexion.Name = "label_connexion";
            this.label_connexion.Size = new System.Drawing.Size(68, 13);
            this.label_connexion.TabIndex = 10;
            this.label_connexion.Text = "Hors Ligne";
            // 
            // Btn_ordonnancementprod
            // 
            this.Btn_ordonnancementprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ordonnancementprod.Location = new System.Drawing.Point(12, 227);
            this.Btn_ordonnancementprod.Name = "Btn_ordonnancementprod";
            this.Btn_ordonnancementprod.Size = new System.Drawing.Size(154, 38);
            this.Btn_ordonnancementprod.TabIndex = 9;
            this.Btn_ordonnancementprod.Text = "Ordonnancement de production";
            this.Btn_ordonnancementprod.UseVisualStyleBackColor = true;
            this.Btn_ordonnancementprod.Click += new System.EventHandler(this.Btn_ordonnancementprod_Click);
            // 
            // Btn_planprod
            // 
            this.Btn_planprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_planprod.Location = new System.Drawing.Point(12, 187);
            this.Btn_planprod.Name = "Btn_planprod";
            this.Btn_planprod.Size = new System.Drawing.Size(154, 23);
            this.Btn_planprod.TabIndex = 8;
            this.Btn_planprod.Text = "Plan de production";
            this.Btn_planprod.UseVisualStyleBackColor = true;
            this.Btn_planprod.Click += new System.EventHandler(this.Btn_planprod_Click);
            // 
            // Btn_gestionclientcom
            // 
            this.Btn_gestionclientcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_gestionclientcom.Location = new System.Drawing.Point(12, 147);
            this.Btn_gestionclientcom.Name = "Btn_gestionclientcom";
            this.Btn_gestionclientcom.Size = new System.Drawing.Size(154, 23);
            this.Btn_gestionclientcom.TabIndex = 6;
            this.Btn_gestionclientcom.Text = "Clients";
            this.Btn_gestionclientcom.UseVisualStyleBackColor = true;
            this.Btn_gestionclientcom.Click += new System.EventHandler(this.Btn_gestionclientcom_Click);
            // 
            // Btn_gestionclientfacturation
            // 
            this.Btn_gestionclientfacturation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_gestionclientfacturation.Location = new System.Drawing.Point(28, 65);
            this.Btn_gestionclientfacturation.Name = "Btn_gestionclientfacturation";
            this.Btn_gestionclientfacturation.Size = new System.Drawing.Size(154, 23);
            this.Btn_gestionclientfacturation.TabIndex = 7;
            this.Btn_gestionclientfacturation.Text = "Factures client";
            this.Btn_gestionclientfacturation.UseVisualStyleBackColor = true;
            this.Btn_gestionclientfacturation.Click += new System.EventHandler(this.Btn_gestionclientfacturation_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_Endprod);
            this.panel1.Controls.Add(this.Btn_Startprod);
            this.panel1.Controls.Add(this.Btn_Changeplanprod);
            this.panel1.Controls.Add(this.Btn_commandesclient);
            this.panel1.Controls.Add(this.Btn_gestionclientfacturation);
            this.panel1.Location = new System.Drawing.Point(413, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 371);
            this.panel1.TabIndex = 8;
            // 
            // Btn_Endprod
            // 
            this.Btn_Endprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Endprod.Location = new System.Drawing.Point(28, 185);
            this.Btn_Endprod.Name = "Btn_Endprod";
            this.Btn_Endprod.Size = new System.Drawing.Size(154, 23);
            this.Btn_Endprod.TabIndex = 11;
            this.Btn_Endprod.Text = "Finir la production";
            this.Btn_Endprod.UseVisualStyleBackColor = true;
            this.Btn_Endprod.Click += new System.EventHandler(this.Btn_Endprod_Click);
            // 
            // Btn_Startprod
            // 
            this.Btn_Startprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Startprod.Location = new System.Drawing.Point(28, 145);
            this.Btn_Startprod.Name = "Btn_Startprod";
            this.Btn_Startprod.Size = new System.Drawing.Size(154, 23);
            this.Btn_Startprod.TabIndex = 10;
            this.Btn_Startprod.Text = "Commencer la production";
            this.Btn_Startprod.UseVisualStyleBackColor = true;
            this.Btn_Startprod.Click += new System.EventHandler(this.Btn_Startprod_Click);
            // 
            // Btn_Changeplanprod
            // 
            this.Btn_Changeplanprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Changeplanprod.Location = new System.Drawing.Point(28, 105);
            this.Btn_Changeplanprod.Name = "Btn_Changeplanprod";
            this.Btn_Changeplanprod.Size = new System.Drawing.Size(154, 23);
            this.Btn_Changeplanprod.TabIndex = 9;
            this.Btn_Changeplanprod.Text = "Changer plan de production";
            this.Btn_Changeplanprod.UseVisualStyleBackColor = true;
            this.Btn_Changeplanprod.Click += new System.EventHandler(this.Btn_Changeplanprod_Click);
            // 
            // Btn_commandesclient
            // 
            this.Btn_commandesclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_commandesclient.Location = new System.Drawing.Point(28, 25);
            this.Btn_commandesclient.Name = "Btn_commandesclient";
            this.Btn_commandesclient.Size = new System.Drawing.Size(154, 23);
            this.Btn_commandesclient.TabIndex = 8;
            this.Btn_commandesclient.Text = "Commandes client";
            this.Btn_commandesclient.UseVisualStyleBackColor = true;
            this.Btn_commandesclient.Click += new System.EventHandler(this.Btn_commandesclient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.listBox_donnees);
            this.Controls.Add(this.pictureBox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application NGIE-TEC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_utilisateur;
        private System.Windows.Forms.Label label_motdepasse;
        private System.Windows.Forms.ListBox listBox_donnees;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Button Btn_gestionclientcom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_gestionclientfacturation;
        private System.Windows.Forms.Button Btn_ordonnancementprod;
        private System.Windows.Forms.Button Btn_planprod;
        private System.Windows.Forms.Label label_connexion;
        private System.Windows.Forms.Button Btn_commandesclient;
        private System.Windows.Forms.Button Btn_Endprod;
        private System.Windows.Forms.Button Btn_Startprod;
        private System.Windows.Forms.Button Btn_Changeplanprod;
    }
}

