using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number between 1 and 25: ");
            int n = int.Parse(Console.ReadLine());
            double r = SQT(n);
            Console.WriteLine("\n" + "Square Root of " + n + " is: " + r + "\n");
        }

        public static double SQT(int y)
        {
            int result;
            result = (int)Math.Sqrt(y);
            return result;
        }
    }
}
