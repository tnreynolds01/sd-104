using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {//variable declaration
            string strPlayerName;
            int nHits, nAtBats;
            double dblBattingAverage;
            //prompt for name and receive
            Console.WriteLine("~This program calculates a baseball player's batting average~");
            Console.WriteLine("<-----------------------------------------------------------");
            Console.WriteLine("");//we will learn other ways to do this in onsole programs
            Console.WriteLine("Enter the player's name");
            strPlayerName = Console.ReadLine();
            //prompt for hits, walks and at bats
            Console.WriteLine("Enter the player's # of at bats:");
            nHits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the player's # of at bats:");
            nAtBats = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblBattingAverage = nHits / nAtBats;

            Console.WriteLine("Enter the player's # of at bats:");
            nAtBats = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblBattingAverage = nHits / nAtBats;

            Console.WriteLine(strPlayerName + "'s batting average is" + dblBattingAverage);
            Console.ReadLine();
        }
            
    }
}
