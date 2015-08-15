using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter double precision no. = ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = n1 / 2;
            Console.WriteLine("\n" + "The square root of " + n1 + " is " + n2);
            double n3 = Math.Round(n2 * 1000.0) / 1000.0; ;
            Console.WriteLine("\n" + "The rounded to 3 decimal places " + n2 + " is " + n3 + "\n");
        }
    }
}
