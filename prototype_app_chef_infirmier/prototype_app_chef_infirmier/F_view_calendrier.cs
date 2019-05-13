using Medicaltrack_admin_planning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prototype_app_chef_infirmier
{
    public partial class F_view_calendrier : Form
    {
        string salle;
        public F_view_calendrier()
        {
            InitializeComponent();
            dgv_calendrier.DefaultCellStyle.Font = new Font("Tahoma", 15);
            dgv_calendrier.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
            dgv_calendrier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void m_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_acceuil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime heure = System.DateTime.Now;
            l_date_heure.Text = heure.Hour + ":" + heure.Minute + " " + heure.Day + "/" + heure.Month + "/" + heure.Year;
        }

        private void cb_salle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selected = cb_salle.Text;
            switch (selected)
            {
                case "Salle d'opération 1":
                    salle = "salle_ope_1";
                    break;
                case "Salle d'opération 2":
                    salle = "salle_ope_2";
                    break;
                case "Salle d'anesthesie":
                    salle = "salle_ane";
                    break;
                case "Salle de reveil":
                    salle = "salle_reveil";
                    break;
                case "Salle de réanimation":
                    salle = "salle_rea";
                    break;
            }
            Calendrier mon_calendrier = new Calendrier();
            DataTable dt = mon_calendrier.afficher_calendrier(dt_calendrier.Value,salle);
            dgv_calendrier.RowHeadersVisible = false;
            dgv_calendrier.DataSource = dt; // On attribue les sources du DataGridView au DataTable
        }
    }

}   
