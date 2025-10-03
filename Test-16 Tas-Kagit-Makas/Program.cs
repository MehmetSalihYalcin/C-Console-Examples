
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_16_Tas_Kagit_Makas
{
	internal class Program
	{
		static void Main(string[] args)
		{ 
			
			while (true)
			{
				Random rnd = new Random();
				var rastgele = rnd.Next(1,3);
				Console.WriteLine(" ---------- Taş-Kağıt-Makas ---------- \n\n" +
					"            1-)  Taş\n" +
					"            2-) Kağıt\n" +
					"            3-) Makas\n\n"
					);

				Console.Write("Yapmak İstediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				if (islem == rastgele)
				{
					Console.WriteLine("Berabere");
				}
				else if (islem == 1)
				{
					if (rastgele != 2) Console.WriteLine(islem + " - "+ rastgele +" Sen kazandım ben kaybettin");
					else Console.WriteLine(islem + " - " + rastgele + " Ben kazandım sen kaybettin");
				}
				else if (islem == 2)
				{
					if (rastgele == 1) Console.WriteLine(islem + " - " + rastgele + " Sen kazandım ben kaybettin");
					else Console.WriteLine(islem + " - " + rastgele + " Ben kazandım sen kaybettin");
				}
				else if (islem == 3)
				{
					if (rastgele == 2) Console.WriteLine(islem + " - " + rastgele + " Sen kazandım ben kaybettin");
					else Console.WriteLine(islem + " - " + rastgele + " Ben kazandım sen kaybettin");
				}
				else 
				{
					Console.WriteLine("Hatalı işlem !!!");
				}
			}
		}
	}
}
