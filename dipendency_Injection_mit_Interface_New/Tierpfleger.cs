using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dipendency_Injection_mit_Interface_New
{
    internal class Tierpfleger 
    {
        List<ITier> liste = new List<ITier>();
        public string Pflegername { get; set; }
        public ITier tier;

        public Tierpfleger()
        {
            setName();
        }
        public void setHund()
        {
            tier = new Hund();
            liste.Add(tier);
        }
        public void setKatze()
        {
            tier = new Katze();
            liste.Add(tier);
        }

        public void setName()
        {
            Console.Write("\nGeben Sie den Namen des Pflegers ein: ");
            Pflegername = Console.ReadLine();
        }
        public void getTiere()
        {
            int counter = 1;
            Console.WriteLine($"Die Tiere des Pflegers {Pflegername} sind:");

            foreach (var x in liste)
            {
                Console.WriteLine($"{counter++}tes Tier: {x.ToString()}");
            }
        }
        public void tierEntfernen()
        {
            Console.WriteLine("Geben Sie bitte den Namen des Tieres ein, welches sie löschen möchten");
            Console.Write("Eingabe: ");
            string TierName = Console.ReadLine();
            for(int i = 0; i < liste.Count; i++)
            {
                if(TierName.Equals(liste[i].Name))
                {
                    liste.RemoveAt(i);
                    Console.WriteLine("Das Tier ist eintfernt worden.");
                    Console.ReadKey();
                    break;
                }
                else if(i==liste.Count-1)
                {
                    Console.WriteLine("\nDas eingegebene Tier ist nicht auf der Liste!");
                }

            }
        }


    }
}
