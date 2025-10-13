using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test_26_Metin_Şifreleyici
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char[] alfabe = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'y', 'z' };
			string sifreliMetin = "";
			while (true)
			{
				List<char> karakterler = new List<char>();  
				Console.Write("\nMetin Giriniz : ");
				string metin = Console.ReadLine();
				metin = metin.ToLower();
				for (int i = 0; i < metin.Length; i++)
				{
					karakterler.Add(metin[i]);  
				}
				for (int i = 0; i < karakterler.Count(); i++)
				{
					if (alfabe.Contains(karakterler[i]))
					{
						var data = Array.IndexOf(alfabe, karakterler[i]); 
						int newIndex = (data + 3) % alfabe.Length;// Kaydırma işlemini uygula (mod ile döngüsel kaydırma)
						sifreliMetin += alfabe[newIndex];
					} 
					else if (karakterler[i] == ' ')
					{
						sifreliMetin += " "; 
					}
					else
					{
						// Alfabe dışı karakterleri olduğu gibi yaz
						sifreliMetin += karakterler[i];
					}
				}

				Console.WriteLine("Şifrelenmiş Metin : " + sifreliMetin);
			}
		}
	}
}
