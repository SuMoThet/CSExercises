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
            int n, result;
            Console.Write("enter an integer: ");
            n = Convert.ToInt16( Console.ReadLine());
            result = n * n;
            Console.WriteLine("The square of "+n+ " is " + result);
        }
    }
}
