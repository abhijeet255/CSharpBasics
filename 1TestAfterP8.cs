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



    //6.Program to Check Whether a Given Number is Even or Odd
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("{0} is an Even Number",a);
            }
            else
            {
                Console.WriteLine("{0} is an Odd Number", a);
            }
        }
    }



    //7. Program to Print Odd Numbers in a Given Range
    class RangeOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Two Numbers For Range:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while (a <= b)
            {
                if (a % 2 != 0)
                {
                    Console.WriteLine(a);
                }
                a += 1;
            }
        }
    }



    //8. Program to Check Whether a Number is Positive or negative
    class PosiNegNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("{0} is Positive Number.", a);
            }
            else if (a < 0)
            {
                Console.WriteLine("{0} is Negative Number", a);
            }
            else
            {
                Console.WriteLine("No. is Zero");
            }
        }
    }


    //9. Program to Find the Largest of Two Numbers
    class LargestNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Two Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is Largest Number.", a);
            }
            else if (b > a)
            {
                Console.WriteLine("{0} is Largest Number", b);
            }
            else
            {
                Console.WriteLine("Both Numbers Are Equal.");
            }
        }
    }



    //10. Program to Find the Sum of All the Multiples of 3 and 5
    class Multiple35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number for Range:");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=3;i<=a;i++) 
            {
                if(i%3==0 || i%5==0)
                {
                    sum=sum+i;
                }
            }
            Console.WriteLine("Sum: "+sum);
        }
    }




    //11. Program to Print All the Multiples of 17 which are Less than 100
    class MultipleOf17
    {
        static void Main(string[] args)
        {
            for(int i=17;i<=100;i=i+17) 
            {
                Console.WriteLine(i);
            }
        }
    }



    //12. Program to Find Sum of Digits of a Number
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            int rem;
            int sum = 0;
            while (temp > 0)
            {
                rem = temp % 10;
                sum = sum + rem;
                temp /= 10;
            }
            Console.WriteLine("The Sum of Digits of Number {0} is {1}", a, sum);
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
