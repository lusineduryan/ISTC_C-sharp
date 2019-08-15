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
        public static FinInstrument[] FinInstrumentsList;
        public static void BuildCollection()
        {
            FinInstrument bond = new FinInstrument("T-bill", "long", 2020, 5.23);
            FinInstrument option = new FinInstrument("FXOption", "short", 2021, 3.26);
            FinInstrument forward = new FinInstrument("BundForward", "short", 2019, 4.69);
            FinInstrumentsList = new FinInstrument[] { bond, option, forward, };
        }
        

        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            if (_initialposition < FinInstrumentsList.Length)
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

        public object Current
        {
            get { return FinInstrumentsList[_initialposition]; }
        }

        public int Count
        {
            get { return FinInstrumentsList.Length; }
        }

        public bool IsSynchronized { get { return false; } }

        public object SyncRoot { get { return this; } }

        public void CopyTo(Array array, int index)
        {
            Array.Copy(FinInstrumentsList,array,FinInstrumentsList.Length);
        }

        public bool IsFixedSize
        {
            get { if (FinInstrumentsList.Length == 5) return true;
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
            if (_initialposition < FinInstrumentsList.Length)
            {
                FinInstrumentsList[_initialposition] = (FinInstrument)value;
                _initialposition++;
                return (_initialposition - 1);
            }
            else return -1;
        }

        public void Clear()
        {
            Array.Clear(FinInstrumentsList, 0, FinInstrumentsList.Length);
        }

        public bool Contains(object value)
        {
            if (FinInstrumentsList.Contains((FinInstrument)value)) return true;
            else return false;
        }

        public int IndexOf(object value)
        {
            return Array.IndexOf(FinInstrumentsList, value);
        }

        public void Insert(int index, object value)
        {
            if ((_initialposition <= FinInstrumentsList.Length) && (index < Count) && (index >= 0))
            {
                _initialposition++;
                for (int i = Count - 1; i > index; i--)
                {
                    FinInstrumentsList[i] = FinInstrumentsList[i - 1];
                }
                FinInstrumentsList[index] = (FinInstrument)value;
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    FinInstrumentsList[i] = FinInstrumentsList[i + 1];
                }
                _initialposition--;
            }
        }

    }    
}
