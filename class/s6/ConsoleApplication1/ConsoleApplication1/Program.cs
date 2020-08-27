using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car  v = new Car ();
            v.Run();
            Console.WriteLine(v.Speed);
        }
    }
    class Vehicle
    {
        private int _speed;
        public virtual int Speed{
            get { return _speed; }
            set { _speed = value; }             //因为这是speed的属性，所以value的值应该赋值给_speed
        }
       
        public virtual  void Run()
        {
            Console.WriteLine("I'm runing");
            _speed = 100;
        }
       
    }
    class Car : Vehicle
    {
        private int _rpm;
        public override int Speed{
            get { return _rpm; }
            set { _rpm = value;}
        } 
        public override  void Run()
        {
            Console.WriteLine("Bus is runing");
            _rpm = 1000;
        }
    }
    class RaceCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("race car is runing");
        }
    }
}
