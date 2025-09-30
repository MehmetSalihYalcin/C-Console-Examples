using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_5_FizzBuzz
{
	public class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine(" ---------- FizzBuzz ---------- ");

			int Number = 1;

			while (Number <= 100)
			{
				 if ((Number % 3) == 0 && (Number % 5) == 0)
				{
					Console.WriteLine(Number + " Sayısı FizzBuzz"); 
				}

				else if ( (Number % 3)  == 0)
				{
					Console.WriteLine(Number + " Sayısı Fizz"); 
				}
				else if ((Number % 5) == 0)
				{
					Console.WriteLine(Number + " Sayısı Buzz"); 
				}
				else
				{
					Console.WriteLine(Number);
				}
				Number++;
			}
		}
	}
}
