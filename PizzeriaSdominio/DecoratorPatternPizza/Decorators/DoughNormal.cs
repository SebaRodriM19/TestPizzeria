using System;
using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio.DecoratorPatternPizza.Decorators
{
	public class DoughNormal : PizzaDecorator
	{ 
		public DoughNormal(IPizza pizza) : base(pizza)
		{
			_dough = "Normale";
			_totalCost = 0.0;
		}
	}
}

