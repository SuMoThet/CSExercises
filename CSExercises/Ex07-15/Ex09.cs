using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the value of x = ");
            int x = int.Parse(Console.ReadLine());
            int y = 2 * x * x - 4 * x + 3;
            Console.WriteLine("\n" + "The value of y = " + y + "\n");
        }
    }
}
