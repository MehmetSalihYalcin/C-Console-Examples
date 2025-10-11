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
			var fakeModel = new List<Gunluk>();
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
						File.AppendAllText(filePath, yeniVeri + Environment.NewLine);
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
						if (sil > 0) // ID'nin geçerli bir sayı olduğunu kontrol et
						{
							var silData = File.ReadAllLines(filePath);
							bool bulundu = false;

							// Dosyadan verileri oku ve fakeModel'e yükle
							foreach (var line in silData)
							{
								string[] parcalar = line.Split(',');
								if (parcalar.Length == 3) // Satırın doğru formatta olduğunu kontrol et
								{
									var kelime = new Gunluk
									{
										Id = int.Parse(parcalar[0]), 
										 Gunluk_Yazısı = parcalar[1],
										Tarih = DateTime.Parse(parcalar[2])
									};
									if (kelime.Id != sil) // Silinecek ID değilse listeye ekle
									{
										fakeModel.Add(kelime);
									}
									else
									{
										bulundu = true; // Silinecek kelime bulundu
									}
								}
							}

							if (!bulundu)
							{
								Console.WriteLine("Bu ID'ye sahip bir günlük bulunamadı.");
								break;
							}

							// Dosyayı güncelle
							File.WriteAllText(filePath, string.Empty); // Dosyayı temizle
							foreach (var item in fakeModel)
							{
								string data = $"{item.Id},{item.Gunluk_Yazısı} ,{item.Tarih.ToShortDateString()}";
								File.AppendAllText(filePath, data + Environment.NewLine);
							}

							Console.WriteLine("Başarılı bir şekilde gunlük silindi");
						}
						else
						{
							Console.WriteLine("Boş veri girilemez !!!");
						}
						break; 
					default:
						break;
				}
			}
		}
	}
}
