using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class SuperLuxury : ICar
    {
        public string GetDescription()
        {
            return "Super Luxury Car";
        }

        public double GetCost()
        {
            return 1500000;
        }
    } 
}
