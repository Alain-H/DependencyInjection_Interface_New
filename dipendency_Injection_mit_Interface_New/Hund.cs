using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dipendency_Injection_mit_Interface_New
{
    internal class Hund :ITier
    {
        public string Name { get; set; }
        public Hund()
        {
            setName();
        }
        public void setName()
        {
            Console.Write("\nBitte geben Sie den Namen Ihres Hundes ein: ");
            Name = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Hund [Name: " + Name + "]";
        }





    }

    
}
