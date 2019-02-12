using ReusableLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLast
{
   

    class Program
    {
  

        public delegate void Dcaller(int Rollno, string EmployeeName);
        static void Main(string[] args)
        {
            //Dcaller dcaller = new Dcaller(PrintInformation);
            //dcaller.Invoke(100, "saillesh");
            PrintInformation(100, "saillesh");
        }

        public static void PrintInformation(int Rollno, string EmployeeName)
        {
            Console.WriteLine("The Roll no of {0} is {1}", EmployeeName, Rollno);
            Console.ReadLine();
        }


    }
}
