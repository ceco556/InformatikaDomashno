using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5{
    class Program{
        private static bool konstanta(int[] arr, int x){
            int a;
            for (int i = 0; i < arr.Length; i++){
                a = arr[i];
                for (int j = i + 1; j < arr.Length - 1; j++){
                    if (arr[i] + arr[j] == x){
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args){
            Console.Write("Broi elementi: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Suma: ");
            int x = Convert.ToInt32(Console.ReadLine()); ;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++){
                Console.Write($"Element {i}: ");
                int c = Convert.ToInt32(Console.ReadLine());
                arr[i] = c;
            }
            if (konstanta(arr, x)){
                Console.WriteLine($"Ima suma {x}");
            }else{
                Console.WriteLine($"Nqma suma {x}");
            }
        }
    }
}