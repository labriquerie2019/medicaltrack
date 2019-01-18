using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype_app_chef_infirmier
{
    public partial class F_ajout_patient : Form
    {
        public F_ajout_patient()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 200;
            timer2.Start();
        }

        private void m_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_configuration_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime heure = System.DateTime.Now;
            l_date_heure.Text = heure.Hour + ":" + heure.Minute + " " + heure.Day + "/" + heure.Month + "/" + heure.Year;
        }

        private void p_bar_progression_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            p_bar_progression.Step = 10;
            if (p_bar_progression.Value <100)
                p_bar_progression.PerformStep();
            if (p_bar_progression.Value ==100)
            {
                timer2.Stop();
                p_bar_progression.Visible = false;
                p_progressbar.Visible = true;
                l_co_bdd.Visible = false;
            }
        }

        private void t_note_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_add_patient_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////Partie info patient
            string nom = t_nom.Text;
            string prenom = t_prenom.Text;
            int age = Convert.ToInt32(t_age.Text);
            DateTime date_naissance = dp_date_naissance.Value;
            string sexe = t_sexe.Text;
            string situation_familial = t_situation_familial.Text;
            string note = t_note.Text;
            ///////////////////////////////////////////////////////////////Partie médical
            string poid = t_poid.Text;
            string taille = t_taille.Text;
            string allergie = t_allergie.Text;
            string antecedant = t_antecedent_medicaux.Text;
            ///////////////////////////////////////////////////////////////
        }
    }
}
