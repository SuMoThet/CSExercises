using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int returnValue = random.Next(1,9);
            int Guess = 0;

            Console.WriteLine("Guess an integer between 0 and 9");

            while (Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.Read());

                while (Guess < returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + Guess + " .  Can you guess what it is?");
                    Console.ReadLine();

                }
                while (Guess > returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + Guess + " .  Can you guess what it is");
                    Console.ReadLine();
                }
            }
            while (Guess == returnValue)
            {
                Console.WriteLine("Well done! The answer was " + returnValue);
                Console.ReadLine();
            }
        }
    }
}
