using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class P2Datatypes
    {
        readonly int y = 6;
        //public DatatypesP2()
        //{
        //    y = 7;   // in Contructor only you can changed the readonly variable value.
        //}
        static void Main(string[] args)
        {
            P2Datatypes dtp = new P2Datatypes();//create an object of the Application
            Console.WriteLine("Hello");
            int a = 1;
            double d = 2.4;
            float f = 3.5f;
            bool b = false;
            char c = 'x';
            DateTime dt = DateTime.Now;   //Now is a property not a method method name like Now().
            Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(dt);
            Console.WriteLine(dtp.y);
        }
    }
}
