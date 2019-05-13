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
        string nom, prenom,id;
        public DataTable afficher_calendrier(DateTime datetimepicker,string salle)
        {
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
            string requette = "SELECT * FROM " + salle + " WHERE date_heure BETWEEN '" + lundi_traiter + "' AND '" + dimanche_traiter + "'";
            ///////////////////////////////////////////////////////////////Recuperation de la BDD pour le datagridview 
            DataTable dt = new DataTable(); // On déclare une DataTable
            dt = GetCalendrier(requette); // On utilise la méthode GetCalendrier() pour recup le dataTable remplie
            return dt;
            ///////////////////////////////////////////////////////////////
        }
        private DataTable GetCalendrier(string requette)
        {
            DataTable dt = new DataTable();

            MySqlConnection con = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
            con.Open(); //On ouvre le flux BDD
            MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
            MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
            dt.Load(reader); // Lecture de la BDD et on la met dans le datatable 
            con.Close(); //Fermuture du flux BDD
            ///////////////////////////////////////////////////////////////
            int compteur = 0;
            compteur = dt.Rows.Count;
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
            for (int i = 0; i < 24; i++)
            {
                if (i < 10)
                {
                    dt.Rows.Add(null, null, "0" + i + "h");
                }
                else
                {
                    dt.Rows.Add(null, null, "" + i + "h");
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                DateTime result;
                if (DateTime.TryParse(row.ItemArray[0].ToString(), out result)) //On essaie de faire un date time, si sa passe on le stock dans result sinon on rentre pas dans le IF permet de savoir si c'est un date time
                {
                    string[] donner_a_traiter = row.ItemArray[0].ToString().Split(' ');
                    string[] annee_mois_jour = donner_a_traiter[0].Split('/');
                    string[] heure_minute_seconde = donner_a_traiter[1].Split(':');
                    int annee = Convert.ToInt32(annee_mois_jour[2]), mois = Convert.ToInt32(annee_mois_jour[1]), jour = Convert.ToInt32(annee_mois_jour[0]);
                    int heure = Convert.ToInt32(heure_minute_seconde[0]), minute = Convert.ToInt32(heure_minute_seconde[1]), seconde = Convert.ToInt32(heure_minute_seconde[2]);
                    DateTime jour_a_determiner = new DateTime(annee, mois, jour);

                    id = row.ItemArray[1].ToString();
                    string req = "SELECT nom,prenom FROM patient WHERE id = '" + id + "'";
                    DataTable datatable = new DataTable();
                    MySqlConnection connection = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                    con.Open(); //On ouvre le flux BDD
                    MySqlCommand commande = new MySqlCommand(req, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                    MySqlDataReader lire = commande.ExecuteReader(); //On execute la requette
                    datatable.Load(lire); // Lecture de la BDD et on la met dans le datatable 
                    con.Close(); //Fermuture du flux BDD  
                    foreach (DataRow ligne in datatable.Rows)
                    {
                        try
                        {
                            nom = ligne.ItemArray[0].ToString();
                            prenom = ligne.ItemArray[1].ToString();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("ERREUR : " + e, "ERREUR RECUPERATION INFO PATIENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    switch (jour_a_determiner.DayOfWeek.ToString()) // Switch sur le jour de la date choisis pour afficher la semaine
                    {
                        case "Monday"://Lundi
                            dt.Rows[heure + compteur].SetField(3, nom + " " + prenom);
                            break;
                        case "Tuesday"://Mardi
                            dt.Rows[heure + compteur].SetField(4, nom + " " + prenom);
                            break;
                        case "Wednesday"://Mercredi
                            dt.Rows[heure + compteur].SetField(5, nom + " " + prenom);
                            break;
                        case "Thursday"://Jeudi
                            dt.Rows[heure + compteur].SetField(6, nom + " " + prenom);
                            break;
                        case "Friday"://Vendredi
                            dt.Rows[heure + compteur].SetField(7, nom + " " + prenom);
                            break;
                        case "Saturday"://Samedi
                            dt.Rows[heure + compteur].SetField(8, nom + " " + prenom);
                            break;
                        case "Sunday"://Dimanche
                            dt.Rows[heure + compteur].SetField(9, nom + " " + prenom);
                            break;
                        default://Si erreur
                            MessageBox.Show("ERREUR : Lors du traitement des heures/date.");
                            break;
                    }
                }
            }
            dt.Columns.RemoveAt(0);//Colonne Date_heure
            dt.Columns.RemoveAt(0);//Colonne ID_patient, deviens 0 car on supprime l'ancien 0
            for (int i = 0; i < compteur; i++)
            {
                dt.Rows.RemoveAt(0);
            }
            return dt; //On return le DataTable traité qui contiens les info de la BDD
        }
    }
}
