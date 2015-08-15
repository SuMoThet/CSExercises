using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter temperature in Centigrade scale : ");
            float C = float.Parse(Console.ReadLine());
            double F = 1.8 * C + 32;
            Console.WriteLine("\n" + "Fahrenheit scale : " + F + "\n");
        }
    }
}
