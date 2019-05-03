using System;
namespace ShadeHero.Serwer
{
	public class Response
	{
		public enum ResponseStatus
		{
			Success,
			Failed
		}

		public string JsonCode;
		public ResponseStatus Status;
	}
}
