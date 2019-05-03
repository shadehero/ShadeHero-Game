using System;
using System.IO;
using Newtonsoft.Json.Linq;
namespace ShadeHero
{
	public class Paths
	{
		public static class Local
		{
				
		}

		public static class Serwer
		{
			public static readonly string Adress = "http://192.168.43.249/";

			public static class Auth
			{
				public static string Login = Adress + "Auth/Login.php";
				public static string Register = Adress + "Auth/Register.php";
			}
		}
	}
}
