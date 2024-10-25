using System;
					
public class loop
{
	public static void Run()
	{
		Console.Write("MASUKKAN ANGKA \t : ");
		int nilai = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\n\nSOAL 1\n");
		
		for(int i = 1; i <= nilai; i++){
		for(int r = 1; r <= i; r++){
		Console.Write("*");
		}
			Console.WriteLine("");
		}
		Console.WriteLine("");
		
		Console.WriteLine("\n\nSOAL 2\n");
		
		for(int i = 1; i <= nilai; i++){
		for(int r = nilai; r >= i; r--){
		Console.Write(" ");
		}
		for(int s = 1; s <= i; s++){
			Console.Write("*");
		}
		Console.WriteLine("");
		}
		Console.WriteLine("");
		
		Console.WriteLine("\n\nSOAL 3\n");
		
		for(int i = 1; i <= nilai; i++){
		for(int n = nilai; n > i; n--){
		Console.Write(" ");
		}
			for(int t = 1; t <= (2 * i - 1); t++){
			Console.Write("*");
			}
			Console.WriteLine("");
		}
		Console.WriteLine("");
		
		Console.WriteLine("\n\nSOAL 4\n");
		
		for(int i = 1; i <= nilai; i++){
		for(int n = 1; n < i; n++){
		Console.Write(" ");
		}
			for(int t = nilai; t >= (2 * i - nilai); t--){
			Console.Write("*");
			}
			Console.WriteLine("");
		}
		Console.WriteLine("");
		
		Console.WriteLine("\n\nSOAL 5\n");
		
		for(int i = 1; i <= nilai; i++){
		for(int r = nilai; r >= i; r--){
		Console.Write("*");
		}
			Console.WriteLine("");
		}
		for(int i = 1; i <= nilai; i++){
		for(int r = 1; r <= i; r++){
		Console.Write("*");
		}
			Console.WriteLine("");
		}
		Console.WriteLine("");
		
		Console.WriteLine("\n\nSOAL 6\n");
		
			for(int i = 1; i <= nilai; i++){
			for(int r = 1; r <= i; r++){
		     Console.Write("*");
		    }
			for(int n = nilai; n > i; n--){
					Console.Write(" ");
		    }
		    for(int t = nilai; t >=(2 * i - nilai); t--){
						Console.Write("");
		    }
		  	for(int r = nilai; r >= i; r--){
							Console.Write(" ");
		    }
		    for(int s = 1; s <= i; s++){
								Console.Write("*");
		    }
				Console.WriteLine();
		}
	
		Console.WriteLine("\n\nSOAL 7\n");
		
		for(int i = 1; i <= nilai; i++){
			for(int r = nilai; r >= i; r--){
			Console.Write(" ");
			}
			for(int q = 1; q <= nilai+5; q++){
			Console.Write("*");
			}
			Console.WriteLine();
	}
			Console.WriteLine("\n\nSOAL 8\n");
		
		for(int i = 1; i <= nilai; i++){
		for(int r = 1; r <= i; r++){
		Console.Write("*");
		}
			Console.WriteLine("");
		}
		Console.WriteLine();
		for(int i = 1; i <= nilai; i++){
		for(int r = nilai; r >= i; r--){
		Console.Write("*");
		}
			Console.WriteLine("");
		}
		Console.WriteLine("\n\nSOAL 9\n");
		
		for(int i = 1; i <= nilai; i++){ 
			for (int r = 1; r <= i; r++){
				Console.Write(" ");
			}
			for(int n = nilai; n >= i; n--){
				Console.Write(" ");
			}
			for(int q = nilai; q >= i; q--){
				Console.Write("*");
			}
		for (int e = 1; e <= i; e++){ 
				Console.Write(" ");
			}
			Console.WriteLine();
	}
			for(int a = 1; a <= nilai; a++){ 
			for(int w = nilai; w >= a; w--){
				Console.Write(" ");
			}
					for (int g = 1; g <= a; g++){ 
				Console.Write("*");
			}
		for (int u = 1; u <= a; u++){ 
				Console.Write(" ");
			}
			for(int z = nilai; z >= a; z--){
				Console.Write(" ");
			}
			Console.WriteLine();
			}
				Console.WriteLine("\n\nSOAL TAMBAHAN\n");
			for(int i = nilai; i >= 1; i--){
			for(int r = i; r <= nilai; r++){
			Console.Write(" ");
			}
			for(int q = nilai; q >= 1-5; q--){
			Console.Write("*");
			}
			Console.WriteLine();
			}
		}
	}
