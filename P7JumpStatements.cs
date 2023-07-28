using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class P7JumpStatements
    {
        static void Main(string[] args)
        {
            //Break.

            for (int i = 0; i < 5; i++)
            {
                if (i > 3)
                {
                    break;  // after hitting the break statement execution jump out of the loop only print 0 1 2 3
                }
                Console.WriteLine(i);
            }

            //Continue.

            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;  // after hitting the continue statement execution ignore this iteration directly go for next iteration it prints 0 1 2 4
                }
                Console.WriteLine(i);
            }

            //goto.

            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    goto Find;  // after hitting the goto statement its goto find property and execute this property and skip remaining iterations print 0 1 2 Jumped Out of the Loop
                }
                Console.WriteLine(i);
            }
        Find:
            Console.WriteLine("Jumped Out of the Loop");
        }
    }
}
