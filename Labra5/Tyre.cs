using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    public class Vehicle
    {
        // Constants and variables
        private const int maxTyres = 4;
        private int countTyres = 0;
        // Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public Tyre[] Tyres { get; }
        // Constructors
        public Vehicle()
        {
            Tyres = new Tyre[maxTyres];
        }
        // Methods
        public void AddTyre(Tyre tyre)
        {
            if (countTyres < maxTyres)
            {
                Tyres[countTyres] = tyre;
                countTyres++;
                Console.WriteLine("{0} lisätty ajoneuvoon {1}", tyre.ToString(), this.Brand);
            }
            else
                Console.WriteLine("Ei sovi enää uusia renkaita.");
        }
        public override string ToString()
        {
            string retval = "\nAjoneuvon valmistaja: " + Brand + "\nMalli: " + Model + "\nRenkaat: ";
            foreach (Tyre tyre in Tyres) // Tässä tutkitaan onko arrayn paikoissa mitään.
            {
                if (tyre != null)
                    retval += tyre.ToString();
            }
            return retval;
        }
    }
    public class Tyre
    {
        public string Branch { get; set; }
        public string Size { get; set; }
        public override string ToString()
        {
            // return "Valmistaja: " + Branch + " koko: " + Size;
            return String.Format("Renkaan valmistaja on {0}, koko on {1}", Branch, Size,);
        }
    }
}
