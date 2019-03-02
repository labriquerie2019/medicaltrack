using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace prototype_app_chef_infirmier
{
    class _MySQL
    {
        string serveur;
        string user;
        string pass;
        string sql_base;
        static DataSet ds;                    //Déclaration Objet DataSet
        static MySqlConnection cn;            //Déclaration Objet Connexion
        static MySqlCommand cmd;              //Déclaration Objet Command
        static MySqlDataAdapter da;           //Ensemble de commande utilisée pour remplir le Dataset
        static MySqlCommandBuilder combuilder;//Déclaration Objet Commandbuilder, pour la mise à jour
        private string cn_base;//chaine de connexion à la base

        public _MySQL(string Serveur, string Base, string User, string Pass)//constructeur
        {
            cn_base = "server=" + Serveur + "; user id=" + User + "; password=" + Pass + "; database=" + Base + "; pooling=false";
        }
        public string Serveur
        {
            get { return serveur; }
            set { serveur = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Base
        {
            get { return sql_base; }
            set { sql_base = value; }
        }
        private string con_string(bool racine)
        {
            string data;
            if (racine == true)
                data = "server=" + Serveur
                + "; user id=" + User + "; password=" + Pass
                + "; database=" + "" + "; pooling=false";
            else
                data = "server=" + Serveur
                + "; user id=" + User + "; password=" + Pass
                + "; database=" + Base + "; pooling=false";
            return data;
        }

        public bool base_exist()//test présence base
        {
            cn = new MySqlConnection(); // création objet connexion
            cn.ConnectionString = con_string(true);
            cn.Open();
            string query = "SHOW DATABASES";
            MySqlCommand clCommand = new MySqlCommand(query, cn);
            MySqlDataReader myReader;
            myReader = clCommand.ExecuteReader();
            int i = 0;
            while (myReader.Read()) if (myReader.GetString(0) == Base) { i = 1; break; }
            myReader.Close();
            if (i == 0) return false;
            else return true;
        }

        public bool base_creer()//création de la base
        {
            try
            {
                cn = new MySqlConnection(); //création objet connexion
                cn.ConnectionString = con_string(true);
                cn.Open();
                cmd = cn.CreateCommand();
                cmd.CommandText = "CREATE DATABASE " + Base;
                cmd.ExecuteNonQuery(); //exécution sans retour
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool table_existe(string table) // test présence table
        {
            cn = new MySqlConnection(); //Création d'un nouvel objet cn
            cn.ConnectionString = con_string(false);
            cn.Open();                  //On ouvre la connexion
            string query = "SHOW TABLES FROM " + Base;
            MySqlCommand clCommand = new MySqlCommand(query, cn);
            MySqlDataReader myReader;
            myReader = clCommand.ExecuteReader();
            int i = 0;
            while (myReader.Read()) if (myReader.GetString(0) == table) { i = 1; break; }
            myReader.Close();
            if (i == 0) return false;
            else return true;
        }
        public bool table_creer(string requette) //création d'une table dans la base
        {
            try
            {
                cn = new MySqlConnection();     //Création d'un nouvel objet cn
                cn.ConnectionString = con_string(false);
                cn.Open();                      // On ouvre la connexion
                cmd = cn.CreateCommand();
                cmd.CommandText = requette;
                cmd.ExecuteNonQuery();  //On exécute la commande sans demande de réponse
                cn.Close();
                return true;
            }
            catch { return false; }
        }
        public DataSet table_lire_search(string table, string filtre, string search)
        {
            cn = new MySqlConnection();     //Création d'un nouvel objet cn
            cn.ConnectionString = con_string(false);
            cn.Open();
            string query = ""; //Declaration d'une variable query de type string pour la requête
            if (filtre.Length == 0)
            {
                if (search.Length != 0) query = "SELECT * FROM " + table + " WHERE Nom = '" + search + "'";
                else query = "SELECT * FROM " + table;
            }
            else query = "SELECT * FROM " + table + " WHERE " + filtre + " = '" + search + "'";
            da = new MySqlDataAdapter(query, cn);
            ds = new DataSet(); // on crée un nouvel objet ds
            da.Fill(ds); // on ajoute da dans le dataset
            cn.Close(); // on se déconnecte de la BDD
            return ds; //On retourne le dataset
        }
        public DataSet table_lire(string requete)//lecture table
        {
            cn = new MySqlConnection();
            cn.ConnectionString = con_string(false);
            cn.Open();
            string query; //Declaration d'une variable query de type string pour la requête
            query = requete;
            da = new MySqlDataAdapter(query, cn);
            ds = new DataSet();//On cree un nouvel objet ds
            da.Fill(ds); //On ajoute da dans le Dataset
            cn.Close(); //On se déconnecte de la bdd
            return ds; // on retourne le dataset
        }
        public bool Table_maj(DataSet ds)//enregistrement dans la base
        {
            try
            {
                combuilder = new MySqlCommandBuilder(da);
                da.Update(ds);//on envoie le dataset ds vers le connecteur de donnés
                combuilder.Dispose();//libération des ressources
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Table_RequetteNonQuery(string requete)
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = con_string(false);//chaine de connexion
                cn.Open();//établissement connexion
                cmd = cn.CreateCommand();
                cmd.CommandText = requete;
                cmd.ExecuteNonQuery();//execution sans retour
                cn.Close();
                return true;
            }
            catch { return false; }
        }
        public string TableRequetteQuery(string Requete)
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = cn_base; //chaine de connexion
                cn.Open();//établissement connexion
                cmd = new MySqlCommand(Requete, cn);
                string data = cmd.ExecuteScalar().ToString();  //exécution avec retour

                cn.Close();
                return data;
            }
            catch { return ""; }
        }
    }
}
