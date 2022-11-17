using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class ExtremeSportAccessories : CarAccessoriesDecorator   
    {   
       public ExtremeSportAccessories(ICar aCar)   
       :base(aCar)   
       {   
       }   
       public override string GetDescription()   
       {   
          return base.GetDescription() +",Extreme Sport Accessories";   
       }   
       public override double GetCost()   
       {   
          return base.GetCost() + 25000;   
       }   
    }   
}
