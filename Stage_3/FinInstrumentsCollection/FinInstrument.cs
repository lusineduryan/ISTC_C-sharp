using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinInstrumentsCollection
{
    public class FinInstrument
    {
        public string name;
        public string position;
        private int _maturity;
        public double yield;
        public FinInstrument(string name, string position, int maturity, double yield)
        {
            this.name = name;
            this.position = position;
            this._maturity = maturity;
            this.yield = yield;
        }

        public int TimeToMaturity(int maturity)
        {
            return _maturity - DateTime.Now.Year;
        }


    }
}
