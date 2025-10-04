using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_17_Basit_Sifre_Uretici
{
	internal class Program
	{
		static void Main(string[] args)
		{
			object[] sifreKarakterleri = { "a", "A", "b", "B", "c", "C", 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, "Q", "q", "*", "/", "&" };//...

			Console.WriteLine(" ---------- Basit Şifre Üretici ---------- ");
			Random randomAl = new Random();
			while (true)
			{
				string sifre = string.Empty;
				Console.Write("\nŞifre uzunluğunu giriniz : ");
				int sayi = Convert.ToInt32(Console.ReadLine());

				for (int i = 0; i < sayi; i++)
				{
					var rnd = randomAl.Next(0, sifreKarakterleri.Length);
					sifre = sifre + sifreKarakterleri[rnd].ToString();
				}

				Console.Write("Şifre : " + sifre);
			}
		}
	}
}
