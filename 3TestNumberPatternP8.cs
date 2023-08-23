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
            Console.WriteLine();
            RectanglePattern(r);
            Console.WriteLine();
            num.RectanglePattern1(r);
            Console.WriteLine();
            num.RectanglePattern2(r);
            Console.WriteLine();
            num.RectanglePattern3(r);
            Console.WriteLine();
            num.TrianglePattern(r);
            Console.WriteLine();
            num.TrianglePattern1(r);
            Console.WriteLine();
            num.TrianglePattern2(r);
            Console.WriteLine();
            num.TrianglePattern3(r);
            Console.WriteLine();
            num.TrianglePattern4(r);
            Console.WriteLine();
            num.TrianglePattern5(r);
            Console.WriteLine();
            num.TrianglePattern6(r);
            Console.WriteLine();
            num.TrianglePattern7(r);
            Console.WriteLine();
            num.TrianglePattern8(r);
            Console.WriteLine();
            num.TrianglePattern9(r);
            Console.WriteLine();
            num.TrianglePattern10(r);
            Console.WriteLine();
            num.TrianglePattern11(r);
            Console.WriteLine();
            num.TrianglePattern12(r);
            Console.WriteLine();
            num.TrianglePattern13(r);
            Console.WriteLine();
            num.TrianglePattern14(r);
            Console.WriteLine();
            num.RectanglePattern4(r);
            Console.WriteLine();
            num.XPattern(r);
            Console.WriteLine();
            num.TrianglePattern15(r);
            Console.WriteLine();
            num.TrianglePattern16(r);
            Console.WriteLine();
            num.TrianglePattern17(r);
            Console.WriteLine();
            num.TrianglePattern18(r);
            Console.WriteLine();
            num.DemoArray();
            Console.WriteLine();
            num.BubbleSort();
            Console.WriteLine();
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
            int a = 1;
            int b = c;
            for (int i = r; i >= 1; i--)
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
                a++;
                b--;
            }
        }

        /* 15. Write a Program to print the Solid Diamond Number Pattern.

    1 
   2 2
  3 3 3
 4 4 4 4
5 5 5 5 5
 4 4 4 4
  3 3 3
   2 2
    1

    */
        public void TrianglePattern10(int r)
        {
            int c = r;
            int a = r / 2 + 1;
            int b = r / 2 + 1;
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
                if (i < r / 2 + 1)
                {
                    a--;
                    b++;
                }
                else
                {
                    a++;
                    b--;
                }
            }
        }

        /* 16. Write a Program to Print the Inverted V Number Pattern.

    1     
   2 2
  3   3
 4     4
5       5

    */
        public void TrianglePattern11(int r)
        {
            int c = 2 * r - 1;
            int a = r;
            int b = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j == b || j == a)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
                a--;
                b++;
            }
        }

        /* 17. Write a Program to Print the V Shape Number Pattern.

5       5 
 4     4
  3   3
   2 2
    1

    */
        public void TrianglePattern12(int r)
        {
            int c = 2 * r - 1;
            int a = 1;
            int b = c;
            for (int i = r; i >= 1; i--)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j == b || j == a)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
                a++;
                b--;
            }
        }

        /* 18. Write a Program to print the Solid Half Diamond Number Pattern.

5
54
543
5432
54321
543210
54321
5432
543
54
5

    */
        public void TrianglePattern13(int r)
        {
            int c = r / 2;
            int b = c;
            for (int i = 1; i <= r; i++)
            {
                for (int j = c; j >= 0; j--)
                {
                    if (j >= b)
                    {
                        Console.Write(j);
                    }

                }
                Console.WriteLine();
                if (i <= c)
                    b--;
                else
                    b++;
            }
        }

        /* 19. Write a Program to print the Solid Inverted Half Diamond Number Pattern.

     5
    45
   345
  2345
 12345
012345
 12345
  2345
   345
    45
     5

    */
        public void TrianglePattern14(int r)
        {
            int c = r / 2;
            int b = c;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 0; j <= c; j++)
                {
                    if (j >= b)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
                if (i <= c)
                    b--;
                else
                    b++;
            }
        }

        /* 20. Write a Program to Print the Hollow Diamond Number Pattern.

    1    
   2 2
  3   3
 4     4
5       5
 4     4
  3   3
   2 2
    1

    */
        public void RectanglePattern4(int r)
        {
            int c = r;
            int a = c / 2 + 1;
            int b = a;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 0; j <= c; j++)
                {
                    if (j == b || j == a)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
                if (i <= c / 2)
                {
                    a++;
                    b--;
                }
                else
                {
                    a--;
                    b++;
                }

            }
        }

        /* 21. Write a Program to Print Cross Sign (╳ ) Number Pattern.

1   1
 2 2
  3
 4 4
5   5

    */
        public void XPattern(int r)
        {
            int a = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j == i || j == a)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                a--;
                Console.WriteLine();
            }
        }

        /* 22. Write a Program to print the Fibonacci Half Pyramid Pattern.

1 
1 2
3 5 8
13 21 34 55
89 144 233 377 610

    */
        public void TrianglePattern15(int r)
        {
            int a = 1;
            int b = 1;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(b + " ");
                        if (i != 1)
                        {
                            int temp = b;
                            b = a + b;
                            a = temp;
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        /* 23. Write a Program to print a butterfly shape Number pattern.

1     7
12   67
123 567
1234567
123 567
12   67
1     7

    */
        public void TrianglePattern16(int r)
        {
            int a = 1;
            int b = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if (j <= a || j >= b)
                        Console.Write(j);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                if (i <= r / 2)
                {
                    a++;
                    b--;
                }
                else
                {
                    a--;
                    b++;
                }
            }
        }

        /* 24. Write a Program to Print the Hollow Half Pyramid Star Pattern.

1    
22   
3 3  
4  4
55555

    */
        public void TrianglePattern17(int r)
        {
            int a = 1;
            int b = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == r || i == j)
                        Console.Write(i);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                if (i <= r / 2)
                {
                    a++;
                    b--;
                }
                else
                {
                    a--;
                    b++;
                }
            }
        }

        /* 25. Write a Program to print Floyd's Triangle Number Pattern.
1 
2 3
4 5 6
7 8 9 10
11 12 13 14 15

    */
        public void TrianglePattern18(int r)
        {
            int a = 1;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(a + " ");
                    a++;
                }
                Console.WriteLine();
            }
        }

        public void DemoArray()
        {
            int[] arr = { 0, 1, 0, 1, 2, 1, 2, 0, 2, 1, 0, 1, 2 };
            int l = arr.Length;
            for (int j = 0; j < l; j++)
            {
                for (int i = j + 1; i < l; i++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }
        public void BubbleSort()
        {
            int[] arr = { 2, 3, 5, 0, 1, 4, 6, 9, 8, 7 };
            int l = arr.Length;

            int count = 1;
            while (count < l - 1)
            {
                for (int i = 0; i < l - count; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                count++;
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }


    }
}
