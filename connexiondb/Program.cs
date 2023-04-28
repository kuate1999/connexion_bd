using MySql.Data.MySqlClient;
using System;

namespace connexiondb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connexion a la base de donnée!");

            //CONECTION DBB
            String cs = @"server=localhost;userid=root;password=;database=tuto";
            using var con = new MySqlConnection(cs);
            con.Open();
            Console.WriteLine("Vous êtes connecté à la BDD");

            //SELECT 
            var stm = "SELECT VERSION()";
            var cmd = new MySqlCommand(stm, con);

            //EXECUTER LA REQUETE 
            var v = cmd.ExecuteScalar().ToString();

            //AFFICHAGE DE LA REQUETE 
            Console.WriteLine($"MySQL version : {v}");

            //INSERER LES INFORMATIONS DANS LA BASE DE DONNEE 




        }
    }
}
