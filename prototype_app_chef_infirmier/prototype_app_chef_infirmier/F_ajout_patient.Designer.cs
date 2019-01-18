namespace prototype_app_chef_infirmier
{
    partial class F_ajout_patient
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_date_heure = new System.Windows.Forms.Label();
            this.p_progressbar = new System.Windows.Forms.Panel();
            this.p_bar_progression = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.l_co_bdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_menu.SuspendLayout();
            this.p_progressbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_menu
            // 
            this.m_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_quitter,
            this.m_acceuil});
            this.m_menu.Location = new System.Drawing.Point(0, 0);
            this.m_menu.Name = "m_menu";
            this.m_menu.Size = new System.Drawing.Size(1147, 24);
            this.m_menu.TabIndex = 1;
            this.m_menu.Text = "menuStrip1";
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
            this.m_acceuil.Click += new System.EventHandler(this.m_configuration_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_date_heure
            // 
            this.l_date_heure.AutoSize = true;
            this.l_date_heure.Location = new System.Drawing.Point(1026, 0);
            this.l_date_heure.Name = "l_date_heure";
            this.l_date_heure.Size = new System.Drawing.Size(0, 13);
            this.l_date_heure.TabIndex = 2;
            // 
            // p_progressbar
            // 
            this.p_progressbar.Controls.Add(this.textBox1);
            this.p_progressbar.Controls.Add(this.label1);
            this.p_progressbar.Location = new System.Drawing.Point(0, 27);
            this.p_progressbar.Name = "p_progressbar";
            this.p_progressbar.Size = new System.Drawing.Size(1147, 550);
            this.p_progressbar.TabIndex = 3;
            this.p_progressbar.Visible = false;
            // 
            // p_bar_progression
            // 
            this.p_bar_progression.ForeColor = System.Drawing.Color.GreenYellow;
            this.p_bar_progression.Location = new System.Drawing.Point(170, 255);
            this.p_bar_progression.Name = "p_bar_progression";
            this.p_bar_progression.Size = new System.Drawing.Size(735, 23);
            this.p_bar_progression.TabIndex = 0;
            this.p_bar_progression.Click += new System.EventHandler(this.p_bar_progression_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // l_co_bdd
            // 
            this.l_co_bdd.AutoSize = true;
            this.l_co_bdd.Location = new System.Drawing.Point(405, 219);
            this.l_co_bdd.Name = "l_co_bdd";
            this.l_co_bdd.Size = new System.Drawing.Size(256, 13);
            this.l_co_bdd.TabIndex = 4;
            this.l_co_bdd.Text = "Connexion à la base de données, veuillez patienter...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // F_ajout_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 589);
            this.Controls.Add(this.p_progressbar);
            this.Controls.Add(this.l_co_bdd);
            this.Controls.Add(this.p_bar_progression);
            this.Controls.Add(this.l_date_heure);
            this.Controls.Add(this.m_menu);
            this.Name = "F_ajout_patient";
            this.Text = "F_ajout_patient";
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            this.p_progressbar.ResumeLayout(false);
            this.p_progressbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_menu;
        private System.Windows.Forms.ToolStripMenuItem m_quitter;
        private System.Windows.Forms.ToolStripMenuItem m_acceuil;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_date_heure;
        private System.Windows.Forms.Panel p_progressbar;
        private System.Windows.Forms.ProgressBar p_bar_progression;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label l_co_bdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}