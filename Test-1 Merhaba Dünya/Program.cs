using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1_Merhaba_Dünya
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Merhaba Dünya");
			Console.Write("Adınız : ");
			string Name = Console.ReadLine();
			Console.WriteLine("Merhaba " + Name + " Galaksiye Hoş Geldin !");
			Console.ReadKey();
		}
	}
}
