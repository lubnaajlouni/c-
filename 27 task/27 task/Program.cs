using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _27_task

{
    class information 
    {
        
        public string name;
        public string gender;
        public int id;
        public int age;
        public string email;
        public string Phone;

        public information(string name1, string gender1, int id1 ,int age1,string email1,string phone1 )
        {
           
            name = name1;
            gender = gender1;
            id= id1;
            age = age1;
            email = email1;
            Phone= phone1;

             
        }

        public void check_phone()
        {
           string s= Phone.Substring(0, 3);
            if(s=="077" || s == "078" || s == "079")
            {
                s = Phone;
            }
            else
            {
                Console.WriteLine("number is not valid");
            }
        }

       public void Age() 
        {
           int m =age;
            if(  m>=18 || m<=60 ) 
            {
                m = age; 
            }
            else 
            {
                Console.WriteLine("age is not valid");
            }

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name ");
            string name1= Console.ReadLine( );

            Console.WriteLine("Enter gender ");
            string gender1 =(Console.ReadLine());

            Console.WriteLine("Enter id");
            int id1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age");
            int  age1  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter email ");
            string email1  = (Console.ReadLine());

            Console.WriteLine("Enter phone ");
            string phone1= (Console.ReadLine());


            information info = new information(name1,gender1,id1,age1,email1,phone1);
            info.Age();
            info.check_phone();
            



        }
    }
}