using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
           Console.Write("Enter an integer: ");
           int n1 = Convert.ToInt16( Console.ReadLine());
           int n2 = n1 * n1;
            Console.WriteLine("\n" + "The square of " + n1 + " is " + n2 + "\n");
        }
    }
}
