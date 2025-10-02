using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_11_Palindrom
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ---------- Not Defteri ---------- ");

			while (true)
			{
				Console.Write("Kelime giriniz : ");
				string kelime = Console.ReadLine();
				string tersHali = "";
				char[] chars = kelime.ToLower().ToCharArray();

				for (int i = chars.Length - 1; i > -1; i--)
				{
					tersHali = tersHali + chars[i];
				}

				if (kelime == tersHali)
				{
					Console.WriteLine(kelime + "Kelimesi palindrom");
				}
				else
				{
					Console.WriteLine(kelime + "Kelimesi palindrom değil");
				}
			}
		}
	}
}
