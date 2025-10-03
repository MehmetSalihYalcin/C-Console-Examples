using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_14_Zamanlayıcı
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Zamanlayıcı ---------- \n\n");
			while (true)
			{
				Console.Write("Geri sayma sayınızı giriniz : ");
				int sayi = Convert.ToInt32(Console.ReadLine());

				for (int i = sayi; i >= 0; i--)
				{
					 Thread.Sleep(1000);
					Console.WriteLine(i);
				}
			}
		}
	}
}
