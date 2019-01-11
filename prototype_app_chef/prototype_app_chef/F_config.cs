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
    public partial class F_config : Form
    {
        public F_config()
        {
            InitializeComponent();
        }

        private void F_config_Load(object sender, EventArgs e)
        {
            // hide max,min and close button at top right of Window
            this.FormBorderStyle = FormBorderStyle.None;
            // fill the screen
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void m_acceuil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_quitter_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
