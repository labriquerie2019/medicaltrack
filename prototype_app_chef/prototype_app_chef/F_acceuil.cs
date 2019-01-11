using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype_app_chef
{
    public partial class f_acceuil : Form
    {
        public f_acceuil()
        {
            InitializeComponent();
        }

        private void f_acceuil_Load(object sender, EventArgs e)
        {
            // hide max,min and close button at top right of Window
            this.FormBorderStyle = FormBorderStyle.None;
            // fill the screen
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void m_menu_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_config_Click(object sender, EventArgs e)
        {
            F_config f_configuration = new F_config();
            f_configuration.Show();
        }

        private void b_add_patient_Click(object sender, EventArgs e)
        {
            F_add_patient f_new_patient = new F_add_patient();
            f_new_patient.Show();
        }
    }
}
