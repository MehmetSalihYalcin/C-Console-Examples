using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_31_Kronometre
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("\n\nKronometre Başlatmak İçin 's' Durdurmak İçin 'd' Tuşlayınız.");
				char input = Console.ReadKey(true).KeyChar;
				DateTime startTime = DateTime.Now;
				DateTime endTime = DateTime.Now;

				if (input == 's')
				{
					Console.WriteLine("\nKronometre Başladı...");
					while (true)
					{
						char stopInput = Console.ReadKey(true).KeyChar;
						if (stopInput == 'd')
						{
							endTime = DateTime.Now;
							Console.WriteLine("Kronometre Durduruldu.");
							TimeSpan elapsedTime = endTime - startTime;
							Console.WriteLine($"Geçen Süre: {elapsedTime.TotalSeconds} saniye");
							break;
						}
					}
				}
				else
				{
					Console.WriteLine("Geçersiz Giriş. Lütfen 's' veya 'd' Tuşlayınız.");
				}
			}
		}
	}
}
