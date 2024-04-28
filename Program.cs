using System;

namespace Condition
{
    class Program
    {
        // Méthode principale de l’application.
        static void Main(string[] args)
        {
            // Déclaration des variables utilisées par l’application.
            string ville = null;

            Console.WriteLine();
            // Affichage du nom de la ville si la variable a été initialisée
            string nomVille = ville ?? "Le nom de la ville est inconnu."; // Utilisation de guillemets droits
            Console.WriteLine(" " + nomVille); // Utilisation de guillemets droits
            Console.ReadKey();
        }
    }
}