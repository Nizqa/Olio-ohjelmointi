using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioidenPerusteet
{
    class Ikkuna
    {
        // These are properties = ominaisuudet.
        public float Width { get; set; }
        public float Height { get; set; }
        public float Area
        {
            get { return Width * Height; }
        }
        public float Circ
        {
            get { return 2 * (Width + Height); }
        }
        // These are constructors = konstruktorit/'rakentajat'
        public Ikkuna ()
        {
            // Tämä on ns. oletuskonstruktori
        }
        public Ikkuna (float width, float height)
        {
            Width = width;
            Height = height;
        }
        // These are methods = metodit.
        public float CalcArea()
        {
            return Width * Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OOIkkunaDemo();
        }
        static void OOIkkunaDemo()
        {
            // Ohjelma laskee ikkunan pinta-alan ja ympärysmitan.
            float Width = 0;
            float Height = 0;
            float Area, Circ = 0;
            // Kysytään käyttäjältä mitat.
            Console.WriteLine("Lasken ikkunan pinta-alan ja ympärysmitan.\nSyötä leveys millimetreinä.");
            Width = float.Parse(Console.ReadLine());
            Console.WriteLine("Syötä korkeus millimetreinä.");
            Height = float.Parse(Console.ReadLine());
            // Lasketaan pinta-ala ja ympärysmitta ja tulostetaan ne.
            Area = Width * Height;
            Circ = 2 * (Width + Height);
            Console.WriteLine("Ikkunan ala on {0} ja ympärys {1}.", Area, Circ);

            // Sama homma olion avulla.
            Ikkuna window = new Ikkuna();
            window.Width = Width;
            window.Height = Height;
            // Area = window.CalcArea
            Console.WriteLine("Olion avulla laskettuna ikkunan ala on {0} ja ympärys {1}.", window.Area, window.Circ);
            // Kokeillaan puolta pienemmällä ikkunalla toista konstruktoria.
            Ikkuna window2 = new Ikkuna(Width / 2, Height / 2);
            Console.WriteLine("Olioikkuna2:n ala on {0} ja ympärys {1}.", window2.Area, window2.Circ);
        }
    }
}
