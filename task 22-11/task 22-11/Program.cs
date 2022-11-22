using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ARR = { 1, 7, 9, 4, 5, };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "the", "the", "the", "the" };


            //task 2

            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[0]);


            //task 3

            String[] Food = { " Fish", "Mango", "Chocolate", "Egge", "meat" };
            String[] sport = { "Football", "Baseball", "Bowling" };
            String[] movie = { "Magpie", "Cargo", " Wasp", "Dream Work" };
            foreach (string i in Food)
            {
                Console.WriteLine(i);
            }

            foreach (string a in sport)
            {
                Console.WriteLine(a);
            }

            foreach (string b in movie)
            {
                Console.WriteLine(b);
            }

            //task 4

            Console.WriteLine("Input three numbers separated by comma:");
            string number = Console.ReadLine();
            string[] num = number.Split(',');
            int[] mynum = new int[3];
            for (int i = 0; i < 3; i++)
            {
                mynum[i] = Convert.ToInt32(num[i]);


            }

            int sum = mynum[0] + mynum[1] + mynum[2];
            Console.WriteLine(sum);








            // task 5

            int nodd = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    nodd += i;
                }
            }

            Console.Write("\n");


            Console.WriteLine("The Sum of odd Numbers is :" + nodd);



            //task 6
            
            for (int i = 0; i < 4; i++)

            {
                for (int y =4; y > i; y--)
                { Console.Write(" "); }

               

                for (int j = 0; j<=i; j++) 
                { Console.Write("*"); }

                Console.Write("\n");

            }


            //task 7 
            int n= 1;
            for (int i = 0; i < 4; i++)

            {
                for (int y =4; y >i; y--)
                {
                  
                    Console.Write(" ");
                }


                for (int j = 0; j <=i; j++)
                {
                    Console.Write( n+" ");
                    n++;

                }

                Console.WriteLine("");

            }





        }
    }
}
            




