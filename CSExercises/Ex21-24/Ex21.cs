using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int i=0;
            while(i < 88)
            {
                Console.Write("enter integer number : " + "\n");
                i =int.Parse( Console.ReadLine());
                
            }
            Console.WriteLine("Lucky you....");
        }
    }
}
