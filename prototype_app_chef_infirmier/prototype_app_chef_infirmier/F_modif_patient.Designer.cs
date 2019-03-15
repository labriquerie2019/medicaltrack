namespace prototype_app_chef_infirmier
{
    partial class F_modif_patient
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
            this.m_menu = new System.Windows.Forms.MenuStrip();
            this.m_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.m_acceuil = new System.Windows.Forms.ToolStripMenuItem();
            this.l_date_heure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_table_patient = new System.Windows.Forms.DataGridView();
            this.p_modif = new System.Windows.Forms.Panel();
            this.m_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // m_menu
            // 
            this.m_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_quitter,
            this.m_acceuil});
            this.m_menu.Location = new System.Drawing.Point(0, 0);
            this.m_menu.Name = "m_menu";
            this.m_menu.Size = new System.Drawing.Size(1247, 24);
            this.m_menu.TabIndex = 2;
            this.m_menu.Text = "date et heure";
            // 
            // m_quitter
            // 
            this.m_quitter.Name = "m_quitter";
            this.m_quitter.Size = new System.Drawing.Size(56, 20);
            this.m_quitter.Text = "Quitter";
            this.m_quitter.Click += new System.EventHandler(this.m_quitter_Click);
            // 
            // m_acceuil
            // 
            this.m_acceuil.Name = "m_acceuil";
            this.m_acceuil.Size = new System.Drawing.Size(58, 20);
            this.m_acceuil.Text = "Acceuil";
            this.m_acceuil.Click += new System.EventHandler(this.m_acceuil_Click);
            // 
            // l_date_heure
            // 
            this.l_date_heure.AutoSize = true;
            this.l_date_heure.Location = new System.Drawing.Point(828, 0);
            this.l_date_heure.Name = "l_date_heure";
            this.l_date_heure.Size = new System.Drawing.Size(70, 13);
            this.l_date_heure.TabIndex = 3;
            this.l_date_heure.Text = "date et heure";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgv_table_patient
            // 
            this.dgv_table_patient.AllowUserToAddRows = false;
            this.dgv_table_patient.AllowUserToDeleteRows = false;
            this.dgv_table_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table_patient.Location = new System.Drawing.Point(0, 27);
            this.dgv_table_patient.Name = "dgv_table_patient";
            this.dgv_table_patient.ReadOnly = true;
            this.dgv_table_patient.Size = new System.Drawing.Size(1247, 545);
            this.dgv_table_patient.TabIndex = 4;
            this.dgv_table_patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_patient_CellContentClick);
            // 
            // p_modif
            // 
            this.p_modif.Location = new System.Drawing.Point(0, 27);
            this.p_modif.Name = "p_modif";
            this.p_modif.Size = new System.Drawing.Size(1247, 545);
            this.p_modif.TabIndex = 5;
            this.p_modif.Visible = false;
            // 
            // F_modif_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 616);
            this.Controls.Add(this.p_modif);
            this.Controls.Add(this.dgv_table_patient);
            this.Controls.Add(this.l_date_heure);
            this.Controls.Add(this.m_menu);
            this.Name = "F_modif_patient";
            this.Text = "F_modif_patient";
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_menu;
        private System.Windows.Forms.ToolStripMenuItem m_quitter;
        private System.Windows.Forms.ToolStripMenuItem m_acceuil;
        private System.Windows.Forms.Label l_date_heure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_table_patient;
        private System.Windows.Forms.Panel p_modif;
    }
}