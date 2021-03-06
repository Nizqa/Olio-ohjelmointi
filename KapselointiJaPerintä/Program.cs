﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapselointiJaPerintä
{
    class Car
    {
        // property = ominaisuus, ominaisuudet on aina julkisia.
        // Näinkin voi tehdä, mutta vältä.
        // public int Speed;
        public int Horsepower { get; set; }
        // Sisäinen muuttuja määrittelee maksiminopeuden, jonka oliolle voi asettaa.
        private const int maxSpeed = 200; // Const tarkoittaa vakiota. Readonly voidaan asettaa kerran.
        private int speedPrivate;
        public int Speed
        {
            // get-aksessori palauttaa propertyn arvon
            get
            {
                return speedPrivate;
            }
            set
            {
                if (value > maxSpeed)
                    speedPrivate = maxSpeed;
                else
                    speedPrivate = value;
            }
        }
        public string Brand { get; set; }
        // Constructors
        public Car ()
        { // Tämä on oletuskonstruktori, joka pitää määritellä, jos määrittelee muita konstruktoreita.
        }
        public Car (int horsepower, int speed)
        {
            Horsepower = horsepower;
            if (speed < maxSpeed)
                this.speedPrivate = speed; // This viittaa olioon itseensä. Tarvitsee jos taustamuuttuja ja argumentti ovat samannimisiä.
            else
                speedPrivate = maxSpeed;
        }
        // Methods
        public void Accelerate(int addition)
        {
            // Kiihdytetään, mutta ei yli maximinopeuden.
            if (speedPrivate + addition <= maxSpeed)
                speedPrivate = speedPrivate + addition;
            else
                speedPrivate = maxSpeed;
        }
        public override string ToString()
        {
            return Brand + ", " + Horsepower + ", " + speedPrivate;
        }
    }
    /*class Elevator
    {
        public int Floor { get; set; }
        private const int MaxFloor = 5;
        private const int Minfloor = 1;
        public int SetFloor()
        {

        }
    }*/
    class Program
    {
        static void TestMyCarClass()
        {
            // luodaan car-olio
            Car car1 = new Car(); // Kutsuu oletuskonstruktoria.
            car1.Brand = "Toyota";
            car1.Horsepower = 128;
            car1.Speed = 175;
            Car car2 = new Car();
            car2.Brand = "Porsche";
            car2.Horsepower = 300;
            car2.Speed = 250;
            Car fiat = new Car(55, 105); // Propertyt voidaan asettaa heti, koska on tehty konstruktori.
            fiat.Brand = "Fiat";
            // näytetään konsolilla
            Console.WriteLine("Auto 1 = {0}", car1.ToString());
            Console.WriteLine("Autosi {1} nopeus on {0}.", car1.Speed, car1.Brand);
            Console.WriteLine("Autosi {1} nopeus on {0}.", car2.Speed, car2.Brand);
            Console.WriteLine("Autosi {1} nopeus on {0}.", fiat.Speed, fiat.Brand);
            // Kiihdytetään kumpaakin autoa 20km/h
            car1.Accelerate(20);
            car2.Accelerate(20);
            fiat.Accelerate(20);
            Console.WriteLine("Kiihdytettiin 20km/h");
            Console.WriteLine("Autosi {1} nopeus on {0}.", car1.Speed, car1.Brand);
            Console.WriteLine("Autosi {1} nopeus on {0}.", car2.Speed, car2.Brand);
            Console.WriteLine("Autosi {1} nopeus on {0}.", fiat.Speed, fiat.Brand);
        }
        static void Main(string[] args)
        {
            TestMyCarClass();
            
        }
    }
}
