using System;
namespace PizzeriaSdominio.FinancialNotification
{
	public class FinantialManager : IFinancialManager
	{
        private Ticket _ticket;

		public FinantialManager(Ticket ticket)
		{
            _ticket = ticket;
		}

        public string PrintTicket()
        {
            double costOrder = 0;
            var listOrder = _ticket.GetListOrder();
            var dataFullOrders = string.Empty;

            foreach (var order in listOrder)
            {
                dataFullOrders =  dataFullOrders + order.GetPizza().GetDescription();
               costOrder = costOrder + order.GetPizza().GetCostPizza();
            }

            return $"Id:{_ticket.GetIdTicket()} Your orders: {dataFullOrders} Total Cost: {costOrder}";
        }
    }
}

