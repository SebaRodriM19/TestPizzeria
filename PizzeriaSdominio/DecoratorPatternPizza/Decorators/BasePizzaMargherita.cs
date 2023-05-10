using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio
{
    public class BasePizzaMargherita : PizzaDecorator
    {
        public BasePizzaMargherita(IPizza pizza) : base(pizza)
        {
            _basePizza = "Margherita";
            _totalCost = 7.0;
        }
    }
}