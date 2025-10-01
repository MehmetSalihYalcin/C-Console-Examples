using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_6_Asal_Sayı_Kontrolü
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Asal Sayı Kontrölü ---------- ");

			while (true)
			{ 
				Console.Write("Sayı giriniz : ");
				int number = Convert.ToInt32(Console.ReadLine());
				if (number == 1)
				{
					Console.WriteLine("Bu sayı bir asal sayı değildir.");
					continue;
				}
				if (number == 2)
				{
					Console.WriteLine("Bu sayı bir asal sayıdır.");
					continue;
				}


				bool isPrime = true;
				for (int i = 2; i <= Math.Sqrt(number); i++)
				{
					if (number % i == 0)
					{
						isPrime = false;
						break;
					}
				}

				Console.WriteLine(isPrime ? "Bu sayı bir asal sayıdır." : "Bu sayı bir asal sayı değildir.");
			}
		}
	}
}
