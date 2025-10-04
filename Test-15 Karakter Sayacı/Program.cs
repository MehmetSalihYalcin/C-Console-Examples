using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_15_Karakter_Sayacı
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Karakter Sayacı ---------- \n\n");

			while (true)
			{
				int sayac = 0;
				Console.Write("Metin giriniz : ");
				string metin = Console.ReadLine();
				metin = metin.ToLower();
				string[] metinKelimeleri = new string[metin.Split(' ').Count()];
				metinKelimeleri = metin.Split(' ');
				Dictionary<string, int> kelimeSayilari = new Dictionary<string, int>();


				foreach (string kelime in metinKelimeleri)
				{
					if (kelimeSayilari.ContainsKey(kelime))
					{
						kelimeSayilari[kelime]++;
					}
					else
					{
						kelimeSayilari.Add(kelime, 1);
					}
				}
				foreach (var kelime in kelimeSayilari)
				{ 
					Console.WriteLine("Metin içinde " + kelime.Value + " adet " + kelime.Key + " var");
				}
			}
		}
	}
}
