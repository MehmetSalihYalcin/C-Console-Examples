using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_28_Kelime_Bulmaca_Oyunu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] kelimeler = { "elma", "armut", "muz", "çilek", "karpuz", "kavun", "kiraz", "şeftali", "erik", "ayva" };
			Random rnd = new Random();
			while (true)
			{
				string tahmin = "";
				var rastgele = rnd.Next(0, 9);
				string kelime = kelimeler[rastgele];
				char[] rastgeleKelimeHarfleri = new char[kelime.Length];
								for (int i = 0; i < kelime.Length; i++)
											{
												int randomIndex;
												do
												{
													randomIndex = rnd.Next(0, kelime.Length);
												} while (rastgeleKelimeHarfleri[randomIndex] != '\0');

												rastgeleKelimeHarfleri[randomIndex] = kelime[randomIndex];
												tahmin += rastgeleKelimeHarfleri[randomIndex].ToString();
								}
				Console.WriteLine("Kelime : " + tahmin);
				Console.Write("Kelimenin doğru yazılışını tahmin edin : ");
				string cevap = Console.ReadLine();

									if (cevap == kelime)
									{
												Console.WriteLine("Doğru tahmin");
									}
									else
									{
												Console.WriteLine("Yanlış");
									}
			}
		}
	}
}
