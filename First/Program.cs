/* 
 * Useamman
 * rivin
 * kommentti
 */
using System;

namespace First
{
    class Henkilö
    {
        public string Nimi { get; set; }
        public int Ikä { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  SayHello();
            AskAge();
            // Console.ReadLine(); // Pysäyttää ohjelman
        }
        static void SayHello()
        {
            string nimi = "Niko Hämäläinen";
            // Hieman oliomaisemmin
            Henkilö immeinen = new Henkilö();
            immeinen.Nimi = "Ville-Petteri Jankko";
            immeinen.Ikä = 42;
            // Näytetään olion tiedot
            Console.WriteLine("Hello " + immeinen.Nimi);
            Console.WriteLine("Olet " + immeinen.Ikä + " vuotta vanha");
        }
        
        static void AskAge()
        {
            Console.WriteLine("Minä vuonna olet syntynyt? Muotoa XXXX.");
            string input = Console.ReadLine();
            // Muutetaan syöte kokonaisluvuksi
            int age = int.Parse(input);
            Console.WriteLine("Olet " + (DateTime.Today.Year - age) + " vuotta vanha.");
        }

    }
}
