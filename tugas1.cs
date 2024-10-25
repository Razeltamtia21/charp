using System;
					
public class tugas1
{
	public static void Run()
	{
		Console.WriteLine("============================================");
		Console.WriteLine("    MENGHITUNG NILAI DENGAN NESTED LOOP");
		Console.WriteLine("============================================");
		Console.Write("MASUKAN NILAI SIKU \t: ");
		int nilai = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine();
		for(int i = nilai; i >= 1; i--){
		for(int r = 1; r <= i; r++){
		Console.Write(r);
		}
			Console.WriteLine("");
		}
		Console.WriteLine("");
		Console.WriteLine("");
		
		for(int i = 1; i <= nilai; i++){
		for(int r = nilai; r >= i; r--){
		Console.Write("*");
		}
			Console.WriteLine("");
		}
		Console.WriteLine("");
		Console.WriteLine("\n\n============================================");
		Console.WriteLine("        TUGAS KELAS 10 RPL by Razel");
		Console.WriteLine("============================================");
	}
}