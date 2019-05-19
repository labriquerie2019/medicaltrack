using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Medicaltrack_admin_planning
{
    public partial class F_config : Form
    {
        public F_config()
        {
            InitializeComponent();
        }

        private void b_fin_Click(object sender, EventArgs e)
        {
            if(t_ndc_admin.Text != null && t_ndc_chef.Text != null && t_mdp_admin.Text != null && t_mdp_chef.Text != null)
            {
                string path = "config.txt";
                bool traiter = false;
                do
                {
                    if (File.Exists(path)) //Si le fichier existe
                    {
                        File.Delete(path);
                    }
                    else //Si le fichier existe pas
                    {
                        StreamWriter sw = File.CreateText(path);
                        sw.WriteLine(t_ndc_chef.Text);
                        sw.WriteLine(t_mdp_chef.Text);
                        sw.WriteLine(t_ndc_admin.Text);
                        sw.WriteLine(t_mdp_admin.Text);
                        sw.Close();
                        traiter = true;
                    }
                } while (traiter != true);
            }
        }
    }
}
