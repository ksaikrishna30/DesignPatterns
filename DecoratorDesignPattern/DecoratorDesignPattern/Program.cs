﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create EcomomyCar instance.   
            ICar objCar = new EconomyCar();

            //Wrp EconomyCar instancw with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

            Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

            Console.Read();
        }  
    }
}
