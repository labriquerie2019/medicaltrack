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
            for (int i = 0; i < 25; i++)
            {
                if (i < 10)
                {
                    dgv_calendrier.Rows.Add("0" + i + "h");
                }
                else
                {
                    dgv_calendrier.Rows.Add(i + "h");
                }
            }
            timer1.Interval = 1000;
            timer1.Start();
            timer3.Interval = 5000;
            timer3.Start();
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

        private void t_note_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_add_patient_Click(object sender, EventArgs e)
        {
            p_progressbar.Visible = false;
            p_bar_chargement.Visible = true;
            pb_progress.Step = 20;
            l_chargement.Text = "Chargement...";
            if (t_nom.Text.Length > 0 && t_prenom.Text.Length > 0 && t_age.Text.Length > 0  && t_sexe.Text.Length > 0 && t_situation_familial.Text.Length > 0 && t_note.Text.Length > 0 && t_poid.Text.Length > 0 && t_taille.Text.Length > 0 && t_allergie.Text.Length > 0 && t_antecedent_medicaux.Text.Length > 0)//tous les champs remplie
            {
                pb_progress.PerformStep();
                l_chargement.Text = "Chargement... TOUT LES CHAMPS SONT REMPLIS";
                ///////////////////////////////////////////////////////////////Partie info patient
                string nom = t_nom.Text;
                string prenom = t_prenom.Text;
                int age = Convert.ToInt32(t_age.Text);
                DateTime date_naissance = dp_date_naissance.Value;
                string dt_nai = date_naissance.ToString("yyyy-MM-dd HH:mm:ss"); //Format americain 
                DateTime date_admission = System.DateTime.Now;
                string dt_adm = date_admission.ToString("yyyy-MM-dd HH:mm:ss"); //Format americain 
                string sexe = t_sexe.Text;
                string situation_familial = t_situation_familial.Text;
                string note = t_note.Text;
                ///////////////////////////////////////////////////////////////Partie médical
                string poid = t_poid.Text;
                string taille = t_taille.Text;
                string allergie = t_allergie.Text;
                string antecedant = t_antecedent_medicaux.Text;
                ///////////////////////////////////////////////////////////////config et connexion bdd
                string Serveur = "localhost";
                string Base = "aaa";
                string User = "root";
                string Pass = "";
                _MySQL bdd = new _MySQL(Serveur, Base, User, Pass);
                bdd.Serveur = Serveur;
                bdd.Base = Base;
                bdd.User = User;
                bdd.Pass = Pass;
                //////////////////////////////////////////////////////////////
                bool traitement = false;
                do
                {
                    pb_progress.PerformStep();
                    l_chargement.Text = "Chargement... CONNEXION A LA BDD REUSSI ET TRAITEMENT DU TEXTE";
                    if (bdd.base_exist()) //Si BDD existe
                    {
                        pb_progress.PerformStep();
                        l_chargement.Text = "Chargement... LA BASE DE DONNEE EXISTE, VERIFICATION DE LA TABLE";
                        if (bdd.table_existe("test")) //Si table existe
                        {
                            pb_progress.PerformStep();
                            l_chargement.Text = "Chargement... LA TABLE EXISTE, INSERTION DES CHAMPS.";
                            bdd.Table_RequetteNonQuery("INSERT INTO test (nom, prenom, age, date_naissance, date_admission, sexe, situation_familial, note, poid, taille, allergie, antecedant) VALUES('" + nom + "' , '" + prenom + "' , '" + age + "' , '" + dt_nai + "' , '" + dt_adm + "' , '" + sexe + "' , '" + situation_familial + "' , '" + note + "' , '" + poid + "' , '" + taille + "' , '" + allergie + "' , '" + antecedant + "')");
                            #region clear textbox
                            t_nom.Clear();
                            t_prenom.Clear();
                            t_age.Clear();
                            t_age.Clear();
                            date_naissance = System.DateTime.Now;
                            t_sexe.Clear();
                            t_situation_familial.Clear();
                            t_note.Clear();
                            t_poid.Clear();
                            t_taille.Clear();
                            t_allergie.Clear();
                            t_antecedent_medicaux.Clear();
                            #endregion
                            l_chargement.Text = "Chargement... INSERTION REUSSI RETOUR AU MENU";
                            pb_progress.Step = 0;
                            pb_progress.PerformStep();
                            p_bar_chargement.Visible = false;
                            p_progressbar.Visible = true;
                            traitement = true;
                        }
                        else //Si table existe pas
                        {
                            bdd.table_creer("CREATE TABLE IF NOT EXISTS `test` (`id` int(11) NOT NULL AUTO_INCREMENT,`nom` varchar(30) NOT NULL,`prenom` varchar(30) NOT NULL,`age` int(11) NOT NULL,`date_naissance` DATE NOT NULL,`date_admission` DATE NOT NULL,`sexe` varchar(30) NOT NULL,`situation_familial` TEXT NOT NULL,`note` TEXT NOT NULL,`poid` TEXT NOT NULL,`taille` TEXT NOT NULL,`allergie` TEXT NOT NULL,`antecedant` TEXT NOT NULL,PRIMARY KEY(`id`)) ENGINE = InnoDB  DEFAULT CHARSET = latin1;");
                        }
                    }
                    else //Si bdd existe pas
                    {
                        bdd.base_creer();
                    }
                } while (traitement == false);
            }
            else //pas tout les champs remplie7
            {
                F_erreur champ_vide = new F_erreur("champs_vide");
                champ_vide.ShowDialog();
                pb_progress.Step = 0;
                p_bar_chargement.Visible = false;
                p_progressbar.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
         
        }
    }
}