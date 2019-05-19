namespace Medicaltrack_admin_planning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_config));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_ndc_chef = new System.Windows.Forms.TextBox();
            this.t_mdp_chef = new System.Windows.Forms.TextBox();
            this.t_mdp_admin = new System.Windows.Forms.TextBox();
            this.t_ndc_admin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_fin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir le nom de compte du chef hospitalier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisir le mot de passe du chef hospitalier";
            // 
            // t_ndc_chef
            // 
            this.t_ndc_chef.Location = new System.Drawing.Point(7, 35);
            this.t_ndc_chef.Name = "t_ndc_chef";
            this.t_ndc_chef.Size = new System.Drawing.Size(316, 26);
            this.t_ndc_chef.TabIndex = 2;
            // 
            // t_mdp_chef
            // 
            this.t_mdp_chef.Location = new System.Drawing.Point(7, 90);
            this.t_mdp_chef.Name = "t_mdp_chef";
            this.t_mdp_chef.Size = new System.Drawing.Size(316, 26);
            this.t_mdp_chef.TabIndex = 3;
            // 
            // t_mdp_admin
            // 
            this.t_mdp_admin.Location = new System.Drawing.Point(8, 90);
            this.t_mdp_admin.Name = "t_mdp_admin";
            this.t_mdp_admin.Size = new System.Drawing.Size(316, 26);
            this.t_mdp_admin.TabIndex = 7;
            // 
            // t_ndc_admin
            // 
            this.t_ndc_admin.Location = new System.Drawing.Point(8, 35);
            this.t_ndc_admin.Name = "t_ndc_admin";
            this.t_ndc_admin.Size = new System.Drawing.Size(316, 26);
            this.t_ndc_admin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choisir le mot de passe du personnel administratif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choisir le nom de compte du personnel administratif";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.t_ndc_chef);
            this.panel1.Controls.Add(this.t_mdp_chef);
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 127);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.t_mdp_admin);
            this.panel2.Controls.Add(this.t_ndc_admin);
            this.panel2.Location = new System.Drawing.Point(356, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 127);
            this.panel2.TabIndex = 9;
            // 
            // b_fin
            // 
            this.b_fin.Location = new System.Drawing.Point(7, 142);
            this.b_fin.Name = "b_fin";
            this.b_fin.Size = new System.Drawing.Size(734, 94);
            this.b_fin.TabIndex = 10;
            this.b_fin.Text = "Finir la saisie";
            this.b_fin.UseVisualStyleBackColor = true;
            this.b_fin.Click += new System.EventHandler(this.b_fin_Click);
            // 
            // F_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 248);
            this.Controls.Add(this.b_fin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_config";
            this.Text = "F_config";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_ndc_chef;
        private System.Windows.Forms.TextBox t_mdp_chef;
        private System.Windows.Forms.TextBox t_mdp_admin;
        private System.Windows.Forms.TextBox t_ndc_admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_fin;
    }
}