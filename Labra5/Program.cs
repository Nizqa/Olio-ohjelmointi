using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labra5;

namespace Labra5
{
    class Program
    {
        static void Main(string[] args)
        {
            Teht1();
        }

        static void Teht1()
        {
            // Testataan Tyre ja Vehicle luokkia.
            // Luodaan ensimmäinen ajoneuvo.
            Vehicle auto = new Labra5.Vehicle();
            auto.Brand = "BMW";
            auto.Model = "320";
            // Ostetaan parit renkaat
            Tyre rinkula = new Tyre();
            rinkula.Branch = "Hankook";
            rinkula.Size = "205/55R16";
            // Erilaiset renkaat
            Tyre nakki = new Tyre();
            nakki.Branch = "Nokia";
            nakki.Size = "ISO";
            // Laitetaan bemariin renkaat
            auto.AddTyre(rinkula);
            auto.AddTyre(rinkula);
            auto.AddTyre(nakki);
            auto.AddTyre(nakki);
            // Näytetään auton tiedot.
            Console.WriteLine("Autossasi {0} on seuraavat tiedot: {1}", auto.Brand, auto.ToString());

        }
    }
}
