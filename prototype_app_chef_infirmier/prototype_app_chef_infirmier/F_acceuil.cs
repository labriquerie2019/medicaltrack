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
            DateTime heure = System.DateTime.Now;
            l_date_heure.Text = heure.Hour + ":" + heure.Minute + " " + heure.Day + "/" + heure.Month + "/" + heure.Year;
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

            m_configuration.Visible = true;
            l_ndc.Visible = false;
            t_ndc.Visible = false;
            l_mdp.Visible = false;
            t_mdp.Visible = false;
            b_connexion.Visible = false;

            p_showbutton.Visible = true;
        }
    }
}
