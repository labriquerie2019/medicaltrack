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
        Calendrier mon_calendrier = new Calendrier();
        string salle, id_patient, duree, nom, salle_mysql;
        int nb_patient=0;
        DateTime date_debut, date_fin;
        bool patient_select=false, duree_select = false,delete=false;
        public F_gerer_planning()
        {
            InitializeComponent();
            timer2.Interval = 500; //Timer pour savoir dans quelle mode on est
            timer2.Start();
            timer1.Interval = 1000; //Timer pour l'heure et la date
            timer1.Start();
            #region initialisation combo box et recuperation nom prenom id
            string requette = "SELECT * FROM patient";
            MySqlConnection con = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
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
                cb_patient.Items.Add(read_bdd.Rows[i]["id"]+ ":" +read_bdd.Rows[i]["nom"] + " " + read_bdd.Rows[i]["prenom"]); //On remplie le combo box avec : ID:Nom Prenom
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(delete)
            {
                l_mode.Text = "Suppression";
            }
            else
            {
                l_mode.Text = "Ajout";
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            delete = true;
        }

        private void dgv_calendrier_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (delete)
            {
                if (dgv_calendrier.SelectedCells[0].Value.ToString() != "" && dgv_calendrier.SelectedCells[0].Value.ToString().Contains(nom)) //Si on choisis une cellule avec des info et avec le bon prenom
                {
                    #region suppression d'info
                    string jour = dgv_calendrier.Columns[e.ColumnIndex].HeaderText;//On recup le jour
                    string heure_choisis = e.RowIndex.ToString(); //On recup l'heure
                    DateTime datetime_traitement = dt_calendrier.Value;
                    DateTime lundi = new DateTime();
                    DateTime dimanche = new DateTime();
                    switch (datetime_traitement.DayOfWeek.ToString()) // Switch sur le jour de la date choisis pour afficher le jour, et determiner le lundi et le dimanche
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
                            break;
                    }
                    bool traiter = false;
                    switch (jour)//Datetime pour la date_debut et date_fin
                    {
                        case "Lundi":
                            date_debut = new DateTime(lundi.Year, lundi.Month, lundi.Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.Year, lundi.Month, lundi.Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Mardi":
                            date_debut = new DateTime(lundi.AddDays(1).Year, lundi.AddDays(1).Month, lundi.AddDays(1).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(1).Year, lundi.AddDays(1).Month, lundi.AddDays(1).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Mercredi":
                            date_debut = new DateTime(lundi.AddDays(2).Year, lundi.AddDays(2).Month, lundi.AddDays(2).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(2).Year, lundi.AddDays(2).Month, lundi.AddDays(2).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Jeudi":
                            date_debut = new DateTime(lundi.AddDays(3).Year, lundi.AddDays(3).Month, lundi.AddDays(3).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(3).Year, lundi.AddDays(3).Month, lundi.AddDays(3).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Vendredi":
                            date_debut = new DateTime(lundi.AddDays(4).Year, lundi.AddDays(4).Month, lundi.AddDays(4).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(4).Year, lundi.AddDays(4).Month, lundi.AddDays(4).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Samedi":
                            date_debut = new DateTime(lundi.AddDays(5).Year, lundi.AddDays(5).Month, lundi.AddDays(5).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(5).Year, lundi.AddDays(5).Month, lundi.AddDays(5).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Dimanche":
                            date_debut = new DateTime(lundi.AddDays(6).Year, lundi.AddDays(6).Month, lundi.AddDays(6).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(6).Year, lundi.AddDays(6).Month, lundi.AddDays(6).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        default:
                            MessageBox.Show("ERREUR : Lors du retracage de la date!");
                            break;
                    }
                    if (traiter && nom != null && duree != null)
                    {
                        try
                        {
                            ////////////////////////////////////////////////////////////// Pour table grand écran 
                            string selected = cb_salle.Text;
                            switch (selected)
                            {
                                case "Salle d'opération 1":
                                    salle_mysql = "Salle operation 1";
                                    break;
                                case "Salle d'opération 2":
                                    salle_mysql = "Salle operation 2";
                                    break;
                                case "Salle d'anesthesie":
                                    salle_mysql = "Salle anesthesie";
                                    break;
                                case "Salle de reveil":
                                    salle_mysql = "Salle de reveil";
                                    break;
                                case "Salle de réanimation":
                                    salle_mysql = "Salle de reanimation";
                                    break;
                            }
                            bool valide = false;
                            string content = dgv_calendrier.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            for(int i=0;i<Convert.ToInt32(duree);i++)
                            {
                                if(dgv_calendrier.Rows[e.RowIndex+i].Cells[e.ColumnIndex].Value.ToString() == content) //Permet de bouclier sur les lignes en dessous afin de vérifier que la durée dépasse pas
                                {
                                    valide = true;
                                }
                                else
                                {
                                    valide = false;
                                }
                            }
                            if (valide)//Si TOUT est bon
                            {
                                string datedebut_formatForMySql = date_debut.ToString("yyyy-MM-dd HH:mm:ss");
                                string datefin_formatForMySql = date_fin.ToString("yyyy-MM-dd HH:mm:ss");
                                string requette_sql = "DELETE FROM grand_ecran WHERE salle='" + salle_mysql + "' AND date_heure_debut='" + datedebut_formatForMySql + "' AND date_heure_fin='" + datefin_formatForMySql + "' AND nom_patient='" + nom + "'";
                                MySqlConnection connect_sql = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                                connect_sql.Open(); //On ouvre le flux BDD
                                MySqlCommand cmd_sql = new MySqlCommand(requette_sql, connect_sql); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                                cmd_sql.ExecuteNonQuery();
                                connect_sql.Close(); //Fermuture du flux BDD
                                                     /////////////////////////////////////////////////////////////// Pour table de MedicalOPS et MedicalAdmin
                                for (int i = 0; i < Convert.ToInt32(duree); i++)
                                {
                                    DateTime datetime_bdd = new DateTime(date_debut.Year, date_debut.Month, date_debut.Day, date_debut.Hour + i, 0, 0);
                                    string date_formatForMySql = datetime_bdd.ToString("yyyy-MM-dd HH:mm:ss");
                                    string req_sql = "DELETE FROM " + salle + " WHERE date_heure='" + date_formatForMySql + "' AND id_patient='" + id_patient + "'";
                                    MySqlConnection con_sql = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                                    con_sql.Open(); //On ouvre le flux BDD
                                    MySqlCommand command_sql = new MySqlCommand(req_sql, con_sql); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                                    command_sql.ExecuteNonQuery();
                                    con_sql.Close(); //Fermuture du flux BDD
                                }
                                /////////////////////////////////////////////////////////////// On refresh le datagriedview
                                DataTable datatable = mon_calendrier.afficher_calendrier(dt_calendrier.Value, salle);
                                dgv_calendrier.RowHeadersVisible = false;
                                dgv_calendrier.DataSource = datatable; // On attribue les sources du DataGridView au DataTable
                                delete = false; //On repasse le delete en false
                                valide = false;
                                MessageBox.Show("Horraire supprimer avec succes, si vous voulez repasser en mode suppression, il faut appuyer de nouveau sur le bouton.", "SUPPRESION EFFECTUER AVEC SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else //else qui recupere erreur : horraire qui dépasse ce patient
                            {
                                MessageBox.Show("Vérifier la durée choisis et le patient séléctionner, si l'erreur persiste, retirer une heure par une");
                            }
                        }
                        catch (Exception erreur)
                        {
                            MessageBox.Show("ERREUR : " + erreur, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERREUR : Merci de choisir un patient et une durée","ERREUR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                    #endregion
                else //Tente de supprimer une cellule vide
                {
                    MessageBox.Show("ERREUR : Merci de choisir une heure qui contient un patient ou vérifier que vous avez sélectionné le bon patient à gauche.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (duree_select && patient_select) //Verif durée choisis et patient choisis
            {
                #region ajouter info calendrier
                if (dgv_calendrier.SelectedCells[0].Value.ToString() == "")
                {
                    string jour = dgv_calendrier.Columns[e.ColumnIndex].HeaderText;//On recup le jour
                    string heure_choisis = e.RowIndex.ToString(); //On recup l'heure
                    ////////////////////////////////////////////////////////////////////////////////
                    DateTime datetime_traitement = dt_calendrier.Value;
                    DateTime lundi = new DateTime();
                    DateTime dimanche = new DateTime();
                    switch (datetime_traitement.DayOfWeek.ToString()) // Switch sur le jour de la date choisis pour afficher le jour, et determiner le lundi et le dimanche
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
                            break;
                    }
                    bool traiter = false;
                    switch (jour)//Datetime pour la date_debut et date_fin
                    {
                        case "Lundi":
                            date_debut = new DateTime(lundi.Year, lundi.Month, lundi.Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.Year, lundi.Month, lundi.Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Mardi":
                            date_debut = new DateTime(lundi.AddDays(1).Year, lundi.AddDays(1).Month, lundi.AddDays(1).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(1).Year, lundi.AddDays(1).Month, lundi.AddDays(1).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Mercredi":
                            date_debut = new DateTime(lundi.AddDays(2).Year, lundi.AddDays(2).Month, lundi.AddDays(2).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(2).Year, lundi.AddDays(2).Month, lundi.AddDays(2).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Jeudi":
                            date_debut = new DateTime(lundi.AddDays(3).Year, lundi.AddDays(3).Month, lundi.AddDays(3).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(3).Year, lundi.AddDays(3).Month, lundi.AddDays(3).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Vendredi":
                            date_debut = new DateTime(lundi.AddDays(4).Year, lundi.AddDays(4).Month, lundi.AddDays(4).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(4).Year, lundi.AddDays(4).Month, lundi.AddDays(4).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Samedi":
                            date_debut = new DateTime(lundi.AddDays(5).Year, lundi.AddDays(5).Month, lundi.AddDays(5).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(5).Year, lundi.AddDays(5).Month, lundi.AddDays(5).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        case "Dimanche":
                            date_debut = new DateTime(lundi.AddDays(6).Year, lundi.AddDays(6).Month, lundi.AddDays(6).Day, Convert.ToInt32(heure_choisis), 0, 0);
                            date_fin = new DateTime(lundi.AddDays(6).Year, lundi.AddDays(6).Month, lundi.AddDays(6).Day, Convert.ToInt32(heure_choisis) + Convert.ToInt32(duree), 0, 0);
                            traiter = true;
                            break;
                        default:
                            MessageBox.Show("ERREUR : Lors du retracage de la date!");
                            break;
                    }
                    if (traiter)
                    {
                        try
                        {
                            ////////////////////////////////////////////////////////////// Pour affichage grand écran
                            string selected = cb_salle.Text;
                            switch (selected)
                            {
                                case "Salle d'opération 1":
                                    salle_mysql = "Salle operation 1";
                                    break;
                                case "Salle d'opération 2":
                                    salle_mysql = "Salle operation 2";
                                    break;
                                case "Salle d'anesthesie":
                                    salle_mysql = "Salle anesthesie";
                                    break;
                                case "Salle de reveil":
                                    salle_mysql = "Salle de reveil";
                                    break;
                                case "Salle de réanimation":
                                    salle_mysql = "Salle de reanimation";
                                    break;
                            }
                            bool valide = false;
                            string content = dgv_calendrier.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            for (int i = 0; i < Convert.ToInt32(duree); i++)
                            {
                                if (dgv_calendrier.Rows[e.RowIndex + i].Cells[e.ColumnIndex].Value.ToString() == content) //Permet de bouclier sur les lignes en dessous afin de vérifier que la durée dépasse pas
                                {
                                    valide = true;
                                }
                                else
                                {
                                    valide = false;
                                }
                            }
                            if (valide)
                            {
                                string datedebut_formatForMySql = date_debut.ToString("yyyy-MM-dd HH:mm:ss");
                                string datefin_formatForMySql = date_fin.ToString("yyyy-MM-dd HH:mm:ss");
                                string requette_sql = "INSERT INTO grand_ecran(salle,date_heure_debut,date_heure_fin,nom_patient) VALUES('" + salle_mysql + "' , '" + datedebut_formatForMySql + "' , '" + datefin_formatForMySql + "' , '" + nom + "')";
                                MySqlConnection connect_sql = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                                connect_sql.Open(); //On ouvre le flux BDD
                                MySqlCommand cmd_sql = new MySqlCommand(requette_sql, connect_sql); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                                cmd_sql.ExecuteNonQuery();
                                connect_sql.Close(); //Fermuture du flux BDD
                                                     /////////////////////////////////////////////////////////////// Pour affichage MedicalOPS et MedicalAdmin
                                for (int i = 0; i < Convert.ToInt32(duree); i++)
                                {
                                    DateTime datetime_bdd = new DateTime(date_debut.Year, date_debut.Month, date_debut.Day, date_debut.Hour + i, 0, 0);
                                    string date_formatForMySql = datetime_bdd.ToString("yyyy-MM-dd HH:mm:ss");
                                    string req_sql = "INSERT INTO " + salle + "(date_heure,id_patient) VALUES('" + date_formatForMySql + "','" + id_patient + "')";
                                    MySqlConnection con_sql = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                                    con_sql.Open(); //On ouvre le flux BDD
                                    MySqlCommand command_sql = new MySqlCommand(req_sql, con_sql); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                                    command_sql.ExecuteNonQuery();
                                    con_sql.Close(); //Fermuture du flux BDD
                                }
                                DataTable datatable = mon_calendrier.afficher_calendrier(dt_calendrier.Value, salle);
                                dgv_calendrier.RowHeadersVisible = false;
                                dgv_calendrier.DataSource = datatable; // On attribue les sources du DataGridView au DataTable
                            }
                            else
                            {
                                MessageBox.Show("ERREUR : ce créneaux horraire est déja pris", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception erreur)
                        {
                            MessageBox.Show("ERREUR : " + erreur, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                #endregion
                else // Si on clique sur une case avec des informations dedans
                {
                    MessageBox.Show("ERREUR : Merci de choisir une periode libre", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //Pas de patient selectionner ou pas de durée
            {
                MessageBox.Show("ERREUR : merci de choisir un patient et une durée", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            DataTable dt = mon_calendrier.afficher_calendrier(dt_calendrier.Value, salle);
            dgv_calendrier.RowHeadersVisible = false;
            dgv_calendrier.DataSource = dt; // On attribue les sources du DataGridView au DataTable
        }
        private void cb_patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] raw_data = cb_patient.Text.Split(':'); //ID:Nom Prenom
            id_patient = raw_data[0];
            string[] raw_name = raw_data[1].Split(' ');
            nom = raw_name[0];
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
        }
    }
}
