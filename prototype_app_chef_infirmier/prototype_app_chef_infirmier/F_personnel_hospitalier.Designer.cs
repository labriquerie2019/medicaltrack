namespace prototype_app_chef_infirmier
{
    partial class F_personnel_hospitalier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.l_date_heure = new System.Windows.Forms.Label();
            this.m_menu = new System.Windows.Forms.MenuStrip();
            this.m_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.m_acceuil = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_personnel_hospitalier = new System.Windows.Forms.DataGridView();
            this.b_nouveau = new System.Windows.Forms.Button();
            this.p_personnel = new System.Windows.Forms.Panel();
            this.t_identifiant = new System.Windows.Forms.TextBox();
            this.l_identifiant = new System.Windows.Forms.Label();
            this.t_mdp = new System.Windows.Forms.TextBox();
            this.l_mdp = new System.Windows.Forms.Label();
            this.t_service = new System.Windows.Forms.TextBox();
            this.l_service = new System.Windows.Forms.Label();
            this.b_new_mdp = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.m_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personnel_hospitalier)).BeginInit();
            this.p_personnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_date_heure
            // 
            this.l_date_heure.AutoSize = true;
            this.l_date_heure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_date_heure.Location = new System.Drawing.Point(1126, 0);
            this.l_date_heure.Name = "l_date_heure";
            this.l_date_heure.Size = new System.Drawing.Size(104, 20);
            this.l_date_heure.TabIndex = 5;
            this.l_date_heure.Text = "date et heure";
            // 
            // m_menu
            // 
            this.m_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_quitter,
            this.m_acceuil});
            this.m_menu.Location = new System.Drawing.Point(0, 0);
            this.m_menu.Name = "m_menu";
            this.m_menu.Size = new System.Drawing.Size(1272, 29);
            this.m_menu.TabIndex = 4;
            this.m_menu.Text = "date et heure";
            // 
            // m_quitter
            // 
            this.m_quitter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_quitter.Name = "m_quitter";
            this.m_quitter.Size = new System.Drawing.Size(71, 25);
            this.m_quitter.Text = "Quitter";
            this.m_quitter.Click += new System.EventHandler(this.m_quitter_Click);
            // 
            // m_acceuil
            // 
            this.m_acceuil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_acceuil.Name = "m_acceuil";
            this.m_acceuil.Size = new System.Drawing.Size(71, 25);
            this.m_acceuil.Text = "Acceuil";
            this.m_acceuil.Click += new System.EventHandler(this.m_acceuil_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgv_personnel_hospitalier
            // 
            this.dgv_personnel_hospitalier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personnel_hospitalier.Location = new System.Drawing.Point(0, 32);
            this.dgv_personnel_hospitalier.Name = "dgv_personnel_hospitalier";
            this.dgv_personnel_hospitalier.Size = new System.Drawing.Size(1272, 485);
            this.dgv_personnel_hospitalier.TabIndex = 6;
            this.dgv_personnel_hospitalier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_personnel_hospitalier_CellContentClick);
            this.dgv_personnel_hospitalier.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_personnel_hospitalier_CellFormatting);
            // 
            // b_nouveau
            // 
            this.b_nouveau.Location = new System.Drawing.Point(0, 523);
            this.b_nouveau.Name = "b_nouveau";
            this.b_nouveau.Size = new System.Drawing.Size(1272, 32);
            this.b_nouveau.TabIndex = 7;
            this.b_nouveau.Text = "Nouveau personnel hospitalier";
            this.b_nouveau.UseVisualStyleBackColor = true;
            this.b_nouveau.Click += new System.EventHandler(this.b_nouveau_Click);
            // 
            // p_personnel
            // 
            this.p_personnel.Controls.Add(this.b_cancel);
            this.p_personnel.Controls.Add(this.b_save);
            this.p_personnel.Controls.Add(this.b_new_mdp);
            this.p_personnel.Controls.Add(this.t_service);
            this.p_personnel.Controls.Add(this.l_service);
            this.p_personnel.Controls.Add(this.t_mdp);
            this.p_personnel.Controls.Add(this.l_mdp);
            this.p_personnel.Controls.Add(this.t_identifiant);
            this.p_personnel.Controls.Add(this.l_identifiant);
            this.p_personnel.Location = new System.Drawing.Point(0, 32);
            this.p_personnel.Name = "p_personnel";
            this.p_personnel.Size = new System.Drawing.Size(1272, 523);
            this.p_personnel.TabIndex = 8;
            // 
            // t_identifiant
            // 
            this.t_identifiant.Location = new System.Drawing.Point(489, 41);
            this.t_identifiant.Name = "t_identifiant";
            this.t_identifiant.Size = new System.Drawing.Size(176, 29);
            this.t_identifiant.TabIndex = 1;
            // 
            // l_identifiant
            // 
            this.l_identifiant.AutoSize = true;
            this.l_identifiant.Location = new System.Drawing.Point(526, 14);
            this.l_identifiant.Name = "l_identifiant";
            this.l_identifiant.Size = new System.Drawing.Size(88, 24);
            this.l_identifiant.TabIndex = 0;
            this.l_identifiant.Text = "Identifiant";
            // 
            // t_mdp
            // 
            this.t_mdp.Location = new System.Drawing.Point(489, 100);
            this.t_mdp.Name = "t_mdp";
            this.t_mdp.ReadOnly = true;
            this.t_mdp.Size = new System.Drawing.Size(176, 29);
            this.t_mdp.TabIndex = 3;
            // 
            // l_mdp
            // 
            this.l_mdp.AutoSize = true;
            this.l_mdp.Location = new System.Drawing.Point(526, 73);
            this.l_mdp.Name = "l_mdp";
            this.l_mdp.Size = new System.Drawing.Size(123, 24);
            this.l_mdp.TabIndex = 2;
            this.l_mdp.Text = "Mot de passe";
            // 
            // t_service
            // 
            this.t_service.Location = new System.Drawing.Point(489, 159);
            this.t_service.Name = "t_service";
            this.t_service.Size = new System.Drawing.Size(176, 29);
            this.t_service.TabIndex = 5;
            // 
            // l_service
            // 
            this.l_service.AutoSize = true;
            this.l_service.Location = new System.Drawing.Point(541, 132);
            this.l_service.Name = "l_service";
            this.l_service.Size = new System.Drawing.Size(73, 24);
            this.l_service.TabIndex = 4;
            this.l_service.Text = "Service";
            // 
            // b_new_mdp
            // 
            this.b_new_mdp.Location = new System.Drawing.Point(685, 100);
            this.b_new_mdp.Name = "b_new_mdp";
            this.b_new_mdp.Size = new System.Drawing.Size(336, 29);
            this.b_new_mdp.TabIndex = 6;
            this.b_new_mdp.Text = "Génerer un nouveau mot de passe";
            this.b_new_mdp.UseVisualStyleBackColor = true;
            this.b_new_mdp.Click += new System.EventHandler(this.b_new_mdp_Click);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(421, 194);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(160, 45);
            this.b_save.TabIndex = 7;
            this.b_save.Text = "Sauvegarder";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(587, 194);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(160, 45);
            this.b_cancel.TabIndex = 8;
            this.b_cancel.Text = "Annuler";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // F_personnel_hospitalier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 556);
            this.Controls.Add(this.p_personnel);
            this.Controls.Add(this.b_nouveau);
            this.Controls.Add(this.dgv_personnel_hospitalier);
            this.Controls.Add(this.l_date_heure);
            this.Controls.Add(this.m_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "F_personnel_hospitalier";
            this.Text = "F_personnel_hospitalier";
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personnel_hospitalier)).EndInit();
            this.p_personnel.ResumeLayout(false);
            this.p_personnel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_date_heure;
        private System.Windows.Forms.MenuStrip m_menu;
        private System.Windows.Forms.ToolStripMenuItem m_quitter;
        private System.Windows.Forms.ToolStripMenuItem m_acceuil;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_personnel_hospitalier;
        private System.Windows.Forms.Button b_nouveau;
        private System.Windows.Forms.Panel p_personnel;
        private System.Windows.Forms.TextBox t_identifiant;
        private System.Windows.Forms.Label l_identifiant;
        private System.Windows.Forms.TextBox t_service;
        private System.Windows.Forms.Label l_service;
        private System.Windows.Forms.TextBox t_mdp;
        private System.Windows.Forms.Label l_mdp;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_new_mdp;
    }
}