using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter double precision no. = ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Math.Pow(2,n1);
            Console.WriteLine("\n" + "The square of " + n1 + " is " + n2 + "\n");
            
            
        }
    }
}
