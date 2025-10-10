using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_23_Kütüphane_Yönetim_Sistemi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var kitapModel = new List<Kutuphane>();
			int count = 1;

			while (true)
			{
				Console.WriteLine("\t ---------- Kütüphane Yönetim Sistemi ---------- \n\n" +
					"            1-) Kitap Ekle\n" +
					"            2-) Kütüphane Listele\n" +
					"            3-) Kitap Sil\n\n"
					);

				Console.Write("Yapmak İstediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				switch (islem)
				{
					case 1:

						Console.Write("Kitap Adı : ");
						string kitapAdi = Console.ReadLine();
						Console.Write("Kitap Yazarı : ");
						string kitapYazari = Console.ReadLine();

						var kitap = new Kutuphane()
						{
							Id = count,
							Kitap_Adi = kitapAdi,
							Yazar = kitapYazari,
							Kayit_Tarihi = DateTime.Now
						};
						kitapModel.Add(kitap);
						count++;
						break;
					case 2:
						foreach (var item in kitapModel)
						{
							Console.Write("Id : " + item.Id);
							Console.Write("\t Kitap Adı : " + item.Kitap_Adi);
							Console.Write("\t  Kitap Yazarı : " + item.Yazar);
							Console.Write("\t  Oluşturulma Tarihi : " + item.Kayit_Tarihi.ToShortTimeString());
							Console.WriteLine();
						}
						break;
					case 3:
						Console.Write("Silinecek Kitap id : ");
						int sil = Convert.ToInt32(Console.ReadLine());
						var delete = kitapModel.Where(x => x.Id == sil).SingleOrDefault();
						kitapModel.Remove(delete);
						break;
					default:
						break;
				}
			}
		}
	}
}
