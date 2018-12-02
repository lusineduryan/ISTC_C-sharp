using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_MathOperations
{
    public class EventClass
    {
        public delegate int OperationDelegate(int number1, int number2);
        public event OperationDelegate OperationsEvent;
        public void Invoker()
        {
            try
            {
                OperationsEvent.Invoke(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            }
            catch (FormatException e) when (OperationsEvent != null)
            {
               Console.WriteLine("Please enter an integer!");
            }
        }
    }
}
