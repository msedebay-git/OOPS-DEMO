using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_DEMO
{
    class ClsEmployee1
    {
        //string make;
        //string model;
        //string color;
        //int year;

        //when the fields are static, no need to create object (obj) for the class
        static string make;
        static string model;
        static string color;
        static int year;

        static void GetCarData()
        {
            //Console.WriteLine("Enter Car Details:");
            //Console.Write("Make: ");
            //this.make = Console.ReadLine();
            //Console.Write("Model: ");
            //this.model = Console.ReadLine();
            //Console.Write("Color: ");
            //this.color = Console.ReadLine();
            //Console.Write("Year: ");
            //this.year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Car Details:");
            Console.Write("Make: ");
            make = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Color: ");
            color = Console.ReadLine();
            Console.Write("Year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }
        static void DisplayCarData()
        {
            //Console.WriteLine("Car Details are:");
            //Console.WriteLine("Car make is: " + this.make);
            //Console.WriteLine("Car model is: " + this.model);
            //Console.WriteLine("Car color is: " + this.color);  
            //Console.WriteLine("Car year is: " + this.year);

            Console.WriteLine("Car Details are:");
            Console.WriteLine("Car make is: " + make);
            Console.WriteLine("Car model is: " + model);
            Console.WriteLine("Car color is: " + color);
            Console.WriteLine("Car year is: " + year);
        }
        static void Main(string[] args)
        {
            //ClsEmployee1 obj1 = new ClsEmployee1();
            //obj1.GetCarData();
            //obj1.DisplayCarData();

            GetCarData();
            DisplayCarData();
            Console.Read();
        }
    }
}
