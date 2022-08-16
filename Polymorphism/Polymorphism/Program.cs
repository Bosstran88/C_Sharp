using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        public static void Main()
        {
            Car myCar;
            // create a Car object , and assign adress to myCar
            System.Console.WriteLine("Creating a Car object and assigning " +
                " its memory location to myCar");
            myCar = new Car();

            // assign values to the Car object's field using mycar;
            myCar.make = "Toyota";
            myCar.model = " MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;

            //display the field values using myCar;
            System.Console.WriteLine("mycar detail:");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("mycar.model = " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);

            // call the method using myCar
            myCar.Start();
            myCar.Stop();

            //declare another Car object reference and
            // create another Car object
            System.Console.WriteLine("Create another Car object and" + "assign " +
                "its memory location to redPorsche");
            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;
            System.Console.WriteLine("redPorsche is a " + redPorsche.model);
            //change the object referenced by the myCar object 
            //reference to the object referenced by redPorsche

            System.Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorsche;
            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model = " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);

            //assign null to myCar (myCar will no longer reference
            //an object
            myCar = null;
            Console.ReadLine();


        }
    }
}
