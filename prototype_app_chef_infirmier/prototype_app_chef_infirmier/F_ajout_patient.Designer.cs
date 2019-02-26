﻿namespace prototype_app_chef_infirmier
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
            this.dgv_calendrier = new System.Windows.Forms.DataGridView();
            this.Heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lundi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mardi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mercredi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jeudi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendredi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Samedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_calendrier = new System.Windows.Forms.DateTimePicker();
            this.dp_admission = new System.Windows.Forms.DateTimePicker();
            this.l_date_admission = new System.Windows.Forms.Label();
            this.t_allergie = new System.Windows.Forms.TextBox();
            this.l_allergies = new System.Windows.Forms.Label();
            this.t_antecedent_medicaux = new System.Windows.Forms.TextBox();
            this.l_antecedant = new System.Windows.Forms.Label();
            this.t_taille = new System.Windows.Forms.TextBox();
            this.l_taille = new System.Windows.Forms.Label();
            this.t_poid = new System.Windows.Forms.TextBox();
            this.l_poid = new System.Windows.Forms.Label();
            this.b_add_patient = new System.Windows.Forms.Button();
            this.dp_date_naissance = new System.Windows.Forms.DateTimePicker();
            this.t_note = new System.Windows.Forms.TextBox();
            this.l_note = new System.Windows.Forms.Label();
            this.t_situation_familial = new System.Windows.Forms.TextBox();
            this.l_situation_familial = new System.Windows.Forms.Label();
            this.t_sexe = new System.Windows.Forms.TextBox();
            this.l_sexe = new System.Windows.Forms.Label();
            this.l_date_de_naissance = new System.Windows.Forms.Label();
            this.t_age = new System.Windows.Forms.TextBox();
            this.l_age = new System.Windows.Forms.Label();
            this.t_prenom = new System.Windows.Forms.TextBox();
            this.l_prenom = new System.Windows.Forms.Label();
            this.t_nom = new System.Windows.Forms.TextBox();
            this.l_nom = new System.Windows.Forms.Label();
            this.p_bar_chargement = new System.Windows.Forms.Panel();
            this.l_chargement = new System.Windows.Forms.Label();
            this.pb_progress = new System.Windows.Forms.ProgressBar();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.cb_salle = new System.Windows.Forms.ComboBox();
            this.l_select_date = new System.Windows.Forms.Label();
            this.l_select_room = new System.Windows.Forms.Label();
            this.m_menu.SuspendLayout();
            this.p_progressbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendrier)).BeginInit();
            this.p_bar_chargement.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_menu
            // 
            this.m_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_quitter,
            this.m_acceuil});
            this.m_menu.Location = new System.Drawing.Point(0, 0);
            this.m_menu.Name = "m_menu";
            this.m_menu.Size = new System.Drawing.Size(1249, 24);
            this.m_menu.TabIndex = 1;
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
            this.l_date_heure.Size = new System.Drawing.Size(70, 13);
            this.l_date_heure.TabIndex = 2;
            this.l_date_heure.Text = "date et heure";
            // 
            // p_progressbar
            // 
            this.p_progressbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_progressbar.Controls.Add(this.l_select_room);
            this.p_progressbar.Controls.Add(this.l_select_date);
            this.p_progressbar.Controls.Add(this.cb_salle);
            this.p_progressbar.Controls.Add(this.dgv_calendrier);
            this.p_progressbar.Controls.Add(this.dt_calendrier);
            this.p_progressbar.Controls.Add(this.dp_admission);
            this.p_progressbar.Controls.Add(this.l_date_admission);
            this.p_progressbar.Controls.Add(this.t_allergie);
            this.p_progressbar.Controls.Add(this.l_allergies);
            this.p_progressbar.Controls.Add(this.t_antecedent_medicaux);
            this.p_progressbar.Controls.Add(this.l_antecedant);
            this.p_progressbar.Controls.Add(this.t_taille);
            this.p_progressbar.Controls.Add(this.l_taille);
            this.p_progressbar.Controls.Add(this.t_poid);
            this.p_progressbar.Controls.Add(this.l_poid);
            this.p_progressbar.Controls.Add(this.b_add_patient);
            this.p_progressbar.Controls.Add(this.dp_date_naissance);
            this.p_progressbar.Controls.Add(this.t_note);
            this.p_progressbar.Controls.Add(this.l_note);
            this.p_progressbar.Controls.Add(this.t_situation_familial);
            this.p_progressbar.Controls.Add(this.l_situation_familial);
            this.p_progressbar.Controls.Add(this.t_sexe);
            this.p_progressbar.Controls.Add(this.l_sexe);
            this.p_progressbar.Controls.Add(this.l_date_de_naissance);
            this.p_progressbar.Controls.Add(this.t_age);
            this.p_progressbar.Controls.Add(this.l_age);
            this.p_progressbar.Controls.Add(this.t_prenom);
            this.p_progressbar.Controls.Add(this.l_prenom);
            this.p_progressbar.Controls.Add(this.t_nom);
            this.p_progressbar.Controls.Add(this.l_nom);
            this.p_progressbar.Location = new System.Drawing.Point(1, 27);
            this.p_progressbar.Name = "p_progressbar";
            this.p_progressbar.Size = new System.Drawing.Size(1248, 550);
            this.p_progressbar.TabIndex = 3;
            // 
            // dgv_calendrier
            // 
            this.dgv_calendrier.AllowUserToAddRows = false;
            this.dgv_calendrier.AllowUserToDeleteRows = false;
            this.dgv_calendrier.AllowUserToOrderColumns = true;
            this.dgv_calendrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calendrier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Heure,
            this.Lundi,
            this.Mardi,
            this.Mercredi,
            this.Jeudi,
            this.Vendredi,
            this.Samedi,
            this.Dimanche});
            this.dgv_calendrier.Location = new System.Drawing.Point(428, 67);
            this.dgv_calendrier.Name = "dgv_calendrier";
            this.dgv_calendrier.ReadOnly = true;
            this.dgv_calendrier.Size = new System.Drawing.Size(819, 461);
            this.dgv_calendrier.TabIndex = 28;
            // 
            // Heure
            // 
            this.Heure.HeaderText = "Heure";
            this.Heure.Name = "Heure";
            this.Heure.ReadOnly = true;
            // 
            // Lundi
            // 
            this.Lundi.HeaderText = "Lundi";
            this.Lundi.Name = "Lundi";
            this.Lundi.ReadOnly = true;
            // 
            // Mardi
            // 
            this.Mardi.HeaderText = "Mardi";
            this.Mardi.Name = "Mardi";
            this.Mardi.ReadOnly = true;
            // 
            // Mercredi
            // 
            this.Mercredi.HeaderText = "Mercredi";
            this.Mercredi.Name = "Mercredi";
            this.Mercredi.ReadOnly = true;
            // 
            // Jeudi
            // 
            this.Jeudi.HeaderText = "Jeudi";
            this.Jeudi.Name = "Jeudi";
            this.Jeudi.ReadOnly = true;
            // 
            // Vendredi
            // 
            this.Vendredi.HeaderText = "Vendredi";
            this.Vendredi.Name = "Vendredi";
            this.Vendredi.ReadOnly = true;
            // 
            // Samedi
            // 
            this.Samedi.HeaderText = "Samedi";
            this.Samedi.Name = "Samedi";
            this.Samedi.ReadOnly = true;
            // 
            // Dimanche
            // 
            this.Dimanche.HeaderText = "Dimanche";
            this.Dimanche.Name = "Dimanche";
            this.Dimanche.ReadOnly = true;
            // 
            // dt_calendrier
            // 
            this.dt_calendrier.Location = new System.Drawing.Point(894, 11);
            this.dt_calendrier.Name = "dt_calendrier";
            this.dt_calendrier.Size = new System.Drawing.Size(200, 20);
            this.dt_calendrier.TabIndex = 27;
            // 
            // dp_admission
            // 
            this.dp_admission.Location = new System.Drawing.Point(6, 19);
            this.dp_admission.Name = "dp_admission";
            this.dp_admission.Size = new System.Drawing.Size(197, 20);
            this.dp_admission.TabIndex = 25;
            // 
            // l_date_admission
            // 
            this.l_date_admission.AutoSize = true;
            this.l_date_admission.Location = new System.Drawing.Point(3, 3);
            this.l_date_admission.Name = "l_date_admission";
            this.l_date_admission.Size = new System.Drawing.Size(87, 13);
            this.l_date_admission.TabIndex = 24;
            this.l_date_admission.Text = "Date d\'admission";
            // 
            // t_allergie
            // 
            this.t_allergie.Location = new System.Drawing.Point(225, 246);
            this.t_allergie.Multiline = true;
            this.t_allergie.Name = "t_allergie";
            this.t_allergie.Size = new System.Drawing.Size(197, 132);
            this.t_allergie.TabIndex = 23;
            // 
            // l_allergies
            // 
            this.l_allergies.AutoSize = true;
            this.l_allergies.Location = new System.Drawing.Point(230, 230);
            this.l_allergies.Name = "l_allergies";
            this.l_allergies.Size = new System.Drawing.Size(46, 13);
            this.l_allergies.TabIndex = 22;
            this.l_allergies.Text = "Allergies";
            // 
            // t_antecedent_medicaux
            // 
            this.t_antecedent_medicaux.Location = new System.Drawing.Point(225, 397);
            this.t_antecedent_medicaux.Multiline = true;
            this.t_antecedent_medicaux.Name = "t_antecedent_medicaux";
            this.t_antecedent_medicaux.Size = new System.Drawing.Size(197, 131);
            this.t_antecedent_medicaux.TabIndex = 21;
            // 
            // l_antecedant
            // 
            this.l_antecedant.AutoSize = true;
            this.l_antecedant.Location = new System.Drawing.Point(230, 381);
            this.l_antecedant.Name = "l_antecedant";
            this.l_antecedant.Size = new System.Drawing.Size(110, 13);
            this.l_antecedant.TabIndex = 20;
            this.l_antecedant.Text = "Antécédent médicaux";
            // 
            // t_taille
            // 
            this.t_taille.Location = new System.Drawing.Point(225, 207);
            this.t_taille.Name = "t_taille";
            this.t_taille.Size = new System.Drawing.Size(197, 20);
            this.t_taille.TabIndex = 19;
            // 
            // l_taille
            // 
            this.l_taille.AutoSize = true;
            this.l_taille.Location = new System.Drawing.Point(224, 191);
            this.l_taille.Name = "l_taille";
            this.l_taille.Size = new System.Drawing.Size(32, 13);
            this.l_taille.TabIndex = 18;
            this.l_taille.Text = "Taille";
            // 
            // t_poid
            // 
            this.t_poid.Location = new System.Drawing.Point(225, 163);
            this.t_poid.Name = "t_poid";
            this.t_poid.Size = new System.Drawing.Size(197, 20);
            this.t_poid.TabIndex = 17;
            // 
            // l_poid
            // 
            this.l_poid.AutoSize = true;
            this.l_poid.Location = new System.Drawing.Point(222, 147);
            this.l_poid.Name = "l_poid";
            this.l_poid.Size = new System.Drawing.Size(28, 13);
            this.l_poid.TabIndex = 16;
            this.l_poid.Text = "Poid";
            // 
            // b_add_patient
            // 
            this.b_add_patient.Location = new System.Drawing.Point(227, 3);
            this.b_add_patient.Name = "b_add_patient";
            this.b_add_patient.Size = new System.Drawing.Size(195, 41);
            this.b_add_patient.TabIndex = 15;
            this.b_add_patient.Text = "Ajouter un nouveau patient";
            this.b_add_patient.UseVisualStyleBackColor = true;
            this.b_add_patient.Click += new System.EventHandler(this.b_add_patient_Click);
            // 
            // dp_date_naissance
            // 
            this.dp_date_naissance.Location = new System.Drawing.Point(11, 280);
            this.dp_date_naissance.Name = "dp_date_naissance";
            this.dp_date_naissance.Size = new System.Drawing.Size(197, 20);
            this.dp_date_naissance.TabIndex = 14;
            // 
            // t_note
            // 
            this.t_note.Location = new System.Drawing.Point(11, 397);
            this.t_note.Multiline = true;
            this.t_note.Name = "t_note";
            this.t_note.Size = new System.Drawing.Size(197, 131);
            this.t_note.TabIndex = 13;
            this.t_note.TextChanged += new System.EventHandler(this.t_note_TextChanged);
            // 
            // l_note
            // 
            this.l_note.AutoSize = true;
            this.l_note.Location = new System.Drawing.Point(7, 381);
            this.l_note.Name = "l_note";
            this.l_note.Size = new System.Drawing.Size(30, 13);
            this.l_note.TabIndex = 12;
            this.l_note.Text = "Note";
            // 
            // t_situation_familial
            // 
            this.t_situation_familial.Location = new System.Drawing.Point(11, 358);
            this.t_situation_familial.Name = "t_situation_familial";
            this.t_situation_familial.Size = new System.Drawing.Size(197, 20);
            this.t_situation_familial.TabIndex = 11;
            // 
            // l_situation_familial
            // 
            this.l_situation_familial.AutoSize = true;
            this.l_situation_familial.Location = new System.Drawing.Point(6, 342);
            this.l_situation_familial.Name = "l_situation_familial";
            this.l_situation_familial.Size = new System.Drawing.Size(82, 13);
            this.l_situation_familial.TabIndex = 10;
            this.l_situation_familial.Text = "Situation familial";
            // 
            // t_sexe
            // 
            this.t_sexe.Location = new System.Drawing.Point(11, 319);
            this.t_sexe.Name = "t_sexe";
            this.t_sexe.Size = new System.Drawing.Size(197, 20);
            this.t_sexe.TabIndex = 9;
            // 
            // l_sexe
            // 
            this.l_sexe.AutoSize = true;
            this.l_sexe.Location = new System.Drawing.Point(6, 303);
            this.l_sexe.Name = "l_sexe";
            this.l_sexe.Size = new System.Drawing.Size(31, 13);
            this.l_sexe.TabIndex = 8;
            this.l_sexe.Text = "Sexe";
            // 
            // l_date_de_naissance
            // 
            this.l_date_de_naissance.AutoSize = true;
            this.l_date_de_naissance.Location = new System.Drawing.Point(8, 264);
            this.l_date_de_naissance.Name = "l_date_de_naissance";
            this.l_date_de_naissance.Size = new System.Drawing.Size(96, 13);
            this.l_date_de_naissance.TabIndex = 6;
            this.l_date_de_naissance.Text = "Date de naissance";
            // 
            // t_age
            // 
            this.t_age.Location = new System.Drawing.Point(11, 241);
            this.t_age.Name = "t_age";
            this.t_age.Size = new System.Drawing.Size(197, 20);
            this.t_age.TabIndex = 5;
            // 
            // l_age
            // 
            this.l_age.AutoSize = true;
            this.l_age.Location = new System.Drawing.Point(8, 225);
            this.l_age.Name = "l_age";
            this.l_age.Size = new System.Drawing.Size(26, 13);
            this.l_age.TabIndex = 4;
            this.l_age.Text = "Age";
            // 
            // t_prenom
            // 
            this.t_prenom.Location = new System.Drawing.Point(11, 202);
            this.t_prenom.Name = "t_prenom";
            this.t_prenom.Size = new System.Drawing.Size(197, 20);
            this.t_prenom.TabIndex = 3;
            // 
            // l_prenom
            // 
            this.l_prenom.AutoSize = true;
            this.l_prenom.Location = new System.Drawing.Point(8, 186);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(43, 13);
            this.l_prenom.TabIndex = 2;
            this.l_prenom.Text = "Prenom";
            // 
            // t_nom
            // 
            this.t_nom.Location = new System.Drawing.Point(11, 163);
            this.t_nom.Name = "t_nom";
            this.t_nom.Size = new System.Drawing.Size(197, 20);
            this.t_nom.TabIndex = 1;
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Location = new System.Drawing.Point(6, 147);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(29, 13);
            this.l_nom.TabIndex = 0;
            this.l_nom.Text = "Nom";
            // 
            // p_bar_chargement
            // 
            this.p_bar_chargement.Controls.Add(this.l_chargement);
            this.p_bar_chargement.Controls.Add(this.pb_progress);
            this.p_bar_chargement.Location = new System.Drawing.Point(0, 27);
            this.p_bar_chargement.Name = "p_bar_chargement";
            this.p_bar_chargement.Size = new System.Drawing.Size(1253, 550);
            this.p_bar_chargement.TabIndex = 26;
            this.p_bar_chargement.Visible = false;
            // 
            // l_chargement
            // 
            this.l_chargement.AutoSize = true;
            this.l_chargement.Location = new System.Drawing.Point(350, 226);
            this.l_chargement.Name = "l_chargement";
            this.l_chargement.Size = new System.Drawing.Size(35, 13);
            this.l_chargement.TabIndex = 1;
            this.l_chargement.Text = "label1";
            // 
            // pb_progress
            // 
            this.pb_progress.Location = new System.Drawing.Point(252, 281);
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(652, 63);
            this.pb_progress.TabIndex = 0;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // cb_salle
            // 
            this.cb_salle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_salle.FormattingEnabled = true;
            this.cb_salle.Items.AddRange(new object[] {
            "Salle d\'opération 1",
            "Salle d\'opération 2"});
            this.cb_salle.Location = new System.Drawing.Point(894, 40);
            this.cb_salle.Name = "cb_salle";
            this.cb_salle.Size = new System.Drawing.Size(200, 21);
            this.cb_salle.TabIndex = 29;
            // 
            // l_select_date
            // 
            this.l_select_date.AutoSize = true;
            this.l_select_date.Location = new System.Drawing.Point(760, 11);
            this.l_select_date.Name = "l_select_date";
            this.l_select_date.Size = new System.Drawing.Size(119, 13);
            this.l_select_date.TabIndex = 30;
            this.l_select_date.Text = "Sélectionner la semaine";
            // 
            // l_select_room
            // 
            this.l_select_room.AutoSize = true;
            this.l_select_room.Location = new System.Drawing.Point(778, 43);
            this.l_select_room.Name = "l_select_room";
            this.l_select_room.Size = new System.Drawing.Size(101, 13);
            this.l_select_room.TabIndex = 31;
            this.l_select_room.Text = "Sélectionner la salle";
            // 
            // F_ajout_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 589);
            this.Controls.Add(this.p_bar_chargement);
            this.Controls.Add(this.l_date_heure);
            this.Controls.Add(this.m_menu);
            this.Controls.Add(this.p_progressbar);
            this.Name = "F_ajout_patient";
            this.Text = "F_ajout_patient";
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            this.p_progressbar.ResumeLayout(false);
            this.p_progressbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendrier)).EndInit();
            this.p_bar_chargement.ResumeLayout(false);
            this.p_bar_chargement.PerformLayout();
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
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.TextBox t_nom;
        private System.Windows.Forms.TextBox t_prenom;
        private System.Windows.Forms.Label l_prenom;
        private System.Windows.Forms.TextBox t_age;
        private System.Windows.Forms.Label l_age;
        private System.Windows.Forms.Label l_date_de_naissance;
        private System.Windows.Forms.TextBox t_sexe;
        private System.Windows.Forms.Label l_sexe;
        private System.Windows.Forms.TextBox t_note;
        private System.Windows.Forms.Label l_note;
        private System.Windows.Forms.TextBox t_situation_familial;
        private System.Windows.Forms.Label l_situation_familial;
        private System.Windows.Forms.Button b_add_patient;
        private System.Windows.Forms.DateTimePicker dp_date_naissance;
        private System.Windows.Forms.TextBox t_allergie;
        private System.Windows.Forms.Label l_allergies;
        private System.Windows.Forms.TextBox t_antecedent_medicaux;
        private System.Windows.Forms.Label l_antecedant;
        private System.Windows.Forms.TextBox t_taille;
        private System.Windows.Forms.Label l_taille;
        private System.Windows.Forms.TextBox t_poid;
        private System.Windows.Forms.Label l_poid;
        private System.Windows.Forms.Label l_date_admission;
        private System.Windows.Forms.DateTimePicker dp_admission;
        private System.Windows.Forms.Panel p_bar_chargement;
        private System.Windows.Forms.Label l_chargement;
        private System.Windows.Forms.ProgressBar pb_progress;
        private System.Windows.Forms.DateTimePicker dt_calendrier;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.DataGridView dgv_calendrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lundi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mardi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mercredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jeudi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Samedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimanche;
        private System.Windows.Forms.Label l_select_room;
        private System.Windows.Forms.Label l_select_date;
        private System.Windows.Forms.ComboBox cb_salle;
    }
}