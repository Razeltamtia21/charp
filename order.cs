using System;
					
public class order
{
	public static void Main()
	{
		int makanan, minuman;
		Console.WriteLine("=============================================");
		Console.WriteLine("		SELAMAT DATANG DI RUMAH MAKAN");
		Console.WriteLine("=============================================");
		home:
		back:
		Console.Write("\n  MENU MAKANAN			     HARGA");
		Console.WriteLine();
		Console.Write("[1] AYAM GORENG			Rp. 10.000-");
		Console.WriteLine();
		Console.Write("[2] NASI GORENG			Rp. 13.000-");
		Console.WriteLine();
		Console.Write("[3] MIE PANGSIT			Rp. 10.000-");
		Console.WriteLine();
		Console.Write("[4] NASI BALAP PUYUNG	  	Rp. 14.000-");
		Console.WriteLine();
		Console.Write("[5] NASI CAMPUR			Rp. 12.000-");
		Console.WriteLine();
		Console.Write("\nSILAHKAN PILIH MENU MAKAN ANDA \t: ");
		makanan =int.Parse(Console.ReadLine());
		house:
		Console.Write("\n  MENU MINUMAN			    HARGA");
		Console.WriteLine();
		Console.Write("[1] ES TEH MANIS		   Rp. 3.000-");
		Console.WriteLine();
		Console.Write("[2] JUS JERUK			  Rp. 7.000-");
		Console.WriteLine();
		Console.Write("[3] AIR GELAS			  Rp. 1.000-");
		Console.WriteLine();
		Console.Write("\nSILAHKAN PILIH MENU MINUM ANDA \t: ");
		minuman =int.Parse(Console.ReadLine());
		
		if (makanan >= 6 && makanan <= 100000){
			Console.WriteLine("\n\n\nMAAF ANDA HARUS MENGULANGI\n\n ");
			goto home;
		}
		if (minuman >= 4 && minuman <= 100000){
			Console.WriteLine("\n\n\nMAAF ANDA HARUS MENGULANGI\n\n ");
			goto house;
		}
		Console.WriteLine("\n=============================================\n");
		Console.WriteLine("	 PROSES PESANAN MAKANAN ANDA ");
		Console.WriteLine("\n=============================================\n");
			if(makanan == 1){
				Console.Write("ANDA MEMESAN\t : " + "AYAM GORENG");
				Console.WriteLine();
				Console.Write("HARGA PESANAN\t: " + "Rp. 10.000-");
				Console.WriteLine();
				Console.Write("\nMASUKAN JUMLAH   : ");
				int jumlah = Convert.ToInt32(Console.ReadLine());
				int total = Convert.ToInt32(jumlah * 10000);
				Console.Write("\nTOTAL HARGA PESANAN : " + "Rp." + total + "-");
					Console.WriteLine();
				kurang:
				Console.Write("\nMASUKAN UANG TUNAI  : ");
				int uang = Convert.ToInt32(Console.ReadLine());
				if (uang <= total){
			Console.WriteLine("\n\n\nMAAF UANG ANDA TIDAK CUKUP\n\n");
			goto kurang;
				}
				int kembalian = Convert.ToInt32(uang-total);
				Console.WriteLine();
				Console.Write("KEMBALIAN UANG ANDA : " + "Rp." + kembalian + "-");
		}
		if(makanan == 2){
			Console.Write("ANDA MEMESAN\t : " + "NASI GORENG");
				Console.WriteLine();
				Console.Write("HARGA PESANAN\t: " + "Rp. 13.000-");
				Console.WriteLine();
				Console.Write("\nMASUKAN JUMLAH   : ");
				int jumlah = Convert.ToInt32(Console.ReadLine());
				int total = Convert.ToInt32(jumlah * 13000);
				Console.Write("\nTOTAL HARGA PESANAN : " + "Rp." + total + "-");
					Console.WriteLine();
				kurang:
				Console.Write("\nMASUKAN UANG TUNAI  : ");
				int uang = Convert.ToInt32(Console.ReadLine());
				if (uang <= total){
			Console.WriteLine("\n\n\nMAAF UANG ANDA TIDAK CUKUP\n\n");
			goto kurang;
				}
				int kembalian = Convert.ToInt32(uang-total);
				Console.WriteLine();
				Console.Write("KEMBALIAN UANG ANDA : " + "Rp." + kembalian + "-");
		}
		if(makanan == 3){
			Console.Write("ANDA MEMESAN\t : " + "MIE PANGSIT");
				Console.WriteLine();
				Console.Write("HARGA PESANAN\t: " + "Rp. 10.000-");
				Console.WriteLine();
				Console.Write("\nMASUKAN JUMLAH   : ");
				int jumlah = Convert.ToInt32(Console.ReadLine());
				int total = Convert.ToInt32(jumlah * 10000);
				Console.Write("\nTOTAL HARGA PESANAN : " + "Rp." + total + "-");
					Console.WriteLine();
				kurang:
				Console.Write("\nMASUKAN UANG TUNAI  : ");
				int uang = Convert.ToInt32(Console.ReadLine());
				if (uang <= total){
			Console.WriteLine("\n\n\nMAAF UANG ANDA TIDAK CUKUP\n\n");
			goto kurang;
				}
				int kembalian = Convert.ToInt32(uang-total);
				Console.WriteLine();
				Console.Write("KEMBALIAN UANG ANDA : " + "Rp." + kembalian + "-");
		}
		if(makanan == 4){
			Console.Write("ANDA MEMESAN\t : " + "NASI BALAP PUYUNG");
				Console.WriteLine();
				Console.Write("HARGA PESANAN\t: " + "Rp. 14.000-");
				Console.WriteLine();
				Console.Write("\nMASUKAN JUMLAH   : ");
				int jumlah = Convert.ToInt32(Console.ReadLine());
				int total = Convert.ToInt32(jumlah * 14000);
				Console.Write("\nTOTAL HARGA PESANAN : " + "Rp." + total + "-");
					Console.WriteLine();
				kurang:
				Console.Write("\nMASUKAN UANG TUNAI  : ");
				int uang = Convert.ToInt32(Console.ReadLine());
				if (uang <= total){
			Console.WriteLine("\n\n\nMAAF UANG ANDA TIDAK CUKUP\n\n");
			goto kurang;
				}
				int kembalian = Convert.ToInt32(uang-total);
				Console.WriteLine();
				Console.Write("KEMBALIAN UANG ANDA : " + "Rp." + kembalian + "-");
		}
		if(makanan == 5){
			Console.Write("ANDA MEMESAN\t : " + "NASI CAMPUR");
				Console.WriteLine();
				Console.Write("HARGA PESANAN\t: " + "Rp. 12.000-");
				Console.WriteLine();
				Console.Write("\nMASUKAN JUMLAH   : ");
				int jumlah = Convert.ToInt32(Console.ReadLine());
				int total = Convert.ToInt32(jumlah * 12000);
				Console.Write("\nTOTAL HARGA PESANAN : " + "Rp." + total + "-");
					Console.WriteLine();
				kurang:
				Console.Write("\nMASUKAN UANG TUNAI  : ");
				int uang = Convert.ToInt32(Console.ReadLine());
				if (uang <= total){
			Console.WriteLine("\n\n\nMAAF UANG ANDA TIDAK CUKUP\n\n");
			goto kurang;
				}
				int kembalian = Convert.ToInt32(uang-total);
				Console.WriteLine();
				Console.Write("KEMBALIAN UANG ANDA : " + "Rp." + kembalian + "-");
		}
		Console.WriteLine();
		Console.WriteLine("\n=============================================\n");
		Console.WriteLine("	 PROSES PESANAN MINUMAN ANDA ");
		Console.WriteLine("\n=============================================\n");
		if(minuman == 1){
				Console.Write("ANDA MEMESAN\t : " + "ES TEH MANIS");
				Console.WriteLine();
				Console.Write("HARGA PESANAN\t: " + "Rp. 3.000-");
				Console.WriteLine();
				Console.Write("\nMASUKAN JUMLAH   : ");
				int jumlah = Convert.ToInt32(Console.ReadLine());
				int total = Convert.ToInt32(jumlah * 3000);
				Console.Write("\nTOTAL HARGA PESANAN : " + "Rp." + total + "-");
					Console.WriteLine();
				kurang:
				Console.Write("\nMASUKAN UANG TUNAI  : ");
				int uang = Convert.ToInt32(Console.ReadLine());
				if (uang <= total){
			Console.WriteLine("\n\n\nMAAF UANG ANDA TIDAK CUKUP\n\n");
			goto kurang;
				}
				int kembalian = Convert.ToInt32(uang-total);
				Console.WriteLine();
				Console.Write("KEMBALIAN UANG ANDA : " + "Rp." + kembalian + "-");
		}
		if(minuman == 2){
				Console.Write("ANDA MEMESAN\t : " + "JUS JERUK");
				Console.WriteLine();
				Console.Write("HARGA PESANAN\t: " + "Rp. 7.000-");
				Console.WriteLine();
				Console.Write("\nMASUKAN JUMLAH   : ");
				int jumlah = Convert.ToInt32(Console.ReadLine());
				int total = Convert.ToInt32(jumlah * 7000);
				Console.Write("\nTOTAL HARGA PESANAN : " + "Rp." + total + "-");
					Console.WriteLine();
				kurang:
				Console.Write("\nMASUKAN UANG TUNAI  : ");
				int uang = Convert.ToInt32(Console.ReadLine());
				if (uang <= total){
			Console.WriteLine("\n\n\nMAAF UANG ANDA TIDAK CUKUP\n\n");
			goto kurang;
				}
				int kembalian = Convert.ToInt32(uang-total);
				Console.WriteLine();
				Console.Write("KEMBALIAN UANG ANDA : " + "Rp." + kembalian + "-");
		}
		if(minuman == 3){
				Console.Write("ANDA MEMESAN\t : " + "AIR GELAS");
				Console.WriteLine();
				Console.Write("HARGA PESANAN\t: " + "Rp. 1.000-");
				Console.WriteLine();
				Console.Write("\nMASUKAN JUMLAH   : ");
				int jumlah = Convert.ToInt32(Console.ReadLine());
				int total = Convert.ToInt32(jumlah * 1000);
				Console.Write("\nTOTAL HARGA PESANAN : " + "Rp." + total + "-");
					Console.WriteLine();
				kurang:
				Console.Write("\nMASUKAN UANG TUNAI  : ");
				int uang = Convert.ToInt32(Console.ReadLine());
				if (uang <= total){
			Console.WriteLine("\n\n\nMAAF UANG ANDA TIDAK CUKUP\n\n");
			goto kurang;
				}
				int kembalian = Convert.ToInt32(uang-total);
				Console.WriteLine();
				Console.Write("KEMBALIAN UANG ANDA : " + "Rp." + kembalian + "-");
		}
		Console.WriteLine();
		Console.WriteLine("\n=============================================\n");
		Console.WriteLine("	DIJAMIN NAMPOL PESAN DI RUMAH MAKAN ");
		Console.WriteLine("\n=============================================\n");
		int jawaban;
		Console.WriteLine();
		Console.Write("APAKAH INGIN MEMESAN LAGI?");
		Console.WriteLine();
		Console.Write("[1] Ya");
		Console.WriteLine();
		Console.Write("[2] No");
		Console.WriteLine();
		Console.Write("\nSILAHKAN MEMLILIH \t: ");
		jawaban =int.Parse(Console.ReadLine());
		if(jawaban == 1){
		Console.Write("\n");
			goto back;
		}
		if(jawaban == 2){
		Console.Write("\nTERIMA KASIH TELAH MEMESAN DI RUMAH MAKAN");
		}
		Console.WriteLine("\n\n============================================");
		Console.WriteLine("        TUGAS KELAS 10 RPL by Razel");
		Console.WriteLine("============================================");
	}
}