using System;
using PizzeriaSdominio.FactoryMethodPizzeria;

namespace PizzeriaSdominio.CsvFile
{
	public interface IReaderCsvOrders
	{
		public List<PizzaOrder> Read(string filepPath);
	}
}

