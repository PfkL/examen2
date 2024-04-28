using System;

namespace Additionner
{
    class Program
    {
        // Méthode principale de l’application.
        static void Main(string[] args)
        {
            // Section de déclaration des variables
            int Nombre_1, Nombre_2, Nombre_3, Total;

            // Saisie du premier nombre.
            Console.Write("Donnez-moi le premier nombre entier : ");
            Nombre_1 = Convert.ToInt32(Console.ReadLine());

            // Saisie du deuxième nombre.
            Console.Write("Donnez-moi le deuxième nombre entier : ");
            Nombre_2 = Convert.ToInt32(Console.ReadLine());

            // Saisie du troisième nombre.
            Console.Write("Donnez-moi le troisième nombre entier : ");
            Nombre_3 = Convert.ToInt32(Console.ReadLine());

            // Opération d’addition.
            Total = Nombre_1 + Nombre_2 + Nombre_3;

            // Affichage du résultat et fin du programme.
            Console.WriteLine(Nombre_1 + " + " + Nombre_2 + " + " + Nombre_3 + " = " + Total);
            Console.ReadKey();
        }
    }
}