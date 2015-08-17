using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 80 && score <= 100 )
            {
                Console.WriteLine("You scored " + score + " marks which is A grade.");
            }
            else if (score <= 79  || score == 0)
            {
                if (score <= 79 && score>=60)
                {
                    Console.WriteLine("You scored " + score + " marks which is B grade.");
                }

                else
                {
                    if (score <=59 && score>=40)
                    {
                        Console.WriteLine("You scored " + score + " marks which is C grade.");
                    }

                    else
                    {
                        if (score <=39 || score == 0)

                            Console.WriteLine("You scored " + score + " marks which is F grade.");
                    }
                }
            }
            else
            { 
                Console.WriteLine("**Error**");
            
            }

        }
    }
}