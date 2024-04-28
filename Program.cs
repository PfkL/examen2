using System;

namespace Calculer_Salaire
{
    class Program
    {
        // Méthode principale du programme.
        static void Main(string[] args)
        {
            // Section de déclaration des variables.
            string No_Emp, Message;
            double Taux_Horaire = 0, Salaire = 0, Salaire_Sup = 0;
            int Heures = 0, Heures_Sup = 0;
            bool Valide = true;

            Console.WriteLine();
            // Début de la saisie des informations de l’employé.
            Console.Write("Donnez-moi le numéro de l’employé : ");
            No_Emp = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Donnez-moi le nombre d’heures travaillées pour la semaine : ");
            Heures = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Donnez-moi le taux horaire de l’employé : ");
            Taux_Horaire = Convert.ToDouble(Console.ReadLine());

            // Si le taux horaire de l’employé est supérieur à $25,
            // création du message d’erreur et modification de la valeur de la variable Valide.
            // Affichage du message d’erreur.
            if (Taux_Horaire > 25)
            {
                Message = "Le taux horaire excède $25.00 de l’heure";
                Valide = false;
                Console.WriteLine();
                Console.WriteLine("Pour l’employé no : " + No_Emp);
                Console.WriteLine("Taux horaire saisi : $" + Taux_Horaire + " de l’heure");
                Console.WriteLine("Nombre d’heures saisi : " + Heures + " heures");
                Console.WriteLine("Erreur : " + Message);
            }
            // Si le nombre d’heures travaillés de l’employé est supérieur à 60,
            // création du message d’erreur et modification de la valeur de la variable Valide.
            // Affichage du message d’erreur.
            else if (Heures > 60)
            {
                Message = "Le nombre d’heures excède le maximum de 60 heures pour la semaine";
                Valide = false;
                Console.WriteLine();
                Console.WriteLine("Pour l’employé no : " + No_Emp);
                Console.WriteLine("Taux horaire saisi : $" + Taux_Horaire + " de l’heure");
                Console.WriteLine("Nombre d’heures saisi : " + Heures + " heures");
                Console.WriteLine("Erreur : " + Message);
            }

            // Si la variable Valide vaut toujours vrai, Calcul du salaire de l’employé.
            if (Valide)
            {
                // Si le nombre d’heures est inférieur ou égal à 35,
                // calcul du salaire sans temps supplémentaire.
                if (Heures <= 35)
                {
                    Salaire = Heures * Taux_Horaire;
                }
                // Si le nombre d’heures est supérieur à 35,
                // calcul du salaire incluant le temps supplémentaire.
                else
                {
                    Heures_Sup = Heures - 35;
                    Salaire_Sup = Heures_Sup * Taux_Horaire * 1.5;
                    Salaire = (35 * Taux_Horaire) + Salaire_Sup;
                }
                // Affichage des informations sur le salaire de l’employé.
                Console.WriteLine();
                Console.WriteLine("Pour l’employé no : " + No_Emp);
                Console.WriteLine("Taux horaire saisi : $" + Taux_Horaire + " de l’heure");
                Console.WriteLine("Nombre d’heures saisi : " + Heures + " heures");
                Console.WriteLine("Son salaire pour la semaine est de : $" + Salaire);
            }
            Console.ReadKey();
        }
    }
}