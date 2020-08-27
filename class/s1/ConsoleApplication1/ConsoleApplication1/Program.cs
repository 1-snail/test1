using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.MyNamSpace;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double result = calc.Add(2.1, 2.1);
            Console.WriteLine(result);
        }   
    }
}
