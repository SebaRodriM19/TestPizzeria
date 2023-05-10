using System;
namespace PizzeriaSdominio.Entities
{
	public class PizzaDecorator : IPizza
	{
		private IPizza _pizza;
		protected double _totalCost = 0.0;
		protected string _dough;
		protected string _basePizza;
		protected string _extraOnPizza;

		public PizzaDecorator(IPizza pizza)
		{
			_pizza = pizza;
		}

        public double GetCostPizza()
        {
			return _pizza.GetCostPizza() + _totalCost;
        }

        public string GetDescription()
        {
			return $"{_pizza.GetDescription()} {_basePizza};{_dough};{_extraOnPizza}";
        }

		public void SetCostToZero()
		{
			_totalCost = 0.0;
		}
    }
}

