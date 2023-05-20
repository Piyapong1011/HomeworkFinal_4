using System.Runtime.Intrinsics.X86;
using System;

class Code{
    static void Main(string[]args){
        Console.Write("Street alley : ");
        int alley = int.Parse(Console.ReadLine());
        Console.Write("range : ");
        int range = int.Parse(Console.ReadLine());
        int [] street = new int [alley];
        int [] sum = new int [alley];
        int [] result = new int [1];
        int limit = alley - range;
        int both_range = range * 2;
        
        if (alley < 1 || alley > 10000 || range < 1 || range > 100){
            Console.WriteLine("Too little or too much amount");
        }else{

            for (int i = 0; i < alley; i++){
                Console.Write("alley {0}'s population : ",i+1);
                int num = int.Parse(Console.ReadLine());
                
                if (num > 500 || num < 0){
                    Console.WriteLine("Too little or too much amount");
                }else{
                    street[i] = num;
                }
            }

            for (int j = range; j < limit; j++){
                for (int k = (-range); k < (range+1); k++){
                    sum[j] = sum[j] + street[j+k];
                }
                if (sum[j-1] > sum[j]){
                    sum[j] = sum[j-1];
                }
                result[0] = sum[j];
            }
            Console.WriteLine(result[0]);
        }                
    }
}