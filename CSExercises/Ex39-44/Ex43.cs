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

            Console.WriteLine("\n" + "int :" + n + " = hex :" + result + "\n");
            Console.Write("***************************************");
            Console.Write("\n" + "\n" + "all Hex number 1 to 100 : " + "\n");

            string h;
            for (int i = 1; i <= 100; i++)
            {
                h = i.ToString("X");
                Console.Write(h + " ," + "\t");

            }
            Console.WriteLine("\n" + "***************************************" + "\n");

        }     
                       
             

        public static string Hex(int n)
        {
            string hex = "";
            
            while (true)
            {
                if ((n % 16) != 0)
                {
                    if ((n % 16) > 9)
                    {
                        switch (n % 16)
                        {
                            case 10:
                                hex = "A" + hex;
                                break;
                            case 11:
                                hex = "B" + hex;
                                break;
                            case 12:
                                hex = "c" + hex;
                                break;
                            case 13:
                                hex = "D" + hex;
                                break;
                            case 14:
                                hex = "E" + hex;
                                break;
                            case 15:
                                hex = "F" + hex;
                                break;
                        }
                    }
                    else
                        hex = (n % 16).ToString() + hex;
                }
                else
                    hex = "0" + hex;

                n /= 16;
                if (n <= 0)
                    break;
            }
            return hex;
        }
    }
}
