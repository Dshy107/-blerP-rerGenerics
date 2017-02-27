using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varebeholdning af Æbler

            var æbleBeholdning = new List<Æbler>();
            æbleBeholdning.Add(new Æbler() { Navn = "Ingrid Marie", Lager = 50, Pris = 20.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Cox Orange", Lager = 25, Pris = 10.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Gråsten", Lager = 10, Pris = 22.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Guldborg", Lager = 100, Pris = 9.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "LøgÆble", Lager = 4, Pris = 5.0M });

            foreach (var item in æbleBeholdning)
            {
                Console.WriteLine($"navn {item.Navn} pris {item.Pris}");
            }

            æbleBeholdning.Sort();
            Console.WriteLine("Pris efter sortering: ");
            foreach (var item in æbleBeholdning)
            {
                Console.WriteLine($"navn {item.Navn} pris {item.Pris}");
            }
            Console.WriteLine("Lager efter sortering igen: ");
            æbleBeholdning.Sort(Æbler.sortLagerDescending());
            foreach (var item in æbleBeholdning)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Pris efter sortering stigene: ");
            æbleBeholdning.Sort(Æbler.sortPrisAccending());
            foreach (var item in æbleBeholdning)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Pris efter sortering faldende: ");
            æbleBeholdning.Sort(Æbler.sortPrisDescending());
            foreach (var item in æbleBeholdning)
            {
                Console.WriteLine(item.ToString());
            }
            //var pærerBeholdning = new List<Pærer>();
            //pærerBeholdning.Add(new Pærer() { Navn = "Conference", Lager = 75M, Pris = 5M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Concorde", Lager = 33M, Pris = 12M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 10, Pris = 15M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Noveau Poiteau", Lager = 5M, Pris = 22M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Tongre", Lager = 7M, Pris = 21M });


            //decimal værdiTotalÆbler = FrugtHandler.CalculateSumÆbler(æbleBeholdning);
            //Console.WriteLine("Så meget er æblebeholdningen værd : " + værdiTotalÆbler );

            //decimal værdiTotalPærer = FrugtHandler.CalculateSumPærer(pærerBeholdning);
            //Console.WriteLine("Så meget er pærerbeholdningen værd: " + værdiTotalPærer);

            var æble1 = new Æbler()
            {
                Navn = "Cox Orange",
                Lager = 22,
                Pris = 10.0M
            };
            var æble2 = new Æbler()
            {
                Navn = "Cox Orange",
                Lager = 22,
                Pris = 10.0M
            };
            Æbler æble3 = æble2;
            var æble4 = new Æbler()
            {
                Navn = "Cox Orange",
                Lager = 1,
                Pris = 25.0M
            };

            Console.WriteLine("æble1 equals æble2: " + æble1.Equals(æble2));
            Console.WriteLine("æble3 equals æble2: " + æble3.Equals(æble1));
            Console.WriteLine("æble1 equals æble4: " + æble1.Equals(æble4));
            Console.ReadLine();
        }
    }
}
