﻿namespace Exceptions
{
	public class CustomException : Exception
	{
        public CustomException(string message) : base($"{DateTime.Now} : {message}")
        {
        }
    }
}
