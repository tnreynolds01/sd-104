using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2__Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondPrev = 0;
            int prev = 1;
            int current = 0;
            int userInput;

            Console.WriteLine("Start with 1 and 1 as pervious two numbers and add");
            userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < userInput; i++)
            {
                current = prev + secondPrev;
                secondPrev = prev;
                prev = current;                
            }
            Console.WriteLine(current);
            Console.ReadLine();
        }
    }
}
