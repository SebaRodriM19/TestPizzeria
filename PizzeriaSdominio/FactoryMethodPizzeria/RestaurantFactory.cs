using System;
namespace PizzeriaSdominio.FactoryMethodPizzeria
{
	public class RestaurantFactory
	{
		public PizzaOrder MakeOrder(string orderPizza)
		{
			return new PizzaOrder(orderPizza);
		}
	}
}

