namespace prototype_app_chef
{
    partial class F_config
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
            this.m_menu_add_patient = new System.Windows.Forms.MenuStrip();
            this.m_acceuil = new System.Windows.Forms.ToolStripMenuItem();
            this.m_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_add_patient.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_menu_add_patient
            // 
            this.m_menu_add_patient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_acceuil,
            this.m_quitter});
            this.m_menu_add_patient.Location = new System.Drawing.Point(0, 0);
            this.m_menu_add_patient.Name = "m_menu_add_patient";
            this.m_menu_add_patient.Size = new System.Drawing.Size(1272, 24);
            this.m_menu_add_patient.TabIndex = 0;
            this.m_menu_add_patient.Text = "menuStrip1";
            // 
            // m_acceuil
            // 
            this.m_acceuil.Name = "m_acceuil";
            this.m_acceuil.Size = new System.Drawing.Size(58, 20);
            this.m_acceuil.Text = "Acceuil";
            this.m_acceuil.Click += new System.EventHandler(this.m_acceuil_Click);
            // 
            // m_quitter
            // 
            this.m_quitter.Name = "m_quitter";
            this.m_quitter.Size = new System.Drawing.Size(56, 20);
            this.m_quitter.Text = "Quitter";
            this.m_quitter.Click += new System.EventHandler(this.m_quitter_Click);
            // 
            // F_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 632);
            this.Controls.Add(this.m_menu_add_patient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.m_menu_add_patient;
            this.Name = "F_config";
            this.Text = "F_config";
            this.Load += new System.EventHandler(this.F_config_Load);
            this.m_menu_add_patient.ResumeLayout(false);
            this.m_menu_add_patient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_menu_add_patient;
        private System.Windows.Forms.ToolStripMenuItem m_acceuil;
        private System.Windows.Forms.ToolStripMenuItem m_quitter;
    }
}