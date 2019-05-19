using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Medicaltrack_admin_planning;

namespace prototype_app_chef_infirmier
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = "config.txt";
            bool traiter = false;
            do
            {
                if (File.Exists(path)) //Si le fichier existe
                {
                    StreamReader sr = File.OpenText(path);
                    string s = sr.ReadLine();//On lis la ligne
                    if (s == "1") //Si sa correspond à 1 donc configurer
                    {
                        Application.Run(new F_Acceuil());
                        traiter = true;
                    }
                    else //Sinon 0 donc pas configurer
                    {
                        Application.Run(new F_config());
                    }
                    sr.Close();
                }
                else //Si le fichier existe pas
                {
                    StreamWriter sw = File.CreateText(path);
                    sw.WriteLine("0");
                }
            } while (traiter != true);
        }
    }
}
