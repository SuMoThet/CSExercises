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
            int count = 0;
            int returnValue = random.Next(0,9);
            int Guess = -1;

            Console.WriteLine("Guess an integer between 0 and 9");

            while (Guess != returnValue)
            {
                Console.Write("Enter a number : ");
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess != returnValue)
                {
                    ++count;
                    int i;
                    for (i = 0; i < 100; i++)
                    {
                        Console.Write("think of the number again: ");
                        Guess = Convert.ToInt32(Console.ReadLine());
                        if (Guess == returnValue)
                            break;
                        ++count;

                    }
                }
            }
            while (Guess == returnValue)
            {
                Console.WriteLine("\n"+ "Congratulations! The answer is " + returnValue);
               
                Console.WriteLine("Your attempt times is " + ++count + "\n");
                break;
            }
           
        }
    }

    

}
