using System;
using System.IO;
using PizzeriaSdominio.FactoryMethodPizzeria;

namespace PizzeriaSdominio.CsvFile
{
	public class WriteOrder : IWriteOrder
	{
        private const string filePath = @"DirectoryPath";
        private List<PizzaOrder> listOfOrders;

        public void Write()
        {
            string[] columns = { "BasePizza", "Impasto", "Aggiunte" };
            StreamWriter writer = new StreamWriter(filePath,false);
            writer.WriteLine(string.Join(";", columns));

            foreach (var order in listOfOrders)
            {
                writer.WriteLine(order.GetPizza().GetDescription());
            }

            writer.Close();
        }
    }
}

