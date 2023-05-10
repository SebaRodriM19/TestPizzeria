using System;
using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio.DecoratorPatternPizza.Decorators
{
    public class BasePizzaNapoletana : PizzaDecorator
    {
        public BasePizzaNapoletana(IPizza pizza) : base(pizza)
        {
            _basePizza = "Margherita";
            _totalCost = 3.0;
        }
    }
}

