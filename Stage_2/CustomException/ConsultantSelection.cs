using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class ConsultantSelection
    {
        public int consultant;
        public ConsultantSelection(int consultant)
        {
            this.consultant = consultant;
        }

        public void WelcomingMessage()
        {
            switch (consultant)
            {
                case 1: Console.WriteLine("You'll be connected with your consultant Dave in a moment!"); break;
                case 2: Console.WriteLine("You'll be connected with your consultant Hannah in a moment!"); break;
                case 3: Console.WriteLine("You'll be connected with your consultant Mary in a moment!"); break;
                case 4: Console.WriteLine("You'll be connected with your consultant Vince in a moment!"); break;
                case 5: Console.WriteLine("You'll be connected with your consultant Keith in a moment!"); break;
                default:
                    WrongNumberException wrongNumber = new WrongNumberException("Please select one of our 5 consultants!");
                    throw wrongNumber;
            }
        }
    }
}
