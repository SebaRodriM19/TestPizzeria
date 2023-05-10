using System;
namespace PizzeriaSdominio.Entities
{
	public interface IPizza
	{
		public double GetCostPizza();
		public string GetDescription();
		public void SetCostToZero();

    }
}

