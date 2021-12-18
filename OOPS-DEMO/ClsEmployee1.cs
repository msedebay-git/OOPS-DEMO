using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_DEMO
{
    class ClsEmployee1
    {
        string make;
        string model;
        string color;
        int year;

        public void GetCarData()
        {
            Console.WriteLine("Enter Car Details:");
            Console.Write("Make: ");
            this.make = Console.ReadLine();
            Console.Write("Model: ");
            this.model = Console.ReadLine();
            Console.Write("Color: ");
            this.color = Console.ReadLine();
            Console.Write("Year: ");
            this.year = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayCarData()
        {
            Console.WriteLine("Car Details are:");
            Console.WriteLine("Car make is: " + this.make);
            Console.WriteLine("Car model is: " + this.model);
            Console.WriteLine("Car color is: " + this.color);
            Console.WriteLine("Car year is: " + this.year);
        }
        static void Main(string[] args)
        {
            ClsEmployee1 obj1 = new ClsEmployee1();
            obj1.GetCarData();
            obj1.DisplayCarData();
            Console.Read();
        }
    }
}
