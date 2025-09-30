using System;

namespace Test_3_Sayı_Tahmini
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ------- Sayı Tahmin Oyunu ------- ");
			Random randomNumber = new Random();
			int rnd = randomNumber.Next(1, 10);
			while (true)
			{
				Console.Write("Sayıyı Tahmin Edin : ");
				int userResponse = Convert.ToInt32(Console.ReadLine());

				if (userResponse == rnd)
				{
					Console.WriteLine("Tebrikler sayıyı doğru tahmin ettiniz.");
					break;
				}
				else if (userResponse <= rnd)
					Console.WriteLine("Tahmin ettiğiniz sayı küçük !!!");
				else if (userResponse >= rnd)
					Console.WriteLine("Tahmin ettiğiniz sayı büyük !!!");
				else
				{
					Console.WriteLine("Geçersiz sayı !!!");
				}
			}
		}
	}
}
