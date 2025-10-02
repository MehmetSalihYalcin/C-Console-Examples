using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_12_Fibonacci_Serisi
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Fibonacci Serisi ---------- ");

			while (true)
			{
				Console.Write("Kaç tane fibonacci sayısı getireyim : ");
				int sayı = Convert.ToInt32(Console.ReadLine());
				int[] sayilar = new int[sayı];
				sayilar[0] = 1;
				sayilar[1] = 1;

				for (int i = 2; i < sayı; i++) // 
				{ 
					sayilar[i] = Convert.ToInt32(sayilar[i - 1]) + Convert.ToInt32(sayilar[i - 2]);
				}
				for (int i = 0; i < sayilar.Length; i++)
				{
					Console.WriteLine(sayilar[i]);
				}
			}
		}
	}
} //1-1- 2-3-5-8-13 ...
