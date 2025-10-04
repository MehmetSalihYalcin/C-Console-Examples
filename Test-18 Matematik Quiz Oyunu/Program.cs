using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_18_Matematik_Quiz_Oyunu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Matematik Quiz Oyunu ---------- ");
			char[] islemler = { '+', '-', '*','/'};
			Random randomIslem = new Random();
			double dogruCevap = 0;
			int soruSayısı = 10;
			int puan = 0;
			while (soruSayısı > 0)
			{ 
				char rnd = Convert.ToChar(islemler[randomIslem.Next(0, 4)]);
				int ilkSayi = randomIslem.Next(1 ,100);
				int ikinciSayi = randomIslem.Next(1 ,100);

				switch (rnd)
				{
					case '+':
						dogruCevap = ilkSayi + ikinciSayi;
						break;
					case '-':
						dogruCevap = ilkSayi - ikinciSayi;
						break;
					case '*':
						dogruCevap = ilkSayi * ikinciSayi;
						break;
					case '/':
						dogruCevap = ilkSayi / ikinciSayi; // Tam bölünme garantilendi
						break;
					default:
						dogruCevap = 0; // Bu satır hata önlemek için, normalde buraya gelinmez
						break;
				}

				Console.Write(ilkSayi+" "+rnd.ToString() + " " + ikinciSayi +"\tişlemin sonucu nedir : ");
				double cevap = Convert.ToInt32(Console.ReadLine());

				if (cevap == dogruCevap)
				{
					Console.WriteLine("Doğru cevap!");
					puan = puan + 10;
				}
				else
				{
					Console.WriteLine( "Yanlış cevap! Doğru cevap: "+dogruCevap);
				}
				soruSayısı--;
			}
			Console.WriteLine("Puanınız : " + puan);
		}
	}
}
