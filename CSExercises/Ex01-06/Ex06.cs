using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter integer value : ");
            int n = int.Parse(Console.ReadLine());
            

            int n2 = (int)Math.Sqrt(n);
            Console.WriteLine("\n" + "The square root is: " + n2 + "\n");
        }
    }
}
