using System;

namespace CalculTemperature
{
    class Program
    {
        // Module principal du programme
        static void Main(string[] args)
        {
            // Déclaration des variables.
            int Temperature_Max, Temperature_Min;
            double Temperature_Moyenne;

            // Affichage du message : "Donnez-moi la température maximale de la journée :" à l’écran.
            Console.Write("Donnez-moi la température maximale de la journée : ");

            // Saisi de la température maximale de la journée et enregistrement dans la variable.
            Temperature_Max = Convert.ToInt32(Console.ReadLine());

            // Répétition pour la température minimale de la journée.
            Console.Write("Donnez-moi la température minimale de la journée : ");
            Temperature_Min = Convert.ToInt32(Console.ReadLine());

            // Opération de calcul de la température moyenne de la journée.
            // Le résultat est enregistré dans la variable Temperature_Moyenne.
            Temperature_Moyenne = (Temperature_Max + Temperature_Min) / 2;

            // Affichage du résultat de l’opération à l’écran.
            Console.WriteLine("La température moyenne de la journée a été de : " + Temperature_Moyenne);
            Console.ReadKey();
        }
    }
}