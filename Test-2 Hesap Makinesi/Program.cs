using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2_Hesap_Makinesi
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" --------- Hesap Makinesi --------- ");
			Console.Write("İlk Sayınız : ");
			int Number_1 = int.TryParse(Console.ReadLine(), out int num1) ? num1 : 0;
			Console.Write("İkinci Sayınız : ");
			int Number_2 = int.TryParse(Console.ReadLine(), out int num2) ? num2 : 0;
			Console.WriteLine("Hangi işlemi yapmak istersiniz (+, -, *, /) : ");
			string Process = Console.ReadLine();

			switch (Process)
			{
				case "+":
					Console.Write("İki sayınızın toplamı : " + (Number_1 + Number_2));
					break;

				case "-":
					Console.Write("İki sayınızın farkı : " + (Number_1 - Number_2));
					break;

				case "*":
					Console.Write("İki sayınızın çarpımı : " + (Number_1 * Number_2));
					break;

				case "/":
					Console.Write("İki sayınızın bölümü : " + (Number_1 / Number_2));
					break;

				default:
					break;
			}
		}
	}
}
