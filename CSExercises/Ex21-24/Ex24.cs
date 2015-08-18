using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number for N: ");
            int N = int.Parse(Console.ReadLine());
            int Result = (int)Math.Sqrt(N);
            Console.Write("The square root for N: " + Result);


            Random random = new Random();
            int random_no = random.Next(1,N);
            int Guess = -1;

           

            while (Guess != random_no)
            {
                Console.Write("\n" + "Guess an integer : ");
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess != random_no)
                {
                   
                    int i;
                    for (i = 0; i < 100; i++)
                    {
                        Console.Write("think of the number again: ");
                        Guess = Convert.ToInt32(Console.ReadLine());
                        if (Guess == random_no)
                            break;
                      
                    }
                }
            }
            while (Guess == random_no)
            {
                if (N == Guess * Guess)
                {
                    N = Guess * Guess;
                    Console.Write("G * G = "+ N + "\n");
                }
                else if ( N != Guess * Guess)
                {
                    int temp;
                    temp = N / Guess;
                   Guess= (Guess + temp) / 2;
                   Console.Write(Guess);

                }

            }
        }
    }

}