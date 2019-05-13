using Medicaltrack_admin_planning;
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
    public partial class F_personnel_hospitalier : Form
    {
        string id;
        bool nouveau;
        public F_personnel_hospitalier()
        {
            InitializeComponent();
            p_personnel.Visible = false;
            timer1.Interval = 3000;
            timer1.Start();
            dgv_personnel_hospitalier.DefaultCellStyle.Font = new Font("Tahoma", 15);
            dgv_personnel_hospitalier.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
            dgv_personnel_hospitalier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            timer1.Interval = 3000;
            DataTable dt = recup_bdd("SELECT * FROM personnel_hospitalier");
            if (dt != null) //BDD remplie on affiche
            {
                dgv_personnel_hospitalier.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                dgv_personnel_hospitalier.DataSource = dt;
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

        private void b_nouveau_Click(object sender, EventArgs e) //Quand on clique sur le bouton
        {
            t_mdp.UseSystemPasswordChar = false;
            p_personnel.Visible = true;
            nouveau = true;
        }

        private void dgv_personnel_hospitalier_CellContentClick(object sender, DataGridViewCellEventArgs e) //Quand on clique sur une cellule
        {
            #region recup valeur datagriedview selection
            id = dgv_personnel_hospitalier.CurrentRow.Cells[0].Value.ToString();
            string identifiant = dgv_personnel_hospitalier.CurrentRow.Cells[1].Value.ToString();
            string mdp = dgv_personnel_hospitalier.CurrentRow.Cells[2].Value.ToString();
            string service = dgv_personnel_hospitalier.CurrentRow.Cells[3].Value.ToString();
            #endregion
            #region messagebox/popup
            string message = "identifiant : " + identifiant + " du service : " + service + "\n Quelle action voulez-vous effectuer?";//Message a afficher
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
                nouveau = false;
                t_mdp.UseSystemPasswordChar = true;
                p_personnel.Visible = true;
                t_identifiant.Text = identifiant;
                t_mdp.Text = mdp;
                t_service.Text = service;
            }
            else if (rep == DialogResult.No) //Si on appuie sur supprimer
            {
                if (id != null)
                {
                    string requette = "DELETE FROM personnel_hospitalier WHERE id = " + id;
                    MySqlConnection con = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                    con.Open(); //On ouvre le flux BDD
                    MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                    MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
                    con.Close(); //Fermuture du flux BDD

                    DataTable dt = recup_bdd("SELECT * FROM personnel_hospitalier");
                    if (dt != null) //BDD remplie on affiche
                    {
                        dgv_personnel_hospitalier.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                        dgv_personnel_hospitalier.DataSource = dt;
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

        private void b_save_Click(object sender, EventArgs e)
        {
            if ((id != null) || (nouveau = true))
            {
                string identifiant = t_identifiant.Text;
                string mdp = t_mdp.Text;
                string service = t_service.Text;
                string requette;
                if (nouveau)
                {
                    requette = "INSERT INTO personnel_hospitalier (identifiant, mdp, service) VALUES('" + identifiant + "' , '" + mdp + "' , '" + service + "')";
                }
                else
                {
                    requette = "UPDATE personnel_hospitalier SET identifiant = '" + identifiant + "', mdp = '" + mdp + "', service = '" + service + "' WHERE id = " + id;
                }
                MySqlConnection con = new MySqlConnection("server=localhost;SslMode=none;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                con.Open(); //On ouvre le flux BDD
                MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                MySqlDataReader reader = cmd.ExecuteReader(); //On execute la requette
                con.Close(); //Fermuture du flux BDD
                DataTable dt = recup_bdd("SELECT * FROM personnel_hospitalier");
                if (dt != null) //BDD remplie on affiche
                {
                    dgv_personnel_hospitalier.RowHeadersVisible = false; // On cache la colonne de gauche inutile
                    dgv_personnel_hospitalier.DataSource = dt;
                    dgv_personnel_hospitalier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    #region clear textbox
                    t_identifiant.Clear();
                    t_mdp.Clear();
                    t_service.Clear(); 
                    #endregion
                    MessageBox.Show("MODIFICATION EFFECTUER", "MODIF FAITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    p_personnel.Visible = false;

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

        private void b_cancel_Click(object sender, EventArgs e)
        {
            t_identifiant.Clear();
            t_mdp.Clear();
            t_service.Clear();
            p_personnel.Visible = false;
        }

        private void b_new_mdp_Click(object sender, EventArgs e)
        {
            t_mdp.UseSystemPasswordChar = false;
            string rdm = Random(8);
            t_mdp.Text = rdm;
        }

       private void dgv_personnel_hospitalier_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
                else
                    e.Value = "Null";
            }
        }
        private string Random(int length)
        {
            string allowed = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(allowed.OrderBy(o => Guid.NewGuid()).Take(length).ToArray());
        }
    }
}
