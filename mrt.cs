using System;
					
public class mrt
{
	public static void Run()
	{
		home:
		Console.WriteLine("														DIMANA LOKASI ANDA SEKARANG \n\n");
		Console.Write("[1]LEBAK BULUS	[2]FATMAWATI 	 [3]CIPETE RAYA			 [4]HAJI NGAWI		[5]BLOK A			 [6]BLOK M			[7]ASEAN");
		Console.WriteLine("\n");
		Console.Write("[8]SENAYAN 	   [9]ISTORA	     [10]BENDUNGAN HILIR	    [11]SETIA BUDI	   [12]DUKUH ATAS	    [13]BUNDARAN HI");
		Console.WriteLine();
		Console.Write("\n\nPILIH LOKASI \t: ");
		int lokasi = Convert.ToInt32(Console.ReadLine());
		if(lokasi >= 14 && lokasi <= 999999999){
		Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~MAAF ANDA HARUS MENGULANGI~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n\n\n ");
			 goto home;		
		}
		Console.WriteLine();
		if (lokasi == 1)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[2]FATMAWATI	[3]CIPETE RAYA	[4]HAJI NGAWI			[5]BLOK A			 [6]BLOK M			 [7]ASEAN");
			Console.WriteLine("\n");
			Console.Write("[8]SENAYAN 	 [9]ISTORA	     [10]BENDUNGAN HILIR	  [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI LEBAK BULUS, TUJUAN ANDA MAU KEMANA? \t: ");
			string m1 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m1 == "2"){Console.WriteLine("   	LOKASI ANDA LEBAK BULUS KE FATMAWATI DENGAN HARGA Rp4.000-");}
			else if (m1 == "3"){Console.WriteLine("   	LOKASI ANDA LEBAK BULUS KE CIPETE RAYA DENGAN HARGA Rp6.000-");}
			else if (m1 == "4"){Console.WriteLine("   	LOKASI ANDA LEBAK BULUS KE HAJI NGAWI DENGAN HARGA Rp8.000-");}
			else if (m1 == "5"){Console.WriteLine("   	LOKASI ANDA LEBAK BULUS KE BLOK A DENGAN HARGA Rp10.000-");}
			else if (m1 == "6"){Console.WriteLine("   	LOKASI ANDA LEBAK BULUS KE BLOK M DENGAN HARGA Rp12.000-");}
			else if (m1 == "7"){Console.WriteLine("   	LOKASI ANDA LEBAK BULUS KE ASEAN DENGAN HARGA Rp14.000-");}
			else if (m1 == "8"){Console.WriteLine("   	LOKASI ANDA LEBAK BULUS KE SENAYAN DENGAN HARGA Rp16.000-");}
			else if (m1 == "9"){Console.WriteLine("  	 LOKASI ANDA LEBAK BULUS KE ISTORA DENGAN HARGA Rp18.000-");}
			else if (m1 == "10"){Console.WriteLine("   LOKASI ANDA LEBAK BULUS KE BENDUNGAN HILIR DENGAN HARGA Rp20.000-");}
			else if (m1 == "11"){Console.WriteLine("   LOKASI ANDA LEBAK BULUS KE SETIA BUDI DENGAN HARGA Rp22.000-");}
			else if (m1 == "12"){Console.WriteLine("   LOKASI ANDA LEBAK BULUS KE DUKUH ATAS DENGAN HARGA Rp24.000-");}
			else if (m1 == "13"){Console.WriteLine("   LOKASI ANDA LEBAK BULUS KE BUNDARAN HI DENGAN HARGA Rp26.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 2)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [3]CIPETE RAYA	[4]HAJI NGAWI		   [5]BLOK A			 [6]BLOK M			  [7]ASEAN");
			Console.WriteLine("\n");
			Console.Write("[8]SENAYAN 	 [9]ISTORA	     [10]BENDUNGAN HILIR	 [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI FATMAWATI, TUJUAN ANDA MAU KEMANA? \t: ");
			string m2 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m2 == "1"){Console.WriteLine("   		LOKASI ANDA FATMAWATI KE LEBAK BULUS DENGAN HARGA Rp4.000-");}
			else if (m2 == "3"){Console.WriteLine("   		LOKASI ANDA FATMAWATI KE CIPETE RAYA DENGAN HARGA Rp4.000-");}
			else if (m2 == "4"){Console.WriteLine("   		LOKASI ANDA FATMAWATI KE HAJI NGAWI DENGAN HARGA Rp6.000-");}
			else if (m2 == "5"){Console.WriteLine("   		LOKASI ANDA FATMAWATI KE BLOK A DENGAN HARGA Rp8.000-");}
			else if (m2 == "6"){Console.WriteLine("   		LOKASI ANDA FATMAWATI KE BLOK M DENGAN HARGA Rp10.000-");}
			else if (m2 == "7"){Console.WriteLine("   		LOKASI ANDA FATMAWATI KE ASEAN DENGAN HARGA Rp12.000-");}
			else if (m2 == "8"){Console.WriteLine("   		LOKASI ANDA FATMAWATI KE SENAYAN DENGAN HARGA Rp14.000-");}
			else if (m2 == "9"){Console.WriteLine("  		 LOKASI ANDA FATMAWATI KE ISTORA DENGAN HARGA Rp16.000-");}
			else if (m2 == "10"){Console.WriteLine("  	 LOKASI ANDA FATMAWATI KE BENDUNGAN HILIR DENGAN HARGA Rp18.000-");}
			else if (m2 == "11"){Console.WriteLine("  	 LOKASI ANDA FATMAWATI KE SETIA BUDI DENGAN HARGA Rp20.000-");}
			else if (m2 == "12"){Console.WriteLine("  	 LOKASI ANDA FATMAWATI KE DUKUH ATAS DENGAN HARGA Rp22.000-");}
			else if (m2 == "13"){Console.WriteLine("  	 LOKASI ANDA FATMAWATI KE BUNDARAN HI DENGAN HARGA Rp24.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 3)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	[4]HAJI NGAWI		   [5]BLOK A			 [6]BLOK M			  [7]ASEAN");
			Console.WriteLine("\n");
			Console.Write("[8]SENAYAN 	 [9]ISTORA	    [10]BENDUNGAN HILIR	 [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI CIPETE RAYA, TUJUAN ANDA MAU KEMANA? \t: ");
			string m3 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m3 == "1"){Console.WriteLine("   		LOKASI ANDA CIPETE RAYA KE LEBAK BULUS DENGAN HARGA Rp6.000-");}
			else if (m3 == "2"){Console.WriteLine("   		LOKASI ANDA CIPETE RAYA KE FATMAWATI DENGAN HARGA Rp4.000-");}
			else if (m3 == "4"){Console.WriteLine("   		LOKASI ANDA CIPETE RAYA KE HAJI NGAWI DENGAN HARGA Rp4.000-");}
			else if (m3 == "5"){Console.WriteLine("   		LOKASI ANDA CIPETE RAYA KE BLOK A DENGAN HARGA Rp6.000-");}
			else if (m3 == "6"){Console.WriteLine("   		LOKASI ANDA CIPETE RAYA KE BLOK M DENGAN HARGA Rp8.000-");}
			else if (m3 == "7"){Console.WriteLine("   		LOKASI ANDA CIPETE RAYA KE ASEAN DENGAN HARGA Rp10.000-");}
			else if (m3 == "8"){Console.WriteLine("   		LOKASI ANDA CIPETE RAYA KE SENAYAN DENGAN HARGA Rp12.000-");}
			else if (m3 == "9"){Console.WriteLine("  		 LOKASI ANDA CIPETE RAYA KE ISTORA DENGAN HARGA Rp14.000-");}
			else if (m3 == "10"){Console.WriteLine("  	 LOKASI ANDA CIPETE RAYA KE BENDUNGAN HILIR DENGAN HARGA Rp16.000-");}
			else if (m3 == "11"){Console.WriteLine("  	 LOKASI ANDA CIPETE RAYA KE SETIA BUDI DENGAN HARGA Rp18.000-");}
			else if (m3 == "12"){Console.WriteLine("  	 LOKASI ANDA CIPETE RAYA KE DUKUH ATAS DENGAN HARGA Rp20.000-");}
			else if (m3 == "13"){Console.WriteLine("  	 LOKASI ANDA CIPETE RAYA KE BUNDARAN HI DENGAN HARGA Rp22.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 4)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	[3]CIPETE RAYA		   [5]BLOK A			 [6]BLOK M			  [7]ASEAN");
			Console.WriteLine("\n");
			Console.Write("[8]SENAYAN 	 [9]ISTORA	    [10]BENDUNGAN HILIR	  [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI HAJI NGAWI, TUJUAN ANDA MAU KEMANA? \t: ");
			string m4 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m4 == "1"){Console.WriteLine("   		LOKASI ANDA HAJI NGAWI KE LEBAK BULUS DENGAN HARGA Rp8.000-");}
			else if (m4 == "2"){Console.WriteLine("   		LOKASI ANDA HAJI NGAWI KE FATMAWATI DENGAN HARGA Rp6.000-");}
			else if (m4 == "3"){Console.WriteLine("   		LOKASI ANDA HAJI NGAWI KE CIPETE RAYA DENGAN HARGA Rp4.000-");}
			else if (m4 == "5"){Console.WriteLine("   		LOKASI ANDA HAJI NGAWI KE BLOK A DENGAN HARGA Rp4.000-");}
			else if (m4 == "6"){Console.WriteLine("   		LOKASI ANDA HAJI NGAWI KE BLOK M DENGAN HARGA Rp6.000-");}
			else if (m4 == "7"){Console.WriteLine("   		LOKASI ANDA HAJI NGAWI KE ASEAN DENGAN HARGA Rp8.000-");}
			else if (m4 == "8"){Console.WriteLine("   		LOKASI ANDA HAJI NGAWI KE SENAYAN DENGAN HARGA Rp10.000-");}
			else if (m4 == "9"){Console.WriteLine("  		 LOKASI ANDA HAJI NGAWI KE ISTORA DENGAN HARGA Rp12.000-");}
			else if (m4 == "10"){Console.WriteLine("  	 LOKASI ANDA HAJI NGAWI KE BENDUNGAN HILIR DENGAN HARGA Rp14.000-");}
			else if (m4 == "11"){Console.WriteLine("  	 LOKASI ANDA HAJI NGAWI KE SETIA BUDI DENGAN HARGA Rp16.000-");}
			else if (m4 == "12"){Console.WriteLine("  	 LOKASI ANDA HAJI NGAWI KE DUKUH ATAS DENGAN HARGA Rp18.000-");}
			else if (m4 == "13"){Console.WriteLine("  	 LOKASI ANDA HAJI NGAWI KE BUNDARAN HI DENGAN HARGA Rp20.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 5)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	[3]CIPETE RAYA		   [4]HAJI NGAWI		 [6]BLOK M			  [7]ASEAN");
			Console.WriteLine("\n");
			Console.Write("[8]SENAYAN 	 [9]ISTORA	    [10]BENDUNGAN HILIR	  [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI BLOK A, TUJUAN ANDA MAU KEMANA? \t: ");
			string m5 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m5 == "1"){Console.WriteLine("   		LOKASI ANDA BLOK A KE LEBAK BULUS DENGAN HARGA Rp10.000-");}
			else if (m5 == "2"){Console.WriteLine("   		LOKASI ANDA BLOK A KE FATMAWATI DENGAN HARGA Rp8.000-");}
			else if (m5 == "3"){Console.WriteLine("   		LOKASI ANDA BLOK A KE CIPETE RAYA DENGAN HARGA Rp6.000-");}
			else if (m5 == "4"){Console.WriteLine("   		LOKASI ANDA BLOK A KE HAJI NGAWI DENGAN HARGA Rp4.000-");}
			else if (m5 == "6"){Console.WriteLine("   		LOKASI ANDA BLOK A KE BLOK M DENGAN HARGA Rp4.000-");}
			else if (m5 == "7"){Console.WriteLine("   		LOKASI ANDA BLOK A KE ASEAN DENGAN HARGA Rp6.000-");}
			else if (m5 == "8"){Console.WriteLine("   		LOKASI ANDA BLOK A KE SENAYAN DENGAN HARGA Rp8.000-");}
			else if (m5 == "9"){Console.WriteLine("  		 LOKASI ANDA BLOK A KE ISTORA DENGAN HARGA Rp10.000-");}
			else if (m5 == "10"){Console.WriteLine("  	 LOKASI ANDA BLOK A KE BENDUNGAN HILIR DENGAN HARGA Rp12.000-");}
			else if (m5 == "11"){Console.WriteLine("  	 LOKASI ANDA BLOK A KE SETIA BUDI DENGAN HARGA Rp14.000-");}
			else if (m5 == "12"){Console.WriteLine("  	 LOKASI ANDA BLOK A KE DUKUH ATAS DENGAN HARGA Rp16.000-");}
			else if (m5 == "13"){Console.WriteLine("  	 LOKASI ANDA BLOK A KE BUNDARAN HI DENGAN HARGA Rp18.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 6)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	[3]CIPETE RAYA		   [4]HAJI NGAWI		 [5]BLOK A			  [7]ASEAN");
			Console.WriteLine("\n");
			Console.Write("[8]SENAYAN 	 [9]ISTORA	    [10]BENDUNGAN HILIR	  [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI BLOK M, TUJUAN ANDA MAU KEMANA? \t: ");
			string m6 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m6 == "1"){Console.WriteLine("   		LOKASI ANDA BLOK M KE LEBAK BULUS DENGAN HARGA Rp12.000-");}
			else if (m6 == "2"){Console.WriteLine("   		LOKASI ANDA BLOK M KE FATMAWATI DENGAN HARGA Rp10.000-");}
			else if (m6 == "3"){Console.WriteLine("   		LOKASI ANDA BLOK M KE CIPETE RAYA DENGAN HARGA Rp8.000-");}
			else if (m6 == "4"){Console.WriteLine("   		LOKASI ANDA BLOK M KE HAJI NGAWI DENGAN HARGA Rp6.000-");}
			else if (m6 == "5"){Console.WriteLine("   		LOKASI ANDA BLOK M KE BLOK A DENGAN HARGA Rp4.000-");}
			else if (m6 == "7"){Console.WriteLine("   		LOKASI ANDA BLOK M KE ASEAN DENGAN HARGA Rp4.000-");}
			else if (m6 == "8"){Console.WriteLine("   		LOKASI ANDA BLOK M KE SENAYAN DENGAN HARGA Rp6.000-");}
			else if (m6 == "9"){Console.WriteLine("  		 LOKASI ANDA BLOK M KE ISTORA DENGAN HARGA Rp8.000-");}
			else if (m6 == "10"){Console.WriteLine("  	 LOKASI ANDA BLOK M KE BENDUNGAN HILIR DENGAN HARGA Rp10.000-");}
			else if (m6 == "11"){Console.WriteLine("  	 LOKASI ANDA BLOK M KE SETIA BUDI DENGAN HARGA Rp12.000-");}
			else if (m6 == "12"){Console.WriteLine("  	 LOKASI ANDA BLOK M KE DUKUH ATAS DENGAN HARGA Rp14.000-");}
			else if (m6 == "13"){Console.WriteLine("  	 LOKASI ANDA BLOK M KE BUNDARAN HI DENGAN HARGA Rp16.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 7)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	[3]CIPETE RAYA		   [4]HAJI NGAWI		 [5]BLOK A			  [6]BLOK M");
			Console.WriteLine("\n");
			Console.Write("[8]SENAYAN 	 [9]ISTORA	    [10]BENDUNGAN HILIR	  [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI ASEAN, TUJUAN ANDA MAU KEMANA? \t: ");
			string m7 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m7 == "1"){Console.WriteLine("   		LOKASI ANDA ASEAN KE LEBAK BULUS DENGAN HARGA Rp14.000-");}
			else if (m7 == "2"){Console.WriteLine("   		LOKASI ANDA ASEAN KE FATMAWATI DENGAN HARGA Rp12.000-");}
			else if (m7 == "3"){Console.WriteLine("   		LOKASI ANDA ASEAN KE CIPETE RAYA DENGAN HARGA Rp10.000-");}
			else if (m7 == "4"){Console.WriteLine("   		LOKASI ANDA ASEAN KE HAJI NGAWI DENGAN HARGA Rp8.000-");}
			else if (m7 == "5"){Console.WriteLine("   		LOKASI ANDA ASEAN KE BLOK A DENGAN HARGA Rp6.000-");}
			else if (m7 == "6"){Console.WriteLine("   		LOKASI ANDA ASEAN KE BLOK M DENGAN HARGA Rp4.000-");}
			else if (m7 == "8"){Console.WriteLine("   		LOKASI ANDA ASEAN KE SENAYAN DENGAN HARGA Rp4.000-");}
			else if (m7 == "9"){Console.WriteLine("  		 LOKASI ANDA ASEAN KE ISTORA DENGAN HARGA Rp6.000-");}
			else if (m7 == "10"){Console.WriteLine("  	 LOKASI ANDA ASEAN KE BENDUNGAN HILIR DENGAN HARGA Rp8.000-");}
			else if (m7 == "11"){Console.WriteLine("  	 LOKASI ANDA ASEAN KE SETIA BUDI DENGAN HARGA Rp10.000-");}
			else if (m7 == "12"){Console.WriteLine("  	 LOKASI ANDA ASEAN KE DUKUH ATAS DENGAN HARGA Rp12.000-");}
			else if (m7 == "13"){Console.WriteLine("  	 LOKASI ANDA ASEAN KE BUNDARAN HI DENGAN HARGA Rp14.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 8)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	[3]CIPETE RAYA		   [4]HAJI NGAWI		 [5]BLOK A			  [6]BLOK M");
			Console.WriteLine("\n");
			Console.Write("[7]ASEAN 	   [9]ISTORA	    [10]BENDUNGAN HILIR	  [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI SENAYAN, TUJUAN ANDA MAU KEMANA? \t: ");
			string m8 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m8 == "1"){Console.WriteLine("   		LOKASI ANDA SENAYAN KE LEBAK BULUS DENGAN HARGA Rp16.000-");}
			else if (m8 == "2"){Console.WriteLine("   		LOKASI ANDA SENAYAN KE FATMAWATI DENGAN HARGA Rp14.000-");}
			else if (m8 == "3"){Console.WriteLine("   		LOKASI ANDA SENAYAN KE CIPETE RAYA DENGAN HARGA Rp12.000-");}
			else if (m8 == "4"){Console.WriteLine("   		LOKASI ANDA SENAYAN KE HAJI NGAWI DENGAN HARGA Rp10.000-");}
			else if (m8 == "5"){Console.WriteLine("   		LOKASI ANDA SENAYAN KE BLOK A DENGAN HARGA Rp8.000-");}
			else if (m8 == "6"){Console.WriteLine("   		LOKASI ANDA SENAYAN KE BLOK M DENGAN HARGA Rp6.000-");}
			else if (m8 == "7"){Console.WriteLine("   		LOKASI ANDA SENAYAN KE ASEAN DENGAN HARGA Rp4.000-");}
			else if (m8 == "9"){Console.WriteLine("  		 LOKASI ANDA SENAYAN KE ISTORA DENGAN HARGA Rp4.000-");}
			else if (m8 == "10"){Console.WriteLine("  	 LOKASI ANDA SENAYAN KE BENDUNGAN HILIR DENGAN HARGA Rp6.000-");}
			else if (m8 == "11"){Console.WriteLine("  	 LOKASI ANDA SENAYAN KE SETIA BUDI DENGAN HARGA Rp8.000-");}
			else if (m8 == "12"){Console.WriteLine("  	 LOKASI ANDA SENAYAN KE DUKUH ATAS DENGAN HARGA Rp10.000-");}
			else if (m8 == "13"){Console.WriteLine("  	 LOKASI ANDA SENAYAN KE BUNDARAN HI DENGAN HARGA Rp12.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 9)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	  [3]CIPETE RAYA		   [4]HAJI NGAWI		 [5]BLOK A			  [6]BLOK M");
			Console.WriteLine("\n");
			Console.Write("[7]ASEAN 	   [8]SENAYAN	     [10]BENDUNGAN HILIR	  [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI ISTORA, TUJUAN ANDA MAU KEMANA? \t: ");
			string m9 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m9 == "1"){Console.WriteLine("   		LOKASI ANDA ISTORA KE LEBAK BULUS DENGAN HARGA Rp18.000-");}
			else if (m9 == "2"){Console.WriteLine("   		LOKASI ANDA ISTORA KE FATMAWATI DENGAN HARGA Rp16.000-");}
			else if (m9 == "3"){Console.WriteLine("   		LOKASI ANDA ISTORA KE CIPETE RAYA DENGAN HARGA Rp14.000-");}
			else if (m9 == "4"){Console.WriteLine("   		LOKASI ANDA ISTORA KE HAJI NGAWI DENGAN HARGA Rp12.000-");}
			else if (m9 == "5"){Console.WriteLine("   		LOKASI ANDA ISTORA KE BLOK A DENGAN HARGA Rp10.000-");}
			else if (m9 == "6"){Console.WriteLine("   		LOKASI ANDA ISTORA KE BLOK M DENGAN HARGA Rp8.000-");}
			else if (m9 == "7"){Console.WriteLine("   		LOKASI ANDA ISTORA KE ASEAN DENGAN HARGA Rp6.000-");}
			else if (m9 == "8"){Console.WriteLine("  		 LOKASI ANDA ISTORA KE SENAYAN DENGAN HARGA Rp4.000-");}
			else if (m9 == "10"){Console.WriteLine("  	 LOKASI ANDA ISTORA KE BENDUNGAN HILIR DENGAN HARGA Rp4.000-");}
			else if (m9 == "11"){Console.WriteLine("  	 LOKASI ANDA ISTORA KE SETIA BUDI DENGAN HARGA Rp6.000-");}
			else if (m9 == "12"){Console.WriteLine("  	 LOKASI ANDA ISTORA KE DUKUH ATAS DENGAN HARGA Rp8.000-");}
			else if (m9 == "13"){Console.WriteLine("  	 LOKASI ANDA ISTORA KE BUNDARAN HI DENGAN HARGA Rp10.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 10)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	  [3]CIPETE RAYA		   [4]HAJI NGAWI		 [5]BLOK A			  [6]BLOK M");
			Console.WriteLine("\n");
			Console.Write("[7]ASEAN 	   [8]SENAYAN	     [9]ISTORA	            [11]SETIA BUDI	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI BENDUNGAN HILIR, TUJUAN ANDA MAU KEMANA? \t: ");
			string m10 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m10 == "1"){Console.WriteLine("   		LOKASI ANDA BENDUNGAN HILIR KE LEBAK BULUS DENGAN HARGA Rp20.000-");}
			else if (m10 == "2"){Console.WriteLine("   		LOKASI ANDA BENDUNGAN HILIR KE FATMAWATI DENGAN HARGA Rp18.000-");}
			else if (m10 == "3"){Console.WriteLine("   		LOKASI ANDA BENDUNGAN HILIR KE CIPETE RAYA DENGAN HARGA Rp16.000-");}
			else if (m10 == "4"){Console.WriteLine("   		LOKASI ANDA BENDUNGAN HILIR KE HAJI NGAWI DENGAN HARGA Rp14.000-");}
			else if (m10 == "5"){Console.WriteLine("   		LOKASI ANDA BENDUNGAN HILIR KE BLOK A DENGAN HARGA Rp12.000-");}
			else if (m10 == "6"){Console.WriteLine("   		LOKASI ANDA BENDUNGAN HILIR KE BLOK M DENGAN HARGA Rp10.000-");}
			else if (m10 == "7"){Console.WriteLine("   		LOKASI ANDA BENDUNGAN HILIR KE ASEAN DENGAN HARGA Rp8.000-");}
			else if (m10 == "8"){Console.WriteLine("  		 LOKASI ANDA BENDUNGAN HILIR KE SENAYAN DENGAN HARGA Rp6.000-");}
			else if (m10 == "9"){Console.WriteLine("  	 LOKASI ANDA BENDUNGAN HILIR KE ISTORA DENGAN HARGA Rp4.000-");}
			else if (m10 == "11"){Console.WriteLine("  	 LOKASI ANDA BENDUNGAN HILIR KE SETIA BUDI DENGAN HARGA Rp4.000-");}
			else if (m10 == "12"){Console.WriteLine("  	 LOKASI ANDA BENDUNGAN HILIR KE DUKUH ATAS DENGAN HARGA Rp6.000-");}
			else if (m10 == "13"){Console.WriteLine("  	 LOKASI ANDA BENDUNGAN HILIR KE BUNDARAN HI DENGAN HARGA Rp8.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 11)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	  [3]CIPETE RAYA		   [4]HAJI NGAWI		      [5]BLOK A			  [6]BLOK M");
			Console.WriteLine("\n");
			Console.Write("[7]ASEAN 	   [8]SENAYAN	     [9]ISTORA	            [10]BENDUNGAN HILIR	    [12]DUKUH ATAS	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI SETIA BUDI, TUJUAN ANDA MAU KEMANA? \t: ");
			string m11 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m11 == "1"){Console.WriteLine("   		LOKASI ANDA SETIA BUDI KE LEBAK BULUS DENGAN HARGA Rp22.000-");}
			else if (m11 == "2"){Console.WriteLine("   		LOKASI ANDA SETIA BUDI KE FATMAWATI DENGAN HARGA Rp20.000-");}
			else if (m11 == "3"){Console.WriteLine("   		LOKASI ANDA SETIA BUDI KE CIPETE RAYA DENGAN HARGA Rp18.000-");}
			else if (m11 == "4"){Console.WriteLine("   		LOKASI ANDA SETIA BUDI KE HAJI NGAWI DENGAN HARGA Rp16.000-");}
			else if (m11 == "5"){Console.WriteLine("   		LOKASI ANDA SETIA BUDI KE BLOK A DENGAN HARGA Rp14.000-");}
			else if (m11 == "6"){Console.WriteLine("   		LOKASI ANDA SETIA BUDI KE BLOK M DENGAN HARGA Rp12.000-");}
			else if (m11 == "7"){Console.WriteLine("   		LOKASI ANDA SETIA BUDI KE ASEAN DENGAN HARGA Rp10.000-");}
			else if (m11 == "8"){Console.WriteLine("  		 LOKASI ANDA SETIA BUDI KE SENAYAN DENGAN HARGA Rp8.000-");}
			else if (m11 == "9"){Console.WriteLine("  	 LOKASI ANDA SETIA BUDI KE ISTORA DENGAN HARGA Rp6.000-");}
			else if (m11 == "10"){Console.WriteLine("  	 LOKASI ANDA SETIA BUDI KE BENDUNGAN HILIR DENGAN HARGA Rp4.000-");}
			else if (m11 == "12"){Console.WriteLine("  	 LOKASI ANDA SETIA BUDI KE DUKUH ATAS DENGAN HARGA Rp4.000-");}
			else if (m11 == "13"){Console.WriteLine("  	 LOKASI ANDA SETIA BUDI KE BUNDARAN HI DENGAN HARGA Rp6.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 12)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	  [3]CIPETE RAYA		   [4]HAJI NGAWI		      [5]BLOK A			  [6]BLOK M");
			Console.WriteLine("\n");
			Console.Write("[7]ASEAN 	   [8]SENAYAN	     [9]ISTORA	            [10]BENDUNGAN HILIR	    [11]SETIA BUDI	     [13]BUNDARAN HI");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI DUKUH ATAS, TUJUAN ANDA MAU KEMANA? \t: ");
			string m12 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m12 == "1"){Console.WriteLine("   		LOKASI ANDA DUKUH ATAS KE LEBAK BULUS DENGAN HARGA Rp24.000-");}
			else if (m12 == "2"){Console.WriteLine("   		LOKASI ANDA DUKUH ATAS KE FATMAWATI DENGAN HARGA Rp22.000-");}
			else if (m12 == "3"){Console.WriteLine("   		LOKASI ANDA DUKUH ATAS KE CIPETE RAYA DENGAN HARGA Rp20.000-");}
			else if (m12 == "4"){Console.WriteLine("   		LOKASI ANDA DUKUH ATAS KE HAJI NGAWI DENGAN HARGA Rp18.000-");}
			else if (m12 == "5"){Console.WriteLine("   		LOKASI ANDA DUKUH ATAS KE BLOK A DENGAN HARGA Rp16.000-");}
			else if (m12 == "6"){Console.WriteLine("   		LOKASI ANDA DUKUH ATAS KE BLOK M DENGAN HARGA Rp14.000-");}
			else if (m12 == "7"){Console.WriteLine("   		LOKASI ANDA DUKUH ATAS KE ASEAN DENGAN HARGA Rp12.000-");}
			else if (m12 == "8"){Console.WriteLine("  		 LOKASI ANDA DUKUH ATAS KE SENAYAN DENGAN HARGA Rp10.000-");}
			else if (m12 == "9"){Console.WriteLine("  	 LOKASI ANDA DUKUH ATAS KE ISTORA DENGAN HARGA Rp8.000-");}
			else if (m12 == "10"){Console.WriteLine("  	 LOKASI ANDA DUKUH ATAS KE BENDUNGAN HILIR DENGAN HARGA Rp6.000-");}
			else if (m12 == "11"){Console.WriteLine("  	 LOKASI ANDA DUKUH ATAS KE SETIA BUDI DENGAN HARGA Rp4.000-");}
			else if (m12 == "13"){Console.WriteLine("  	 LOKASI ANDA DUKUH ATAS KE BUNDARAN HI DENGAN HARGA Rp4.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
		
		if (lokasi == 13)
		{
			Console.WriteLine("											TUJUAN ANDA SEKARANG \n\n");
			Console.Write("[1]LEBAK BULUS  [2]FATMAWATI 	  [3]CIPETE RAYA		   [4]HAJI NGAWI		      [5]BLOK A			  [6]BLOK M");
			Console.WriteLine("\n");
			Console.Write("[7]ASEAN 	   [8]SENAYAN	     [9]ISTORA	            [10]BENDUNGAN HILIR	    [11]SETIA BUDI	     [12]DUKUH ATAS");
			Console.WriteLine("");
			Console.Write("\n\nLOKASI ANDA DI BUNDARAN HI, TUJUAN ANDA MAU KEMANA? \t: ");
			string m13 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine("                    	  PESANAN YANG ANDA INPUT");
			Console.WriteLine("");
			if (m13 == "1"){Console.WriteLine("   		LOKASI ANDA BUNDARAN HI KE LEBAK BULUS DENGAN HARGA Rp26.000-");}
			else if (m13 == "2"){Console.WriteLine("   		LOKASI ANDA BUNDARAN HI KE FATMAWATI DENGAN HARGA Rp24.000-");}
			else if (m13 == "3"){Console.WriteLine("   		LOKASI ANDA BUNDARAN HI KE CIPETE RAYA DENGAN HARGA Rp22.000-");}
			else if (m13 == "4"){Console.WriteLine("   		LOKASI ANDA BUNDARAN HI KE HAJI NGAWI DENGAN HARGA Rp20.000-");}
			else if (m13 == "5"){Console.WriteLine("   		LOKASI ANDA BUNDARAN HI KE BLOK A DENGAN HARGA Rp18.000-");}
			else if (m13 == "6"){Console.WriteLine("   		LOKASI ANDA BUNDARAN HI KE BLOK M DENGAN HARGA Rp16.000-");}
			else if (m13 == "7"){Console.WriteLine("   		LOKASI ANDA BUNDARAN HI KE ASEAN DENGAN HARGA Rp14.000-");}
			else if (m13 == "8"){Console.WriteLine("  		 LOKASI ANDA BUNDARAN HI KE SENAYAN DENGAN HARGA Rp12.000-");}
			else if (m13 == "9"){Console.WriteLine("  	 LOKASI ANDA BUNDARAN HI KE ISTORA DENGAN HARGA Rp10.000-");}
			else if (m13 == "10"){Console.WriteLine("  	 LOKASI ANDA BUNDARAN HI KE BENDUNGAN HILIR DENGAN HARGA Rp8.000-");}
			else if (m13 == "11"){Console.WriteLine("  	 LOKASI ANDA BUNDARAN HI KE SETIA BUDI DENGAN HARGA Rp6.000-");}
			else if (m13 == "12"){Console.WriteLine("  	 LOKASI ANDA BUNDARAN HI KE DUKUH ATAS DENGAN HARGA Rp4.000-");}
			else {Console.WriteLine("					     MAAF ANDA HARUS MENGULANGI ");}
			Console.WriteLine("===============================================================================");
			Console.WriteLine("                  TERIMA KASIH TELAH MENGGUNAKAN MRT JAYA");
		}
	}
}