namespace Exceptions
{
	public class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ThrowError("Hello World");
			}
			catch (CustomException e)
			{
				Console.WriteLine(e.Message);
			}
		}

		static void ThrowError(string message)
		{
			throw new CustomException(message);
		}
	}
}
