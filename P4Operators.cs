using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class P4Operators
    {
        static void Main(string[] args)
        {
            //Arithmatic Operators

            int a = 10;
            int b = 3;
            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            int mod = a % b;
            int inc1 = ++a;  //This is pre incremented operator incremented by 1
            int dec1 = --a;//This is pre decremented operator decremented by 1
            int inc = a++;  //This is Post incremented operator incremented by 1
            int dec = a--;//This is Post decremented operator decremented by 1
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
            Console.WriteLine(div);
            Console.WriteLine(mod);
            Console.WriteLine(inc1);
            Console.WriteLine(dec1);
            Console.WriteLine(inc);
            Console.WriteLine(dec);

            //Relational Operator
            bool check = a == b;
            bool check1 = a != b;
            bool check2 = a > b;
            bool check3 = a < b;
            bool check4 = a >= b;
            bool check5 = a <= b;
            Console.WriteLine(check);
            Console.WriteLine(check1);
            Console.WriteLine(check2);
            Console.WriteLine(check3);
            Console.WriteLine(check4);
            Console.WriteLine(check5);

            //Logical Operator

            bool lnum = a != b && inc != dec;
            bool lnum1 = a == b || inc == dec;
            Console.WriteLine(lnum);
            Console.WriteLine(lnum1);

            //Arrithmetic Operator

            a += 3;
            Console.WriteLine(a);
        }
    }
}
