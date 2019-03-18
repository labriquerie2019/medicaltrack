namespace prototype_app_chef_infirmier
{
    partial class F_gerer_planning
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
            this.cb_salle = new System.Windows.Forms.ComboBox();
            this.l_choix_salle = new System.Windows.Forms.Label();
            this.dgv_calendrier = new System.Windows.Forms.DataGridView();
            this.l_choix_patient = new System.Windows.Forms.Label();
            this.cb_patient = new System.Windows.Forms.ComboBox();
            this.l_select_date = new System.Windows.Forms.Label();
            this.dt_calendrier = new System.Windows.Forms.DateTimePicker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.m_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendrier)).BeginInit();
            this.SuspendLayout();
            // 
            // m_menu
            // 
            this.m_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_quitter,
            this.m_acceuil});
            this.m_menu.Location = new System.Drawing.Point(0, 0);
            this.m_menu.Name = "m_menu";
            this.m_menu.Size = new System.Drawing.Size(1283, 24);
            this.m_menu.TabIndex = 2;
            this.m_menu.Text = "menuStrip1";
            this.m_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.m_menu_ItemClicked);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_date_heure
            // 
            this.l_date_heure.AutoSize = true;
            this.l_date_heure.Location = new System.Drawing.Point(1181, 0);
            this.l_date_heure.Name = "l_date_heure";
            this.l_date_heure.Size = new System.Drawing.Size(70, 13);
            this.l_date_heure.TabIndex = 3;
            this.l_date_heure.Text = "date et heure";
            // 
            // cb_salle
            // 
            this.cb_salle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_salle.FormattingEnabled = true;
            this.cb_salle.Items.AddRange(new object[] {
            "Salle d\'opération 1",
            "Salle d\'opération 2"});
            this.cb_salle.Location = new System.Drawing.Point(8, 79);
            this.cb_salle.Name = "cb_salle";
            this.cb_salle.Size = new System.Drawing.Size(207, 21);
            this.cb_salle.TabIndex = 30;
            this.cb_salle.SelectedIndexChanged += new System.EventHandler(this.cb_salle_SelectedIndexChanged);
            // 
            // l_choix_salle
            // 
            this.l_choix_salle.AutoSize = true;
            this.l_choix_salle.Location = new System.Drawing.Point(12, 63);
            this.l_choix_salle.Name = "l_choix_salle";
            this.l_choix_salle.Size = new System.Drawing.Size(83, 13);
            this.l_choix_salle.TabIndex = 31;
            this.l_choix_salle.Text = "Choix de la salle";
            // 
            // dgv_calendrier
            // 
            this.dgv_calendrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calendrier.Location = new System.Drawing.Point(527, 24);
            this.dgv_calendrier.Name = "dgv_calendrier";
            this.dgv_calendrier.Size = new System.Drawing.Size(724, 516);
            this.dgv_calendrier.TabIndex = 32;
            // 
            // l_choix_patient
            // 
            this.l_choix_patient.AutoSize = true;
            this.l_choix_patient.Location = new System.Drawing.Point(12, 287);
            this.l_choix_patient.Name = "l_choix_patient";
            this.l_choix_patient.Size = new System.Drawing.Size(83, 13);
            this.l_choix_patient.TabIndex = 33;
            this.l_choix_patient.Text = "Choix du patient";
            // 
            // cb_patient
            // 
            this.cb_patient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_patient.FormattingEnabled = true;
            this.cb_patient.Location = new System.Drawing.Point(15, 303);
            this.cb_patient.Name = "cb_patient";
            this.cb_patient.Size = new System.Drawing.Size(200, 21);
            this.cb_patient.TabIndex = 34;
            // 
            // l_select_date
            // 
            this.l_select_date.AutoSize = true;
            this.l_select_date.Location = new System.Drawing.Point(12, 24);
            this.l_select_date.Name = "l_select_date";
            this.l_select_date.Size = new System.Drawing.Size(119, 13);
            this.l_select_date.TabIndex = 37;
            this.l_select_date.Text = "Sélectionner la semaine";
            // 
            // dt_calendrier
            // 
            this.dt_calendrier.Location = new System.Drawing.Point(8, 40);
            this.dt_calendrier.Name = "dt_calendrier";
            this.dt_calendrier.Size = new System.Drawing.Size(207, 20);
            this.dt_calendrier.TabIndex = 36;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // F_gerer_planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 552);
            this.Controls.Add(this.l_select_date);
            this.Controls.Add(this.dt_calendrier);
            this.Controls.Add(this.cb_patient);
            this.Controls.Add(this.l_choix_patient);
            this.Controls.Add(this.dgv_calendrier);
            this.Controls.Add(this.l_choix_salle);
            this.Controls.Add(this.cb_salle);
            this.Controls.Add(this.l_date_heure);
            this.Controls.Add(this.m_menu);
            this.Name = "F_gerer_planning";
            this.Text = "F_gerer_planning";
            this.Load += new System.EventHandler(this.F_gerer_planning_Load);
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendrier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_menu;
        private System.Windows.Forms.ToolStripMenuItem m_quitter;
        private System.Windows.Forms.ToolStripMenuItem m_acceuil;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_date_heure;
        private System.Windows.Forms.ComboBox cb_salle;
        private System.Windows.Forms.Label l_choix_salle;
        private System.Windows.Forms.DataGridView dgv_calendrier;
        private System.Windows.Forms.Label l_choix_patient;
        private System.Windows.Forms.ComboBox cb_patient;
        private System.Windows.Forms.Label l_select_date;
        private System.Windows.Forms.DateTimePicker dt_calendrier;
        private System.Windows.Forms.Timer timer2;
    }
}