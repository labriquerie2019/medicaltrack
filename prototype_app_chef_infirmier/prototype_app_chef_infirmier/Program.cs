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
            string Chemin = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Medical_admin";
            string path = @"\config.txt";
        bool traiter = false;
            do
            {
                if (File.Exists(Chemin + path)) //Si le fichier text existe
                {
                    StreamReader sr = File.OpenText(Chemin + path);
                    string s = sr.ReadLine();//On lis la ligne
                    if (s == "1") //Si sa correspond à 1 donc configurer
                    {
                        Application.Run(new F_Acceuil());
                        traiter = true;
                        sr.Close();
                    }
                    else //Sinon 0 donc pas configurer
                    {
                        sr.Close();
                        Application.Run(new F_config());
                    }
                }
                else //Si le fichier existe pas
                {
                    Directory.CreateDirectory(Chemin);
                    StreamWriter sw = File.CreateText(Chemin + path);
                    sw.WriteLine("0");
                    sw.Close();
                }
            } while (traiter != true);
        }
    }
}
