using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_DEMO
{
    class ClsContruct_param
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public ClsContruct_param(int Id,string s1, string s2, int Age) //parameterize constructoe
        {
            this.Empid = Id;
            this.Ename = s1;
            this.Eaddress = s2;
            this.Eage = Age;
        }

        public ClsContruct_param()
        {
            this.Empid = 1234;
            this.Ename = "John";
            this.Eaddress = "Talisman Lane";
            this.Eage = 22;
        }

        public ClsContruct_param(int Id, string s1) //parameterize constructoe
        {
            this.Empid = Id;
            this.Ename = s1;
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
    class ClsParameter
    {
        static void Main(string[] args)
        {
            ClsContruct_param obj1 = new ClsContruct_param(101, "Mohammed", "7177 Talisman Lane", 34);
            ClsContruct_param obj2 = new ClsContruct_param(102, "James", "Doe Community, Monrovia", 29);

            ClsContruct_param obj3 = new ClsContruct_param();

            ClsContruct_param obj4 = new ClsContruct_param(4657, "Kelly");
            obj1.DisplayEmpData();
            obj2.DisplayEmpData();
            obj3.DisplayEmpData();
            obj4.DisplayEmpData();
            Console.Read();
        }
    }
    

}
