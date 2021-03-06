﻿namespace prototype_app_chef_infirmier
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
            this.t_rfid = new System.Windows.Forms.TextBox();
            this.l_l_new_bracelet_2 = new System.Windows.Forms.Label();
            this.l_l_new_bracelet = new System.Windows.Forms.Label();
            this.l_l_rfid = new System.Windows.Forms.Label();
            this.l_last_scan = new System.Windows.Forms.Label();
            this.l_l_last_scan = new System.Windows.Forms.Label();
            this.b_annuler = new System.Windows.Forms.Button();
            this.b_done_modif = new System.Windows.Forms.Button();
            this.l_date_admission = new System.Windows.Forms.Label();
            this.l_label_date_admission = new System.Windows.Forms.Label();
            this.t_allergie = new System.Windows.Forms.TextBox();
            this.l_allergies = new System.Windows.Forms.Label();
            this.t_antecedent_medicaux = new System.Windows.Forms.TextBox();
            this.l_antecedant = new System.Windows.Forms.Label();
            this.t_taille = new System.Windows.Forms.TextBox();
            this.l_taille = new System.Windows.Forms.Label();
            this.t_poid = new System.Windows.Forms.TextBox();
            this.l_poid = new System.Windows.Forms.Label();
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
            this.l_filtre = new System.Windows.Forms.Label();
            this.cb_filtre = new System.Windows.Forms.ComboBox();
            this.t_filtre = new System.Windows.Forms.TextBox();
            this.m_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table_patient)).BeginInit();
            this.p_modif.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_menu
            // 
            this.m_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_quitter,
            this.m_acceuil});
            this.m_menu.Location = new System.Drawing.Point(0, 0);
            this.m_menu.Name = "m_menu";
            this.m_menu.Size = new System.Drawing.Size(1247, 29);
            this.m_menu.TabIndex = 2;
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
            // l_date_heure
            // 
            this.l_date_heure.AutoSize = true;
            this.l_date_heure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_date_heure.Location = new System.Drawing.Point(1096, 0);
            this.l_date_heure.Name = "l_date_heure";
            this.l_date_heure.Size = new System.Drawing.Size(104, 20);
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
            this.dgv_table_patient.Location = new System.Drawing.Point(0, 77);
            this.dgv_table_patient.Name = "dgv_table_patient";
            this.dgv_table_patient.ReadOnly = true;
            this.dgv_table_patient.Size = new System.Drawing.Size(1235, 549);
            this.dgv_table_patient.TabIndex = 4;
            this.dgv_table_patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_patient_CellContentClick);
            // 
            // p_modif
            // 
            this.p_modif.Controls.Add(this.t_rfid);
            this.p_modif.Controls.Add(this.l_l_new_bracelet_2);
            this.p_modif.Controls.Add(this.l_l_new_bracelet);
            this.p_modif.Controls.Add(this.l_l_rfid);
            this.p_modif.Controls.Add(this.l_last_scan);
            this.p_modif.Controls.Add(this.l_l_last_scan);
            this.p_modif.Controls.Add(this.b_annuler);
            this.p_modif.Controls.Add(this.b_done_modif);
            this.p_modif.Controls.Add(this.l_date_admission);
            this.p_modif.Controls.Add(this.l_label_date_admission);
            this.p_modif.Controls.Add(this.t_allergie);
            this.p_modif.Controls.Add(this.l_allergies);
            this.p_modif.Controls.Add(this.t_antecedent_medicaux);
            this.p_modif.Controls.Add(this.l_antecedant);
            this.p_modif.Controls.Add(this.t_taille);
            this.p_modif.Controls.Add(this.l_taille);
            this.p_modif.Controls.Add(this.t_poid);
            this.p_modif.Controls.Add(this.l_poid);
            this.p_modif.Controls.Add(this.dp_date_naissance);
            this.p_modif.Controls.Add(this.t_note);
            this.p_modif.Controls.Add(this.l_note);
            this.p_modif.Controls.Add(this.t_situation_familial);
            this.p_modif.Controls.Add(this.l_situation_familial);
            this.p_modif.Controls.Add(this.t_sexe);
            this.p_modif.Controls.Add(this.l_sexe);
            this.p_modif.Controls.Add(this.l_date_de_naissance);
            this.p_modif.Controls.Add(this.t_age);
            this.p_modif.Controls.Add(this.l_age);
            this.p_modif.Controls.Add(this.t_prenom);
            this.p_modif.Controls.Add(this.l_prenom);
            this.p_modif.Controls.Add(this.t_nom);
            this.p_modif.Controls.Add(this.l_nom);
            this.p_modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_modif.Location = new System.Drawing.Point(0, 32);
            this.p_modif.Name = "p_modif";
            this.p_modif.Size = new System.Drawing.Size(1247, 593);
            this.p_modif.TabIndex = 5;
            this.p_modif.Visible = false;
            // 
            // t_rfid
            // 
            this.t_rfid.Location = new System.Drawing.Point(0, 305);
            this.t_rfid.Name = "t_rfid";
            this.t_rfid.ReadOnly = true;
            this.t_rfid.Size = new System.Drawing.Size(342, 31);
            this.t_rfid.TabIndex = 52;
            // 
            // l_l_new_bracelet_2
            // 
            this.l_l_new_bracelet_2.AutoSize = true;
            this.l_l_new_bracelet_2.Location = new System.Drawing.Point(3, 237);
            this.l_l_new_bracelet_2.Name = "l_l_new_bracelet_2";
            this.l_l_new_bracelet_2.Size = new System.Drawing.Size(291, 25);
            this.l_l_new_bracelet_2.TabIndex = 51;
            this.l_l_new_bracelet_2.Text = "scanner un nouveau bracelet";
            // 
            // l_l_new_bracelet
            // 
            this.l_l_new_bracelet.AutoSize = true;
            this.l_l_new_bracelet.Location = new System.Drawing.Point(-5, 212);
            this.l_l_new_bracelet.Name = "l_l_new_bracelet";
            this.l_l_new_bracelet.Size = new System.Drawing.Size(355, 25);
            this.l_l_new_bracelet.TabIndex = 50;
            this.l_l_new_bracelet.Text = "Si vous voulez changer de bracelet,";
            // 
            // l_l_rfid
            // 
            this.l_l_rfid.AutoSize = true;
            this.l_l_rfid.Location = new System.Drawing.Point(3, 274);
            this.l_l_rfid.Name = "l_l_rfid";
            this.l_l_rfid.Size = new System.Drawing.Size(159, 25);
            this.l_l_rfid.TabIndex = 48;
            this.l_l_rfid.Text = "NUMERO RFID";
            // 
            // l_last_scan
            // 
            this.l_last_scan.AutoSize = true;
            this.l_last_scan.Location = new System.Drawing.Point(976, 223);
            this.l_last_scan.Name = "l_last_scan";
            this.l_last_scan.Size = new System.Drawing.Size(104, 25);
            this.l_last_scan.TabIndex = 47;
            this.l_last_scan.Text = "last_scan";
            // 
            // l_l_last_scan
            // 
            this.l_l_last_scan.AutoSize = true;
            this.l_l_last_scan.Location = new System.Drawing.Point(837, 198);
            this.l_l_last_scan.Name = "l_l_last_scan";
            this.l_l_last_scan.Size = new System.Drawing.Size(405, 25);
            this.l_l_last_scan.TabIndex = 46;
            this.l_l_last_scan.Text = "Dernier lieux ou le patient à était scanner";
            // 
            // b_annuler
            // 
            this.b_annuler.Location = new System.Drawing.Point(607, 516);
            this.b_annuler.Name = "b_annuler";
            this.b_annuler.Size = new System.Drawing.Size(224, 69);
            this.b_annuler.TabIndex = 45;
            this.b_annuler.Text = "Annuler";
            this.b_annuler.UseVisualStyleBackColor = true;
            this.b_annuler.Click += new System.EventHandler(this.b_annuler_Click);
            // 
            // b_done_modif
            // 
            this.b_done_modif.Location = new System.Drawing.Point(348, 516);
            this.b_done_modif.Name = "b_done_modif";
            this.b_done_modif.Size = new System.Drawing.Size(239, 70);
            this.b_done_modif.TabIndex = 44;
            this.b_done_modif.Text = "Affecter une modification";
            this.b_done_modif.UseVisualStyleBackColor = true;
            this.b_done_modif.Click += new System.EventHandler(this.b_done_modif_Click);
            // 
            // l_date_admission
            // 
            this.l_date_admission.AutoSize = true;
            this.l_date_admission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_date_admission.Location = new System.Drawing.Point(12, 40);
            this.l_date_admission.Name = "l_date_admission";
            this.l_date_admission.Size = new System.Drawing.Size(106, 25);
            this.l_date_admission.TabIndex = 43;
            this.l_date_admission.Text = "date admi";
            // 
            // l_label_date_admission
            // 
            this.l_label_date_admission.AutoSize = true;
            this.l_label_date_admission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_label_date_admission.Location = new System.Drawing.Point(12, 15);
            this.l_label_date_admission.Name = "l_label_date_admission";
            this.l_label_date_admission.Size = new System.Drawing.Size(188, 25);
            this.l_label_date_admission.TabIndex = 42;
            this.l_label_date_admission.Text = "Date d\'admission :";
            // 
            // t_allergie
            // 
            this.t_allergie.Location = new System.Drawing.Point(607, 150);
            this.t_allergie.Multiline = true;
            this.t_allergie.Name = "t_allergie";
            this.t_allergie.Size = new System.Drawing.Size(224, 132);
            this.t_allergie.TabIndex = 41;
            // 
            // l_allergies
            // 
            this.l_allergies.AutoSize = true;
            this.l_allergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_allergies.Location = new System.Drawing.Point(661, 126);
            this.l_allergies.Name = "l_allergies";
            this.l_allergies.Size = new System.Drawing.Size(95, 25);
            this.l_allergies.TabIndex = 40;
            this.l_allergies.Text = "Allergies";
            // 
            // t_antecedent_medicaux
            // 
            this.t_antecedent_medicaux.Location = new System.Drawing.Point(607, 379);
            this.t_antecedent_medicaux.Multiline = true;
            this.t_antecedent_medicaux.Name = "t_antecedent_medicaux";
            this.t_antecedent_medicaux.Size = new System.Drawing.Size(224, 131);
            this.t_antecedent_medicaux.TabIndex = 39;
            // 
            // l_antecedant
            // 
            this.l_antecedant.AutoSize = true;
            this.l_antecedant.Location = new System.Drawing.Point(612, 351);
            this.l_antecedant.Name = "l_antecedant";
            this.l_antecedant.Size = new System.Drawing.Size(219, 25);
            this.l_antecedant.TabIndex = 38;
            this.l_antecedant.Text = "Antécédent médicaux";
            // 
            // t_taille
            // 
            this.t_taille.Location = new System.Drawing.Point(607, 92);
            this.t_taille.Name = "t_taille";
            this.t_taille.Size = new System.Drawing.Size(224, 31);
            this.t_taille.TabIndex = 37;
            // 
            // l_taille
            // 
            this.l_taille.AutoSize = true;
            this.l_taille.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_taille.Location = new System.Drawing.Point(683, 64);
            this.l_taille.Name = "l_taille";
            this.l_taille.Size = new System.Drawing.Size(64, 25);
            this.l_taille.TabIndex = 36;
            this.l_taille.Text = "Taille";
            // 
            // t_poid
            // 
            this.t_poid.Location = new System.Drawing.Point(607, 30);
            this.t_poid.Name = "t_poid";
            this.t_poid.Size = new System.Drawing.Size(224, 31);
            this.t_poid.TabIndex = 35;
            // 
            // l_poid
            // 
            this.l_poid.AutoSize = true;
            this.l_poid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_poid.Location = new System.Drawing.Point(692, 2);
            this.l_poid.Name = "l_poid";
            this.l_poid.Size = new System.Drawing.Size(55, 25);
            this.l_poid.TabIndex = 34;
            this.l_poid.Text = "Poid";
            // 
            // dp_date_naissance
            // 
            this.dp_date_naissance.Location = new System.Drawing.Point(607, 317);
            this.dp_date_naissance.Name = "dp_date_naissance";
            this.dp_date_naissance.Size = new System.Drawing.Size(224, 31);
            this.dp_date_naissance.TabIndex = 33;
            // 
            // t_note
            // 
            this.t_note.Location = new System.Drawing.Point(348, 336);
            this.t_note.Multiline = true;
            this.t_note.Name = "t_note";
            this.t_note.Size = new System.Drawing.Size(242, 174);
            this.t_note.TabIndex = 32;
            // 
            // l_note
            // 
            this.l_note.AutoSize = true;
            this.l_note.Location = new System.Drawing.Point(419, 308);
            this.l_note.Name = "l_note";
            this.l_note.Size = new System.Drawing.Size(57, 25);
            this.l_note.TabIndex = 31;
            this.l_note.Text = "Note";
            // 
            // t_situation_familial
            // 
            this.t_situation_familial.Location = new System.Drawing.Point(348, 274);
            this.t_situation_familial.Name = "t_situation_familial";
            this.t_situation_familial.Size = new System.Drawing.Size(242, 31);
            this.t_situation_familial.TabIndex = 30;
            // 
            // l_situation_familial
            // 
            this.l_situation_familial.AutoSize = true;
            this.l_situation_familial.Location = new System.Drawing.Point(376, 246);
            this.l_situation_familial.Name = "l_situation_familial";
            this.l_situation_familial.Size = new System.Drawing.Size(169, 25);
            this.l_situation_familial.TabIndex = 29;
            this.l_situation_familial.Text = "Situation familial";
            // 
            // t_sexe
            // 
            this.t_sexe.Location = new System.Drawing.Point(348, 212);
            this.t_sexe.Name = "t_sexe";
            this.t_sexe.Size = new System.Drawing.Size(242, 31);
            this.t_sexe.TabIndex = 28;
            // 
            // l_sexe
            // 
            this.l_sexe.AutoSize = true;
            this.l_sexe.Location = new System.Drawing.Point(410, 184);
            this.l_sexe.Name = "l_sexe";
            this.l_sexe.Size = new System.Drawing.Size(61, 25);
            this.l_sexe.TabIndex = 27;
            this.l_sexe.Text = "Sexe";
            // 
            // l_date_de_naissance
            // 
            this.l_date_de_naissance.AutoSize = true;
            this.l_date_de_naissance.Location = new System.Drawing.Point(623, 289);
            this.l_date_de_naissance.Name = "l_date_de_naissance";
            this.l_date_de_naissance.Size = new System.Drawing.Size(191, 25);
            this.l_date_de_naissance.TabIndex = 26;
            this.l_date_de_naissance.Text = "Date de naissance";
            // 
            // t_age
            // 
            this.t_age.Location = new System.Drawing.Point(348, 150);
            this.t_age.Name = "t_age";
            this.t_age.Size = new System.Drawing.Size(242, 31);
            this.t_age.TabIndex = 25;
            // 
            // l_age
            // 
            this.l_age.AutoSize = true;
            this.l_age.Location = new System.Drawing.Point(410, 126);
            this.l_age.Name = "l_age";
            this.l_age.Size = new System.Drawing.Size(50, 25);
            this.l_age.TabIndex = 24;
            this.l_age.Text = "Age";
            // 
            // t_prenom
            // 
            this.t_prenom.Location = new System.Drawing.Point(348, 92);
            this.t_prenom.Name = "t_prenom";
            this.t_prenom.Size = new System.Drawing.Size(242, 31);
            this.t_prenom.TabIndex = 4;
            // 
            // l_prenom
            // 
            this.l_prenom.AutoSize = true;
            this.l_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_prenom.Location = new System.Drawing.Point(390, 64);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(86, 25);
            this.l_prenom.TabIndex = 3;
            this.l_prenom.Text = "Prenom";
            // 
            // t_nom
            // 
            this.t_nom.Location = new System.Drawing.Point(348, 30);
            this.t_nom.Name = "t_nom";
            this.t_nom.Size = new System.Drawing.Size(242, 31);
            this.t_nom.TabIndex = 2;
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nom.Location = new System.Drawing.Point(410, 2);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(56, 25);
            this.l_nom.TabIndex = 1;
            this.l_nom.Text = "Nom";
            // 
            // l_filtre
            // 
            this.l_filtre.AutoSize = true;
            this.l_filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_filtre.Location = new System.Drawing.Point(-5, 41);
            this.l_filtre.Name = "l_filtre";
            this.l_filtre.Size = new System.Drawing.Size(305, 25);
            this.l_filtre.TabIndex = 6;
            this.l_filtre.Text = "Choisissez le champs à filtrer :";
            // 
            // cb_filtre
            // 
            this.cb_filtre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filtre.FormattingEnabled = true;
            this.cb_filtre.Items.AddRange(new object[] {
            "AUCUN",
            "ID",
            "NOM",
            "PRENOM",
            "AGE",
            "SEXE",
            "SITUATION FAMILIAL",
            "NOTE",
            "POID",
            "TAILLE",
            "ALLERGIES",
            "ANTECEDENT MEDICAUX",
            "TAG RFID",
            "DERNIER SCAN"});
            this.cb_filtre.Location = new System.Drawing.Point(306, 38);
            this.cb_filtre.Name = "cb_filtre";
            this.cb_filtre.Size = new System.Drawing.Size(200, 33);
            this.cb_filtre.TabIndex = 30;
            this.cb_filtre.SelectedIndexChanged += new System.EventHandler(this.cb_filtre_SelectedIndexChanged);
            // 
            // t_filtre
            // 
            this.t_filtre.Location = new System.Drawing.Point(512, 38);
            this.t_filtre.Multiline = true;
            this.t_filtre.Name = "t_filtre";
            this.t_filtre.ReadOnly = true;
            this.t_filtre.Size = new System.Drawing.Size(711, 33);
            this.t_filtre.TabIndex = 42;
            this.t_filtre.TextChanged += new System.EventHandler(this.t_filtre_TextChanged);
            // 
            // F_modif_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 624);
            this.Controls.Add(this.p_modif);
            this.Controls.Add(this.t_filtre);
            this.Controls.Add(this.cb_filtre);
            this.Controls.Add(this.l_filtre);
            this.Controls.Add(this.dgv_table_patient);
            this.Controls.Add(this.l_date_heure);
            this.Controls.Add(this.m_menu);
            this.Name = "F_modif_patient";
            this.Text = " ";
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table_patient)).EndInit();
            this.p_modif.ResumeLayout(false);
            this.p_modif.PerformLayout();
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
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.TextBox t_nom;
        private System.Windows.Forms.Label l_prenom;
        private System.Windows.Forms.TextBox t_prenom;
        private System.Windows.Forms.TextBox t_allergie;
        private System.Windows.Forms.Label l_allergies;
        private System.Windows.Forms.TextBox t_antecedent_medicaux;
        private System.Windows.Forms.Label l_antecedant;
        private System.Windows.Forms.TextBox t_taille;
        private System.Windows.Forms.Label l_taille;
        private System.Windows.Forms.TextBox t_poid;
        private System.Windows.Forms.Label l_poid;
        private System.Windows.Forms.DateTimePicker dp_date_naissance;
        private System.Windows.Forms.TextBox t_note;
        private System.Windows.Forms.Label l_note;
        private System.Windows.Forms.TextBox t_situation_familial;
        private System.Windows.Forms.Label l_situation_familial;
        private System.Windows.Forms.TextBox t_sexe;
        private System.Windows.Forms.Label l_sexe;
        private System.Windows.Forms.Label l_date_de_naissance;
        private System.Windows.Forms.TextBox t_age;
        private System.Windows.Forms.Label l_age;
        private System.Windows.Forms.Label l_date_admission;
        private System.Windows.Forms.Label l_label_date_admission;
        private System.Windows.Forms.Button b_annuler;
        private System.Windows.Forms.Button b_done_modif;
        private System.Windows.Forms.Label l_filtre;
        private System.Windows.Forms.ComboBox cb_filtre;
        private System.Windows.Forms.TextBox t_filtre;
        private System.Windows.Forms.Label l_last_scan;
        private System.Windows.Forms.Label l_l_last_scan;
        private System.Windows.Forms.Label l_l_rfid;
        private System.Windows.Forms.Label l_l_new_bracelet_2;
        private System.Windows.Forms.Label l_l_new_bracelet;
        private System.Windows.Forms.TextBox t_rfid;
    }
}