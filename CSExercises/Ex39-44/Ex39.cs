using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {

        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            long r = Factorial(n);
            Console.WriteLine("\n" + n + "! = " + r + "\n");
        
        
        }
        public static long Factorial(long n)
        {
            int t, result;
            result = 1;
            for (t = 1; t <= n; t++)
                result *= t;
            return result;
        }
    }
}
