using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex42
    {
        public static void main(string[] args)

        {
            Console.Write("Enter string for s1: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.Write("Enter string for s2: ");
            string s2 = Convert.ToString(Console.ReadLine());

            int result = FindWord(s1,s2);
            Console.WriteLine("Starting Position of the word s2 in s1 is : " + result);

        
        }
        public static int FindWord(string s1, string s2)
        {
          int  index = s1.IndexOf(s2);
                return index;
        }
    }
}
