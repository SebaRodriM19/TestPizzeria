using System;
using PizzeriaSdominio.CsvFile;
using PizzeriaSdominio.FactoryMethodPizzeria;

namespace PizzeriaSdominio.FinancialNotification
{
	public class Ticket
	{
		private static int autoincremetId = 0;
        private const string filePath = @"DirectoryPath";
		private IReaderCsvOrders readerOrders;
		private int _idTicket;
		private List<PizzaOrder> _pizzaOrders;

        public Ticket(int idTicket, List<PizzaOrder> pizzaOrders)
        {
            _idTicket = autoincremetId + 1;
            _pizzaOrders = readerOrders.Read(filePath);
        }

        public int GetIdTicket() => _idTicket;
        public List<PizzaOrder> GetListOrder() => _pizzaOrders;
    }
}

