using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_30_Metin_Analiz_Aracı
{
	internal class Program
	{
		static void Main(string[] args)
		{ 
			string[] harfler = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
			while (true)
			{
				Console.WriteLine("\n\n ---------- Metin Analiz Aracı ---------- \n\n");

				Console.Write("Metin giriniz : ");
				string metin = Console.ReadLine();
				metin  = metin.ToLower();
				int harfSayisi = 0;
				int cumleSayisi = 0;
				int kelimeSayisi = 0;

				for (int i = 0; i < metin.Length; i++)
				{ 
					if (metin[i] != ' ' && harfler.Contains(metin[i].ToString()) == true)
					{
						harfSayisi++;
					}
					else if (metin[i] != ' ' && harfler.Contains(metin[i].ToString()) == false)
					{
						cumleSayisi++;
					}
					else if (metin[i] == ' ')
					{
						kelimeSayisi++;
					}
				}
				Console.WriteLine("Toplam harf sayısı : "+harfSayisi +" Cümle Sayısı : " +cumleSayisi + " Kelime Sayısı : " + kelimeSayisi);
			}
		}
	}
}
