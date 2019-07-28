using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    /* There are 5 consultants for the online store. The customer should pick a number for the corresponding consultant: 
        1 for Dave, 2 for Hannah, 3 for Mary, 4 for Vince and 5 for Keith.
        In case of a wrong numver, there should be a warning message. */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select one of our 5 consultants: 1 for Dave, 2 for Hannah, 3 for Mary, 4 for Vince and 5 for Keith.");
            int cons = 0;
            try
            {
                cons = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please input only integer numbers!");
            }
            try
            {
                ConsultantSelection consSel = new ConsultantSelection(cons);
                consSel.WelcomingMessage();
            }
            catch (Exception e) when (e is WrongNumberException)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
