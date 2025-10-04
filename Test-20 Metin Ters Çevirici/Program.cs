using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_20_Metin_Ters_Çevirici
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Metin Ters Çevirici ---------- ");

			while (true)
			{
				string[] metinKelimeleri = { };
				Console.WriteLine("Mretin giriniz : ");
				string metin = Console.ReadLine();
				metinKelimeleri = metin.Split(' ');

				for (int i = metinKelimeleri.Length-1; i >= 0; i--)
				{
					Console.Write(metinKelimeleri[i].Reverse().ToArray());
					Console.Write(" ");
				}
			}
		}
	}
}