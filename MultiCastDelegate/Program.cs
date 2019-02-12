using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
   
    class Program
    {
        delegate void Dcalculate(int num1, int num2, int num3);

        static void Main(string[] args)
        {
            //IS there any use of doing this when i can directly call my methods
            Dcalculate calculuate = new Dcalculate(Sum);
            calculuate.Invoke(1, 2, 3);
            calculuate = new Dcalculate(Multiply);
            calculuate.Invoke(1, 5, 3);

            Console.WriteLine("Without Delegate");
            Sum(1, 2, 3);
            Multiply(1, 5, 3);

          //Answer is Callback Callback
          //Delegate is a manager which delegates and say call me or inform when this is done

        }


        public static void Sum(int firstNum,int secondNum,int thirdNum)
        {

            Console.WriteLine(firstNum+secondNum+thirdNum);
        }

        public static void Multiply(int firstNum, int secondNum, int thirdNum)
        {
            Console.WriteLine(firstNum * secondNum * thirdNum);
        }
    }
}
