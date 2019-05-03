using System;
using Console = Colorful.Console;
using System.Drawing;
using System.Text;

namespace ShadeHero.Rooms
{
	public class Room
	{
		protected string Name;
		protected string LocationPath;

		string[] Commands;
		string Title;
		string[] Info;

		/// <summary>
		/// Wystartuj room
		/// </summary>
		public void Run()
		{
			Main_Loop();
		}

		/// <summary>
		/// Definiowanie Rozmiaru Okna Konsoli
		/// </summary>
		/// <param name="x">x - Szerokosc</param>
		/// <param name="y">y - Wysykosc</param>
		protected void SetWindowSize(int x, int y)
		{
			Console.SetWindowSize(x, y);
			Console.SetBufferSize(x, y);
		}

		/// <summary>
		/// Ustaw opis/info
		/// </summary>
		/// <param name="info">Info.</param>
		protected void SetInfo(string[] info)
		{
			Info = info;
		}

		/// <summary>
		/// Przedstaw Dostepne Komendy
		/// </summary>
		/// <param name="commands">Commands.</param>
		protected void SetCommands(string[] commands)
		{
			Commands = commands;
		}

		/// <summary>
		/// Ustaw Tytul
		/// </summary>
		/// <param name="title">Title.</param>
		protected void SetTitle(string title)
		{
			Title = title;
		}

		/// <summary>
		/// Wejscie Uzytkownika
		/// </summary>
		/// <returns>The input.</returns>
		protected string UserInput()
		{
			Console.Write("$> ");
			return Console.ReadLine();
		}

		protected string UserInput(string prompt)
		{
			Console.Write(prompt + " > ");
			return Console.ReadLine();
		}

		protected void Notyfication(string text)
		{
			Console.Clear();
			Console.WriteLine();
			DrawSeparator();
			Console.WriteLine(" " + text, Color.YellowGreen);
			DrawSeparator();
			Console.WriteLine();
			Console.ReadKey();
		}

		protected void NotyficationFree(string text)
		{
			Console.Clear();
			Console.WriteLine();
			DrawSeparator();
			Console.WriteLine(" " + text, Color.YellowGreen);
			DrawSeparator();
			Console.WriteLine();
		}

		/// <summary>
		/// Inicjacja
		/// </summary>
		protected void Init()
		{
			Console.Clear();
			Console.Title = Title;
			Console.WriteLine();

			if (Info != null)
			{
				DrawSeparator();
				foreach (string info in Info)
				{
					Console.WriteLine(" " + info);
				}
				DrawSeparator();
			}

			if (Commands != null)
			{
				DrawSeparator();
				foreach (string command in Commands)
				{
					Console.Write(" " + command + "\n", Color.Magenta);
				}
				DrawSeparator();
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Główna pętla Pokoju
		/// </summary>
		protected virtual void Main_Loop()
		{
			Console.Clear();
			Main_Loop();
		}

		/// <summary>
		/// Rysowanie Separatora(lini)
		/// </summary>
		void DrawSeparator()
		{
			for (int i = 0; i < Console.BufferWidth; i++)
			{
				Console.Write("=", Color.Tomato);			
			}
		}
	}
}
