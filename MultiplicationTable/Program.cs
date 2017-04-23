using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will print out a mulitplication Table 12 x 12
            for (int j = 0; j <= 12; j++)
            {
                for (int i = 0; i <= 12; i++)
                {
                    Console.Write(" " + j * i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
