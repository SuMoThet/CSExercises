using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter string s1:  ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.Write("\n" + "Enter string s2:  ");
            string s2 = Convert.ToString(Console.ReadLine());

            
            bool r = InString(s1,s2);
            Console.WriteLine("\n" + r + "\n");
        }

        public static bool InString(string s1, string s2)
        {

            if (s1.Contains(s2))
                return true;
            else
                return false;
               
        }
    }
}
