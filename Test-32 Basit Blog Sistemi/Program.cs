using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_32_Basit_Blog_Sistemi
{
	internal class Program
	{
		static void Main(string[] args)
		{  
			string filepath = "Blogs.txt";
			while (true)
			{
				var data = File.ReadAllLines(filepath);
				Console.WriteLine("\t ---------- Bloglarım ---------- \n\n" +
					"            1-) Blog Ekle\n" +
					"            2-) Bloglarımı Listele\n" +
					"            3-) Blog Sil\n\n"
					);

				Console.Write("Yapmak İstediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				switch (islem)
				{
					case 1:

						Console.Write("Başlık : ");
						string baslik = Console.ReadLine();
						Console.Write("Açıklama : ");
						string aciklama = Console.ReadLine();

						var blog = new BlogModel()
						{
							Id = data.Length,
							Title = baslik,
							Description = aciklama,
							CreateTİme = DateTime.Now
						}; 
						string model = $"{blog.Id}\t {blog.Title}\t {blog.Description}\t {blog.CreateTİme.ToShortDateString()}";
						File.AppendAllText(filepath, model + Environment.NewLine); 
						break;
					case 2:

						foreach (var item in data)
						{
							string[] parcala = item.Split('\t');
							Console.Write("Id : " + parcala[0]);
							Console.Write("\t Başlık : " + parcala[1]);
							Console.Write("\t  Açıklama : " + parcala[2]);
							Console.Write("\t  Oluşturulma Tarihi : " + parcala[3]);
							Console.WriteLine();
						} 
						break;
					case 3:
						Console.Write("Silinecek Blog id : "); 
						int silinecekId = Convert.ToInt32(Console.ReadLine());
						var silinecekblog = data.Where(x => x.StartsWith(silinecekId.ToString())).FirstOrDefault();
						if (silinecekblog != null)
						{
							var yeniler = data.ToList().Where(x => !x.StartsWith(silinecekId.ToString())).ToList();
							File.WriteAllLines(filepath, yeniler); 
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
	}
}
