using System;

namespace Condition
{
    class Program
    {
        // Méthode principale de l’application.
        static void Main(string[] args)
        {
            // Déclaration des variables utilisées par l’application.
            int temperature = 0;

            Console.WriteLine();
            // Récupération de la température saisie par l’utilisateur
            Console.Write("Donnez-moi la température actuelle en degré Fahrenheit : ");
            temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Utilisation de l'opérateur ternaire pour afficher un message en fonction de la température
            Console.WriteLine(temperature <= 32 ? "Brrr ! Il fait froid aujourd’hui." :
                              temperature <= 60 ? "C’est mieux que d’être sous le point de congélation." :
                              temperature <= 90 ? "La température est bonne." :
                              "Il commence à faire trop chaud !");
            Console.ReadKey();
        }
    }
}