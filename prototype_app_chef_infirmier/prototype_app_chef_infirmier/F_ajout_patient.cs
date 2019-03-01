using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace prototype_app_chef_infirmier
{
    public partial class F_ajout_patient : Form
    {
        static _MySQL bdd;
        static string salle;
        public F_ajout_patient()
        {
            InitializeComponent();
            ///////////////////////////////////////////////////////////////config et connexion bdd
            string Serveur = "localhost";
            string Base = "aaa";
            string User = "root";
            string Pass = "";
            bdd = new _MySQL(Serveur, Base, User, Pass);
            bdd.Serveur = Serveur;
            bdd.Base = Base;
            bdd.User = User;
            bdd.Pass = Pass;
            //////////////////////////////////////////////////////////////
            //for (int i = 0; i < 25; i++)
            //{
            //    dgv_calendrier.Rows.Add(""+i);
            //}
            //////////////////////////////////////////////////////////////
            DataTable dt = new DataTable();
            dt = GetCalendrier();
            dgv_calendrier.DataSource = dt;
            timer1.Interval = 3000;
            timer1.Start();
        }
        private DataTable GetCalendrier()
        {
            DataTable dt = new DataTable();

            MySqlConnection con = new MySqlConnection("server=localhost;database=aaa;user id=root;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT date_heure FROM salle_ope_1 ",con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            con.Close();
            dt.Columns[0].AllowDBNull = true;
            dt.Columns.Add("Heure");
            dt.Columns.Add("Lundi");
            dt.Columns.Add("Mardi");
            dt.Columns.Add("Mercredi");
            dt.Columns.Add("Jeudi");
            dt.Columns.Add("Vendredi");
            dt.Columns.Add("Samedi");
            dt.Columns.Add("Dimanche");
            int compteur = 0;
            foreach (DataRow row in dt.Rows)
            {
                compteur++;
            }
            for (int i = 0; i < 24; i++)
            {
                dt.Rows.Add(null, "" + i);
            }
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    DateTime result;
                    if (DateTime.TryParse(item.ToString(),out result))
                    {
                        string[] donner_a_traiter = item.ToString().Split(' ');
                        string[] annee_mois_jour = donner_a_traiter[0].Split('/');
                        string[] heure_minute_seconde = donner_a_traiter[1].Split(':');
                        int annee = Convert.ToInt32(annee_mois_jour[2]), mois = Convert.ToInt32(annee_mois_jour[1]), jour = Convert.ToInt32(annee_mois_jour[0]);
                        int heure = Convert.ToInt32(heure_minute_seconde[0]), minute = Convert.ToInt32(heure_minute_seconde[1]), seconde = Convert.ToInt32(heure_minute_seconde[2]);
                        DateTime jour_a_determiner = new DateTime(annee, mois, jour);
                        switch (jour_a_determiner.DayOfWeek.ToString()) // Switch sur le jour de la date choisis pour afficher la semaine
                        {
                            case "Monday"://Lundi
                                dt.Rows[heure+compteur].SetField(2, "ya un gars ici");
                                break;
                            case "Tuesday"://Mardi
                                dt.Rows[heure+compteur].SetField(3, "ya un gars ici");
                                break;
                            case "Wednesday"://Mercredi
                                dt.Rows[heure+compteur].SetField(4, "ya un gars ici");
                                break;
                            case "Thursday"://Jeudi
                                dt.Rows[heure+compteur].SetField(5, "ya un gars ici");
                                break;
                            case "Friday"://Vendredi
                                dt.Rows[heure+compteur].SetField(6, "ya un gars ici");
                                break;
                            case "Saturday"://Samedi
                                dt.Rows[heure+compteur].SetField(7, "ya un gars ici");
                                break;
                            case "Sunday"://Dimanche
                                dt.Rows[heure+compteur].SetField(8, "ya un gars ici");
                                break;
                            default://Si erreur
                                F_erreur erreur_date = new F_erreur("ERREUR : Lors du traitement des heures/date.");
                                erreur_date.ShowDialog();
                                this.timer3.Stop();
                                break;
                        }
                    }
                }
            }
            dt.Columns.RemoveAt(0);
            for(int i=0;i<compteur+1;i++)
            {
                dt.Rows.RemoveAt(i);
            }
            return dt;
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
            else //pas tout les champs remplie
            {
                F_erreur champ_vide = new F_erreur("ERREUR : Tous les champs ne sont pas remplie!");
                champ_vide.ShowDialog();
                pb_progress.Step = 0;
                p_bar_chargement.Visible = false;
                p_progressbar.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e) 
        {
            DataSet db_content = new DataSet();
            DateTime datetime_traitement = dt_calendrier.Value;
            DateTime lundi = new DateTime();
            DateTime dimanche = new DateTime();

            switch (datetime_traitement.DayOfWeek.ToString()) // Switch sur le jour de la date choisis pour afficher la semaine, Tostring("dddd") permet d'afficher juste le jour
            {
                case "Monday"://Lundi
                    lundi = datetime_traitement;
                    dimanche = datetime_traitement.AddDays(6);
                    break;
                case "Tuesday"://Mardi
                    lundi = datetime_traitement.AddDays(-1);
                    dimanche = datetime_traitement.AddDays(5);
                    break;
                case "Wednesday"://Mercredi
                    lundi = datetime_traitement.AddDays(-2);
                    dimanche = datetime_traitement.AddDays(4);
                    break;
                case "Thursday"://Jeudi
                    lundi = datetime_traitement.AddDays(-3);
                    dimanche = datetime_traitement.AddDays(3);
                    break;
                case "Friday"://Vendredi
                    lundi = datetime_traitement.AddDays(-4);
                    dimanche = datetime_traitement.AddDays(2);
                    break;
                case "Saturday"://Samedi
                    lundi = datetime_traitement.AddDays(-5);
                    dimanche = datetime_traitement.AddDays(1);
                    break;
                case "Sunday"://Dimanche
                    lundi = datetime_traitement.AddDays(-6);
                    dimanche = datetime_traitement;
                    break;
                default://Si erreur
                    F_erreur erreur_date = new F_erreur("ERREUR : Lors de la séléction de la date pour le calendrier!");
                    erreur_date.ShowDialog();
                    this.timer3.Stop();
                    break;
            }
            string lundi_traiter = lundi.ToString("yyyy-MM-dd HH:mm:ss");
            string dimanche_traiter = dimanche.ToString("yyyyy-MM-dd HH:mm:ss");
            string requette = "SELECT date_heure FROM " + salle + " WHERE date_heure BETWEEN '" + lundi + "' AND '" + dimanche +"'";
            db_content = bdd.table_lire(requette);//dt_calendrier
            dgv_calendrier.DataSource = db_content;
            
        }
        private void cb_salle_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer3.Stop(); //Sécurise si on change la salle a afficher
            string selected = cb_salle.Text;
            switch (selected)
            {
                case "Salle d'opération 1":
                    salle = "salle_ope_1";
                    break;
                case "Salle d'opération 2":
                    salle = "salle_ope_2";
                    break;
            }
            timer3.Interval = 1000;//toutes les 10 minutes refresh des info 
            timer3.Start();
        }
    }
}