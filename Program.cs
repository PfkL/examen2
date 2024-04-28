using System;

namespace Calcul_Achat
{
    class Program
    {
        // Méthode principale du programme.
        static void Main(string[] args)
        {
            // Section de déclaration des variables.
            char CodeTaxe;
            double Achat;
            double Taxe;
            double Total;
            string NomClient;

            // Début de la saisie des informations pour l’achat d’un client.
            Console.WriteLine();
            Console.Write("Nom du client : ");
            NomClient = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Montant total des achats : ");
            Achat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // Affichage des choix applicables à la taxe de vente.
            Console.WriteLine("**** CodeTaxe de taxe *****");
            Console.WriteLine("* 0 - Aucune taxe *");
            Console.WriteLine("* 1 - Taxe provinciale 4% *");
            Console.WriteLine("* 2 - Taxe fédérale 7% *");
            Console.WriteLine("* 3 - Taxe spéciale 8% *");
            Console.WriteLine("***************************");
            Console.WriteLine();

            // Saisie du code de taxe applicable à l’achat du client.
            Console.Write("Code de la taxe applicable : ");
            CodeTaxe = Convert.ToChar(Console.ReadLine());

            // Calcul de la taxe applicable sur les achats du client
            switch (CodeTaxe)
            {
                case '0':
                    Taxe = 0;
                    break;
                case '1':
                    Taxe = Achat * 0.04;
                    break;
                case '2':
                    Taxe = Achat * 0.07;
                    break;
                default:
                    Taxe = Achat * 0.08;
                    break;
            }

            // Calcul du total des achats, taxes incluses, du client.
            Total = Achat + Taxe;

            Console.WriteLine();
            // Affichage des informations sur l’achat du client.
            Console.WriteLine("Le total des achats de " + NomClient);
            Console.WriteLine("Achat : $" + Achat);
            Console.WriteLine("Taxe : $" + Taxe);
            Console.WriteLine("Total : $" + Total);
            Console.ReadKey();
        }
    }
}