using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_DEMO
{
    class ClsContructor
    {
        int Empid;       
        string Ename;    
        string Eaddress; 
        int Eage;

        // constructor
        public ClsContructor()
        {
            this.Empid = 1234;
            this.Ename = "Mohammed";
            this.Eaddress = "7177 Talisman Lane";
            this.Eage = 35;
        }

        //method get
        public void GetEmpData()
        {
            Console.WriteLine("Enter Employee Info:");
            this.Empid = int.Parse(Console.ReadLine());
            this.Ename = Console.ReadLine();
            this.Eaddress = Console.ReadLine();
            this.Eage = int.Parse(Console.ReadLine());
        }

        public void DisplayEmpData() //Display method
        {
            Console.WriteLine("Employee Details are:");
            Console.WriteLine("Employee id is: " + this.Empid);
            Console.WriteLine("Employee name is: " + this.Ename);
            Console.WriteLine("Employee address is: " + this.Eaddress);
            Console.WriteLine("Employee age is: " + this.Eage);
        }
    }

    class ClsUDConstructor //main method
    {
        static void Main(string[] args)
        {
            ClsContructor obj1 = new ClsContructor();
            ClsContructor obj2 = new ClsContructor();
            obj1.DisplayEmpData();
            obj2.DisplayEmpData();
            Console.Read();

        }
    }
}
