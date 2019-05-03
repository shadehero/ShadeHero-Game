using System;
namespace ShadeHero.Rooms
{
	public class MainMenu : Room
	{
		public MainMenu()
		{
			SetTitle("Main Menu");
			SetWindowSize(64,32);
			SetCommands(new string[] { "/login","/register","/credits","/options","/exit" });
			SetInfo(new string[] { "Shade Hero","Version: Beta 0.1" });
		}

		protected override void Main_Loop()
		{
			Init();
			string input = UserInput();

			switch (input)
			{
				case "/register":
					new Register().Run();
					return;
				case "/login":
					new Login().Run();
					return;
			}

			base.Main_Loop();
		}
	}
}
