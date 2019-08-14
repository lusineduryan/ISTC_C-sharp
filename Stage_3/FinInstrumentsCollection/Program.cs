using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinInstrumentsCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            FinInstrument bond = new FinInstrument("T-bill", "long", 2020, 5.23);
            FinInstrument option = new FinInstrument("FXOption", "short", 2021, 3.26);
            FinInstrument forward = new FinInstrument("BundForward", "short", 2019, 4.69);
            List<FinInstrument> FinInstrumentsList = new List<FinInstrument>() { bond, option, forward, };
        }
    }
}
