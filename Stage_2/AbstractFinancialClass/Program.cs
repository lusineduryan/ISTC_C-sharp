using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFinancialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            LiquidInstrument Equity = new LiquidInstrument("cash", 1);
            ILLiquidInstrument ABS = new ILLiquidInstrument("capital", 30);
            AbstractFinancialInstrument abstractInstrument = null;
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1: abstractInstrument = Equity; break;
                case 2: abstractInstrument = ABS; break;
                default: break;
            }

            try
            {
                Console.WriteLine(abstractInstrument.GetType());
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Please enter 1 or 2");
            }
            try
            {
                Console.WriteLine(abstractInstrument.GetTenor());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter 1 or 2");
            }
            Console.ReadKey();
        }
    }
}
