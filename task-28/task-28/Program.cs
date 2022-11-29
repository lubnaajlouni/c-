using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace task_28
{
    class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public int Pallet_No { get; set; }
        public string Color { get; set; }

        public Car(string make, int year, string type, double price, string model, int pallet_No, string color)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            Pallet_No = pallet_No;
            Color = color;
        }

        public Car() { }

        public void start()
        {
            Console.WriteLine("start engine");
        }

        public void stop()
        {
            Console.WriteLine("stop engine");
        }

        public void testcar()
        {

            Console.WriteLine("car make :" + Make);
            Console.WriteLine("car year :" + Year);
            Console.WriteLine("car type :" + Type);
            Console.WriteLine("car price :" + Price);
            Console.WriteLine("car model :" + Model);
            Console.WriteLine("car pallet-no :" + Pallet_No);
            Console.WriteLine("car color :" + Color);
        }






    }
    class honda : Car 
    {
        string driver;
        public honda(string driverr,string make, int year, string type, double price, string model, int pallet_No, string color) :base( make, year,  type,  price, model,pallet_No, color)
        {
             driver = driverr;
        }
        public void testcar1()
        {
            Console.WriteLine("car driver :" + driver);
        }
    }



        internal class Program
        {
            static void Main(string[] args)
            {
                 Car c= new Car("china", 2020, "honda", 50000, "honda", 0222, "whith");
                 c.testcar();
                  c.start();
                  honda h = new honda("ali", "china", 2020, "honda", 50000, "honda", 0222, "whith");
                    h.testcar();
                    h.testcar1();
            }
        }
    
}
