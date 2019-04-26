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
using System.IO.Ports;
using System.Threading;

namespace prototype_app_chef_infirmier
{
    public partial class F_ajout_patient : Form
    {
        static string salle;
        SerialPort my_serie;
        public F_ajout_patient()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Start();
            this.dgv_calendrier.DefaultCellStyle.Font = new Font("Tahoma", 15);
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// DEBUT RFID
            try
            {
                my_serie = new SerialPort("COM1");
                my_serie.BaudRate = Convert.ToInt32(9600);
                my_serie.DataBits = 8;
                my_serie.StopBits = StopBits.One;
                my_serie.Parity = Parity.None;
                my_serie.Handshake = Handshake.None;
                my_serie.Open();
                my_serie.DataReceived += new SerialDataReceivedEventHandler(ReceptionSerie);
                //"Ouverture du port " + portCom;
            }
            catch { }
        }
           delegate void SetTextCallback(string text);
        private void ReceptionSerie(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(750);///attente pour les gros paquets de données
            string data = my_serie.ReadExisting();
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            SetText(data);
        }
        private void SetText(string textCOM)
        {
            if (t_rfid.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                t_rfid.Invoke(d, new object[] { textCOM });
                string input = this.t_rfid.Text;
                char[] values = input.ToCharArray();
                textCOM = string.Empty;

            }
            else
            {
                t_rfid.Text = "";
                t_rfid.Text += ConvertToHex(textCOM);
            }
        }
        public string ConvertToHex(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
            {
                int tmp = c;
                hex += String.Format("{0:X2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
                hex += " ";
            }
            return hex;
        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// FIN RFID
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
            if (t_nom.Text.Length > 0 && t_prenom.Text.Length > 0 && t_age.Text.Length > 0  && t_sexe.Text.Length > 0 && t_situation_familial.Text.Length > 0 && t_note.Text.Length > 0 && t_poid.Text.Length > 0 && t_taille.Text.Length > 0 && t_allergie.Text.Length > 0 && t_antecedent_medicaux.Text.Length > 0)//tous les champs remplie
            {
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
                string requette = "INSERT INTO patient (nom, prenom, age, date_naissance, date_admission, sexe, situation_familial, note, poid, taille, allergie, antecedant) VALUES('" + nom + "' , '" + prenom + "' , '" + age + "' , '" + dt_nai + "' , '" + dt_adm + "' , '" + sexe + "' , '" + situation_familial + "' , '" + note + "' , '" + poid + "' , '" + taille + "' , '" + allergie + "' , '" + antecedant + "')";
                MySqlConnection con = new MySqlConnection("server=localhost;database=medicaltrack;user id=root;"); //On prépare la connexion en passant les arguments nécessaire
                con.Open(); //On ouvre le flux BDD
                MySqlCommand cmd = new MySqlCommand(requette, con); // On prépare la requette SQL, et comme deuxieme argument on met l'objet connexion MySQL
                cmd.ExecuteNonQuery();
                con.Close(); //Fermuture du flux BDD
                ///////////////////////////////////////////////////////////////
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
                MessageBox.Show("INSERTION REUSSI", "PATIENT AJOUTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //pas tout les champs remplie
            {
                F_erreur champ_vide = new F_erreur("ERREUR : Tous les champs ne sont pas remplie!");
                champ_vide.ShowDialog();
            }
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

        private void t_rfid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}