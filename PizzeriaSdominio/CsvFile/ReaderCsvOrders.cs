using System;
using PizzeriaSdominio.FactoryMethodPizzeria;

namespace PizzeriaSdominio.CsvFile
{
	public class ReaderCsvOrders : IReaderCsvOrders
	{
        private List<PizzaOrder> _pizzaOrders;


        public List<PizzaOrder> Read(string filepPath)
        {
            StreamReader reader = new StreamReader(filepPath);
            //skip first line
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string orderToCreate = reader.ReadLine();
                //create orders
                var order = RestaurantFactory.MakeOrder(orderToCreate);

                _pizzaOrders.Add(order);
            }

            reader.Close();

            return _pizzaOrders;
        }
    }
}

