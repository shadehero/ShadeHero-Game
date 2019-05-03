using System;
using System.IO;
using System.Text;
using ShadeHero.Rooms;
using ShadeHero.Serwer;

namespace ShadeHero
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			MainMenu menu = new MainMenu();
			menu.Run();
		}
	}
}
