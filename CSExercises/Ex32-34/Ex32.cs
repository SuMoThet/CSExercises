using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            {
                int[] sale = new Int32[12];
                double total_sales = 0;
                double avg_sales = 0;
                int temp_max = 0;
                int temp_min = -1;

                for (int i = 0; i < sale.Length; i++)
                {
                    Console.Write("Enter sales for month " + i + ": ");
                    sale[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < sale.Length; i++)
                {
                    for (int j = sale.Length - 1; j >= 0; j--)
                    {

                        if (sale[i] > sale[j])
                        {
                            if (temp_max == 0)
                            {
                                temp_max = sale[i];
                            }
                            else if (temp_max < sale[i])
                            {
                                temp_max = sale[i];
                            }

                        }
                    }
                }

                Console.WriteLine("\n" + "Maximum sales:\t" + temp_max);

                for (int i = 0; i < sale.Length; i++)
                {
                    for (int j = sale.Length - 1; j >= 0; j--)
                    {

                        if (sale[i] < sale[j])
                        {
                            if (temp_min == -1)
                            {
                                temp_min = sale[i];
                            }
                            else if (temp_min > sale[i])
                            {
                                temp_min = sale[i];
                            }


                        }
                    }
                }
                Console.WriteLine("Manimum sales: " + temp_min);

                for (int j = 0; j < sale.Length; j++)
                {
                    total_sales += sale[j];
                    avg_sales = Math.Round(total_sales / sale.Length);
                }
                Console.WriteLine("Average Sales For the year: " + avg_sales + "\n");
            }
        }
    }
}
