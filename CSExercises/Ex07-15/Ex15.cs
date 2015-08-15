using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int n, remainder, sum = 0;
            Console.Write("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }
            if (sum == n)
            {
                Console.Write("Entered number is an Armstrong number.");
            }
            else
                Console.Write("Entered number is not an Armstrong number.");
            Console.ReadLine();
        }
    }
}