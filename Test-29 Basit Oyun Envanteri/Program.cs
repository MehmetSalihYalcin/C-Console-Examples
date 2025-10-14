using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_29_Basit_Oyun_Envanteri
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Envarterler> envanterler = new List<Envarterler>();
			while (true)
			{
				Console.WriteLine("\n\n ---------- Basit Oyun Envanteri ---------- \n\n" +
						"            1-) Envarter Ekle\n" +
						"            2-) Envarter Listele\n" +
						"            3-) Envarter Sil\n\n"
						);

				Console.Write("Yapmak istediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				switch (islem)
				{
					case 1:
								Console.Write("Envanter Adı : ");
								string name = Console.ReadLine();
								Console.Write("Envanter Türü : ");
								string type = Console.ReadLine();
								Console.Write("Envanter Nadirlik : ");
								string rarity = Console.ReadLine();
								var envarter = new Envarterler(name, type, rarity);
								envanterler.Add(envarter);
						break;
					case 2:
								foreach (var item in envanterler)
								{
									Console.WriteLine($"ID : {item.Id} | Adı : {item.Adi} | Türü : {item.Turu} | Nadirlik : {item.Nadirlik}");
								}
						break;
					case 3:
								Console.Write("Silmek istediğiniz envanterin ID'si : ");
								int id = Convert.ToInt32(Console.ReadLine());
								var silinecek = envanterler.FirstOrDefault(x => x.Id == id);
								if (silinecek != null)
								{
									envanterler.Remove(silinecek);
									Console.WriteLine("Envanter silindi.");
								}
								else
								{
									Console.WriteLine("Envanter bulunamadı.");
								}
						break;
					default:
						break;
				}
			}
		}
	}
}
