using System;
namespace PizzeriaSdominio.Exceptions
{
	public class InvalidExtraException : Exception
	{
		public InvalidExtraException(string message) : base(message)
		{
		}
	}
}

