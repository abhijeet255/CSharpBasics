using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class DigitalAlphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            DigitalAlphabet digital = new DigitalAlphabet();
            Console.WriteLine();
            digital.Digital_A(r);
            Console.WriteLine();
            digital.Digital_B(r);
            Console.WriteLine();
            digital.Digital_C(r);
            Console.WriteLine();
            digital.Digital_D(r);
            Console.WriteLine();
            digital.Digital_E(r);
            Console.WriteLine();
            digital.Digital_F(r);
            Console.WriteLine();
            digital.Digital_G(r);
        }

        //  A
        public void Digital_A(int r)
        {
            /*int c = 2 * r + 1;
            int a = r;
            int b = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j == a || j == b || ((i == r / 2 + 1) && j >= a && j <= b))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                a--;
                b++;
            }
            Console.WriteLine();*/
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == 1 || j == r || i == 1 || i == r / 2 + 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  B
        public void Digital_B(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == 1 || j == r || i == 1 || i == r || i == r / 2 + 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  C
        public void Digital_C(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == 1 || i == 1 || i == r)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  D
        public void Digital_D(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == 2 || i == 1 || i == r || j == r)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  E
        public void Digital_E(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == 1 || i == 1 || i == r || i == r / 2 + 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  F
        public void Digital_F(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == 1 || i == 1 || i == r / 2 + 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //  G
        public void Digital_G(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == 1 || i == 1 || i == r || (j == r && i > r / 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
