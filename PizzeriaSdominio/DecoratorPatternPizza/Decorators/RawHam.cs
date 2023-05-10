using System;
using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio.DecoratorPatternPizza.Decorators
{
    public class RawHam : PizzaDecorator
    {
        public RawHam(IPizza pizza) : base(pizza)
        {
            _extraOnPizza = "Prosciutto crudo,";
            _totalCost = 2.0;
        }
    }
}

