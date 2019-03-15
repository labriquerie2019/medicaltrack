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
        public F_modif_patient()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Start();
            DataTable dt = recup_bdd("SELECT * FROM test");
            dgv_table_patient.RowHeadersVisible = false; // On cache la colonne de gauche inutile
            dgv_table_patient.DataSource = dt; 

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
            string id = dgv_table_patient.CurrentRow.Cells[0].Value.ToString();
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
            string action = "Action à éffectuer"; //Nom de la fenettre
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
            }
            else if (rep == DialogResult.No) //Si on appuie sur supprimer
            {

            }
        }
    }
}
