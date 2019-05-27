using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2{
    class Program{
        static void Main(string[] args){
            string palindrom = Console.ReadLine();
            Console.WriteLine(Palindrom(palindrom));
        }

        private static bool Palindrom(string palindrom){
            int start = 0;
            int end = palindrom.Length - 1;
            for (int i = 0; i < palindrom.Length / 2; i++){
                if (palindrom[start] != palindrom[end]){
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
