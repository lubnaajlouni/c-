using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace task_29
{
    class Employee
    {
        public string Employeename { get; set; }
        public int birth { get; set; }
        public int id { get; set; }

        public Employee(string Employeename1, int birth1, int id1)
        {
            Employeename = Employeename1;
            birth = birth1;
            id = id1;

        }

        public void age(int a, int b, int c)
        {
            var birthday = new DateTime(a, b, c);
            int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
            Console.WriteLine(age);
        }

        public void age()
        {
            var birthday = new DateTime(1999,3,14);
            int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
            Console.WriteLine(age);
        }


        public virtual void lubna()
        { Console.WriteLine("lubna");
        }

        public void info() 
        
        {
            Console.WriteLine("Employeename:" + Employeename);
            Console.WriteLine("birth: " + birth);
            Console.WriteLine("id :" +id);
        }


    }
        class manger : Employee
        {

        public manger(string Employeename, int birth, int id) : base(Employeename, birth, id)
        {
            

         }

        public  override void lubna()
        {
            Console.WriteLine("lubna ajlouni");
        }

    }

        




        internal class Program
        {
            static void Main(string[] args)
            {
            Employee m = new manger("lubna",1,123);
            Console.WriteLine();
            m.lubna();
            m.age();
            m.age(2000,11,3);
            m.info();

        }
        }
   
}
