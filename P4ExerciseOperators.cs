using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSharp
{
    //1.Write a program to calculate (a+b)'2   formula:(a'2 + b'2 + 2*a*b)
    class Operator1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int ans = ((a * a) + (b * b) + (2 * a * b));
            Console.WriteLine(ans);

        }
    }

    //2.Write a program to calculate formulae πr2.
    class Operator2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius:");
            int r = Convert.ToInt32(Console.ReadLine());
            double ans = (double)22 / 7 * r * r;
            Console.WriteLine(ans);
        }
    }

    //3.Write a program to calculate area of triangle.
    class Operator3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Height and Base of Triangle:");
            int h = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double ans = 0.5 * h * b;
            Console.WriteLine(ans);
        }
    }

    //4. C# Program to Swap two Numbers.
    class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Two Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    //5. C# Program to Swap two Numbers without using temp variable.
    class Swap1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Two Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }




    /*
    //2.Write a program to calculate formulae πr2.
    class Operator3
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            fun(x, y);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public static void fun(int x, int y)
        {
            int temp = x; x = y; y = temp;
        }
    }*/
}
