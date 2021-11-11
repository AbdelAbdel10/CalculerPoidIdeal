using System;

namespace CalculerPoidIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            int taille;
            double poid;
            char sexe;

            Console.Write("Enter votre taille en CM : \t  ");
            taille = Int16.Parse(Console.ReadLine());
            Console.Write("Enter votre Sexe : \t  ");
            sexe =Char.Parse(Console.ReadLine());
            if (sexe=='M')
            {
                poid = taille - 100 - ((taille - 150) / 4);
            }
            else
            {
                poid = taille - 100 - ((taille - 150) / 2);
            }

            Console.WriteLine($"votre poid ideal pour  est {poid}");;

            Console.ReadKey();
        }
    }
}
