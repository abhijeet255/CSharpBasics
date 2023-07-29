using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
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



    //13. Program to Find Sum of Digits of a Number using Recursion

    /*Recursion is a function that calls itself.
     Or in other words, recursion is a process 
     where a function calls itself repeatedly until some 
    specified conditions have been completed. It is just like a loop; in the loop,
    if the condition is satisfied, the function will call itself similarly if the condition is satisfied.*/

    class SumOfDigitsWithRecursion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Recursion rec= new Recursion();
            int sum = 0;
            sum = rec.Sum(a);
            Console.WriteLine("The Sum of Digits of Number {0} is {1}", a, sum);
        }
    }

    class Recursion
    {
        public int Sum(int num)
        {
            int sum = 0;
            if (num != 0)
            {
                return (num%10+(Sum(num/10)));
            }
            return sum;
        }
    }




    //14.    Program to Reverse a Number
    class RevNumber
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
                sum = sum*10 + rem;
                temp /= 10;
            }
            Console.WriteLine("The reverse Number of {0} is {1}", a, sum);
        }
    }



    //15. Program to Reverse a Number and Check if it is a Palindrome
    class PalindromeNo
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
                sum = sum*10 + rem;
                temp /= 10;
            }
            if(sum==a)
            {
                Console.WriteLine(a+" is a Palindrome Number");
            }
            else
            {
                Console.WriteLine(a+" is not a Palindrome Number");
            }
        }
    }



    //16.Program to Calculate the Sum, Multiplication, Division and Subtraction of Two Numbers
    class ArithmeticOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Two Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Substraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + ((double)a / b));
        }
    }



    //17.Program to Perform Multiplication of Exponents of Same Base
    class PowerOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Power:");
            int b = Convert.ToInt32(Console.ReadLine());
            int power=1;
            for(int i = 0; i < b;i++)
            {
                power = power * a;
            }
            Console.WriteLine("Power: "+ power);
        }
    }



    //18. Program to Print Multiplication Table
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int ans=1;
            Console.WriteLine("Multiplication ");
            for (int i = 1; i <= 10;i++)
            {
                ans = a * i;
                Console.WriteLine( ans);
            }
            
        }
    }


    //19. Program to Read a Grade and Display the Equivalent Description
    class Grade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Grade Like O,A,B,P:");
            char a = Convert.ToChar(Console.ReadLine());
            a=char.ToUpper(a);
            switch(a)
            {
                case 'O':
                    Console.WriteLine("First Class With Distinction.");
                    break;
                case 'A':
                    Console.WriteLine("First Class.");
                    break;
                case 'B':
                    Console.WriteLine("Second Class.");
                    break;
                case 'P':
                    Console.WriteLine("Pass.");
                    break;
                default:
                    Console.WriteLine("Fail.");
                    break;
            }
        }
    }


    //20. Program to Convert Lowercase Characters by Uppercase and Vice-Versa
    class ViceVersaCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any character:");
            char a = Convert.ToChar(Console.ReadLine());
            int ch = a;
            if(ch>=65 && ch<=90)    //Ascii value 65 to 90 = A to Z
            {
                Console.WriteLine((char)(ch + 32));
                //or
                Console.WriteLine(char.ToLower(a));
            }
            else if(ch>=97 && ch<=122)   //ASCII value 97 to 122 = a to z
            {
                Console.WriteLine((char)(ch - 32));
                //or
                Console.WriteLine(char.ToUpper(a));
            }

        }
    }


    //21. Program to Accept the Height of a Person and Categorize as Taller, Dwarf & Average
    class HeightOfPerson
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Height Of A Person In CentiMeters:");
            decimal h = Convert.ToDecimal(Console.ReadLine());
            //Using Ternary Operator  --- Condition ? True Values : False value
            string result= h<150?"Dwarf":
                            ((h>=150 &&h<165 )?"Average Height":
                            ((h >= 165 && h <= 195) ? "Taller" :
                            "Abnormal Height"));

            Console.WriteLine(result);

        }
    }


    //22. Program to Find the Minimum and Maximum Range of Data Types

    class rangeOfDatatypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Minimum Range of the Decimal : {0} ", Decimal.MinValue);
            Console.WriteLine("The Maximum Range of the Decimal : {0} ", Decimal.MaxValue);
            Console.WriteLine("The Minimum Range of the Integer : {0} ", int.MinValue);
            Console.WriteLine("The Maximum Range of the Integer : {0} ", int.MaxValue);
            Console.WriteLine("The Minimum Range of the Long : {0} ", long.MinValue);
            Console.WriteLine("The Maximum Range of the Long : {0} ", long.MaxValue);
            Console.WriteLine("The Minimum Range of the Float : {0} ", float.MinValue);
            Console.WriteLine("The Maximum Range of the Float : {0} ", float.MaxValue);
            Console.WriteLine("The Minimum Range of the Double : {0} ", Double.MinValue);
            Console.WriteLine("The Maximum Range of the Double : {0} ", Double.MaxValue);
        }
    }


    //23. Program to Perform All Arithmetic Operations with Menu driven program.

    class Arithmeticoperations
    {
        static void Main(string[] args)
        {
            char choise;
           do
            {
                Console.WriteLine("Enter First Number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine();
                Console.WriteLine("Enter Option You want to perform Operation:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Addition of {0} and {1} is {2}", a, b, (a + b));
                        break;
                    case 2:
                        Console.WriteLine("Substraction of {0} and {1} is {2}", a, b, (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication of {0} and {1} is {2}", a, b, (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Division of {0} and {1} is {2}", a, b, ((double)a / b));
                        break;
                    default:
                        Console.WriteLine("InValid Option");
                        break;
                }
                Console.WriteLine("Enter Y if You want to continue, Otherwise enter N :");
                choise=Convert.ToChar(Console.ReadLine());
            }
           while (char.ToUpper(choise)=='Y');
        }
    }


    //24. Program to Demonstrate the use of Conditional Logical Operator
    class Conditional
    {
        static void Main()
        {
            int age;
            Console.WriteLine("Enter the Age :");
            age = int.Parse(Console.ReadLine());
            bool adult = age >= 18 ? true : false;
            Console.WriteLine("Adult : {0}", adult);
        }
    }

    //25. Fibonacci Series Program with limit of number

    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit:");
            int limit = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int last = 0;
            Console.WriteLine("Fibonacci Series:");
            Console.Write(a+", ");
            Console.Write(b);
            while (last <limit)
            {
                last = a + b;
                if(last >limit)
                {
                    break;
                }
                Console.Write(", "+last);
                a = b;
                b = last;
            }
        }
    }

    //26. Fibonacci Series Program with limit of count

    class Fibonacci1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit:");
            int limit = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int last = 0;
            Console.WriteLine("Fibonacci Series:");
            Console.Write(a+", ");
            Console.Write(b);
            for(int i = 1; i < limit-1; i++)
            {
                last = a + b;
                Console.Write(", " + last);
                a = b;
                b = last;
            }
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
