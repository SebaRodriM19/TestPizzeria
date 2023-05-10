using System;
using Microsoft.Extensions.DependencyInjection;
using PizzeriaSdominio.DecoratorPatternPizza;
using PizzeriaSdominio.DecoratorPatternPizza.Decorators;
using PizzeriaSdominio.Entities;
using PizzeriaSdominio.FactoryMethodPizzeria;
using PizzeriaSdominio.FinancialNotification;
using PizzeriaSdominio.Exceptions;
using PizzeriaSdominio.CsvFile;

namespace PizzeriaSdominio.IOC
{
	public static class RestaurantIOC
	{
		private static void GetCollection(this IServiceCollection service)
		{
			service.AddSingleton<IFinancialManager, FinantialManager>();
            service.AddSingleton<Ticket>();
            service.AddSingleton<IWriteOrder,WriteOrder>();
            service.AddSingleton<IReaderCsvOrders, ReaderCsvOrders>();
            service.AddSingleton<IRestaurant, PizzaOrder>();
			service.AddSingleton<RestaurantFactory>();
            service.AddSingleton<IPizza, Pizza>();
			service.AddSingleton<PizzaDecorator>();
            service.AddSingleton<BasePizzaMargherita>();
            service.AddSingleton<BasePizzaNapoletana>();
            service.AddSingleton<BasePizzaWhite>();
            service.AddSingleton<DoughIntegral>();
            service.AddSingleton<DoughNormal>();
            service.AddSingleton<BakedHam>();
            service.AddSingleton<RawHam>();
			service.AddSingleton<Pineapple>();
            service.AddSingleton<Mushrooms>();
            service.AddSingleton<BasePizzaMargherita>();
            service.AddSingleton<InvalidBasePizzaException>();
            service.AddSingleton<InvalidDoughException>();
            service.AddSingleton<InvalidExtraException>();
        }

        public static ServiceProvider GetProvider()
        {
            var services = new ServiceCollection();
            services.GetCollection();
            return services.BuildServiceProvider();
        }
    }
}

