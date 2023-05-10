using System;
using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio.DecoratorPatternPizza.Decorators
{
    public class Pineapple : PizzaDecorator
    {
        public Pineapple(IPizza pizza) : base(pizza)
        {
            _extraOnPizza = "Ananas,";
            _totalCost = 0.0;
        }
    }
}

