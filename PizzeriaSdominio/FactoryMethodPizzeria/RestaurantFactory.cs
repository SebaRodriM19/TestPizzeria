using System;
namespace PizzeriaSdominio.FactoryMethodPizzeria
{
	public class RestaurantFactory
	{
		public static PizzaOrder MakeOrder(string orderPizza)
		{
			return new PizzaOrder(orderPizza);
		}
	}
}

