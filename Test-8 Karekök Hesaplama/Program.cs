using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7_Karekök_Hesaplama
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Karekök Hesaplama ---------- ");

			while (true)
			{
				Console.Write("Sayı giriniz : ");
				double number = Convert.ToInt32(Console.ReadLine());

				double yaklasikDeger = number / 2;
				double epsilon = 0.000001;

				while(Math.Abs(yaklasikDeger * yaklasikDeger - number) > epsilon)
				{
					yaklasikDeger = (yaklasikDeger + number / yaklasikDeger) / 2;
				}
				Console.WriteLine(number + " sayısının karekökü: " + yaklasikDeger);
			}
		}
	}
}
