using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prototype_app_chef_infirmier
{
    public partial class F_Acceuil : Form
    {
        public F_Acceuil()
        {
            InitializeComponent();
        }

        private void F_Acceuil_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void m_configuration_Click(object sender, EventArgs e)
        {

        }

        private void m_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void b_connexion_Click(object sender, EventArgs e)
        {
            string ndc = t_ndc.Text;
            string mdp = t_mdp.Text;

            bool connected = true; //methode pour se connecter
            double step = 12.5;
            pb_chargement.Step = (int)step;
            l_chargement.Visible = true;
            pb_chargement.Visible = true;
            l_chargement.Text = "TEST SI LA BDD EXISTE!";
            pb_chargement.PerformStep();
            MessageBox.Show("MERCI DE PATIENTER QUELQUES SECONDES!", "CONNEXION BDD", MessageBoxButtons.OK, MessageBoxIcon.Information);

            #region config et connexion bdd puis test table,bdd,et tout sa qui existe
            _MySQL bdd;
            string Serveur = "localhost";
            string Base = "medicaltrack";
            string User = "root";
            string Pass = "";
            bdd = new _MySQL(Serveur, Base, User, Pass);
            bdd.Serveur = Serveur;
            bdd.Base = Base;
            bdd.User = User;
            bdd.Pass = Pass;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            l_chargement.Text = "TEST SI LA BASE DE DONNEES EXISTE SINON ON LA CREER!";
            if (bdd.base_exist()) //Si BDD existe
            {
                pb_chargement.PerformStep();
            }
            else //Si bdd existe pas
            {
                bdd.base_creer();
                pb_chargement.PerformStep();
            }
            l_chargement.Text = "TEST SI LA TABLE PATIENT EXISTE SINON ON LA CREER!";
            if (bdd.table_existe("patient")) //Si table patient existe
            {
                pb_chargement.PerformStep();
            }
            else //Si table patient existe pas
            {
                bdd.table_creer("CREATE TABLE IF NOT EXISTS `patient` (`id` int(11) NOT NULL AUTO_INCREMENT,`nom` varchar(30) NOT NULL,`prenom` varchar(30) NOT NULL,`age` int(11) NOT NULL,`date_naissance` DATE NOT NULL,`date_admission` DATE NOT NULL,`sexe` varchar(30) NOT NULL,`situation_familial` TEXT NOT NULL,`note` TEXT NOT NULL,`poid` TEXT NOT NULL,`taille` TEXT NOT NULL,`allergie` TEXT NOT NULL,`antecedant` TEXT NOT NULL,`id_rfid` varchar(255) NOT NULL,`last_scan` TEXT,PRIMARY KEY(`id`)) ENGINE = InnoDB  DEFAULT CHARSET = latin1;");
                pb_chargement.PerformStep();
            }
            l_chargement.Text = "TEST SI LA TABLE PERSONNELS HOSPITALIERS EXISTE SINON ON LA CREER!";
            if(bdd.table_existe("personnel_hospitalier")) //Si table personnel_hospitalier existe
            {
                pb_chargement.PerformStep();
            }
            else//Si table personnel_hospitalier existe pas on la créer
            {
                bdd.table_creer("CREATE TABLE IF NOT EXISTS `personnel_hospitalier` (`id` int(11) NOT NULL AUTO_INCREMENT,`identifiant` TEXT NOT NULL,`mdp` TEXT NOT NULL,`service` TEXT NOT NULL,PRIMARY KEY(`id`)) ENGINE = InnoDB  DEFAULT CHARSET = latin1;");
                pb_chargement.PerformStep();
            }
            l_chargement.Text = "TEST SI LA TABLE SALLE OPE 1 EXISTE SINON ON LA CREER!";
            if (bdd.table_existe("salle_ope_1")) //Si table salle_ope_1 existe
            {
                pb_chargement.PerformStep();
            }
            else//Si table salle_ope_1 existe pas on la créer
            {
                pb_chargement.PerformStep();
                bdd.table_creer("CREATE TABLE IF NOT EXISTS `salle_ope_1` (date_heure DATETIME NOT NULL,id_patient int(11)) ENGINE = InnoDB  DEFAULT CHARSET = latin1;");
            }
            l_chargement.Text = "TEST SI LA TABLE SALLE OPE 2 EXISTE SINON ON LA CREER!";
            if (bdd.table_existe("salle_ope_2"))//Si table salle_ope_2 existe
            {
                pb_chargement.PerformStep();
            }
            else//Si table salle_ope_2 existe pas on la créer
            {
                pb_chargement.PerformStep();
                bdd.table_creer("CREATE TABLE IF NOT EXISTS `salle_ope_2` (date_heure DATETIME NOT NULL,id_patient int(11)) ENGINE = InnoDB  DEFAULT CHARSET = latin1;");
            }
            l_chargement.Text = "TEST SI LA TABLE SALLE REA EXISTE SINON ON LA CREER!";
            if (bdd.table_existe("salle_rea"))//Si salle_rea existe
            {
                l_chargement.Text = "TEST SI LA TABLE SALLE REVEIL EXISTE SINON ON LA CREER!";
                pb_chargement.PerformStep();
            }
            else//Si salle_rea existe pas
            {
                pb_chargement.PerformStep();
                bdd.table_creer("CREATE TABLE IF NOT EXISTS `salle_rea` (date_heure DATETIME NOT NULL,id_patient int(11)) ENGINE = InnoDB  DEFAULT CHARSET = latin1;");
            }
            l_chargement.Text = "TEST SI LA TABLE SALLE REA EXISTE SINON ON LA CREER!";
            if (bdd.table_existe("salle_reveil"))//Si salle_reveil existe
            {
                pb_chargement.PerformStep();
            }
            else//Si salle_reveil existe pas
            {
                bdd.table_creer("CREATE TABLE IF NOT EXISTS `salle_reveil` (date_heure DATETIME NOT NULL,id_patient int(11)) ENGINE = InnoDB  DEFAULT CHARSET = latin1;");
                pb_chargement.PerformStep();
            }
            l_chargement.Text = "TEST SI LA TABLE SALLE REA EXISTE SINON ON LA CREER!";
            if (bdd.table_existe("grand_ecran"))//Si grand_ecran existe
            {
                pb_chargement.PerformStep();
            }
            else//Si salle_reveil existe pas
            {
                bdd.table_creer("CREATE TABLE IF NOT EXISTS `grand_ecran` (`id` int(11) NOT NULL AUTO_INCREMENT,`salle` TEXT NOT NULL,`date_heure_debut` DATETIME NOT NULL,`date_heure_fin` DATETIME NOT NULL,`nom_patient` TEXT NOT NULL,PRIMARY KEY(`id`)) ENGINE = InnoDB  DEFAULT CHARSET = latin1;");
                pb_chargement.PerformStep();
            }
            if (bdd.table_existe("salle_ane"))//Si salle_ane existe
            { 
                 l_chargement.Text = "TOUT EST PRET!";
                 pb_chargement.Value=100;
                 l_chargement.Visible = false;
                 pb_chargement.Visible = false;
                 MessageBox.Show("CONNEXION A LA BASE DE DONNEES REUSSI, VOUS POUVEZ UTILISER LE LOGICIEL!", "CONNEXION BDD REUSSI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //Si salle_ane existe pas
            {
                 bdd.table_creer("CREATE TABLE IF NOT EXISTS `salle_ane` (date_heure DATETIME NOT NULL,id_patient int(11)) ENGINE = InnoDB  DEFAULT CHARSET = latin1;");
                l_chargement.Text = "TOUT EST PRET!";
                pb_chargement.Value = 100;
                l_chargement.Visible = false;
                pb_chargement.Visible = false;
                MessageBox.Show("CONNEXION A LA BASE DE DONNEES REUSSI, VOUS POUVEZ UTILISER LE LOGICIEL!", "CONNEXION BDD REUSSI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion

            m_configuration.Visible = true;
            l_ndc.Visible = false;
            t_ndc.Visible = false;
            l_mdp.Visible = false;
            t_mdp.Visible = false;
            b_connexion.Visible = false;

            p_showbutton.Visible = true;

            if (ndc == "administration") //Tester qui est connecter
            {
                b_gerer_planning.Visible = false; //Administration
            }
            else if(ndc == "chef")
            {
                b_gerer_planning.Visible = true; //Chef hospitalier
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime heure = System.DateTime.Now;
            l_date_heure.Text = heure.Hour + ":" + heure.Minute + " " + heure.Day + "/" + heure.Month + "/" + heure.Year;
        }

        private void b_add_patient_Click(object sender, EventArgs e)
        {
            F_ajout_patient f_add_patient = new F_ajout_patient();
            f_add_patient.Show();
        }

        private void b_edit_patient_Click(object sender, EventArgs e)
        {
            F_modif_patient f_edit_patient = new F_modif_patient();
            f_edit_patient.Show();
        }

        private void b_gerer_planning_Click(object sender, EventArgs e)
        {
            F_gerer_planning f_modif_planning = new F_gerer_planning();
            f_modif_planning.Show();
        }

        private void b_check_planning_Click(object sender, EventArgs e)
        {
            F_view_calendrier f_check_calendrier = new F_view_calendrier();
            f_check_calendrier.Show();
        }

        private void b_personnel_Click(object sender, EventArgs e)
        {
            F_personnel_hospitalier f_personnel_hospitalier = new F_personnel_hospitalier();
            f_personnel_hospitalier.Show();
        }
    }
}
