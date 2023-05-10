using System;
using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio.DecoratorPatternPizza.Decorators
{
    public class BasePizzaWhite : PizzaDecorator
    {
        public BasePizzaWhite(IPizza pizza) : base(pizza)
        {
            _basePizza = "Bianca";
            _totalCost = 5.0;
        }
    }
}


