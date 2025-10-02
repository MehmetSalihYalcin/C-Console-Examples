using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_9_Basit_Not_Defteri
{
	public class Program
	{
		static void Main(string[] args)
		{
			var _not = new List<NotDefteri>();
			int Id = 1;
			Console.WriteLine(" ---------- Not Defteri ---------- ");

			while (true)
			{
				Console.Write("Not Eklemek için 1 - Silmek için 2 : ");
				int secenek = Convert.ToInt32(Console.ReadLine());

				if (secenek == 1)
				{
					Console.Write("Notunuzu yazın : ");
					string Note = Console.ReadLine();

					var data = new NotDefteri
					{
						Note = Note,
						Id = Id
					};
					_not.Add(data);
					foreach (var item in _not)
					{
						Console.WriteLine(item.Id + "  " + item.Note);
					}
					Id++;
				}
				else if (secenek == 2)
				{
					Console.Write("Silinecek not id yazın : ");
					int notId = Convert.ToInt32(Console.ReadLine());
					 
					var response = _not.Find(x => x.Id == notId);
					_not.Remove(response);
				}
				else Console.WriteLine("Yanlış işlem");
			}
		}
	}
}
