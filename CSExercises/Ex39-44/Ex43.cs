using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)

        {
            Console.Write("Enter integer: ");
            int n = int.Parse(Console.ReadLine());

            string result = Hex(n);
            
            Console.WriteLine("\n" + "int :" +n+" = hex :"+ result + "\n");
            Console.Write("***************************************");
            Console.Write("\n" + "\n"+ "all Hex number 1 to 100 : " + "\n");

            string h;
            for (int i = 1; i <= 100; i++)
            {
                h = i.ToString("X");
                Console.Write(h+ " ," + "\t");
            
            }
            Console.WriteLine("\n" + "***************************************"+"\n");

        }
        public static string Hex(int i)
        {
            string hex = i.ToString("X");
            return hex;
        }
    }
}
