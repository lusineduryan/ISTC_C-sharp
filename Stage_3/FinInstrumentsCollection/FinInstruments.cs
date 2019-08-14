using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinInstrumentsCollection
{
    public class FinInstruments //: IList, ICollection, IEnumerable, IEnumerator
    {
        private int _initialposition = -1;
        FinInstrument bond = new FinInstrument("T-bill", "long", 2020, 5.23);
        FinInstrument option = new FinInstrument("FXOption", "short", 2021, 3.26);
        FinInstrument forward = new FinInstrument("BundForward", "short", 2019, 4.69);
        //List<FinInstrument> FinInstrumentsList = new List<FinInstrument>() { bond, option, forward, };

        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            if (_initialposition < FinInstrumentsList.Count)
            {
                _initialposition++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            _initialposition = -1;
        }

        object Current
        {
            get { return FinInstrumentsList[_initialposition]; }
        }




    }    
}
