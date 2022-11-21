using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_21_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            int y = 18;
            if (x < y)
            {
                Console.WriteLine(x + " smaller than" + y);
            }
            else { Console.WriteLine(x + "bigger than" + y); }


            //task2
            int value =-7;

            if (value < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }



            // task 3

            int a = 0;
            int b = -1;
            int c = 4;
            if (a > b && a > c && b > c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }

            else if (b < a && b < c && c > a)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }

            else
            {
                Console.WriteLine(c + " " + a +" " + b);
            }


            //task 4
            int d = 5;
            int f = 2;
            int g = 5;
            int h = 0;
            int i = 1;
            if (d > f && d > f && d > g && d > h && d > i)
            {
                Console.WriteLine(d);
            }
            else if (f > d && f > g && f > h && f > i)
            {
                Console.WriteLine(f);
            }
            else if (g > d && g > f && g > h && g > i)
            {
                Console.WriteLine(g);
            }
            else if (h > d && h > g && h > f && h > i)
            {
                Console.WriteLine(h);
            }
            else if (i > d && i > g && i > h && i > f)
            {
                Console.WriteLine(i);
            }



            // task 5

            Console.WriteLine("Input kilometers per hour: ");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(num * 1.609344 + "miles per hour");

            //task 6

            Console.WriteLine("iput hours :");
            int hours = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("iput minuts :");
            int minuts = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(hours * 60 + minuts);

            //task 7

            Console.WriteLine("iput minutes :");
            int minutes = Convert.ToInt16(Console.ReadLine());
            int ho = minutes / 60;
            int u = minutes % 60;
            Console.WriteLine(ho +"hours" + " " + u +"minuts");

            //task 8

            string[] mynum = { "lubna", "rzan", " nesreen", "noraan", "rojenaaaa" };
            Console.WriteLine(mynum[0].Substring(0, 4));
            Console.WriteLine(mynum[1].Substring(0, 2));
            Console.WriteLine(mynum[2].Substring(1, 3));
            Console.WriteLine(mynum[3].Substring(0, 4));
            Console.WriteLine(mynum[4].Substring(0, 4));
        }
    }
}
