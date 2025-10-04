using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_19_Basit_Çarpım_Tablosu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Basit Çarpım Tablosu ---------- ");

			while (true)
			{
				Console.Write("Sayı giriniz : ");
				int sayi = Convert.ToInt32(Console.ReadLine());

				for (int i = 1; i <= sayi; i++)
				{
					for (int j = 1; j <= sayi; j++)
					{
						Console.Write(i*j + "\t");
					}
					Console.WriteLine();
				}
			}
		}
	}
}