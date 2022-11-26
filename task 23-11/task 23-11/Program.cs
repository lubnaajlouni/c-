using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task_23_11
{
    internal class Program
    {
        static void task1()
        {

            int[] num = new int[10];
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"input number: {i}");
                int x = Convert.ToInt32(Console.ReadLine());
                sum = sum + x;
            }
            Console.WriteLine($"The sum of 10 numbers is :{sum}");
            int avg = sum / 10;
            Console.WriteLine($"The avg of 10 numbers is : {avg}");
        }

        static void task2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Input number  : {i}");
                string a = Console.ReadLine();
                int x = i * i * i;
                Console.WriteLine($" the Number is :  {i} and cube of the {i} is :{x}");
            }
        }

        static void getyears(int[] year)
        {

            for (int i = 0; i < year.Length; i++)
            {
                if (year[i] > 1950)
                {
                    Console.WriteLine(year[i]);

                }
            }

        }


        static void task4()
        {
            Console.WriteLine("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            int num = age * 365;
            Console.WriteLine($"your age in days:{num}");
        }


        static int task5(int x, int a, int y)
        {
            Console.WriteLine($"input how many chickens :");
            int chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"input how many cows  :");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"input how many pigs  :");
            int pigs = Convert.ToInt32(Console.ReadLine());
            int sumlege = x * 2 + a * 4 + y * 4;
            return sumlege;
        }


        static void task6(string username, string password)
        {
            string[] usern = { "lubna", "sura", "roaa", "osama" };
            string[] pass = { "2468", "1345", "0123", "1234" };
            for (int i = 1; i <= 3; i++)
            {
                if (password == pass[i] && username == usern[i])
                {
                    Console.WriteLine("pass");
                }

                else
                {
                    Console.WriteLine("failed");
                }
            }
        }


        static int task7(int x, int y)
        {

            int consst = x;
            if (y == 0) return 1;
            else if (y == 1) return consst;
            else
            {
                for (int i = 1; i < y; i++) { x = x * consst; }
                return x;
            }

        }


        static void task8(int year)
        {


            if (year >= 1900 && year <= 2024)
            {

                if (year == 1900)
                {
                    Console.WriteLine(" this year is not leap year.");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine(" this year is leap year.");
                }

                else
                {
                    Console.WriteLine(" this year is not leap year.");
                }


            }
        }

        static string task9()
        {
            Console.Write("Enter the Number to check Prime: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return "not prime";
                }
            }
            return "prime";
        }

        static void task10()
        {
            Console.WriteLine(" write sentance:");
            string snt = Console.ReadLine();
            string[] array = snt.Split(' ');
            Console.WriteLine("the number of words is :" + array.Length);
        }




        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            task1();

            Console.WriteLine("task2");
            task2();

            Console.WriteLine("task3");
            int[] year = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            getyears(year);

            Console.WriteLine("task4");
            task4();

            Console.WriteLine("task5");
            Console.WriteLine("total legs :" + task5(1, 3, 5));

            Console.WriteLine("task6");
            task6("sura", "1345");

            Console.WriteLine("task7");
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the cub of this number:" + task7(a, b));



            Console.WriteLine("task8");
            Console.WriteLine("input year:");
            int y = Convert.ToInt32(Console.ReadLine());
            task8(y);

            Console.WriteLine("task9");
            task9();

            Console.WriteLine("task10");
            task10();

        }

    }
}




