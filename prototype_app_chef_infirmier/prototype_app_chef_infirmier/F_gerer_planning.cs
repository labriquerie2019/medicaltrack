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
    public partial class F_gerer_planning : Form
    {
        string salle, id_patient, duree;
        int nb_patient=0;
        bool patient_select=false, duree_select = false;
        public F_gerer_planning()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            #region initialisation combo box et recuperation nom prenom id
            string requette = "SELECT * FROM patient";
            MySqlConnection con = new MySqlConnection("server=localhost;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
            con.Open(); //On ouvre le flux BDD
            MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
            MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
            DataTable read_bdd = new DataTable();
            read_bdd.Load(reader);
            con.Close(); //Fermuture du flux BDD
            var patient = new Dictionary<int, string[]>();
            for (int i = 0; i < read_bdd.Rows.Count; i++) //On lis le DataTable qui contient la réponse de la BDD
            {
                nb_patient++; //On compte le nombre de patient
                string[] toadd = { read_bdd.Rows[i]["id"].ToString(), read_bdd.Rows[i]["nom"].ToString(), read_bdd.Rows[i]["prenom"].ToString() }; //On créer un array de string pour l'ajouter dans un Dictonary
                patient[i] = toadd;  //On stock id,nom,prenom pour plus tard dans une List
                cb_patient.Items.Add(read_bdd.Rows[i]["id"]+ " : " +read_bdd.Rows[i]["nom"] + " " + read_bdd.Rows[i]["prenom"]); //On remplie le combo box avec : ID:Nom Prenom
            }

            /*for(int i = 0; i < patient.LongCount();i++)
            {
                cb_test.Items.Add(patient[i][0]+" ; "+ patient[i][1] + " ; " + patient[i][2]); //Exemple pour lire dans le Dictonary de tableau de string
            }*/

            l_nb_patient.Text = "Nombre de patients recensé : " + nb_patient.ToString();
            #endregion
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

        private void m_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void F_gerer_planning_Load(object sender, EventArgs e)
        {

        }

        private void cb_salle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cb_salle.Text;
            switch (selected)
            {
                case "Salle d'opération 1":
                    salle = "salle_ope_1";
                    break;
                case "Salle d'opération 2":
                    salle = "salle_ope_2";
                    break;
                case "Salle d'anesthesie":
                    salle = "salle_ane";
                    break;
                case "Salle de reveil":
                    salle = "salle_reveil";
                    break;
                case "Salle de réanimation":
                    salle = "salle_rea";
                    break;
            }
            Calendrier mon_calendrier = new Calendrier();
            DataTable dt = mon_calendrier.afficher_calendrier(dt_calendrier.Value, salle);
            dgv_calendrier.RowHeadersVisible = false;
            dgv_calendrier.DataSource = dt; // On attribue les sources du DataGridView au DataTable
        }
        private void cb_patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] raw_data = cb_patient.Text.Split(':');
            id_patient = raw_data[0];
            patient_select = true;
        }

        private void cb_duree_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cb_duree.Text;
            switch(selected)
            {
                case "1h":
                    duree = "1";
                    break;
                case "2h":
                    duree = "2";
                    break;
                case "3h":
                    duree = "3";
                    break;
                case "4h":
                    duree = "4";
                    break;
                default: //Choix invalide
                    MessageBox.Show("Choix invalide, veuilliez recommencer.", "Choix invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            duree_select = true;
        }
        private void dgv_calendrier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(duree_select && patient_select) //Verif durée choisis et patient choisis
            {
                string jour = e.ColumnIndex.ToString(); //On recup le jour
                string heure_choisis = e.RowIndex.ToString(); //On recup l'heure
                ////////////////////////////////////////////////////////////////////////////////
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
                        MessageBox.Show("ERREUR : Lors de la séléction de la date pour le calendrier!");
                        //this.timer2.Stop();
                        break;
                }
                ////////////////////////////////////////////////////////////////////////////////
                DateTime date_debut,date_fin;
                switch (jour)//Datetime pour la date_debut et date_fin
                {
                    case "Lundi":
                        date_debut = new DateTime(lundi.Year, lundi.Month, lundi.Day, Convert.ToInt32(heure_choisis), 0, 0);
                        date_fin = new DateTime(lundi.Year, lundi.Month, lundi.Day, Convert.ToInt32(heure_choisis)+Convert.ToInt32(duree), 0, 0);
                        break;
                    case "Mardi":
                        date_debut = new DateTime(lundi.AddDays(1).Year, lundi.AddDays(1).Month, lundi.AddDays(1).Day, Convert.ToInt32(heure_choisis), 0, 0);
                        date_fin = new DateTime(lundi.AddDays(1).Year, lundi.AddDays(1).Month, lundi.AddDays(1).Day, Convert.ToInt32(heure_choisis)+Convert.ToInt32(duree), 0, 0);
                        break;
                    case "Mercredi":
                        date_debut = new DateTime(lundi.AddDays(2).Year, lundi.AddDays(2).Month, lundi.AddDays(2).Day, Convert.ToInt32(heure_choisis), 0, 0);
                        date_fin = new DateTime(lundi.AddDays(2).Year, lundi.AddDays(2).Month, lundi.AddDays(2).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                        break;
                    case "Jeudi":
                        date_debut = new DateTime(lundi.AddDays(3).Year, lundi.AddDays(3).Month, lundi.AddDays(3).Day, Convert.ToInt32(heure_choisis), 0, 0);
                        date_fin = new DateTime(lundi.AddDays(3).Year, lundi.AddDays(3).Month, lundi.AddDays(3).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                        break;
                    case "Vendredi":
                        date_debut = new DateTime(lundi.AddDays(4).Year, lundi.AddDays(4).Month, lundi.AddDays(4).Day, Convert.ToInt32(heure_choisis), 0, 0);
                        date_fin = new DateTime(lundi.AddDays(4).Year, lundi.AddDays(4).Month, lundi.AddDays(4).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                        break;
                    case "Samedi":
                        date_debut = new DateTime(lundi.AddDays(5).Year, lundi.AddDays(5).Month, lundi.AddDays(5).Day, Convert.ToInt32(heure_choisis), 0, 0);
                        date_fin = new DateTime(lundi.AddDays(5).Year, lundi.AddDays(5).Month, lundi.AddDays(5).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                        break;
                    case "Dimanche":
                        date_debut = new DateTime(lundi.AddDays(6).Year, lundi.AddDays(6).Month, lundi.AddDays(6).Day, Convert.ToInt32(heure_choisis), 0, 0);
                        date_fin = new DateTime(lundi.AddDays(6).Year, lundi.AddDays(6).Month, lundi.AddDays(6).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                        break;
                    default:
                        MessageBox.Show("ERREUR : Lors du retracage de la date!");
                        break;
                }
            }
        }

    }
}
