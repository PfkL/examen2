using System;

namespace Trier_Caracteres
{
    class Program
    {
        // Méthode principale de l’application
        static void Main(string[] args)
        {
            // Déclaration des variables.
            char Caractere_1 = ' ';
            char Caractere_2 = ' ';
            char Caractere_3 = ' ';
            char Temp = ' ';

            // Saisie des trois caractères par l’utilisateur.
            Console.WriteLine();
            Console.Write("Donnez-moi votre premier caractère : ");
            Caractere_1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Donnez-moi votre deuxième caractère : ");
            Caractere_2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Donnez-moi votre troisième caractère : ");
            Caractere_3 = Convert.ToChar(Console.ReadLine());

            // Changement de l’ordre des caractères si Caractere_1 est plus grand que Caractere_2.
            if (Caractere_1 > Caractere_2)
            {
                Temp = Caractere_1;
                Caractere_1 = Caractere_2;
                Caractere_2 = Temp;
            }
            // Changement de l’ordre des caractères si Caractere_2 est plus grand que Caractere_3.
            if (Caractere_2 > Caractere_3)
            {
                Temp = Caractere_2;
                Caractere_2 = Caractere_3;
                Caractere_3 = Temp;
            }
            // Changement de l’ordre des caractères si Caractere_1 est plus grand que Caractere_2.
            if (Caractere_1 > Caractere_2)
            {
                Temp = Caractere_1;
                Caractere_1 = Caractere_2;
                Caractere_2 = Temp;
            }

            // Affichage des trois caractères mis en ordre.
            Console.WriteLine();
            Console.Write("Vos trois caractères mis en ordre alphabétique sont : "
                + Caractere_1 + ", " + Caractere_2 + ", " + Caractere_3);
            Console.ReadKey();
        }
    }
}