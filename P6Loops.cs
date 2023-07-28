using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class P6Loops
    {
        //while Loop
        static void Main(string[] args)
        {
            //while Loop

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //Do...while Loop

            int ii = 6;
            do
            {
                Console.WriteLine(ii);//Loop executes one's even condition is true or false.
                ii++;
            }
            while (ii <= 5);

            //For Loop

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }

        }
    }
}
