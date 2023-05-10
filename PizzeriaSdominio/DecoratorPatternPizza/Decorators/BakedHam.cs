using System;
using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio.DecoratorPatternPizza.Decorators
{
	public class BakedHam : PizzaDecorator
	{
        public BakedHam(IPizza pizza) : base(pizza)
        {
            _extraOnPizza = "Prosciutto cotto,";
            _totalCost = 1.0;
        }
    }
}

