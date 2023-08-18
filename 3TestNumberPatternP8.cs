using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{

    public class NumberPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            NumberPattern num = new NumberPattern();
            //Console.WriteLine();
            //RectanglePattern(r);
            //Console.WriteLine();
            //num.RectanglePattern1(r);
            //Console.WriteLine();
            //num.RectanglePattern2(r);
            //Console.WriteLine();
            //num.RectanglePattern3(r);
            //Console.WriteLine();
            //num.TrianglePattern(r);
            //Console.WriteLine();
            //num.TrianglePattern1(r);
            //Console.WriteLine();
            //num.TrianglePattern2(r);
            //Console.WriteLine();
            //num.TrianglePattern3(r);
            //Console.WriteLine();
            //num.TrianglePattern4(r);
            //Console.WriteLine();
            //num.TrianglePattern5(r);
            //Console.WriteLine();
            //num.TrianglePattern6(r);
            //Console.WriteLine();
            //num.TrianglePattern7(r);
            Console.WriteLine();
            num.TrianglePattern8(r);
            Console.WriteLine();
            num.TrianglePattern9(r);
        }

        /* 1. Write a program to print the rectangle Number pattern.

       11111
       22222
       33333
       44444
       55555
    */
        public static void RectanglePattern(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        /*2. Write a program to print the rectangle Number pattern.

        12345
        12345
        12345
        12345
        12345
    */
        public void RectanglePattern1(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        /* 3. Write a program to print the rectangle Number pattern.

        55555
        44444
        33333
        22222
        11111
    */
        public void RectanglePattern2(int r)
        {
            for (int i = r; i >= 1; i--)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        /* 4. Write a program to print the rectangle Number pattern.

        54321
        54321
        54321
        54321
        54321
    */
        public void RectanglePattern3(int r)
        {
            for (int i = r; i >= 1; i--)
            {
                for (int j = r; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        /*5. Write a Program to print the Half Pyramid Number Pattern.

        1
        22
        333
        4444
        55555
    */
        public void TrianglePattern(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        /* 6. Write a Program to print the Half Pyramid Number Pattern.

1
12
123
1234
12345
    */
        public void TrianglePattern1(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        /* 7. Write a Program to print the Half Pyramid Number Pattern.

11111
2222
333
44
5
    */
        public void TrianglePattern2(int r)
        {
            int l = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j <= l)
                    {
                        Console.Write(i);
                    }
                }
                Console.WriteLine();
                l--;
            }
        }

        /* 8. Write a Program to print the Inverted Half Pyramid Number Pattern.

12345
 1234
  123
   12
    1
    */
        public void TrianglePattern3(int r)
        {
            for (int i = 1; i <= r; i++)
            {
                int k = 1;
                for (int j = 1; j <= r; j++)
                {
                    if (j < i)
                        Console.Write(" ");
                    else
                    {
                        Console.Write(k);
                        k++;
                    }
                }
                Console.WriteLine();
            }
        }

        /* 9. Write a Program to print the Full Pyramid Number Pattern.
      
    1
   222
  33333
 4444444
555555555

    */
        public void TrianglePattern4(int r)
        {
            int c = 2 * r - 1;
            int a = r;
            int b = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j >= a && j <= b)
                        Console.Write(i);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                a--;
                b++;
            }
        }

        /* 10. Write a Program to print the Full Pyramid Number Pattern.
   
    1
   333
  55555
 7777777
999999999

    */
        public void TrianglePattern5(int r)
        {
            int c = 2 * r - 1;
            int a = r;
            int b = r;
            for (int i = 1; i <= r * 2; i = i + 2)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j >= a && j <= b)
                        Console.Write(i);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                a--;
                b++;
            }
        }

        /* 11. Write a Program to print the Full Pyramid Number Pattern.
        
    1
   123
  12345
 1234567
123456789

    */
        public void TrianglePattern6(int r)
        {
            int c = 2 * r - 1;
            int a = r;
            int b = r;
            for (int i = 1; i <= r; i++)
            {
                int l = 1;
                for (int j = 1; j <= c; j++)
                {
                    if (j >= a && j <= b)
                    {
                        Console.Write(l);
                        l++;
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                a--;
                b++;
            }
        }

        /* 12. Write a Program to print the Full Pyramid Number Pattern.
       
    1
   321
  54321
 7654321
987654321

    */
        public void TrianglePattern7(int r)
        {
            int c = 2 * r - 1;
            int a = r;
            int b = r;
            int m = 1;
            for (int i = 1; i <= r; i++)
            {
                int l = m;
                for (int j = 1; j <= c; j++)
                {
                    if (j >= a && j <= b)
                    {
                        Console.Write(l);
                        l--;
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                a--;
                b++;
                m = m + 2;
            }
        }

        /* 13. Write a Program to print the Full Pyramid Number Pattern.

    1 
   2 2
  3 3 3
 4 4 4 4
5 5 5 5 5

    */
        public void TrianglePattern8(int r)
        {
            int c = 2 * r - 1;
            int a = r;
            int b = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (i % 2 == 1)
                    {
                        if (j <= b && j >= a && j % 2 != 0)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j <= b && j >= a && j % 2 == 0)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
                a--;
                b++;
            }
        }

        /* 14. Write a Program to print the Full Inverted Pyramid Number Pattern.

5 5 5 5 5 
 4 4 4 4
  3 3 3
   2 2
    1

    */
        public void TrianglePattern9(int r)
        {
            int c = 2 * r - 1;
            int a = r;
            int b = r;
            for (int i = r; i >= 1; i--)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (i % 2 == 1)
                    {
                        if (j <= b && j >= a && j % 2 != 0)
                        {
                            Console.Write(b);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j <= b && j >= a && j % 2 == 0)
                        {
                            Console.Write(b);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
                a++;
                b--;
            }
        }
    }
}
