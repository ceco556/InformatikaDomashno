using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3{
    class Program{
        static void Main(string[] args){
            string text = Console.ReadLine();

            StringBuilder filtriran = new StringBuilder();

            for (int i = 0; i < text.Length; i++){
                if (text[i] == ')' || text[i] == '(')
                    filtriran.Append(text[i]);
            }

            text = filtriran.ToString();

            List<char> skobi = new List<char>();

            bool balansiran = true;

            if (text[0] == ')'){
                balansiran = false;
            }else{
                for (int i = 0; i < text.Length; i++){
                    if (text[i] == '(')
                        skobi.Add('(');
                    if (text[i] == ')'){
                        if (skobi.Count > 0){
                            skobi.Remove('(');
                        }else{ 
                            balansiran = false;
                        }
                    }
                }
            }

            if (balansiran == false || skobi.Count != 0){
                Console.WriteLine("Nebalansiran");
            }else{
                Console.WriteLine("Balansiran");
            }
        }
    }
    }

