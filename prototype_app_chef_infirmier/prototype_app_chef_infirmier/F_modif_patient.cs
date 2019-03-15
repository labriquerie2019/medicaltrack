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
    public partial class F_modif_patient : Form
    {
        string id;
        public F_modif_patient()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Start();
            DataTable dt = recup_bdd("SELECT * FROM test");
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

            MySqlConnection con = new MySqlConnection("server=localhost;database=aaa;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
            con.Open(); //On ouvre le flux BDD
            MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
            MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
            dt.Load(reader); // Lecture de la BDD et on la met dans le datatable 
            con.Close(); //Fermuture du flux BDD
            return dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime heure = System.DateTime.Now;
            l_date_heure.Text = heure.Hour + ":" + heure.Minute + " " + heure.Day + "/" + heure.Month + "/" + heure.Year;
        }

        private void m_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_acceuil_Click(object sender, EventArgs e)
        {
            this.Close();
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
            #endregion
            #region messagebox/popup
            string message = "Test nom : " + nom + " prenom : " + prenom;//Message a afficher
            string action = "Action à effectuer"; //Nom de la fenettre
            MessageBoxManager.Yes = "Modifier";//On utilise la classe MessageBoxManager pour changer les boutons
            MessageBoxManager.No = "Supprimer";
            MessageBoxManager.Cancel = "Annuler";
            MessageBoxManager.Register(); //On applique nos changements
            var rep = MessageBox.Show(message, action, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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
                l_date_admission.Text = date_admission.ToString().Substring(0,10); // Au final je le repasse en String mais il est déjà traiter si besoin

                t_sexe.Text = sexe;
                t_situation_familial.Text = situation_familial;
                t_note.Text = note;
                t_poid.Text = poid;
                t_taille.Text = taille;
                t_allergie.Text = allergie;
                t_antecedent_medicaux.Text = antecedant;
            }
            else if (rep == DialogResult.No) //Si on appuie sur supprimer
            {
                if (id != null)
                {
                    string requette = "DELETE FROM test WHERE id = " + id;
                    MySqlConnection con = new MySqlConnection("server=localhost;database=aaa;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                    con.Open(); //On ouvre le flux BDD
                    MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                    MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
                    con.Close(); //Fermuture du flux BDD

                    DataTable dt = recup_bdd("SELECT * FROM test");
                    if (dt != null) //BDD remplie on affiche
                    {
                        dgv_table_patient.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                        dgv_table_patient.DataSource = dt;
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
                    MessageBox.Show("ERREUR LORS DE LA SUPPRESION : L'ID EST NUL", "ERREUR SUPPRESSION BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                //////////////////////////////////////////////////////////////
                string requette = "UPDATE test SET nom = '" + nom + "', prenom = '" + prenom + "', age = '" + age + "', date_naissance = '" + dt_nai + "', sexe = '" + sexe + "', situation_familial = '" + situation_familial + "', note = '" + note + "', poid = '" + poid + "', taille = '" + taille + "', allergie = '" + allergie + "', antecedant= '" + antecedant + "' WHERE id = " + id;
                MySqlConnection con = new MySqlConnection("server=localhost;database=aaa;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                con.Open(); //On ouvre le flux BDD
                MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
                con.Close(); //Fermuture du flux BDD
                DataTable dt = recup_bdd("SELECT * FROM test");
                if (dt != null) //BDD remplie on affiche
                {
                    dgv_table_patient.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                    dgv_table_patient.DataSource = dt;
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
            #endregion
            p_modif.Visible = false;
        }
    }
}
