using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prototype_app_chef_infirmier
{
    public partial class F_view_calendrier : Form
    {
        string salle;
        public F_view_calendrier()
        {
            InitializeComponent();
            ///////////////////////////////////////////////////////////////
            timer1.Interval = 1000;
            timer1.Start();
        }

        private DataTable GetCalendrier(string requette)
        {
            DataTable dt = new DataTable();

            MySqlConnection con = new MySqlConnection("server=localhost;database=aaa;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
            con.Open(); //On ouvre le flux BDD
            MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
            MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
            dt.Load(reader); // Lecture de la BDD et on la met dans le datatable 
            con.Close(); //Fermuture du flux BDD
            ///////////////////////////////////////////////////////////////
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
                    if (DateTime.TryParse(item.ToString(), out result)) //On essaie de faire un date time, si sa passe on le stock dans result sinon on rentre pas dans le IF permet de savoir si c'est un date time
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
                                dt.Rows[heure + compteur].SetField(2, "ya un gars ici");
                                break;
                            case "Tuesday"://Mardi
                                dt.Rows[heure + compteur].SetField(3, "ya un gars ici");
                                break;
                            case "Wednesday"://Mercredi
                                dt.Rows[heure + compteur].SetField(4, "ya un gars ici");
                                break;
                            case "Thursday"://Jeudi
                                dt.Rows[heure + compteur].SetField(5, "ya un gars ici");
                                break;
                            case "Friday"://Vendredi
                                dt.Rows[heure + compteur].SetField(6, "ya un gars ici");
                                break;
                            case "Saturday"://Samedi
                                dt.Rows[heure + compteur].SetField(7, "ya un gars ici");
                                break;
                            case "Sunday"://Dimanche
                                dt.Rows[heure + compteur].SetField(8, "ya un gars ici");
                                break;
                            default://Si erreur
                                F_erreur erreur_date = new F_erreur("ERREUR : Lors du traitement des heures/date.");
                                erreur_date.ShowDialog();
                                timer2.Stop();
                                break;
                        }
                    }
                }
            }
            dt.Columns.RemoveAt(0);
            for (int i = 0; i < compteur; i++)
            {
                dt.Rows.RemoveAt(0);
            }
            return dt; //On return le DataTable traité qui contiens les info de la BDD
        }
        private void afficher_calendrier()
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
                    this.timer2.Stop();
                    break;
            }
            string lundi_traiter = lundi.ToString("yyyy-MM-dd");
            string dimanche_traiter = dimanche.ToString("yyyyy-MM-dd");
            string requette = "SELECT date_heure FROM " + salle + " WHERE date_heure BETWEEN '" + lundi_traiter + "' AND '" + dimanche_traiter + "'";
            ///////////////////////////////////////////////////////////////Recuperation de la BDD pour le datagridview 
            DataTable dt = new DataTable(); // On déclare une DataTable
            dt = GetCalendrier(requette); // On utilise la méthode GetCalendrier() pour recup le dataTable remplie
            dgv_calendrier.RowHeadersVisible = false;
            dgv_calendrier.DataSource = dt; // On attribue les sources du DataGridView au DataTable
            ///////////////////////////////////////////////////////////////
        }

        private void m_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_acceuil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime heure = System.DateTime.Now;
            l_date_heure.Text = heure.Hour + ":" + heure.Minute + " " + heure.Day + "/" + heure.Month + "/" + heure.Year;
        }

        private void cb_salle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            timer2.Stop(); //Sécurise si on change la salle a afficher
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
            afficher_calendrier();
            timer2.Interval = 60000;//toutes les 10 minutes refresh des info 
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            afficher_calendrier();
        }
    }

}
