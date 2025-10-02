using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_10_Kelime_Sayacı
{
	public class Program
	{
		static void Main(string[] args)
		{  
			Console.WriteLine(" ---------- Kelime Sayacı ---------- ");

			while (true)
			{
				Console.Write("Metin giriniz : ");
				string secenek = Console.ReadLine() ;
				 var count = secenek.Split(' ');
				Console.WriteLine("Kelime sayısı : " + count.Length);
			}
		}
	}
}
