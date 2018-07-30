using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P1_BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");

            //// Make a Car object and set max speed.
            //Car myCar = new Car(120);
            //// Set the current speed, and print it.
            //myCar.Speed = 90;
            //Console.WriteLine("My car is going {0} Km/h", myCar.Speed);


            #region Specifying the Parent Class of an Existing Class

            // Now make a MiniVan object.
            MiniVan myVan = new MiniVan();
            myVan.Speed = 20;
            Console.WriteLine("My van is going {0} Km/h", myVan.Speed);

            //// Error! Can't access private members!
            //myVan.currSpeed = 55;

            #endregion


            Console.ReadLine();
        }
    }
}
