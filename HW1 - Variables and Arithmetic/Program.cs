using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1___Variables_and_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {//variable declaration
            
            int nNum1, nNum2;
            double dblAnswer;

            //prompt for num1, and num2
            Console.WriteLine("Enter the a number :");
            nNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number :");
            nNum2 = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblAnswer = (double)nNum1 / nNum2;
            Console.WriteLine(nNum1+" / "+nNum2+" = "+dblAnswer);
            dblAnswer = nNum1 + nNum2;
            Console.WriteLine(nNum1 + " + " + nNum2 + " = " + dblAnswer);
            dblAnswer = nNum1 - nNum2;
            Console.WriteLine(nNum1 + " - " + nNum2 + " = " + dblAnswer);
            dblAnswer = nNum1 * nNum2;
            Console.WriteLine(nNum1 + " * " + nNum2 + " = " + dblAnswer);

            Console.ReadLine();
          
        }
    }
}
