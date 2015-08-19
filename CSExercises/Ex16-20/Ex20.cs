using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int order_discount = 0, order_realprice = 0;

            int tv_price = 900;
            int dvd_price = 500;
            int mp3_price = 700;

            System.Console.WriteLine("Hello Customer! \n Please Enter your Quantity for each TV , DVD, MP3:\t");

            System.Console.Write("Enter quantity for TV:\t");
            int TV_quantity = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter quantity for DVD:\t");
            int DVD_quantity = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter quantity for MP3:\t");
            int MP3_quantity = Convert.ToInt32(Console.ReadLine());

            int TVtotal_price = tv_price * TV_quantity;
            int DVDtotal_price = dvd_price * DVD_quantity;
            int MP3total_price = mp3_price * MP3_quantity;

            int orderamount = TVtotal_price + DVDtotal_price;

            if (orderamount > 0)
            {
                if (orderamount > 5000 && orderamount <= 10000)
                {
                    order_discount = (orderamount * 10) / 100;
                    order_realprice = orderamount - order_discount;
                    System.Console.WriteLine(order_realprice);
                }
                if (orderamount > 10000)
                {
                    order_discount = (orderamount * 15) / 100;
                    order_realprice = orderamount - order_discount;
                    System.Console.WriteLine(order_realprice);
                }
                if (orderamount <= 5000)
                {
                    order_realprice = orderamount;
                }
            }

            int total_orderprice = order_realprice + MP3total_price;
            System.Console.Write("****************************************************************\n\nTotal price for this order is \t" + total_orderprice + "\n\n");


            
        }
    }
}