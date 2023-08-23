using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class DigitalNumber0_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            DigitalNumber0_10 digit = new DigitalNumber0_10();
            Console.WriteLine();
            digit.Digit0(r);
            Console.WriteLine();
            digit.Digit1(r);
            Console.WriteLine();
            digit.Digit2(r);
            Console.WriteLine();
            digit.Digit3(r);
            Console.WriteLine();
            digit.Digit4(r);
            Console.WriteLine();
            digit.Digit5(r);
            Console.WriteLine();
            digit.Digit6(r);
            Console.WriteLine();
            digit.Digit7(r);
            Console.WriteLine();
            digit.Digit8(r);
            Console.WriteLine();
            digit.Digit9(r);
            Console.WriteLine();
            digit.Digit10(r);
        }

        //  0
        public void Digit0(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (i == 1 || i == r || j == 1 || j == r)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  1
        public void Digit1(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == r)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  2
        public void Digit2(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (i == 1 || i == r || i == r / 2 + 1 || (i <= r / 2 && j == r) || (i > r / 2 && j == 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  3
        public void Digit3(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (i == 1 || i == r || j == r || i == r / 2 + 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  4
        public void Digit4(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if ((j == 1 && i <= r / 2) || j == r || i == r / 2 + 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  5
        public void Digit5(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (i == 1 || i == r || i == r / 2 + 1 || (i <= r / 2 && j == 1) || (i > r / 2 && j == r))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  6
        public void Digit6(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (i == 1 || i == r || i == r / 2 + 1 || j == 1 || (i > r / 2 && j == r))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  7
        public void Digit7(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (i == 1 || j == r)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  8
        public void Digit8(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (i == 1 || i == r || i == r / 2 + 1 || j == 1 || j == r)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  9
        public void Digit9(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (i == 1 || i == r || i == r / 2 + 1 || j == r || (i <= r / 2 && j == 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  10
        public void Digit10(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == 1 || (j >= 3 && (i == 1 || i == r || j == 3 || j == r)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
