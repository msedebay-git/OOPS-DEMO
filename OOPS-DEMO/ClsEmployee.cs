using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_DEMO
{
    class ClsEmployee
    {
        // Class member
        int Empid;       //Field
        string Ename;    //Field
        string Eaddress; //Field
        int Eage;        //Field

        public void GetEmpData()
        {
            Console.WriteLine("Enter Employee Info:");
            this.Empid = int.Parse(Console.ReadLine());
            this.Ename = Console.ReadLine();
            this.Eaddress = Console.ReadLine();
            this.Eage = int.Parse(Console.ReadLine());
        }
        public void DisplayEmpData()
        {
            Console.WriteLine("Employee Details are:");
            Console.WriteLine("Employee id is: " + this.Empid);
            Console.WriteLine("Employee name is: " + this.Ename);
            Console.WriteLine("Employee address is: " + this.Eaddress);
            Console.WriteLine("Employee age is: " + this.Eage);
        }
    }
    class ClsAccess
    {
        static void Main(string[] args)
        {
            ClsEmployee obj1 = new ClsEmployee();
            ClsEmployee obj2 = new ClsEmployee();
            obj1.GetEmpData(); //member access operator
            obj2.GetEmpData();
            obj1.DisplayEmpData();
            obj2.DisplayEmpData();
            Console.Read();
        }


    }
}
