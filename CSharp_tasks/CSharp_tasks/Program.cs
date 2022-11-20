using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine(); 
          
            Console.WriteLine(item);

            // task 2


            int myNum = 15;
            Console.WriteLine(myNum);

            Double num = 5.99;
            Console.WriteLine(num);

            string name = "John";
            Console.WriteLine(name);

            char ch = 'j';
            Console.WriteLine(ch);

            bool mybool = true;
            Console.WriteLine(mybool);

            const int myconst = 15;
            myNum = 20;
            Console.WriteLine(myconst);


            //task 3


            string[] cars = { "Volvo", "BMW", "Ford", };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars.Length);



            //task 4
            Console.WriteLine("tInput your firstname: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("tInput your lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("yearbirth: ");
           string yearbirth = Console.ReadLine();


            // task 5 
            int[] testdata = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(testdata[0]);
            Console.WriteLine(testdata[1]);
            Console.WriteLine(testdata[2]);
            Console.WriteLine(testdata[3]);
            Console.WriteLine(testdata[4]);
            Console.WriteLine(testdata[5]);
            Console.WriteLine(testdata[6]);
            Console.WriteLine(testdata[7]);
            Console.WriteLine(testdata[8]);
            Console.WriteLine(testdata[9]);
            Console.WriteLine(testdata[10]);

            // task 6

            int[] test = { 1, 2, 3};
            int x = test[0] + test[1] + test[2];
            Console.WriteLine(x);
        }
    }
}













