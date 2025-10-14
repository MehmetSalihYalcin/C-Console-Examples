using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_27_Basit_Sınav_Geçmişi_Saklama
{
	internal class Program
	{

		static void Main(string[] args)
		{
			var ders = new Dersler();
			string filepath = "Dersler.txt";

			List<Dersler> _fakeDersler = new List<Dersler>();
			while (true)
			{
				AnaMenu();
				Console.Write("Yapmak İstediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				var data = File.ReadAllLines(filepath);

				switch (islem)
				{
					case 1:

						Console.Write("Ders Adı : ");
						string dersim = Console.ReadLine();
						Console.Write("Vize Notu : ");
						double vize = Convert.ToDouble(Console.ReadLine());
						Console.Write("Final Notu : ");
						double final = Convert.ToDouble(Console.ReadLine());


						ders = new Dersler()
						{
							Id = data.Count() + 1,
							Ders = dersim,
							Final = final,
							Ortalamam = (vize * 0.4) + (final * 0.6),
							Vize = vize
						};
						string model = $"{ders.Id}\t {ders.Ders}\t {ders.Vize}\t {ders.Final}\t {ders.Ortalamam}";
						File.AppendAllText(filepath, model + Environment.NewLine);
						Console.WriteLine("Başarılı bir şekilde eklendi.");
						break;
					case 2:
						foreach (var item in data.ToList())
						{
							string[] parcala = item.Split(' ');
							Console.WriteLine($"{parcala[0]}\t {parcala[1]}\t {parcala[2]}\t {parcala[3]}\t {parcala[4]}");
						}
						break;
					case 3:
						Console.Write("Düzenlemek istediğiniz dersin ID'sini giriniz : ");
						int duzenlenecekId = Convert.ToInt32(Console.ReadLine());
						var duzenlenecekDers = data.Where(x => x.StartsWith(duzenlenecekId.ToString())).FirstOrDefault();
						if (duzenlenecekDers != null)
						{
							string[] parcala = duzenlenecekDers.Split(' ');
							Console.WriteLine($"Ders Adı : {parcala[1]}");
							Console.WriteLine($"Vize Notu : {parcala[2]}");
							Console.WriteLine($"Final Notu : {parcala[3]}");
							Console.WriteLine($"Ortalama Notu : {parcala[4]}");
							Console.Write("Yeni Ders Adı : ");
							string yeniDers = Console.ReadLine();
							Console.Write("Yeni Vize Notu : ");
							double yeniVize = Convert.ToDouble(Console.ReadLine());
							Console.Write("Yeni Final Notu : ");
							double yeniFinal = Convert.ToDouble(Console.ReadLine());

							var yeniModel = $"{duzenlenecekId}\t {yeniDers}\t {yeniVize}\t {yeniFinal}\t {(yeniVize * 0.4) + (yeniFinal * 0.6)}";
							var eskiModel = $"{duzenlenecekId}\t {parcala[1]}\t {parcala[2]}\t {parcala[3]}\t {parcala[4]}";

							var silDers = data.ToList().Where(x => !x.StartsWith(duzenlenecekDers.ToString())).ToList();
							File.WriteAllLines(filepath, silDers);  
							File.AppendAllText(filepath, yeniModel);
							Console.WriteLine("Başarılı bir şekilde düzenlendi.");
						}
						else
						{
							Console.WriteLine("Böyle bir ID bulunamadı.");
						}
						break;
					case 4:
						Console.Write("Silmek istediğiniz dersin ID'sini giriniz : ");
						int silinecekId = Convert.ToInt32(Console.ReadLine());
						var silinecekDers = data.Where(x => x.StartsWith(silinecekId.ToString())).FirstOrDefault();
						if (silinecekDers != null)
						{ 
							var yeniler = data.ToList().Where(x => !x.StartsWith(silinecekId.ToString())).ToList();
							File.WriteAllLines(filepath, yeniler);
							Console.WriteLine("Başarılı bir şekilde silindi.");
						}
						else
						{
							Console.WriteLine("Böyle bir ID bulunamadı.");
						}
						break;
					default:
						break;
				}
			}
		}
		public static void AnaMenu()
		{
			Console.WriteLine("\t ---------- Basit Sınav Sistemi ---------- \n\n" +
			"            1-) Ders Ekle\n" +
			"            2-) Derslerimi Listele\n" +
			"            3-) Dersler Düzenle\n" +
			"            4-) Ders Sil\n\n"
			);
		}
	}
}
