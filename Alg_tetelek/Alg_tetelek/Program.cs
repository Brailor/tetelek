using System;

namespace Alg_tetelek
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			tetel_2();
			Console.ReadKey();
		}
		static void tetel_1(){
			Console.Clear();
			Console.WriteLine("Mekkora tömböt szeretnél feltölteni?:");
			int elem = int.Parse(Console.ReadLine());
			int[] tomb = new int[elem];
			Console.Clear();
			for (int i = 0; i < elem; i++)
			{
				
				tomb[i] = int.Parse(Console.ReadLine());
			
				Console.WriteLine("Szám feltöltve!");

			}

		}
		static void tetel_2(){
			Console.WriteLine("Add meg a végértéket:");
			int szam = int.Parse(Console.ReadLine());
			Random r = new Random();
			int vsz = r.Next(1, szam);
			Console.WriteLine("A véletlen szám: " + vsz);
		}

	}
}

