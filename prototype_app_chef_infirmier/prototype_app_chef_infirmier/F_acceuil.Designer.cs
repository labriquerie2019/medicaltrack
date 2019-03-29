namespace prototype_app_chef_infirmier
{
    partial class F_Acceuil
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
            this.components = new System.ComponentModel.Container();
            this.m_menu = new System.Windows.Forms.MenuStrip();
            this.m_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.m_configuration = new System.Windows.Forms.ToolStripMenuItem();
            this.p_showbutton = new System.Windows.Forms.Panel();
            this.b_gerer_planning = new System.Windows.Forms.Button();
            this.b_check_planning = new System.Windows.Forms.Button();
            this.b_edit_patient = new System.Windows.Forms.Button();
            this.b_add_patient = new System.Windows.Forms.Button();
            this.l_chargement = new System.Windows.Forms.Label();
            this.pb_chargement = new System.Windows.Forms.ProgressBar();
            this.t_ndc = new System.Windows.Forms.TextBox();
            this.t_mdp = new System.Windows.Forms.TextBox();
            this.l_ndc = new System.Windows.Forms.Label();
            this.l_mdp = new System.Windows.Forms.Label();
            this.b_connexion = new System.Windows.Forms.Button();
            this.l_date_heure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.m_menu.SuspendLayout();
            this.p_showbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_menu
            // 
            this.m_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_quitter,
            this.m_configuration});
            this.m_menu.Location = new System.Drawing.Point(0, 0);
            this.m_menu.Name = "m_menu";
            this.m_menu.Size = new System.Drawing.Size(884, 29);
            this.m_menu.TabIndex = 0;
            this.m_menu.Text = "date et heure";
            this.m_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.m_menu_ItemClicked);
            // 
            // m_quitter
            // 
            this.m_quitter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_quitter.Name = "m_quitter";
            this.m_quitter.Size = new System.Drawing.Size(71, 25);
            this.m_quitter.Text = "Quitter";
            this.m_quitter.Click += new System.EventHandler(this.m_quitter_Click);
            // 
            // m_configuration
            // 
            this.m_configuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_configuration.Name = "m_configuration";
            this.m_configuration.Size = new System.Drawing.Size(118, 25);
            this.m_configuration.Text = "Configuration";
            this.m_configuration.Visible = false;
            this.m_configuration.Click += new System.EventHandler(this.m_configuration_Click);
            // 
            // p_showbutton
            // 
            this.p_showbutton.Controls.Add(this.b_gerer_planning);
            this.p_showbutton.Controls.Add(this.b_check_planning);
            this.p_showbutton.Controls.Add(this.b_edit_patient);
            this.p_showbutton.Controls.Add(this.b_add_patient);
            this.p_showbutton.Location = new System.Drawing.Point(1, 32);
            this.p_showbutton.Name = "p_showbutton";
            this.p_showbutton.Size = new System.Drawing.Size(883, 506);
            this.p_showbutton.TabIndex = 1;
            this.p_showbutton.Visible = false;
            // 
            // b_gerer_planning
            // 
            this.b_gerer_planning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_gerer_planning.Location = new System.Drawing.Point(226, 16);
            this.b_gerer_planning.Name = "b_gerer_planning";
            this.b_gerer_planning.Size = new System.Drawing.Size(452, 102);
            this.b_gerer_planning.TabIndex = 3;
            this.b_gerer_planning.Text = "Gérer le planning";
            this.b_gerer_planning.UseVisualStyleBackColor = true;
            this.b_gerer_planning.Click += new System.EventHandler(this.b_gerer_planning_Click);
            // 
            // b_check_planning
            // 
            this.b_check_planning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_check_planning.Location = new System.Drawing.Point(226, 129);
            this.b_check_planning.Name = "b_check_planning";
            this.b_check_planning.Size = new System.Drawing.Size(452, 96);
            this.b_check_planning.TabIndex = 2;
            this.b_check_planning.Text = "Consulter le planning";
            this.b_check_planning.UseVisualStyleBackColor = true;
            this.b_check_planning.Click += new System.EventHandler(this.b_check_planning_Click);
            // 
            // b_edit_patient
            // 
            this.b_edit_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_edit_patient.Location = new System.Drawing.Point(226, 364);
            this.b_edit_patient.Name = "b_edit_patient";
            this.b_edit_patient.Size = new System.Drawing.Size(452, 117);
            this.b_edit_patient.TabIndex = 1;
            this.b_edit_patient.Text = "Modifier/supprimer un patient";
            this.b_edit_patient.UseVisualStyleBackColor = true;
            this.b_edit_patient.Click += new System.EventHandler(this.b_edit_patient_Click);
            // 
            // b_add_patient
            // 
            this.b_add_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_add_patient.Location = new System.Drawing.Point(226, 244);
            this.b_add_patient.Name = "b_add_patient";
            this.b_add_patient.Size = new System.Drawing.Size(452, 105);
            this.b_add_patient.TabIndex = 0;
            this.b_add_patient.Text = "Ajouter un patient";
            this.b_add_patient.UseVisualStyleBackColor = true;
            this.b_add_patient.Click += new System.EventHandler(this.b_add_patient_Click);
            // 
            // l_chargement
            // 
            this.l_chargement.AutoSize = true;
            this.l_chargement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_chargement.Location = new System.Drawing.Point(18, 366);
            this.l_chargement.Name = "l_chargement";
            this.l_chargement.Size = new System.Drawing.Size(86, 31);
            this.l_chargement.TabIndex = 5;
            this.l_chargement.Text = "label1";
            this.l_chargement.Visible = false;
            // 
            // pb_chargement
            // 
            this.pb_chargement.Location = new System.Drawing.Point(24, 271);
            this.pb_chargement.Name = "pb_chargement";
            this.pb_chargement.Size = new System.Drawing.Size(860, 81);
            this.pb_chargement.TabIndex = 4;
            this.pb_chargement.Visible = false;
            // 
            // t_ndc
            // 
            this.t_ndc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_ndc.Location = new System.Drawing.Point(368, 93);
            this.t_ndc.Name = "t_ndc";
            this.t_ndc.Size = new System.Drawing.Size(216, 38);
            this.t_ndc.TabIndex = 2;
            // 
            // t_mdp
            // 
            this.t_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_mdp.Location = new System.Drawing.Point(368, 169);
            this.t_mdp.Name = "t_mdp";
            this.t_mdp.PasswordChar = '*';
            this.t_mdp.Size = new System.Drawing.Size(216, 38);
            this.t_mdp.TabIndex = 3;
            // 
            // l_ndc
            // 
            this.l_ndc.AutoSize = true;
            this.l_ndc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ndc.Location = new System.Drawing.Point(369, 59);
            this.l_ndc.Name = "l_ndc";
            this.l_ndc.Size = new System.Drawing.Size(215, 31);
            this.l_ndc.TabIndex = 4;
            this.l_ndc.Text = "Nom d\'utilisateur";
            // 
            // l_mdp
            // 
            this.l_mdp.AutoSize = true;
            this.l_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mdp.Location = new System.Drawing.Point(372, 135);
            this.l_mdp.Name = "l_mdp";
            this.l_mdp.Size = new System.Drawing.Size(176, 31);
            this.l_mdp.TabIndex = 5;
            this.l_mdp.Text = "Mot de passe";
            // 
            // b_connexion
            // 
            this.b_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_connexion.Location = new System.Drawing.Point(368, 216);
            this.b_connexion.Name = "b_connexion";
            this.b_connexion.Size = new System.Drawing.Size(216, 49);
            this.b_connexion.TabIndex = 6;
            this.b_connexion.Text = "Se connecter";
            this.b_connexion.UseVisualStyleBackColor = true;
            this.b_connexion.Click += new System.EventHandler(this.b_connexion_Click);
            // 
            // l_date_heure
            // 
            this.l_date_heure.AutoSize = true;
            this.l_date_heure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_date_heure.Location = new System.Drawing.Point(731, 0);
            this.l_date_heure.Name = "l_date_heure";
            this.l_date_heure.Size = new System.Drawing.Size(104, 20);
            this.l_date_heure.TabIndex = 7;
            this.l_date_heure.Text = "date et heure";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 531);
            this.Controls.Add(this.p_showbutton);
            this.Controls.Add(this.pb_chargement);
            this.Controls.Add(this.l_date_heure);
            this.Controls.Add(this.b_connexion);
            this.Controls.Add(this.m_menu);
            this.Controls.Add(this.l_mdp);
            this.Controls.Add(this.l_ndc);
            this.Controls.Add(this.t_ndc);
            this.Controls.Add(this.t_mdp);
            this.Controls.Add(this.l_chargement);
            this.MainMenuStrip = this.m_menu;
            this.Name = "F_Acceuil";
            this.Text = "Gestion des patients";
            this.Load += new System.EventHandler(this.F_Acceuil_Load);
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            this.p_showbutton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_menu;
        private System.Windows.Forms.ToolStripMenuItem m_quitter;
        private System.Windows.Forms.ToolStripMenuItem m_configuration;
        private System.Windows.Forms.Panel p_showbutton;
        private System.Windows.Forms.TextBox t_ndc;
        private System.Windows.Forms.TextBox t_mdp;
        private System.Windows.Forms.Label l_ndc;
        private System.Windows.Forms.Label l_mdp;
        private System.Windows.Forms.Button b_connexion;
        private System.Windows.Forms.Button b_add_patient;
        private System.Windows.Forms.Button b_edit_patient;
        private System.Windows.Forms.Label l_date_heure;
        private System.Windows.Forms.Button b_check_planning;
        private System.Windows.Forms.Button b_gerer_planning;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_chargement;
        private System.Windows.Forms.ProgressBar pb_chargement;
    }
}

