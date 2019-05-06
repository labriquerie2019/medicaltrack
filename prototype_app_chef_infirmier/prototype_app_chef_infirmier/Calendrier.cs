using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;

namespace prototype_app_chef_infirmier
{
    class Calendrier
    {
        private DataTable GetCalendrier(string requette)
        {
            DataTable dt = new DataTable();

            MySqlConnection con = new MySqlConnection("server=localhost;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
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
                                MessageBox.Show("ERREUR : Lors du traitement des heures/date.");
                                //timer2.Stop();
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
        public DataTable afficher_calendrier(DateTime datetimepicker,string salle)
        {
            DataSet db_content = new DataSet();
            DateTime datetime_traitement = datetimepicker;
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
                    MessageBox.Show("ERREUR : Lors de la séléction de la date pour le calendrier!");
                    //this.timer2.Stop();
                    break;
            }
            string lundi_traiter = lundi.ToString("yyyy-MM-dd");
            string dimanche_traiter = dimanche.ToString("yyyyy-MM-dd");
            string requette = "SELECT date_heure FROM " + salle + " WHERE date_heure BETWEEN '" + lundi_traiter + "' AND '" + dimanche_traiter + "'";
            ///////////////////////////////////////////////////////////////Recuperation de la BDD pour le datagridview 
            DataTable dt = new DataTable(); // On déclare une DataTable
            dt = GetCalendrier(requette); // On utilise la méthode GetCalendrier() pour recup le dataTable remplie
            return dt;
            ///////////////////////////////////////////////////////////////
        }
    }
}
