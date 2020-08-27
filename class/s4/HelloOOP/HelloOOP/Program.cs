using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            vehicle.Refuel();
            vehicle.accelerate();
            car.TurboAccelerate();
            Console.WriteLine( );
        }
    }
    class Bus:Vehicle
    {
        public void SlowAccelerate()
        {
            Burn(1);
            _rpm = 500;
        }
    }
}
