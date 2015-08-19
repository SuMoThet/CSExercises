using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)

        {
            Console.Write("Enter string : ");
            string s = Convert.ToString(Console.ReadLine());

            Console.Write("\n" + "Enter char value for c1 : ");
            char c1 = Convert.ToChar(Console.ReadLine());

            Console.Write("\n" + "Enter char value for c2 : ");
            char c2 = Convert.ToChar(Console.ReadLine());

            string result = Substitute(s,c1,c2);
            if (result != null)
                Console.WriteLine("\n" + "Substitute c1 with character c2: " + result + "\n");
            else
                Console.WriteLine("\n" + "No Substitute Found!" + "\n" + "\n");
        
        }

        public static string Substitute(string s, char c1, char c2)
        {
            string r;
            if (s.Contains(c1))
            {
              r = s.Replace(c1, c2);
              return r;
            }
           else
              return null;
           
        }
    }
}
