using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {

       

        static void Main(string[] args)
        {
            string choice = "";

            //Ask for the number
            Console.WriteLine("Ight fam I'm thinking of a number between 1 and 20.");
            Console.ReadLine();

            Random rand = new Random();
            rand.Next(1, 20);

            for (int i = 1; i < 20 && i > 20; i++)
            {
                if (i is < rand)
                {
                    Console.WriteLine("Sike. Higher.");
                }
                if (i is > rand)
                {
                    Console.WriteLine("Sike. Lower.");
                }
                if (i is == rand)
                {
                    Console.WriteLine("Sike. Lemme stop. You got it right.");
                }
            }
        }
    }
}
