using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_8_Sıcaklık_Dönüştürücü
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Sıcaklık Dönüştürücü ---------- ");
			while (true)
			{
				Console.Write("Celsius’u Fahrenheit’a çevirmek için 1 tam tersi için 2 giriniz : ");
				int secenek = Convert.ToInt32(Console.ReadLine());

				if (secenek == 1)
				{
					Console.Write("Celsius değerini giriniz : ");
					int calsiuse = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Fahrenheit'e denk gelen değer : " + ((calsiuse * 9 / 5) - 32));
				}
				else if (secenek == 2)
				{
					Console.Write("Fahrenheit değerini giriniz : ");
					int fahren = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Celsius'e denk gelen değer : " + ((fahren + 32) * 5 / 9));
				}
				else
				{
					Console.WriteLine("Yanlış işlem");
				}
			}
		}
	}
}
