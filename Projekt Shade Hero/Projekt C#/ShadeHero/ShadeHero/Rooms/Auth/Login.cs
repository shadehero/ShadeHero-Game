using System;
using ShadeHero.Serwer;

namespace ShadeHero.Rooms
{
	public class Login : Room
	{
		readonly string[] TEXT_INFO = { "Login to your account." };
		readonly string TEXT_SET_LOGIN = "Login/NickName:";
		readonly string TEXT_SET_PASSWORD = "Password:";
		readonly string TEXT_IN_PROGRESS = "Login is in progress...";
		readonly string TEXT_LOGIN_OK = "Logged in!";
		readonly string TEXT_LOGIN_BAD = "Wrong password or login. Try again.";

		public Login()
		{
			SetTitle(TEXT_INFO[0]);
			SetInfo(TEXT_INFO);
		}

		protected override void Main_Loop()
		{
			Init();

			string login = UserInput(TEXT_SET_LOGIN);
			string password = UserInput(TEXT_SET_PASSWORD);
			NotyficationFree(TEXT_IN_PROGRESS);

			SerwerClient client = new SerwerClient();
			Request request = Request.Create.Auth.Login(login, password);
			Response response = client.SendRequest(request);

			if (response.JsonCode == "OK")
			{
				Notyfication(TEXT_LOGIN_OK);
				new SelectCharacter().Run();
			}
			else
			{
				Notyfication(TEXT_LOGIN_BAD);
			}

			base.Main_Loop();
		}
	}
}
