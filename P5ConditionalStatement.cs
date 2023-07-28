using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class P5ConditionalStatement
    {
        static void Main(string[] args)
        {
            //if , if... else , if... else if

            Console.WriteLine("Enter Any number");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i > 0)
            {
                Console.WriteLine("Possitive Number");
            }
            else if (i < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Zero");
            }


            Console.Write("Enter any number :");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 0:
                    Console.WriteLine("number is 0");
                    break;
                case 1:
                    Console.WriteLine("number is 1");
                    break;
                case 2:
                    Console.WriteLine("number is 2");
                    break;
                case 3:
                    Console.WriteLine("number is 3");
                    break;
                case 4:
                    Console.WriteLine("number is 4");
                    break;
                default:
                    Console.WriteLine("number is greater than 4");
                    break;
            }

        }
    }
}
