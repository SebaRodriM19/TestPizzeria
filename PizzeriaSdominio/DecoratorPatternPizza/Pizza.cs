using PizzeriaSdominio.Entities;

namespace PizzeriaSdominio;

public class Pizza : IPizza 
{

    public Pizza()
    { 
    }

    public double GetCostPizza()
    {
        return 0.0;
    }

    public string GetDescription()
    {
        return "";
    }

    public void SetCostToZero()
    {
    }
}

