using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class P8Strings
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine(str);

            //Length of the string

            Console.WriteLine("Length of {0} is {1}", str, str.Length);
            //or
            Console.WriteLine($"Length of {str} is {str.Length}");
            //or
            Console.WriteLine("Length of " + str + " is " + str.Length);

            Console.WriteLine(str[0]);//It returns the 0th index character of the specific string.
            Console.WriteLine(str[1]);
            Console.WriteLine(str[str.Length - 1]);//It returns the LAST character of the specific string.


            string str1 = "Hello " +
                           "World";
            Console.WriteLine(str1);
            string str2 = @"Hello 
                             World";
            Console.WriteLine(str2);
            Console.WriteLine(str1 + str2);   //Concate the two strings
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            IEnumerable<char> list = str1.Concat(str2);
            foreach (char c in list)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(list);
        }
    }
}
