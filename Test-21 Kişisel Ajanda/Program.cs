using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_21_Kişisel_Ajanda
{
	public class Program
	{
		static void Main(string[] args)
		{
			var tasksList = new List<Tasks>();
			int count = 1;

			while (true)
			{
				Console.WriteLine("\t ---------- Kişisel Ajanda ---------- \n\n" +
					"            1-) Görev Ekle\n" +
					"            2-) Görev Listele\n" +
					"            3-) Görev Sil\n\n"
					);

				Console.Write("Yapmak İstediğiniz işlem : ");
				int islem = Convert.ToInt32(Console.ReadLine());

				switch (islem)
				{
					case 1:

						Console.Write("Görev : ");
						string ekle = Console.ReadLine();
						var data = new Tasks
						{
							Id = count,
							Görev = ekle,
							Olusturulma_Tarihi = DateTime.Now
						};
						tasksList.Add(data);

						count++;
						break;
					case 2:
						foreach (var item in tasksList)
						{
							Console.Write("Görev Id : " + item.Id);
							Console.Write("\t Görev : " + item.Görev);
							Console.Write("\t  Görev Tarihi : " + item.Olusturulma_Tarihi.ToShortTimeString());
							Console.WriteLine();
						}
						break;
					case 3: 
						Console.Write("Silinecek görev id : ");
						int sil = Convert.ToInt32(Console.ReadLine());
						var silinecekGorev = tasksList.Where(x => x.Id == sil).FirstOrDefault();
						tasksList.Remove(silinecekGorev);
						break;
					default:
						break;
				}
			}
		}
	}
}
