using System;

namespace CalculSuperficieGazon
{
    class Program
    {
        // Module principal de l’application.
        static void Main(string[] args)
        {
            // Déclaration des variables et de la constante.
            int Longueur_terrain, Largeur_terrain, Longueur_maison, Largeur_maison, Longueur_entree,
                Largeur_entree, Superficie_terrain, Superficie_maison, Superficie_entree,
                Superficie_gazon, Temps_requis;
            const int Taux_de_coupe = 2;

            // Affichage de messages demandant les dimensions du terrain, de la maison et de l’entrée pavée.
            Console.Write("Quelle est la longueur du terrain ? ");
            Longueur_terrain = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quelle est la largeur du terrain ? ");
            Largeur_terrain = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quelle est la longueur de la maison ? ");
            Longueur_maison = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quelle est la largeur de la maison ? ");
            Largeur_maison = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quelle est la longueur de l’entrée ? ");
            Longueur_entree = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quelle est la largeur de l’entrée ? ");
            Largeur_entree = Convert.ToInt32(Console.ReadLine());

            // Calcul de la superficie du terrain.
            Superficie_terrain = Longueur_terrain * Largeur_terrain;

            // Calcul de la superficie de la maison.
            Superficie_maison = Longueur_maison * Largeur_maison;

            // Calcul de la superficie de l’entrée pavée.
            Superficie_entree = Longueur_entree * Largeur_entree;

            // Calcul de la superficie du gazon.
            Superficie_gazon = Superficie_terrain - (Superficie_maison + Superficie_entree);

            // Calcul du temps requis pour tondre la superficie du gazon.
            Temps_requis = Superficie_gazon / Taux_de_coupe;

            // Affichage du résultat du temps requis pour tondre le gazon.
            Console.WriteLine("Il vous faudra " + Temps_requis + " minutes pour tondre votre gazon.");
            Console.ReadKey();
        }
    }
}