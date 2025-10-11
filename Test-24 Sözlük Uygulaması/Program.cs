using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test_24_Sözlük_Uygulaması
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var sozlukModel = new Sozluk();
			string filepath = "Sozluk.txt";
			var fakeModel = new List<Sozluk>();

			while (true)
			{
				Console.WriteLine("\t ---------- Kütüphane Yönetim Sistemi ---------- \n\n" +
					"            1-) Kelime Ekle\n" +
					"            2-) Kelime Listele\n" +
					"            3-) Kelime Sil\n" +
					"            4-) Kelime Ara\n\n"
					);

				Console.Write("Yapmak İstediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				switch (islem)
				{
					case 1:
						Console.Write("Kelimenin Türkçesi : ");
						string turkceKelime = Console.ReadLine();
						Console.Write("Kelimenin İngilizcesi : ");
						string ingilizceKelime = Console.ReadLine();

						if (turkceKelime != null || ingilizceKelime != null)
						{
							var count = File.ReadLines(filepath).Count();  // txt dosyasındaki verilerin sayısını al ve 1 fazlası ile yeni verinin id değerini belirle
							var model = new Sozluk()
							{
								Id = count + 1,
								Turkce_Adi = turkceKelime,
								Ingilizce_Adi = ingilizceKelime,
								Tarih = DateTime.Now
							};
							string data = $"{model.Id},{model.Turkce_Adi + " = " + ingilizceKelime},{model.Tarih.ToShortDateString()}";
							File.AppendAllText(filepath, data + Environment.NewLine);
							Console.WriteLine("Başarılı bir şekilde kelime eklendi");
						}
						else
						{
							Console.WriteLine("Boş Alan Girilemez !!!");
						}
						break;
					case 2:
						var dataRead = File.ReadLines(filepath);
						foreach (var line in dataRead)
						{
							string[] parcala = line.Split(',');
							Console.WriteLine($"{parcala[0]}\t{parcala[1]}\t{parcala[2]}");
						}
						break;
					case 3:
						Console.Write("Silinecek kelime id : ");
						int sil = Convert.ToInt32(Console.ReadLine());
						if (sil > 0) // ID'nin geçerli bir sayı olduğunu kontrol et
						{
							var silData = File.ReadAllLines(filepath);
							bool bulundu = false;

							// Dosyadan verileri oku ve fakeModel'e yükle
							foreach (var line in silData)
							{
								string[] parcalar = line.Split(',');
								if (parcalar.Length == 3) // Satırın doğru formatta olduğunu kontrol et
								{
									var kelime = new Sozluk
									{
										Id = int.Parse(parcalar[0]),
										Turkce_Adi = parcalar[1].Split('=')[0].Trim(), // "Türkçe = İngilizce" formatından Türkçe'yi al
										Ingilizce_Adi = parcalar[1].Split('=')[1].Trim(), // İngilizce'yi al
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
								Console.WriteLine("Bu ID'ye sahip bir kelime bulunamadı.");
								break;
							}

							// Dosyayı güncelle
							File.WriteAllText(filepath, string.Empty); // Dosyayı temizle
							foreach (var kelime in fakeModel)
							{
								string data = $"{kelime.Id},{kelime.Turkce_Adi} = {kelime.Ingilizce_Adi},{kelime.Tarih.ToShortDateString()}";
								File.AppendAllText(filepath, data + Environment.NewLine);
							}

							Console.WriteLine("Başarılı bir şekilde kelime silindi");
						}
						else
						{
							Console.WriteLine("Boş veri girilemez !!!");
						}
						break;
					case 4:
						Console.Write("Aranacak kelime : ");
						string ara = Console.ReadLine();
						var araData = File.ReadAllLines(filepath);

						// Dosyadan verileri oku ve fakeModel'e yükle
						foreach (var line in araData)
						{
							string[] parcalar = line.Split(',');
							if (parcalar.Length == 3) // Satırın doğru formatta olduğunu kontrol et
							{
								var kelime = new Sozluk
								{
									Id = int.Parse(parcalar[0]),
									Turkce_Adi = parcalar[1].Split('=')[0].Trim(), // "Türkçe = İngilizce" formatından Türkçe'yi al
									Ingilizce_Adi = parcalar[1].Split('=')[1].Trim(), // İngilizce'yi al
									Tarih = DateTime.Parse(parcalar[2])
								};
								if (kelime.Turkce_Adi.ToLower() == ara.ToLower() || kelime.Ingilizce_Adi.ToLower() == ara.ToLower()) // Silinecek ID değilse listeye ekle
								{
									sozlukModel = kelime;
								}
							}
						}
						Console.WriteLine($"\n" +sozlukModel.Id + "\t"+sozlukModel.Turkce_Adi+" = "+sozlukModel.Ingilizce_Adi+"\t"+sozlukModel.Tarih.ToShortDateString());
						break;
					default:
						break;
				}
			}
		}
	}
}
