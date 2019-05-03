using System;
using ShadeHero.Serwer;
using System.Text.RegularExpressions;

namespace ShadeHero.Rooms
{
	public class Register : Room
	{
		readonly string[] TEXT_INFO = { "" };
		readonly string TEXT_TO_LONG = "The maximum length is 16 characters.";
		readonly string TEXT_TO_SHORT = "The minimum length is 4 characters.";
		readonly string TEXT_ILLEGAL_CHARS = "Contains illegal characters";
		readonly string TEXT_LOGIN_ERROR = "Your login is not available.";
		readonly string TEXT_ACC_WAS_CREATED = "Account was created!";
		readonly string TEXT_CREATING_ACC = "Creating an Account...";
		readonly string TEXT_SET_LOGIN = "Set Login/Nick:";
		readonly string TEXT_SET_PASSWORD = "Set Password: ";
		readonly string TEXT_SET_EMAIL = "Set Email";
		readonly string TEXT_LOGIN = "[LOGIN]: ";
		readonly string TEXT_PASSWORD = "[PASSWORD]: ";

		public Register()
		{
			SetTitle(TEXT_INFO[0]);
			SetInfo(TEXT_INFO);
		}

		protected override void Main_Loop()
		{
			Init();

			string login = UserInput(TEXT_SET_LOGIN);
			string password = UserInput(TEXT_SET_PASSWORD);
			string email = UserInput(TEXT_SET_EMAIL);

			if (CheckPassword(password) && CheckLogin(login))
			{
				NotyficationFree(TEXT_CREATING_ACC);
				SerwerClient client = new SerwerClient();
				Request req = Request.Create.Auth.Register(login, password, email);
				Response response = client.SendRequest(req);

				if (response.JsonCode == "LOGIN_ERROR") { Notyfication(TEXT_LOGIN_ERROR); }
				if (response.JsonCode == "OK") { Notyfication(TEXT_ACC_WAS_CREATED); new MainMenu().Run();}
			}
			base.Main_Loop();
		}

		bool CharsAreGood(string text)
		{
			return false;
		}

		bool CheckLogin(string login)
		{
			if (login.Length > 16) { Notyfication(TEXT_LOGIN + TEXT_TO_LONG); return false; }
			if (login.Length < 4) { Notyfication(TEXT_LOGIN + TEXT_TO_SHORT); return false; }
			if (CharsAreGood(login)) { Notyfication(TEXT_LOGIN + TEXT_ILLEGAL_CHARS); return false; }
			return true;
		}

		bool CheckPassword(string password)
		{
			if (password.Length > 16) { Notyfication(TEXT_PASSWORD + TEXT_TO_LONG); return false; }
			if (password.Length < 4) { Notyfication(TEXT_PASSWORD + TEXT_TO_SHORT); return false; }
			if (CharsAreGood(password)) { Notyfication(TEXT_PASSWORD + TEXT_ILLEGAL_CHARS); return false; }
			return true;
		}
	}
}
