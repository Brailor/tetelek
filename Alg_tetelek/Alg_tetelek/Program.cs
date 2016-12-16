using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Collections.Generic;

namespace Alg_tetelek
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//	int n = int.Parse(Console.ReadLine());
			tetel_28();
			Console.ReadKey();
		}

		static void tetel_1()
		{
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

		static void tetel_2()
		{
			Console.WriteLine("Add meg a végértéket:");
			int szam = int.Parse(Console.ReadLine());
			Random r = new Random();
			int vsz = r.Next(1, szam);
			Console.WriteLine("A véletlen szám: " + vsz);
		}

		static void tetel_3()
		{
			Console.WriteLine("Mekkora tömböt szeretnél feltölteni?:");
			int elem = int.Parse(Console.ReadLine());
			int[] tomb = new int[elem];
			Random r = new Random();
			Console.Clear();
			for (int i = 0; i < elem; i++)
			{

				tomb[i] = r.Next(0, 1000);
				Console.Write("A tömb " + (i + 1) + ". eleme: " + tomb[i] + "\n");

			}
		}

		static void tetel_4()
		{
			bool end = false;
			int x;
			int db = 0;
			int[] tömb = new int[100];
			Console.WriteLine("A tömb feltöltéséhez írd be a számokat!");
			do
			{
				x = int.Parse(Console.ReadLine());

				if (x == 0)
				{
					Console.Write("Vége a feltöltésnek");
					end = true;
				}
				else {
					tömb[db] = x;
					Console.WriteLine("A tömb " + (db + 1) + ". eleme:" + x);
					db++;
				}

			} while (!end);

		}

		static void tetel_5()
		{

			Random r = new Random();
			Console.WriteLine("Mekkora tömböt szeretnél feltölteni?:");
			int elem = int.Parse(Console.ReadLine());
			int[] tömb = new int[elem];
			Console.WriteLine("A tömb 1. eleme:" + tömb[0]);
			for (int i = 1; i < elem; i++)
			{
				tömb[i] = tömb[i - 1] + r.Next(1, 100);
				Console.WriteLine("A tömb " + (i + 1) + ". eleme:" + tömb[i]);
			}

		}

		static void tetel_6()
		{
			Console.WriteLine("Add meg a mátrix adatait:[sor, oszlop]");
			int sor = int.Parse(Console.ReadLine());
			int oszlop = int.Parse(Console.ReadLine());
			if (sor < 1 || oszlop < 1)
			{
				Console.WriteLine("A mátrix adatainak pozitív egész számnak kell lenniük!");
				Console.ReadKey();
				tetel_6();
			}
			else {
				Console.WriteLine("########################################################");
				int[,] matrix = new int[sor, oszlop];
				for (int i = 0; i < sor; i++)
				{
					for (int j = 0; j < oszlop; j++)
					{
						matrix[i, j] = int.Parse(Console.ReadLine());

					}
					Console.WriteLine("Kész az " + (i + 1) + ". sor");
					Console.WriteLine("########################################################");
				}

			}
		}

		static void tetel_7()
		{
			Console.WriteLine("Mennyivel akarod megnövelni a tömb értékeit?");
			int kons = int.Parse(Console.ReadLine());
			int[] tomb = new int[15] { 0, 1, 5, 6, 7, 845, 56, 6, 9, 11, 27, 85, 99, 951, 77 };

			for (int i = 0; i < tomb.Length; i++)
			{
				Console.WriteLine("########################################################");
				Console.WriteLine("A tömb " + (i + 1) + ". eleme az összeadás előtt: " + tomb[i]);
				tomb[i] += kons;
				Console.WriteLine("A tömb " + (i + 1) + ". eleme az összeadás után: " + tomb[i]);
				Console.WriteLine("########################################################");
			}
		}

		static void tetel_8()
		{

			Console.WriteLine("Mennyivel akarod megszorozni a tömb értékeit?");
			int kons = int.Parse(Console.ReadLine());
			int[] tomb = new int[15] { 0, 1, 5, 6, 7, 845, 56, 6, 9, 11, 27, 85, 99, 951, 77 };

			for (int i = 0; i < tomb.Length; i++)
			{
				Console.WriteLine("########################################################");
				Console.WriteLine("A tömb " + (i + 1) + ". eleme az összeadás előtt: " + tomb[i]);
				tomb[i] *= kons;
				Console.WriteLine("A tömb " + (i + 1) + ". eleme az összeadás után: " + tomb[i]);
				Console.WriteLine("########################################################");
			}

		}

		static void tetel_9()
		{
			//matrix értékeinek összeadása... ResidentSleeper
		}

		static void tetel_10()
		{

			//matrix értékeinek szórzása... !PogChamp
		}

		static void tetel_11()
		{
			int[] tomb = new int[] { 94, 84156, 95256, 2223, 0, 13, 5, 42, 7, 84, 54, 6, 102 };
			int[] tomb2 = new int[tomb.Length];
			Console.WriteLine("Az első tömb elemei: " + string.Join(", ", tomb) + "");
			Console.WriteLine("A második tömb elemei: " + string.Join(", ", tomb2) + "\n");

			for (int i = 0; i < tomb.Length; i++)
			{
				tomb2[i] = tomb[i];
				Console.WriteLine("Az első tömb " + (i + 1) + ". eleme átmásolva a második tömbbe.");
			}
			Console.WriteLine("\nA másolás utáni tömb elemei: " + string.Join(", ", tomb2));
		}

		static void tetel_12()
		{
			//matrix másolása... Residen...
		}

		static void tetel_13()
		{
			Random r = new Random();
			int összeg = 0;
			int[] tömb = new int[r.Next(5, 30)];

			for (int i = 0; i < tömb.Length; i++)
			{
				tömb[i] = r.Next(0, 200);
				összeg += tömb[i];
			}
			Console.WriteLine("A tömb elemei: " + string.Join(",", tömb) + "\n");
			Console.WriteLine("A tömb elemeinek összege: " + összeg);


		}

		static void tetel_14()
		{
			Random r = new Random();
			long szorzat = 1;
			int[] tömb = new int[r.Next(2, 10)];

			for (int i = 0; i < tömb.Length; i++)
			{
				tömb[i] = r.Next(1, 55);
				szorzat *= tömb[i];
			}
			Console.WriteLine("A tömb elemei: " + string.Join(",", tömb) + "\n");
			Console.WriteLine("A tömb elemeinek szorzata: " + szorzat);

		}

		static void tetel_15()
		{
			int i = 0;

			int[] tömb = random_tomb(30, 1000);
			Console.WriteLine("Az eljárás megkeresi az első 5-tel osztható számot egy tömbben. <enter>");
			while (Console.ReadKey().Key != ConsoleKey.Enter) { }
			Console.Clear();
			Console.WriteLine("A meglévő tömb elemei: " + String.Join(",", tömb));
			bool talalat = false;
			int sorszam = 0;

			while (i < tömb.Length && !talalat)
			{
				if (tömb[i] % 5 == 0)
				{
					talalat = true;
					sorszam = i;
					Console.WriteLine("A keresett elem sorszáma a tömbben: " + sorszam);
				}
				++i;
			}

			if (i == tömb.Length && !talalat)
			{
				Console.WriteLine("A keresett elem nincs a tömb elemei között");
			}


		}

		static void tetel_16()
		{
			//	...

		}

		static void tetel_28(){
			int[] tömb = random_tomb(30, 500);
			Console.WriteLine("A tömb: " + string.Join(",", tömb) + "\n");
			var paros = new List<int>();

			for (int i = 0; i < tömb.Length; i++)
			{
				if(tömb[i] % 2 == 0){
					paros.Add(tömb[i]);
				}
			}
			int[] uj_tomb = paros.ToArray();
			Console.WriteLine("Az első tömb páros elemei átmásolva az új tömbbe: " + string.Join(",", uj_tomb));
		}

		static void tetel_29_binary(){
			
			int[] tömb = random_tomb(200, 1000);
			int csere;
			for (int j = 1; j < tömb.Length; j++)
			{
				{
					bool vege = true;

					for (int i = 0; i < tömb.Length - j; ++i)
					{
						if (tömb[i] > tömb[i + 1])
						{
							csere = tömb[i];
							tömb[i] = tömb[i + 1];
							tömb[i + 1] = csere;
							vege = false;
						}
					}

					if (vege == true)
					{
						break;
					}
				}

			}

			int min = 1;
			int max = tömb.Length;
			int tipp;
			Console.WriteLine("A lista elemei:" + string.Join(",", tömb) + "\n");
			Console.WriteLine("Melyik számot keresed?:");
			int keresett_szam = int.Parse(Console.ReadLine());
			bool megtalaltuk = false;
			while(!megtalaltuk && !(min > max))
			{
				tipp = (min + max) / 2;
				if(tömb[tipp] == keresett_szam){
					
					Console.WriteLine("A keresett szám a " + tipp + " indexű helyen van a listában.");
					megtalaltuk = true;

				}
				else if (tömb[tipp] < keresett_szam){
					min = tipp + 1;
				}
				else{
					max = tipp - 1;
				}

			}
			if(megtalaltuk == false){
				Console.WriteLine("A szám nincs a listában.");
			}
		}

		static void tetel_32(){

			int[] tömb = random_tomb(30, 1000);
			Console.WriteLine("A tömb elemei rendezés előtt:\n" + String.Join(",", tömb) + "\n");
			int csere;
			for (int i = 0; i < tömb.Length; i++)
			{
				for (int j = i + 1; j < tömb.Length; j++)
				{
					if(tömb[i] > tömb[j]){
						csere = tömb[i];
						tömb[i] = tömb[j];
						tömb[j] = csere;
					}
				}
			}
			Console.WriteLine("A tömb elemei rendezés után:\n" + String.Join(",", tömb));


		}

		static void tetel_35_bubble()
		{

			int[] tömb = random_tomb(30, 1000);
			Console.WriteLine("A tömb elemei rendezés előtt:\n" + String.Join(",", tömb) + "\n");
			int csere;


			for (int j = 1; j < tömb.Length; j++)
			{
				{
					bool vege = true;

					for (int i = 0; i < tömb.Length - j; ++i)
					{
						if (tömb[i] > tömb[i + 1])
						{
							csere = tömb[i];
							tömb[i] = tömb[i + 1];
							tömb[i + 1] = csere;
							vege = false;
						}
					}

					if (vege == true)
					{
						break;
					}
				}

			}
			Console.WriteLine("A tömb elemei rendezés után:\n" + String.Join(",", tömb));
		}
	


		static void tetel_38_insertion(){
			int x,j;

			int[] tömb = random_tomb(30, 1000);
			Console.WriteLine("A tömb elemei rendezés előtt:\n" + String.Join(",", tömb) + "\n");

			for (int i = 1; i < tömb.Length; i++ ){
				j = i - 1;
				x = tömb[i];
				while (j >= 0 && x < tömb[j])
				{
					tömb[j + 1] = tömb[j];
					j = j - 1;

				} 
				tömb[j + 1] = x;
			}
			Console.WriteLine("A tömb elemei rendezés után:\n" + String.Join(",", tömb));
		}
		static int[] random_tomb(int nagysag, int vegertek){
			Random r = new Random();
			int[] tömb = new int[r.Next(5,nagysag)];
			for (int k = 0; k < tömb.Length; k++)
			{
				tömb[k] = r.Next(0, vegertek);
			}

			return tömb;
		}

	}	
}

