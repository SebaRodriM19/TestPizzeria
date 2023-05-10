using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio
{
    public class DoughIntegral : PizzaDecorator
    {
        public DoughIntegral(IPizza pizza) : base(pizza)
        {
            _dough = "Integrale";
            _totalCost = 1.0;
        }
    }
}