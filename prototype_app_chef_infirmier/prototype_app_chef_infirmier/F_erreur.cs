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
    public partial class F_erreur : Form
    {
        int compteur = 0;
        public F_erreur(string erreur)
        {
            InitializeComponent();
            string num_erreur = erreur;
            timer1.Interval = 1000;
            timer1.Start();
            switch (erreur)
            {
                case "champs_vide":
                    l_message.Text = "ERREUR, vous n'avez pas remplie tous les champs";
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            compteur++;
            if(compteur == 3)
            {
                this.Close();
            }
        }
    }
}
