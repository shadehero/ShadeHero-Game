using System;
using System.Text;
using System.Collections.Generic;

namespace ObjectCrypter
{
	class ShadeCrypt
	{
		/* 
            ShadeCrypt autorski algorytm "szyfrowania"
            Przykladowy Klucz:
                c3:2d:s5:gf:sd:sc
             */

		// Elementy Klucza

		private class KeyNode
		{
			public char X;
			public char Y;

			public KeyNode(char x, char y)
			{
				X = x;
				Y = y;
			}
		}

		// Dzielenie Klucza na segmenty
		private static List<KeyNode> GetNodesFromKey(string key)
		{
			List<KeyNode> Key_Nodes = new List<KeyNode>();
			string[] nodes = key.Split(':');

			foreach (string s in nodes)
			{
				Key_Nodes.Add(new KeyNode(s[0], s[1]));
			}
			return Key_Nodes;
		}

		// Szyfrowanie 
		public static string Crypt(string key, string data)
		{
			byte[] byte_data = Encoding.UTF8.GetBytes(data);
			string base64_data = Convert.ToBase64String(byte_data);
			List<KeyNode> key_nodes = new List<KeyNode>();

			foreach (KeyNode k in GetNodesFromKey(key))
			{
				base64_data.Replace(k.X, k.Y);
			}

			return base64_data;
		}

		// Deszyfrowanie
		public static string Decrypt(string key, string data)
		{
			byte[] data_bytes = Convert.FromBase64String(data);
			string data_frombase64 = Encoding.UTF8.GetString(data_bytes);

			foreach (KeyNode k in GetNodesFromKey(key))
			{
				data_frombase64.Replace(k.Y, k.X);
			}
			return data_frombase64;
		}
	}
}
