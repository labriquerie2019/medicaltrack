namespace prototype_app_chef
{
    partial class f_acceuil
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
            this.m_menu = new System.Windows.Forms.MenuStrip();
            this.m_menu_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.m_config = new System.Windows.Forms.ToolStripMenuItem();
            this.b_add_patient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.m_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_menu
            // 
            this.m_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menu_quitter,
            this.m_config});
            this.m_menu.Location = new System.Drawing.Point(0, 0);
            this.m_menu.Name = "m_menu";
            this.m_menu.Size = new System.Drawing.Size(1300, 24);
            this.m_menu.TabIndex = 0;
            this.m_menu.Text = "menuStrip1";
            // 
            // m_menu_quitter
            // 
            this.m_menu_quitter.Name = "m_menu_quitter";
            this.m_menu_quitter.Size = new System.Drawing.Size(56, 20);
            this.m_menu_quitter.Text = "Quitter";
            this.m_menu_quitter.Click += new System.EventHandler(this.m_menu_quitter_Click);
            // 
            // m_config
            // 
            this.m_config.Name = "m_config";
            this.m_config.Size = new System.Drawing.Size(93, 20);
            this.m_config.Text = "Configuration";
            this.m_config.Click += new System.EventHandler(this.m_config_Click);
            // 
            // b_add_patient
            // 
            this.b_add_patient.Location = new System.Drawing.Point(442, 65);
            this.b_add_patient.Name = "b_add_patient";
            this.b_add_patient.Size = new System.Drawing.Size(263, 62);
            this.b_add_patient.TabIndex = 1;
            this.b_add_patient.Text = "Ajouter un patient";
            this.b_add_patient.UseVisualStyleBackColor = true;
            this.b_add_patient.Click += new System.EventHandler(this.b_add_patient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 142);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // f_acceuil
            // 
            this.AccessibleName = "f_acceuil";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_add_patient);
            this.Controls.Add(this.m_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.m_menu;
            this.Name = "f_acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC_Medicaltrack";
            this.Load += new System.EventHandler(this.f_acceuil_Load);
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_menu;
        private System.Windows.Forms.ToolStripMenuItem m_menu_quitter;
        private System.Windows.Forms.ToolStripMenuItem m_config;
        private System.Windows.Forms.Button b_add_patient;
        private System.Windows.Forms.Button button1;
    }
}

