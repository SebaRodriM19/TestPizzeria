using System;
namespace PizzeriaSdominio.Exceptions
{
	public class InvalidBasePizzaException : Exception
	{
		public InvalidBasePizzaException(string message) : base(message)
		{
		}
	}
}

