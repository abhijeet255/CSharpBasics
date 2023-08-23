using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class AlphabetPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            AlphabetPattern alpha = new AlphabetPattern();
            Console.WriteLine();
            alpha.RectanglePattern(r);
        }
        /* 1. Write a program to print the rectangle alphabet pattern.

AAAAA
BBBBB
CCCCC
DDDDD
EEEEE

  */
        public void RectanglePattern(int r)
        {
            for (int i = 'A'; i < 65 + r; i++)
            {
                for (int j = 'A'; j < 65 + r; j++)
                {
                    Console.Write((char)i);
                }
                Console.WriteLine();
            }
        }
    }
}
