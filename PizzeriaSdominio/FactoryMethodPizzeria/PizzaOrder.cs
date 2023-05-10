using System;
using PizzeriaSdominio.DecoratorPatternPizza;
using PizzeriaSdominio.DecoratorPatternPizza.Decorators;
using PizzeriaSdominio.Entities;
using PizzeriaSdominio.Exceptions;

namespace PizzeriaSdominio.FactoryMethodPizzeria
{
	public class PizzaOrder : IRestaurant
	{
		private string _order;
		private IPizza _pizza;
		private int _idOrder = 0;

		public PizzaOrder(string order)
		{
			_order = order;
			_pizza = GeneratePizza(order);
		}

		private IPizza GeneratePizza(string order)
		{
			IPizza pizza = new Pizza();

			var orderSplitted = order.Split(";");

			var basePizza = orderSplitted[0];
			var doughPizza = orderSplitted[1];
			var extrasPizza = orderSplitted[2];

			if (basePizza != string.Empty)
			{
				pizza = CheckBasePizza(basePizza, pizza);
			}
			else
			{
				throw new InvalidBasePizzaException("Invalid base pizza.");
			}

			if (doughPizza != string.Empty)
			{
				pizza = CheckDough(doughPizza, pizza);
			}
			else
			{
				throw new InvalidDoughException("Invalid dough.");
			}

			if (extrasPizza != string.Empty)
			{
				pizza = CheckExtrasPizza(extrasPizza, pizza);
			}

			return pizza;
		}

		private IPizza CheckExtrasPizza(string extrasPizza, IPizza pizza)
		{
			if (extrasPizza.Contains(','))
			{
				var extras = extrasPizza.Split(",");
				var pineapple = CheckPineappleInExtras(extras);
				for (int i = 0; i < extras.Length; i++)
				{
					pizza = CheckSingleExtra(extras[i], pizza);
				}

				if (pineapple)
				{
					_pizza.SetCostToZero();
				}
			}

			return pizza;
		}

		private bool CheckPineappleInExtras(string[] extras)
		{
			var res = false;

			for (int i = 0; i < extras.Length; i++)
			{
				if (extras[i].Equals("Pineapple"))
				{
					res = true;
					break;
				}
			}

			return res;
		}

		private IPizza CheckSingleExtra(string extra, IPizza pizza) => extra switch
		{
			"Prosciutto crudo" => new RawHam(pizza),
			"Prosciutto Cotto" => new BakedHam(pizza),
			"Funghi" => new RawHam(pizza),
			"Ananas" => new Mushrooms(pizza),
			_ => throw new InvalidExtraException("Invalid extra")
		};

        private IPizza CheckBasePizza(string basePizza, IPizza pizza) => basePizza switch
		{
			"Margherita" => new BasePizzaMargherita(pizza),
			"Napoletana" => new BasePizzaNapoletana(pizza),
			"Bianca" => new BasePizzaWhite(pizza),
			_ => throw new InvalidDoughException("Invalid dough.")
		};

		private IPizza CheckDough(string doughPizza, IPizza pizza) => doughPizza switch
		{
			"Normale" => new DoughNormal(pizza),
			"Integrale" => new DoughIntegral(pizza),
			_ => throw new InvalidDoughException("Invalid dough.")
		};

		public IPizza GetPizza() => _pizza;

        public int GetId() => _idOrder;

        public string PizzaSelection => _pizza.GetDescription();

	}
}


