using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_13_Basit_ATM_Simülasyonu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int _banka = 0;
			while (true)
			{
				Console.WriteLine(" ---------- Basit ATM Simülasyonu ---------- \n\n" +
					"            1-) Güncel Bakiye\n" +
					"            2-) Pare Çek\n" +
					"            3-) Pare Yatır\n\n"
					);

				Console.Write("Yapmak İstediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				if (islem == 1)
				{
					Console.WriteLine("Güncel Bakiyeniz : " + " "+_banka+" TL");
				}
				else if (islem == 2)
				{
					Console.WriteLine("Çekmek istediğiniz tutar : ");
					int cek = Convert.ToInt32(Console.ReadLine());
					_banka = _banka - cek; 
					Console.WriteLine("\nGüncel Bakiyeniz : " + " " + _banka + " TL");
				}
				else if (islem == 3)
				{
					Console.WriteLine("Yatırmak istediğiniz tutar : ");
					int yatir = Convert.ToInt32(Console.ReadLine());
					_banka = _banka + yatir;
					Console.WriteLine("\nGüncel Bakiyeniz : " + " " + _banka + " TL");
				}
				else
				{
					Console.WriteLine("Yanlış işlem !!!" );
				}
			}
		}
	}
}
