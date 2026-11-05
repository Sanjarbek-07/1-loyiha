using System;
namespace Funksiyalar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 45;
			int b;
			DI5(ref a);
			Console.WriteLine(a);
		}


		static void DI5(ref int alfa )
		{
			alfa = alfa + 5;
		}
		static string DI4()
		{
			return "hvshh";

		}

	}
}
