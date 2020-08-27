using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
     class Program
    {
        static void Main(string[] Args)
        {
            Type t = typeof(Car);
            Type tb = t.BaseType;
            Console.WriteLine(tb.FullName );
   
        }
    }
    class Vehicle
    {
        
    }
    class Car :Vehicle
    {

    }

}
