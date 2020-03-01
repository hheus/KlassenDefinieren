using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{
    public class Auto
    {
        public string marke;
        public int alterInJahren;

        public void BeschleinigeAuf100Kmh()
        {
            if (IstSchnell())
            {
                Console.WriteLine("Habe schnell beschleunigt");
            }
            else
            {
                Console.WriteLine("Habe normal beschleunigt");
            }
        }

        private bool IstSchnell()
        {
            if (marke == "Porsche")
            {
                return true;
            }
            return false;
        }
    }
}
