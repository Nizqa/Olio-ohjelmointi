using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sormiharjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            Lotto();
           // Names();
        }
        static void Names()
        {
            string[] names = new string[5];

            Console.WriteLine("Anna 5 nimeä");

            for (int i = 0; i < 5; i++)
                names[i] = Console.ReadLine();
            Console.WriteLine(); // Tekee tyhjän rivin.

            Console.WriteLine("Nimet tulostettuna syöttöjärjestyksessä:");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(names[i]);
            Console.WriteLine();

            Console.WriteLine("Nimet tulostettuna aakkosjärjestyksessä:");
            Array.Sort(names); // Järjestää defaulttina aakkosjärjestykseen.
            for (int i = 0; i < 5; i++)
                Console.WriteLine(names[i]);
        }
        static void Lotto()
        {
            int[] numbers = new int[7];
            Console.WriteLine("Montako riviä lottoa haluat?");
            string input = Console.ReadLine();
            int amount = int.Parse(input); // Muutetaan syöte kokonaisluvuksi.

            Random Rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    bool reroll = true;
                    
                    numbers[j] = Rnd.Next(1, 40);
                    
                    
                }

                for (int k = 0; k < 7; k++)
                    Console.Write(numbers[k] + " ");
                Console.WriteLine();
            }
        }
    }
}
