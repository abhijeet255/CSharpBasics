using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /* 1. Write a Program to print the right triangle star pattern.

        *
        **
        ***
        ****
        *****
    */
    public class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    /* 2. Write a Program to print an inverted right triangle star pattern.

        *****
        ****
        ***
        **
        *
    */
    public class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    /* 3. Write a Program to print mirrored right triangle star pattern.

            *
           **
          ***
         ****
        *****
    */
    public class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    /* 4. Write a Program to print the Inverted Half Pyramid Star Pattern.

        *****
         ****
          ***
           **
            *
    */
    public class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    /* 5. Write a Program to print the Full Pyramid Star pattern.

            *  
           * * 
          * * *
         * * * *
        * * * * *
    */
    public class Pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int k = 5 + i - 1;
                int y = 5 - i + 1;
                for (int j = 1; j <= 9; j++)
                {
                    if (i % 2 == 1)
                    {
                        if (j <= k && j >= y && j % 2 != 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j <= k && j >= y && j % 2 == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }

    /* 6. Write a Program to print an inverted pyramid star pattern.

        * * * * * 
         * * * *
          * * *
           * *
            *
    */
    public class Pattern6
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                int k = 5 + i - 1;
                int y = 5 - i + 1;
                for (int j = 1; j <= 9; j++)
                {
                    if (i % 2 == 1)
                    {
                        if (j <= k && j >= y && j % 2 != 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j <= k && j >= y && j % 2 == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }

    /* 7. Write a Program to print a square star pattern.

        *****
        *****
        *****
        *****
        *****
    */
    public class Pattern7
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    /* 8. Write a Program to Print Half Diamond Star Pattern.

        *
        **
        ***
        ****
        *****
        ****
        ***
        **
        *
    */
    public class Pattern8
    {
        static void Main(string[] args)
        {
            int k = 9;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j <= i)
                        Console.Write("*");
                    else if (i >= 5 && j <= k)
                        Console.Write("*");

                }
                Console.WriteLine();
                k--;
            }
        }
    }

    /* 9. Write a program to Print a solid Diamond Star Pattern.

             *      
            * *     
           * * *    
          * * * *   
         * * * * *  
        * * * * * * 
         * * * * *  
          * * * *   
           * * *    
            * *     
             *      
    */
    public class Pattern9
    {

        static void Main(string[] args)
        {
            int x = 5;
            for (int i = 1; i <= 11; i++)
            {
                if (i <= 6)
                {
                    int k = 6 + i - 1;
                    int y = 6 - i + 1;
                    for (int j = 1; j <= 11; j++)
                    {
                        if (i % 2 == 1)
                        {
                            if (j <= k && j >= y && j % 2 == 0)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            if (j <= k && j >= y && j % 2 != 0)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                }
                else
                {
                    int k = 6 + x - 1;
                    int y = 6 - x + 1;
                    for (int j = 1; j <= 11; j++)
                    {
                        if (i % 2 == 1)
                        {
                            if (j <= k && j >= y && j % 2 == 0)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            if (j <= k && j >= y && j % 2 != 0)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    x--;
                }
                Console.WriteLine();
            }
        }
    }

    /* 10. Write a program to Print Inverted V Star Pattern.

            *     
           * *    
          *   *   
         *     *  
        *       *
    */
    public class Pattern10
    {

        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int k = 5 + i - 1;
                int y = 5 - i + 1;
                for (int j = 1; j <= 9; j++)
                {
                    if (j == k || j == y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }

    /*11. Write a Program to print the Full Pyramid Star Pattern.
 
            *
           ***
          *****
         *******
        *********
    */
    public class Pattern11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Columns:");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= r; i++)
            {
                int k = (c / 2) + i;
                int y = (c / 2 + 1) - i + 1;
                for (int j = 1; j <= c; j++)
                {
                    if (j <= k && j >= y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }

    /*12. Write a Program to Print the Inverted Full Pyramid Star Pattern.

        *********
         *******
          *****
           ***
            *
    */
    public class Pattern12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Columns:");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = 5; i >= 1; i--)
            {
                int k = (c / 2) + i;
                int y = (c / 2 + 1) - i + 1;
                for (int j = 1; j <= c; j++)
                {
                    if (j <= k && j >= y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }

    /*13. Write a  Program to print the Solid Inverted Half Diamond Star Pattern.

             *
            **
           ***
          ****
         *****
        ******
         *****
          ****
           ***
            **
             *
    */
    public class Pattern13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = r / 2 + 1;
            int z = r;
            for (int i = 1; i <= r; i++)
            {
                if (i <= (r / 2 + 1))
                {
                    for (int j = c; j >= 1; j--)
                    {
                        if (j <= i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                else
                {
                    for (int j = c; j >= 1; j--)
                    {
                        if (j <= z)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                z--;
                Console.WriteLine();
            }
        }
    }

    /* 14. Write a Program to Print the V Star Pattern.

        *       * 
         *     *  
          *   *   
           * *    
            *   
    */
    public class Pattern14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = r * 2 - 1;
            int k = c;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j == i || j == k)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                k--;
                Console.WriteLine();
            }
        }
    }

    /* 15. Write a Program to Print the Hollow Diamond Star Pattern.


           *   
          * *
         *   * 
        *     *
         *   *
          * *
           *
    */
    public class Pattern15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = r;
            int a = c / 2 + 1;
            int m = a;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j == a || j == m)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                if (i <= (r / 2))
                {
                    a--;
                    m++;
                }
                else
                {
                    a++;
                    m--;
                }
            }
        }
    }

    /* 16. Write a Program to Print the Pant's style Star Pattern.

        *********
        **** ****
        ***   ***
        **     **
        *       *
    */
    public class Pattern16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = 2 * r - 1;
            int a = c / 2 + 1;
            int m = a;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j >= a && j <= m && i != 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                if (i != 1)
                {
                    a--;
                    m++;
                }
            }
        }
    }

    /* 17. Write a Program to Print the Inverted Pant's Shape Star Pattern.

        *       *
        **     **
        ***   ***
        **** ****
        *********
    */
    public class Pattern17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = 2 * r - 1;
            int a = 1;
            int m = c;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j > a && j < m && i != r)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                if (i != r)
                {
                    a++;
                    m--;
                }
            }
        }
    }

    /* 18. Write a Program to Print the Double Pyramid Star Pattern.

        ******
        *****
        ****
        ***
        **
        *
        **
        ***
        ****
        *****
        ******
    */
    public class Pattern18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = r / 2 + 1;
            int a = c;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j > a)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                if (i < c)
                {
                    a--;
                }
                else
                {
                    a++;
                }
            }
        }
    }

    /* 19. Write a Program to Print Cross Sign (╳ ) Star Pattern.

        *   *
         * *
          *
         * *
        *   *
    */
    public class Pattern19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = r;
            int a = c;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j == i || j == a)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                a--;
            }
        }
    }

    /* 20. Write a Program to Print the Hollow Half Pyramid Star Pattern.

        *    
        **
        * *
        *  *
        *****
    */
    public class Pattern20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j == i || j == 1 || i == r)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    /* 21. Write a Program to Print the Hollow Rectangle Star Pattern.

        *****
        *   *
        *   *
        *   *
        *****
    */
    public class Pattern21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = r;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j == 1 || j == c || i == 1 || i == r)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    /* 22. Write a Program to print a butterfly shape star pattern.

        *     *
        **   **
        *** ***
        *******
        *** ***
        **   **
        *     *
    */
    public class Pattern22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = r;
            int a = 1;
            int m = c;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (j <= a || j >= m)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (i < (r / 2 + 1))
                {
                    a++;
                    m--;
                }
                else
                {
                    a--;
                    m++;
                }
                Console.WriteLine();
            }
        }
    }
}
