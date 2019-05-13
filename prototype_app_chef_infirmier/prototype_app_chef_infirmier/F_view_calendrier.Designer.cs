namespace prototype_app_chef_infirmier
{
    partial class F_view_calendrier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_view_calendrier));
            this.m_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.m_acceuil = new System.Windows.Forms.ToolStripMenuItem();
            this.l_date_heure = new System.Windows.Forms.Label();
            this.m_menu = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_select_room = new System.Windows.Forms.Label();
            this.l_select_date = new System.Windows.Forms.Label();
            this.cb_salle = new System.Windows.Forms.ComboBox();
            this.dgv_calendrier = new System.Windows.Forms.DataGridView();
            this.dt_calendrier = new System.Windows.Forms.DateTimePicker();
            this.m_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendrier)).BeginInit();
            this.SuspendLayout();
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
            this.l_date_heure.Location = new System.Drawing.Point(1076, 0);
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
            this.m_menu.Size = new System.Drawing.Size(1244, 29);
            this.m_menu.TabIndex = 4;
            this.m_menu.Text = "menuStrip1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_select_room
            // 
            this.l_select_room.AutoSize = true;
            this.l_select_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_select_room.Location = new System.Drawing.Point(266, 48);
            this.l_select_room.Name = "l_select_room";
            this.l_select_room.Size = new System.Drawing.Size(206, 25);
            this.l_select_room.TabIndex = 36;
            this.l_select_room.Text = "Sélectionner la salle";
            // 
            // l_select_date
            // 
            this.l_select_date.AutoSize = true;
            this.l_select_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_select_date.Location = new System.Drawing.Point(230, 20);
            this.l_select_date.Name = "l_select_date";
            this.l_select_date.Size = new System.Drawing.Size(242, 25);
            this.l_select_date.TabIndex = 35;
            this.l_select_date.Text = "Sélectionner la semaine";
            // 
            // cb_salle
            // 
            this.cb_salle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_salle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_salle.FormattingEnabled = true;
            this.cb_salle.Items.AddRange(new object[] {
            "Salle d\'anesthesie",
            "Salle d\'opération 1",
            "Salle d\'opération 2",
            "Salle de réanimation",
            "Salle de reveil"});
            this.cb_salle.Location = new System.Drawing.Point(478, 48);
            this.cb_salle.Name = "cb_salle";
            this.cb_salle.Size = new System.Drawing.Size(329, 33);
            this.cb_salle.TabIndex = 34;
            this.cb_salle.SelectedIndexChanged += new System.EventHandler(this.cb_salle_SelectedIndexChanged_1);
            // 
            // dgv_calendrier
            // 
            this.dgv_calendrier.AllowUserToAddRows = false;
            this.dgv_calendrier.AllowUserToDeleteRows = false;
            this.dgv_calendrier.AllowUserToOrderColumns = true;
            this.dgv_calendrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calendrier.Location = new System.Drawing.Point(12, 87);
            this.dgv_calendrier.Name = "dgv_calendrier";
            this.dgv_calendrier.ReadOnly = true;
            this.dgv_calendrier.Size = new System.Drawing.Size(1220, 569);
            this.dgv_calendrier.TabIndex = 33;
            // 
            // dt_calendrier
            // 
            this.dt_calendrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_calendrier.Location = new System.Drawing.Point(478, 23);
            this.dt_calendrier.Name = "dt_calendrier";
            this.dt_calendrier.Size = new System.Drawing.Size(329, 31);
            this.dt_calendrier.TabIndex = 32;
            // 
            // F_view_calendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 668);
            this.Controls.Add(this.l_select_room);
            this.Controls.Add(this.l_select_date);
            this.Controls.Add(this.cb_salle);
            this.Controls.Add(this.dgv_calendrier);
            this.Controls.Add(this.dt_calendrier);
            this.Controls.Add(this.l_date_heure);
            this.Controls.Add(this.m_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_view_calendrier";
            this.Text = "Calendrier";
            this.m_menu.ResumeLayout(false);
            this.m_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendrier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem m_quitter;
        private System.Windows.Forms.ToolStripMenuItem m_acceuil;
        private System.Windows.Forms.Label l_date_heure;
        private System.Windows.Forms.MenuStrip m_menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_select_room;
        private System.Windows.Forms.Label l_select_date;
        private System.Windows.Forms.ComboBox cb_salle;
        private System.Windows.Forms.DataGridView dgv_calendrier;
        private System.Windows.Forms.DateTimePicker dt_calendrier;
    }
}