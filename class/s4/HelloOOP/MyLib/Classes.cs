using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{   
     public class Vehicle
    {
         protected int _rpm;
         protected  int _fuel;

         public void Refuel()
         {
             _fuel = 100;
         }
         protected void Burn(int fuel)
         {
             _fuel-= fuel ;
         }
         public void accelerate()
         {
             _rpm += 1000;
             Burn(1);

         }
         public int Speed { get { return _rpm; } }
    }
   
    public class Car:Vehicle
    {
        public void TurboAccelerate()
        {
            Burn(2);
            _rpm += 3000; 
        }
    }
}
