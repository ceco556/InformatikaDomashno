using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4{
    class Program{
        static void Main(string[] args){
            List<string> tochki = new List<string>();
            Console.Write("Broi tochki:");
            int a = int.Parse(Console.ReadLine());
            if (a <= 3){
                Console.WriteLine("Ne moje da ima max diametyr pri " + a + " tochki");
                return;
            }
           

            Console.WriteLine("Primer: chislo1 chislo2");
            Console.Write("Vyvedi koordinati[x, y]:");
            for (int i = 0; i < a; i++){
                tochki.Add(Console.ReadLine());
            }

            double diametyr = 0;
            for (int i = 1; i < tochki.Count - 1; i++){
                for (int j = 0; j < tochki.Count; j++){
                    if (i == j || i == j - 1 || i == j + 1){
                        continue;
                    }else{
                        int[] xy = tochki[i].Split().Select(int.Parse).ToArray();
                        int[] xy0 = tochki[j].Split().Select(int.Parse).ToArray();
                        int x = xy0[0] - xy[0];
                        int y = xy0[1] - xy[1];
                        double dyljina = Math.Sqrt(x * x + y * y);
                        if (dyljina > diametyr){
                            diametyr = dyljina;
                        }
                    }
                        
                }
            }
            Console.WriteLine($"Max diametyr: {diametyr}");
            Console.ReadLine();
        }
    }
}
