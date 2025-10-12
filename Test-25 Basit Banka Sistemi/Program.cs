using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_25_Basit_Banka_Sistemi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var hesap = new Hesaplar();
			List<Hesaplar> _hesaplar = new List<Hesaplar>(); 
			while (true)
			{ 
				bool icDonguCalisiyor = true;

				AnaMenu();
				Console.Write("Yapmak İstediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				if (islem == 1)
				{
					Console.Write("İsim Soyisim : ");
					string adSoyad = Console.ReadLine();
					Console.Write("Şifre : ");
					string sifre = Console.ReadLine();
					hesap = new Hesaplar()
					{
						Id = _hesaplar.Count + 1,
						Bakiye = 0,
						Iban = "TR" + new Random().Next(10000, 99999).ToString(),
						Sifre = sifre,
						ısım = adSoyad
					};
					_hesaplar.Add(hesap);
					Console.WriteLine("Hesabınız Oluşturuldu. İban Numaranız : " + hesap.Iban + "\n\n\n\n");
				}
				else if (islem == 2)
				{
					Console.Write("Şifre : ");
					string sifre = Console.ReadLine();
					hesap = _hesaplar.FirstOrDefault(x => x.Sifre == sifre); 
					if (hesap != null)
					{
						while (icDonguCalisiyor)
						{ 
							ParaYatirMenu();
							Console.Write("Yapmak İstediğiniz işlem : ");
							int hesapIslem = Convert.ToInt32(Console.ReadLine());
							switch (hesapIslem)
							{
								case 1:
									Console.WriteLine("\nYatırmak İstediğiniz Tutar : ");
									int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
									hesap.Bakiye += yatirilacakTutar;
									Console.WriteLine("Güncel Bakiye : " + hesap.Bakiye + "\n\n\n\n");
									break;
								case 2: 
									Console.Write("\nGöndermek İstediğiniz Tutar : ");
									int gonderilecekkTutar = Convert.ToInt32(Console.ReadLine());
									Console.Write("\nIban : ");
									string iban = Console.ReadLine();

									var alıcı = _hesaplar.FirstOrDefault(x => x.Iban == iban.ToString());
									var gonderici = _hesaplar.FirstOrDefault(x => x.Sifre == sifre);
									if (alıcı != null && gonderici != null && gonderici.Bakiye >= gonderilecekkTutar)
									{
										gonderici.Bakiye -= gonderilecekkTutar;
										alıcı.Bakiye += gonderilecekkTutar;
										Console.WriteLine("Para Gönderme İşlemi Başarılı.");
										Console.WriteLine("Güncel Bakiye : " + gonderici.Bakiye + "\n\n\n\n");
									}
									else
									{
										Console.WriteLine("İşlem Başarısız. Yetersiz Bakiye veya Geçersiz IBAN.");
									}
									Console.WriteLine("Güncel Bakiye : " + hesap.Bakiye + "\n\n\n\n");
									break;
								case 3:
									Console.WriteLine("\nÇekmek İstediğiniz Tutar : ");
									int cekilecekkTutar = Convert.ToInt32(Console.ReadLine());
									hesap.Bakiye -= cekilecekkTutar;
									Console.WriteLine("Güncel Bakiye : " + hesap.Bakiye + "\n\n\n\n");
									break;
								case 4:
									icDonguCalisiyor = false; // İç döngüden çık 
									break;
								default:
									break;
							}
						}
					}
					else
					{
						Console.WriteLine("Böyle bir hesap bulunamadı.");
					}
				}
				else
				{
					Console.WriteLine("Hatalı işlem yaptınız.");
				}
			}
		}

		public static void AnaMenu()
		{
			Console.WriteLine("\t ---------- Basit Banka Sistemi ---------- \n\n" +
			"            1-) Hesap Oluştur\n" +
			"            2-) Hesabım\n\n"
			);
		}
		public static void ParaYatirMenu()
		{
			Console.WriteLine("\t ---------- Basit Banka Sistemi ---------- \n\n" +
			"            1-) Para Yatır\n" +
			"            2-) Para Gönder\n" +
			"            3-) Para çek\n" +
			"            4-) Ana Menü\n\n"
			); 
		}
	}
}
