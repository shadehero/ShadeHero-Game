using System;
using System.Net;
using System.Web;
using System.Text;
using Newtonsoft.Json;

namespace ShadeHero.Serwer
{
	public class SerwerClient
	{
		private WebClient Client;

		public SerwerClient()
		{
			Client = new WebClient();
		}

		public Response SendRequest(Request req)
		{
			try
			{
				Response response = new Response();
				byte[] res = Client.UploadValues(req.Adress, req.Args);
				response.JsonCode = Encoding.UTF8.GetString(res);
				response.Status = Response.ResponseStatus.Success;
				return response;
			}
			catch
			{
				ExceptionManager.CantConnnetToSerwer();
				return new Response();
			}
		}
	}
}
