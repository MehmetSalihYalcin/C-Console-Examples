using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_22_Dosya_Tabanlı_Not_Defteri
{
	public class Program
	{
		static void Main(string[] args)
		{
			string filePath = "Gunluk_DB.txt";
			var gunluk = new Gunluk();
			int count = 1;

			while (true)
			{
				Console.WriteLine("\t ---------- Dosya Tabanlı Not Defteri ---------- \n\n" +
					"            1-) Yeni Günlük Sayfası Ekle\n" +
					"            2-) Günlük Sayfalarını Listele\n" +
					"            3-) Günlük Sayfası Sil\n\n"
					);

				Console.Write("Yapmak İstediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				switch (islem)
				{
					case 1:

						Console.Write("Günlük : ");
						string ekle = Console.ReadLine();
						gunluk = new Gunluk()
						{
							Id = count,
							Gunluk_Yazısı = ekle,
							Tarih = DateTime.Now
						};
						string yeniVeri = $"{gunluk.Id},{gunluk.Gunluk_Yazısı},{gunluk.Tarih.ToShortDateString()}";
						File.WriteAllText(filePath, yeniVeri + Environment.NewLine);
						count++;
						break;
					case 2:
						string[] satirlar = File.ReadAllLines(filePath);
						foreach (var item in satirlar)
						{ 
							string[] parcalar = item.Split(',');
							Console.Write("Günlük Id : " + parcalar[0]);
							Console.Write("\t Günlük : " + parcalar[1]);
							Console.Write("\t  Günlük Tarihi : " + parcalar[2]);
							Console.WriteLine();
						}
						break;
					case 3:
						Console.Write("Silinecek günlük id : ");
						int sil = Convert.ToInt32(Console.ReadLine());

						string[] silinecekSatir = File.ReadAllLines(filePath);
						foreach (var item in silinecekSatir)
						{
							string[] parcalar = item.Split(',');
							if (Convert.ToInt32(parcalar[0]) == sil)
							{
								var data = $"{parcalar[0]},{parcalar[1]},{parcalar[2]}";
								silinecekSatir.ToList().Remove(data) ;
							}
						}
						break;
					default:
						break;
				}
			}
		}
	}
}
