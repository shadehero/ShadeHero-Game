using System;
namespace ShadeHero
{
	public class ExceptionManager
	{
		public static void CantLoadFile(string location)
		{
			Console.WriteLine(location + " Does not exits");
			Console.ReadKey();
			Environment.Exit(1);
		}

		public static void CantConnnetToSerwer()
		{
			Console.WriteLine("Brak polaczenia z serwerem");
			Console.ReadKey();
			Environment.Exit(1);
		}
	}
}
