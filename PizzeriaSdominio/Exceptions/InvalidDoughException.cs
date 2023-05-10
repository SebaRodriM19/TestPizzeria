using System;
namespace PizzeriaSdominio.Exceptions
{
	public class InvalidDoughException : Exception
	{
		public InvalidDoughException(string message) : base(message)
		{
		}
	}
}

