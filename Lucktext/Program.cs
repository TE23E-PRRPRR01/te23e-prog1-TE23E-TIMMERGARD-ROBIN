using System;

namespace GissaOrdet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rensa konsolen
            Console.Clear();

            // Fråga användaren efter ett ord
            Console.Write("Gissa ordet: ");
            string gissatOrd = Console.ReadLine();

            // Kolla om ordet är "Johnny"
            if (gissatOrd.Equals("Johnny", StringComparison.OrdinalIgnoreCase))
            {
                // Om ordet är "Johnny", skriv ut "Rätt svar!" i grön text
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rätt svar!");
            }
            else
            {
                // Annars, skriv ut "Fel svar!" i blå text
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Fel svar!");
            }

            // Återställ textfärgen till standard
            Console.ResetColor();
        }
    }
}
