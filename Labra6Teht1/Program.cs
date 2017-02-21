using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labra6;

namespace Labra6
{
    class Program
    {
        static void TestPersonsClass()
        {
            // Luodaan ns henkilörekisteri
            Persons myFriends = new Persons();
            // Lisätään kaveri rekisteriin
            Person friend1 = new Person();
            friend1.Firstname = "Kirsi";
            friend1.Lastname = "Kernell";
            friend1.SocialSecurityNumber = "121270-123A";
            // Lyhyempi tapa luoda olio ominaisuuksineen
            Person friend2 = new Person { Firstname = "Jack", Lastname = "Russel", SocialSecurityNumber = "148754-321B" };
            Person friend3 = new Person { Firstname = "Kola", Lastname = "Olli", SocialSecurityNumber = "987456-987X" };
            Person friend4 = new Person { Firstname = "Teppo", Lastname = "Testaaja", SocialSecurityNumber = "01" };
            // Lisätään kaverit yksi kerrallaan henkilörekisteriin
            myFriends.Add(friend1);
            myFriends.Add(friend2);
            myFriends.Add(friend3);
            myFriends.Add(friend4);




            // Näytetään rekisteri
            Console.WriteLine("*** Kaverirekisterisi ***");
            myFriends.ShowPersons();
            // Testataan kaverin hakua
            Console.WriteLine("Anna kaverinumero.");
            string retval = Console.ReadLine();
            // Tutkitaan onko syöte numero.
            int i = 0;
            if (int.TryParse(retval, out i))
            {
                // Huom. tämä Get() palauttaa null jos indeksin osoittamaa kaveria ei löydy
                Person searchFriend = myFriends.Get(int.Parse(retval));
                if (searchFriend != null)
                    Console.WriteLine(string.Format("Löytyi ystävä nimeltä: {0}", searchFriend.ToString()));
                else
                    Console.WriteLine("Annetulla numerolla ei löydy kaveria.");
            }
            else
                Console.WriteLine("Syöte ei kelpaa");
            // Testataan kaverin hakua HETUn avulla
            Console.WriteLine("Anna kaverisi HETU");
            retval = Console.ReadLine();
            Person findFriend = myFriends.Find(retval);
            if (findFriend != null)
                Console.WriteLine(string.Format("Löytyi ystävä nimeltä: {0}", findFriend.ToString()));
            else
                Console.WriteLine("Annetulla HETUlla ei löydy kaveria.");
        }
        static void Main(string[] args)
        {
            TestPersonsClass();
        }
    }
}
