using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter salary amount : ");
            int salary = int.Parse(Console.ReadLine());
            int house = salary * 10 / 100;
            Console.WriteLine("\n" + "10% housing allowance : " + house);
            int transport = transport = salary * 3 / 100;
            Console.WriteLine("\n" + "3% transport allowance : " + transport);
            int total = salary + house + transport;
            string T = String.Format(" Total: {0:C}", total); 
            Console.WriteLine("\n" + "The total income :" + T + "\n");
        }
    }
}
