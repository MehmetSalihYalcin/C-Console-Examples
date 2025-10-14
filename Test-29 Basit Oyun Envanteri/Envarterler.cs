using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_29_Basit_Oyun_Envanteri
{
	public class Envarterler
	{
		public int Id { get; set; }
		public string Adi { get; set; }
		public string Turu { get; set; }
		public string Nadirlik { get; set; }

		public Envarterler( string name, string type, string rarity)
		{
			Id = Id+1;
			Adi = name;
			Turu = type;
			Nadirlik = rarity;
		}
	}
}
