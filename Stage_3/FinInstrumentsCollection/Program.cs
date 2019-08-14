using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FinInstrumentsCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            FinInstruments.BuildCollection();
            foreach (FinInstrument financialInstrument in FinInstruments.FinInstrumentsList)
            {
                Console.WriteLine(financialInstrument.name);
            }
            Console.ReadKey();
        }
    }
}
