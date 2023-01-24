using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dipendency_Injection_mit_Interface_New
{
    internal class Katze :ITier
    {

        public string Name { get; set; }  

        public Katze()
        {
            SetName();
        }

        public void SetName()
        {
            Console.Write("Bitte geben Sie den Namen Ihrer Katze ein: ");
            Name = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Katze [Name :" + Name + "]";
        }
    }
}
