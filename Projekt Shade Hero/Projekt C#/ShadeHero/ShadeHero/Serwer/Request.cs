using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ShadeHero.Serwer
{
	public class Request
	{
		public string Adress;
		public NameValueCollection Args;

		public static class Create
		{
			public static class Auth
			{
				
				public static Request Login(string login, string password)
				{
					Request r = new Request();
					r.Adress = Paths.Serwer.Auth.Login;
					r.Args = new NameValueCollection();
					r.Args.Add("login",login);
					r.Args.Add("password", password);
					return r;
				}


				public static Request Register(string login, string password, string email)
				{
					Request r = new Request();
					r.Args = new NameValueCollection();
					r.Args.Add("login", login);
					r.Args.Add("password", password);
					r.Args.Add("email", email);
					r.Adress = Paths.Serwer.Auth.Register;
					return r;
				}
			}
		}
	}
}
