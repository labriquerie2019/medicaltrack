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
    public partial class F_Acceuil : Form
    {
        public F_Acceuil()
        {
            InitializeComponent();
        }

        private void F_Acceuil_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void m_configuration_Click(object sender, EventArgs e)
        {

        }

        private void m_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void b_connexion_Click(object sender, EventArgs e)
        {
            string ndc = t_ndc.Text;
            string mdp = t_mdp.Text;

            bool connected = true; //methode pour se connecter

            m_configuration.Visible = true;
            l_ndc.Visible = false;
            t_ndc.Visible = false;
            l_mdp.Visible = false;
            t_mdp.Visible = false;
            b_connexion.Visible = false;

            p_showbutton.Visible = true;

            if (ndc == "administration") //Tester qui est connecter
            {
                b_gerer_planning.Visible = false; //Administration
            }
            else if(ndc == "chef")
            {
                b_gerer_planning.Visible = true; //Chef hospitalier
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime heure = System.DateTime.Now;
            l_date_heure.Text = heure.Hour + ":" + heure.Minute + " " + heure.Day + "/" + heure.Month + "/" + heure.Year;
        }

        private void b_add_patient_Click(object sender, EventArgs e)
        {
            F_ajout_patient f_add_patient = new F_ajout_patient();
            f_add_patient.Show();
        }
    }
}
