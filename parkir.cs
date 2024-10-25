using System;
					
public class parkir
{
	public static void Run()
	{
		int order, parkir, total, bayar;
		Console.WriteLine("============================================");
		Console.WriteLine(" 	PROGRAM TARIF PARKIR KENDARAAN");
		Console.WriteLine("============================================");
		home:
		Console.Write("\n [1] MOBIL");
		Console.WriteLine();
		Console.Write(" [2] MOTOR");
		Console.WriteLine();
		Console.Write("\nPILILAH JENIS KENDARAAN ANDA \t: ");
		order =int.Parse(Console.ReadLine());
	    Console.Write("\nMASUKAN JENIS PARKIR ANDA(perjam): ");
		parkir = Convert.ToInt32(Console.ReadLine());
		bayar = Convert.ToInt32(parkir*4000);
		total = Convert.ToInt32(4000*parkir+2000);
		if (order >= 3 && order <= 100000){
			Console.WriteLine("\n\n\nMAAF ANDA HARUS MENGULANGI ");
			goto home;
		}
		Console.WriteLine("\n============================================");
		Console.WriteLine("     HASIL TARIF PARKIR KENDARAAN ANDA");
		Console.WriteLine("============================================");
		if(order == 1){
		Console.Write("\nJENIS KENDARAN ANDA \t: MOBIL");
		}
		if(order == 2){
		Console.Write("\nJENIS KENDARAN ANDA \t: MOTOR");
		}
		Console.WriteLine();
		Console.Write("\nBIAYA PARKIR    \t\t: " + "Rp." + bayar + "-");
		Console.WriteLine();
		Console.Write("\nBIAYA TAMBAHAN  \t\t: " + "Rp.2000" + "-");
		Console.WriteLine();
		Console.Write("\nTOTAL HASIL PARKIR \t : " + "Rp." + total + "-");
		
		Console.WriteLine("\n\n============================================");
		Console.WriteLine("        TUGAS KELAS 10 RPL by Razel");
		Console.WriteLine("============================================");
	}
}