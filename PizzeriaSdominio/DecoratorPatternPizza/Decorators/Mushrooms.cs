using System;
using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio.DecoratorPatternPizza
{
    public class Mushrooms : PizzaDecorator
    {
        public Mushrooms(IPizza pizza) : base(pizza)
        {
            _extraOnPizza = "Funghi";
            _totalCost = 2.0;
        }
    }
}

