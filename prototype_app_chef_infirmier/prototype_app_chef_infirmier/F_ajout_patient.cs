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
    }
}
