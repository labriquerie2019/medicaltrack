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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_date_heure = new System.Windows.Forms.Label();
            this.cb_salle = new System.Windows.Forms.ComboBox();
            this.l_choix_salle = new System.Windows.Forms.Label();
            this.dgv_calendrier = new System.Windows.Forms.DataGridView();
            this.l_choix_patient = new System.Windows.Forms.Label();
            this.cb_patient = new System.Windows.Forms.ComboBox();
            this.l_select_date = new System.Windows.Forms.Label();
            this.dt_calendrier = new System.Windows.Forms.DateTimePicker();
            this.l_nb_patient = new System.Windows.Forms.Label();
            this.cb_duree = new System.Windows.Forms.ComboBox();
            this.l_duree = new System.Windows.Forms.Label();
            this.m_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.m_acceuil = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu = new System.Windows.Forms.MenuStrip();
            this.b_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendrier)).BeginInit();
            this.m_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_date_heure
            // 
            this.l_date_heure.AutoSize = true;
            this.l_date_heure.Location = new System.Drawing.Point(2165, 0);
            this.l_date_heure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_date_heure.Name = "l_date_heure";
            this.l_date_heure.Size = new System.Drawing.Size(121, 24);
            this.l_date_heure.TabIndex = 3;
            this.l_date_heure.Text = "date et heure";
            // 
            // cb_salle
            // 
            this.cb_salle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_salle.FormattingEnabled = true;
            this.cb_salle.Items.AddRange(new object[] {
            "Salle d\'anesthesie",
            "Salle d\'opération 1",
            "Salle d\'opération 2",
            "Salle de réanimation",
            "Salle de reveil"});
            this.cb_salle.Location = new System.Drawing.Point(15, 146);
            this.cb_salle.Margin = new System.Windows.Forms.Padding(6);
            this.cb_salle.Name = "cb_salle";
            this.cb_salle.Size = new System.Drawing.Size(376, 32);
            this.cb_salle.TabIndex = 30;
            this.cb_salle.SelectedIndexChanged += new System.EventHandler(this.cb_salle_SelectedIndexChanged);
            // 
            // l_choix_salle
            // 
            this.l_choix_salle.AutoSize = true;
            this.l_choix_salle.Location = new System.Drawing.Point(22, 116);
            this.l_choix_salle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_choix_salle.Name = "l_choix_salle";
            this.l_choix_salle.Size = new System.Drawing.Size(148, 24);
            this.l_choix_salle.TabIndex = 31;
            this.l_choix_salle.Text = "Choix de la salle";
            // 
            // dgv_calendrier
            // 
            this.dgv_calendrier.AllowUserToAddRows = false;
            this.dgv_calendrier.AllowUserToDeleteRows = false;
            this.dgv_calendrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calendrier.Location = new System.Drawing.Point(435, 43);
            this.dgv_calendrier.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_calendrier.Name = "dgv_calendrier";
            this.dgv_calendrier.ReadOnly = true;
            this.dgv_calendrier.Size = new System.Drawing.Size(977, 505);
            this.dgv_calendrier.TabIndex = 32;
            this.dgv_calendrier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_calendrier_CellContentClick);
            this.dgv_calendrier.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_calendrier_CellMouseUp);
            // 
            // l_choix_patient
            // 
            this.l_choix_patient.AutoSize = true;
            this.l_choix_patient.Location = new System.Drawing.Point(22, 215);
            this.l_choix_patient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_choix_patient.Name = "l_choix_patient";
            this.l_choix_patient.Size = new System.Drawing.Size(146, 24);
            this.l_choix_patient.TabIndex = 33;
            this.l_choix_patient.Text = "Choix du patient";
            // 
            // cb_patient
            // 
            this.cb_patient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_patient.FormattingEnabled = true;
            this.cb_patient.Location = new System.Drawing.Point(15, 244);
            this.cb_patient.Margin = new System.Windows.Forms.Padding(6);
            this.cb_patient.Name = "cb_patient";
            this.cb_patient.Size = new System.Drawing.Size(363, 32);
            this.cb_patient.TabIndex = 34;
            this.cb_patient.SelectedIndexChanged += new System.EventHandler(this.cb_patient_SelectedIndexChanged);
            // 
            // l_select_date
            // 
            this.l_select_date.AutoSize = true;
            this.l_select_date.Location = new System.Drawing.Point(22, 44);
            this.l_select_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_select_date.Name = "l_select_date";
            this.l_select_date.Size = new System.Drawing.Size(212, 24);
            this.l_select_date.TabIndex = 37;
            this.l_select_date.Text = "Sélectionner la semaine";
            // 
            // dt_calendrier
            // 
            this.dt_calendrier.Location = new System.Drawing.Point(15, 74);
            this.dt_calendrier.Margin = new System.Windows.Forms.Padding(6);
            this.dt_calendrier.Name = "dt_calendrier";
            this.dt_calendrier.Size = new System.Drawing.Size(376, 29);
            this.dt_calendrier.TabIndex = 36;
            // 
            // l_nb_patient
            // 
            this.l_nb_patient.AutoSize = true;
            this.l_nb_patient.Location = new System.Drawing.Point(15, 184);
            this.l_nb_patient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_nb_patient.Name = "l_nb_patient";
            this.l_nb_patient.Size = new System.Drawing.Size(92, 24);
            this.l_nb_patient.TabIndex = 38;
            this.l_nb_patient.Text = "nb patient";
            // 
            // cb_duree
            // 
            this.cb_duree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_duree.FormattingEnabled = true;
            this.cb_duree.Items.AddRange(new object[] {
            "1h",
            "2h",
            "3h",
            "4h"});
            this.cb_duree.Location = new System.Drawing.Point(15, 311);
            this.cb_duree.Margin = new System.Windows.Forms.Padding(6);
            this.cb_duree.Name = "cb_duree";
            this.cb_duree.Size = new System.Drawing.Size(363, 32);
            this.cb_duree.TabIndex = 40;
            this.cb_duree.SelectedIndexChanged += new System.EventHandler(this.cb_duree_SelectedIndexChanged);
            // 
            // l_duree
            // 
            this.l_duree.AutoSize = true;
            this.l_duree.Location = new System.Drawing.Point(22, 282);
            this.l_duree.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_duree.Name = "l_duree";
            this.l_duree.Size = new System.Drawing.Size(261, 24);
            this.l_duree.TabIndex = 39;
            this.l_duree.Text = "Choisir la durée de l\'opération";
            // 
            // m_quitter
            // 
            this.m_quitter.Name = "m_quitter";
            this.m_quitter.Size = new System.Drawing.Size(83, 29);
            this.m_quitter.Text = "Quitter";
            this.m_quitter.Click += new System.EventHandler(this.m_quitter_Click);
            // 
            // m_acceuil
            // 
            this.m_acceuil.Name = "m_acceuil";
            this.m_acceuil.Size = new System.Drawing.Size(85, 29);
            this.m_acceuil.Text = "Acceuil";
            this.m_acceuil.Click += new System.EventHandler(this.m_acceuil_Click);
            // 
            // m_menu
            // 
            this.m_menu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_quitter,
            this.m_acceuil});
            this.m_menu.Location = new System.Drawing.Point(0, 0);
            this.m_menu.Name = "m_menu";
            this.m_menu.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.m_menu.Size = new System.Drawing.Size(1429, 37);
            this.m_menu.TabIndex = 2;
            this.m_menu.Text = "menuStrip1";
            this.m_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.m_menu_ItemClicked);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(15, 466);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(363, 39);
            this.b_delete.TabIndex = 41;
            this.b_delete.Text = "Effacer une opération";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // F_gerer_planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 563);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.cb_duree);
            this.Controls.Add(this.l_duree);
            this.Controls.Add(this.l_nb_patient);
            this.Controls.Add(this.l_select_date);
            this.Controls.Add(this.dt_calendrier);
            this.Controls.Add(this.cb_patient);
            this.Controls.Add(this.l_choix_patient);
            this.Controls.Add(this.dgv_calendrier);
            this.Controls.Add(this.l_choix_salle);
            this.Controls.Add(this.cb_salle);
            this.Controls.Add(this.l_date_heure);
            this.Controls.Add(this.m_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "F_gerer_planning";
            this.Text = "F_gerer_planning";
            this.Load += new System.EventHandler(this.F_gerer_planning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendrier)).EndInit();
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_date_heure;
        private System.Windows.Forms.ComboBox cb_salle;
        private System.Windows.Forms.Label l_choix_salle;
        private System.Windows.Forms.DataGridView dgv_calendrier;
        private System.Windows.Forms.Label l_choix_patient;
        private System.Windows.Forms.ComboBox cb_patient;
        private System.Windows.Forms.Label l_select_date;
        private System.Windows.Forms.DateTimePicker dt_calendrier;
        private System.Windows.Forms.Label l_nb_patient;
        private System.Windows.Forms.ComboBox cb_duree;
        private System.Windows.Forms.Label l_duree;
        private System.Windows.Forms.ToolStripMenuItem m_quitter;
        private System.Windows.Forms.ToolStripMenuItem m_acceuil;
        private System.Windows.Forms.MenuStrip m_menu;
        private System.Windows.Forms.Button b_delete;
    }
}