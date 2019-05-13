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

namespace Medicaltrack_admin_planning
{
    public partial class F_chef_modif_patient : Form
    {
        string id;
        public F_chef_modif_patient()
        {
            InitializeComponent();
            dgv_table_patient.DefaultCellStyle.Font = new Font("Tahoma", 15);
            dgv_table_patient.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
            dgv_table_patient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            timer1.Interval = 1000;
            timer1.Start();
            DataTable dt = recup_bdd("SELECT * FROM patient");
            if (dt != null) //BDD remplie on affiche
            {
                dgv_table_patient.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                dgv_table_patient.DataSource = dt;
            }
            else //Erreur BDD
            {
                string message = "Erreur lors du chargement des données de la base de données";//Message a afficher
                string action = "ERREUR BDD"; //Nom de la fenettre
                MessageBoxManager.OK = "Réessayer";//On utilise la classe MessageBoxManager pour changer les boutons
                MessageBoxManager.Register(); //On applique nos changements
                var rep = MessageBox.Show(message, action, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBoxManager.Unregister(); //Evite les erreurs "one handle per thread"
            }
        }
        private DataTable recup_bdd(string requette)
        {
            DataTable dt = new DataTable();

            MySqlConnection con = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
            con.Open(); //On ouvre le flux BDD
            MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
            MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
            dt.Load(reader); // Lecture de la BDD et on la met dans le datatable 
            con.Close(); //Fermuture du flux BDD
            return dt;
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
        private void dgv_table_patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            #region recup valeur datagriedview selection
            id = dgv_table_patient.CurrentRow.Cells[0].Value.ToString();
            string nom = dgv_table_patient.CurrentRow.Cells[1].Value.ToString();
            string prenom = dgv_table_patient.CurrentRow.Cells[2].Value.ToString();
            string age = dgv_table_patient.CurrentRow.Cells[3].Value.ToString();
            string date_naissance_nontraiter = dgv_table_patient.CurrentRow.Cells[4].Value.ToString();
            string date_admission_nontraiter = dgv_table_patient.CurrentRow.Cells[5].Value.ToString();
            string sexe = dgv_table_patient.CurrentRow.Cells[6].Value.ToString();
            string situation_familial = dgv_table_patient.CurrentRow.Cells[7].Value.ToString();
            string note = dgv_table_patient.CurrentRow.Cells[8].Value.ToString();
            string poid = dgv_table_patient.CurrentRow.Cells[9].Value.ToString();
            string taille = dgv_table_patient.CurrentRow.Cells[10].Value.ToString();
            string allergie = dgv_table_patient.CurrentRow.Cells[11].Value.ToString();
            string antecedant = dgv_table_patient.CurrentRow.Cells[12].Value.ToString();
            string tag_rfid = dgv_table_patient.CurrentRow.Cells[13].Value.ToString();
            string last_scan = dgv_table_patient.CurrentRow.Cells[14].Value.ToString();
            #endregion
            #region messagebox/popup
            string message = "nom : " + nom + " prenom : " + prenom + "\n Quelle action voulez-vous effectuer?";//Message a afficher
            string action = "Action à effectuer"; //Nom de la fenettre
            MessageBoxManager.OK = "Modifier";//On utilise la classe MessageBoxManager pour changer les boutons
            MessageBoxManager.Cancel = "Annuler";
            MessageBoxManager.Register(); //On applique nos changements
            var rep = MessageBox.Show(message, action, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBoxManager.Unregister(); //Evite les erreurs "one handle per thread"
            #endregion
            if (rep == DialogResult.Yes) //Si on appuie sur Modifier
            {
                p_modif.Visible = true;
                t_nom.Text = nom;
                t_prenom.Text = prenom;
                t_age.Text = age;
                //string[] date_naissance_atraiter = date_naissance_nontraiter.Split(''); //Format jj/mm/yyyy 00:00:00"
                //Date de naissance
                string[] date_naissance_atraiter = date_naissance_nontraiter.Split(' '); //date_naissance_atraiter[0] = jj/mm/yyyy et date_naissance_atraiter[1] = 00:00:00
                string[] date_naissance_traiter = date_naissance_atraiter[0].Split('/'); //date_naissance_traiter[0] = jj ; date_naissance_traiter[1] = mm; date_naissance_traiter[2] = yyyy
                int jj = Convert.ToInt32(date_naissance_traiter[0]), mm = Convert.ToInt32(date_naissance_traiter[1]), yyyy = Convert.ToInt32(date_naissance_traiter[2]);
                DateTime date_naissance = new DateTime(yyyy, mm, jj);
                dp_date_naissance.Value = date_naissance;
                //Date d'admission
                string[] date_admission_atraiter = date_admission_nontraiter.Split(' '); //date_admission_atraiter[0] = jj/mm/yyyy et date_admission_atraiter[1] = 00:00:00
                string[] date_admission_traiter = date_admission_atraiter[0].Split('/'); //date_admission_traiter[0] = jj ; date_admission_traiter[1] = mm; date_admission_traiter[2] = yyyy
                jj = Convert.ToInt32(date_admission_traiter[0]); mm = Convert.ToInt32(date_admission_traiter[1]); yyyy = Convert.ToInt32(date_admission_traiter[2]);
                DateTime date_admission = new DateTime(yyyy, mm, jj);
                l_date_admission.Text = date_admission.ToString().Substring(0, 10); // Au final je le repasse en String mais il est déjà traiter si besoin

                t_sexe.Text = sexe;
                t_situation_familial.Text = situation_familial;
                t_note.Text = note;
                t_poid.Text = poid;
                t_taille.Text = taille;
                t_allergie.Text = allergie;
                t_antecedent_medicaux.Text = antecedant;
                if (last_scan == "")
                {
                    l_last_scan.Text = "Aucun scan effectué";
                }
                else
                {
                    l_last_scan.Text = last_scan;
                }
                t_rfid.Text = tag_rfid;
            }
        }

        private void b_done_modif_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                ///////////////////////////////////////////////////////////////Partie info patient
                string nom = t_nom.Text;
                string prenom = t_prenom.Text;
                int age = Convert.ToInt32(t_age.Text);
                DateTime date_naissance = dp_date_naissance.Value;
                string dt_nai = date_naissance.ToString("yyyy-MM-dd HH:mm:ss"); //Format americain 
                string sexe = t_sexe.Text;
                string situation_familial = t_situation_familial.Text;
                string note = t_note.Text;
                ///////////////////////////////////////////////////////////////Partie médical
                string poid = t_poid.Text;
                string taille = t_taille.Text;
                string allergie = t_allergie.Text;
                string antecedant = t_antecedent_medicaux.Text;
                string rfid = t_rfid.Text;
                //////////////////////////////////////////////////////////////
                string requette = "UPDATE patient SET nom = '" + nom + "', prenom = '" + prenom + "', age = '" + age + "', date_naissance = '" + dt_nai + "', sexe = '" + sexe + "', situation_familial = '" + situation_familial + "', note = '" + note + "', poid = '" + poid + "', taille = '" + taille + "', allergie = '" + allergie + "', antecedant= '" + antecedant + "', id_rfid = '" + rfid + "' WHERE id = " + id;
                MySqlConnection con = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                con.Open(); //On ouvre le flux BDD
                MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
                con.Close(); //Fermuture du flux BDD
                DataTable dt = recup_bdd("SELECT * FROM patient");
                if (dt != null) //BDD remplie on affiche
                {
                    dgv_table_patient.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                    dgv_table_patient.DataSource = dt;
                    dgv_table_patient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    #region clear textbox
                    t_nom.Clear();
                    t_prenom.Clear();
                    t_age.Clear();
                    t_age.Clear();
                    dp_date_naissance.Value = System.DateTime.Now;
                    t_sexe.Clear();
                    t_situation_familial.Clear();
                    t_note.Clear();
                    t_poid.Clear();
                    t_taille.Clear();
                    t_allergie.Clear();
                    t_antecedent_medicaux.Clear();
                    t_rfid.Clear();
                    #endregion
                    MessageBox.Show("MODIFICATION EFFECTUER", "MODIF FAITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    p_modif.Visible = false;

                }
                else //Erreur BDD
                {
                    string messagee = "Erreur lors du chargement des données de la base de données";//Message a afficher
                    string actionn = "ERREUR BDD"; //Nom de la fenettre
                    MessageBoxManager.OK = "Réessayer";//On utilise la classe MessageBoxManager pour changer les boutons
                    MessageBoxManager.Register(); //On applique nos changements
                    var repp = MessageBox.Show(messagee, actionn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBoxManager.Unregister(); //Evite les erreurs "one handle per thread"
                }
            }
            else
            {
                MessageBox.Show("ERREUR LORS DE LA MISE A JOUR : L'ID EST NUL", "ERREUR MAJ BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void b_annuler_Click(object sender, EventArgs e)
        {
            #region clear textbox
            t_nom.Clear();
            t_prenom.Clear();
            t_age.Clear();
            t_age.Clear();
            dp_date_naissance.Value = System.DateTime.Now;
            t_sexe.Clear();
            t_situation_familial.Clear();
            t_note.Clear();
            t_poid.Clear();
            t_taille.Clear();
            t_allergie.Clear();
            t_antecedent_medicaux.Clear();
            t_rfid.Clear();
            #endregion
            p_modif.Visible = false;
        }

        private void t_filtre_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            switch (cb_filtre.Text) //Permet de savoir quelle champs va être filter
            {
                case "ID":
                    if (t_filtre.Text != null)
                    {
                        dt = recup_bdd("SELECT * FROM patient WHERE id =" + t_filtre.Text);
                        if (dt != null) //BDD remplie on affiche
                        {
                            dgv_table_patient.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                            dgv_table_patient.DataSource = dt;
                            dgv_table_patient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                        else //Erreur BDD
                        {
                            string message = "Erreur lors du chargement des données de la base de données";//Message a afficher
                            string action = "ERREUR BDD"; //Nom de la fenettre
                            MessageBoxManager.OK = "Réessayer";//On utilise la classe MessageBoxManager pour changer les boutons
                            MessageBoxManager.Register(); //On applique nos changements
                            var rep = MessageBox.Show(message, action, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MessageBoxManager.Unregister(); //Evite les erreurs "one handle per thread"
                        }
                    }
                    else
                    {
                        dt = recup_bdd("SELECT * FROM patient");
                        if (dt != null) //BDD remplie on affiche
                        {
                            dgv_table_patient.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                            dgv_table_patient.DataSource = dt;
                            dgv_table_patient.Columns["date_naissance"].Width = 160;
                            dgv_table_patient.Columns["date_admission"].Width = 160;
                            dgv_table_patient.Columns["id_rfid"].Width = 160;
                            dgv_table_patient.Columns["last_scan"].Width = 160;
                        }
                        else //Erreur BDD
                        {
                            string message = "Erreur lors du chargement des données de la base de données";//Message a afficher
                            string action = "ERREUR BDD"; //Nom de la fenettre
                            MessageBoxManager.OK = "Réessayer";//On utilise la classe MessageBoxManager pour changer les boutons
                            MessageBoxManager.Register(); //On applique nos changements
                            var rep = MessageBox.Show(message, action, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MessageBoxManager.Unregister(); //Evite les erreurs "one handle per thread"
                        }
                    }
                    break;
                case "NOM":
                    dt = recup_bdd("SELECT * FROM patient WHERE nom LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "PRENOM":
                    dt = recup_bdd("SELECT * FROM patient WHERE prenom LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "AGE":
                    dt = recup_bdd("SELECT * FROM patient WHERE age LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "SEXE":
                    dt = recup_bdd("SELECT * FROM patient WHERE sexe LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "SITUATION FAMILIAL":
                    dt = recup_bdd("SELECT * FROM patient WHERE situation_familial LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "NOTE":
                    dt = recup_bdd("SELECT * FROM patient WHERE note LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "POID":
                    dt = recup_bdd("SELECT * FROM patient WHERE poid LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "TAILLE":
                    dt = recup_bdd("SELECT * FROM patient WHERE taille LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "ALLERGIES":
                    dt = recup_bdd("SELECT * FROM patient WHERE allergies LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "ANTECEDENT MEDICAUX":
                    dt = recup_bdd("SELECT * FROM patient WHERE antecedant LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "TAG RFID":
                    dt = recup_bdd("SELECT * FROM patient WHERE id_rfid LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                case "DERNIER SCAN":
                    dt = recup_bdd("SELECT * FROM patient WHERE last_scan LIKE '%" + t_filtre.Text + "%'");
                    dgv_load(dt);
                    break;
                default://Aucun filtre
                    if (t_filtre.Text == "")
                    {
                        dt = recup_bdd("SELECT * FROM patient");
                        dgv_load(dt);
                    }
                    break;
            }
        }
        public void dgv_load(DataTable datatable)
        {
            if (datatable != null) //BDD remplie on affiche
            {
                dgv_table_patient.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                dgv_table_patient.DataSource = datatable;
                dgv_table_patient.Columns["date_naissance"].Width = 160;
                dgv_table_patient.Columns["date_admission"].Width = 160;
                dgv_table_patient.Columns["id_rfid"].Width = 160;
                dgv_table_patient.Columns["last_scan"].Width = 160;
            }
            else //Erreur BDD
            {
                string message = "Erreur lors du chargement des données de la base de données";//Message a afficher
                string action = "ERREUR BDD"; //Nom de la fenettre
                MessageBoxManager.OK = "Réessayer";//On utilise la classe MessageBoxManager pour changer les boutons
                MessageBoxManager.Register(); //On applique nos changements
                var rep = MessageBox.Show(message, action, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBoxManager.Unregister(); //Evite les erreurs "one handle per thread"
            }
        }

        private void cb_filtre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_filtre.Text == "AUCUN")
            {
                t_filtre.Text = "";
                t_filtre.ReadOnly = true;
                DataTable dt = recup_bdd("SELECT * FROM patient");
                dgv_load(dt);
            }
            else
            {
                t_filtre.ReadOnly = false;
            }
        }
    }
}
