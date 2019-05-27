using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1 {
    class Program {
        public static string red = "cherven\n";
        public static string blue = "sin\n";
        public static string white = "bql\n";
        
        public static void swap(string[] input, int i, int j) {
            string temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }

        public static void color(string[] input) {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            int c = input.Length - 1;
            

            while (a <= c) {
                if (String.Equals(input[a], red)) {
                    swap(input, a, b);
                    a++;
                    b++;
                } else if (String.Equals(input[a], blue)) {

                    a++;
                } else if (String.Equals(input[a], white)) {

                    swap(input, a, c);
                    c--;
                } else {

                    break;
                }
            }
        }

        public static void Main(string[] args) {


            string[] input = { white, white, white, white, white, white, white, red, white, blue, white, white, white};


            color(input);

            for (int i = 0; i < input.Length; i++) {
                Console.WriteLine(input[i]);
            }

        }

        


    }

}