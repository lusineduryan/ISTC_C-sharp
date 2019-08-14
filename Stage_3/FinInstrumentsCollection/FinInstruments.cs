using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FinInstrumentsCollection
{
    public class FinInstruments : IList, ICollection, IEnumerable, IEnumerator
    {
        private int _initialposition = -1;
        public  static List<FinInstrument> FinInstrumentsList;
        public static void BuildCollection()
        {
            FinInstrument bond = new FinInstrument("T-bill", "long", 2020, 5.23);
            FinInstrument option = new FinInstrument("FXOption", "short", 2021, 3.26);
            FinInstrument forward = new FinInstrument("BundForward", "short", 2019, 4.69);
            FinInstrumentsList = new List<FinInstrument>() { bond, option, forward, };
        }
        

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

        object IEnumerator.Current
        {
            get { return FinInstrumentsList[_initialposition]; }
        }

        public int Count
        {
            get { return FinInstrumentsList.Count; }
        }

        public bool IsSynchronized { get { return false; } }

        public object SyncRoot { get { return this; } }

        public void CopyTo(Array array, int index)
        {
            FinInstrumentsList.CopyTo((FinInstrument[])array, index);
        }

        public bool IsFixedSize
        {
            get { if (FinInstrumentsList.Count == 5) return true;
                else return false; }
        }

        public bool IsReadOnly { get { return true; } }

        public object this[int index]
        {
            get { return FinInstrumentsList[index]; }
            set { FinInstrumentsList[index] = (FinInstrument)value; }
        }

        public int Add(object value)
        {
            if (_initialposition < FinInstrumentsList.Count)
            {
                FinInstrumentsList[_initialposition] = (FinInstrument)value;
                _initialposition++;
                return (_initialposition - 1);
            }
            else return -1;
        }

        public void Clear()
        {
            FinInstrumentsList.Clear();
        }

        public bool Contains(object value)
        {
            if (FinInstrumentsList.Contains((FinInstrument)value)) return true;
            else return false;
        }

        public int IndexOf(object value)
        {
            return FinInstrumentsList.IndexOf((FinInstrument)value);
        }

        public void Insert(int index, object value)
        {
            FinInstrumentsList.Insert(index, (FinInstrument)(value));
        }

        public void Remove(object value)
        {
            FinInstrumentsList.Remove((FinInstrument)value);
        }

        public void RemoveAt(int index)
        {
            FinInstrumentsList.RemoveAt(index);
        }

    }    
}
