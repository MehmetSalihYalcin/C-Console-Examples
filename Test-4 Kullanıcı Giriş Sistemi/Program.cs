using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_4_Kullanıcı_Giriş_Sistemi
{
	public class Program
	{
		static void Main(string[] args)
		{
			LoginUserModel login = new LoginUserModel();
			string userName = "Test-User";
			string userPassword = "Test-User";

			Console.WriteLine(" ---------- Kullanıcı Giriş Paneli ---------- ");

			while (true)
			{
				Console.Write("Kullanıcı Adınız : ");
				login.UserName = Console.ReadLine();
				Console.Write("Kullanıcı Şifreniz : ");
				login.UserPassword = Console.ReadLine();

				if (login.UserName == userName && login.UserPassword == userPassword) 
				{
					Console.WriteLine("Giriş Başarılı.");
					break;
				}
				else
				{
					Console.WriteLine("Giriş Bilgilerin Yanlış !!!");
				}
			}
		}
	}
}
