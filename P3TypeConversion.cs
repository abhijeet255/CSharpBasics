using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class P3TypeConversion
    {
        static void Main(string[] args)
        {

            //Implicite Conversion
            int a = 5;
            double d = a;
            long l = a;
            Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine(l);

            //Explicite Conversion
            double db = 3.34;
            //int i = db;   //Not convert Implicity
            int i = (int)db;
            Console.WriteLine(db);
            Console.WriteLine(i);
        }
    }
}
