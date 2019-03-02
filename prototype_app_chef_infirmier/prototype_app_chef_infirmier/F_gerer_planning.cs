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
    public partial class F_gerer_planning : Form
    {
        public F_gerer_planning()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void m_quitter_Click(object sender, EventArgs e)
        {

        }

        private void m_acceuil_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime heure = System.DateTime.Now;
            l_date_heure.Text = heure.Hour + ":" + heure.Minute + " " + heure.Day + "/" + heure.Month + "/" + heure.Year;
        }

        private void m_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
