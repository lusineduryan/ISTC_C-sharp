using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    class FXForwardValuation
    {
        private double Strike {get; set;}
        private class FXForwardRate
        {
            private double SpotRate { get; set; }
            public double DomesticInterestRate { get; set; }
            private double ForeignInterestRate { get; set; }
            public double ForwardRate(double SpotRate, double DomesticInterestRate, double ForeignInterestRate)
            {
                return SpotRate * (1 + DomesticInterestRate) / (1 + ForeignInterestRate);
            }
            public FXForwardRate(double spotRate, double domesticInterestRate, double foreignInterestRate)
            {
                SpotRate = spotRate;
                DomesticInterestRate = domesticInterestRate;
                ForeignInterestRate = foreignInterestRate;
            }
        }
        FXForwardRate EURGBP = new FXForwardRate(0.8736, -0.00257, 0.0099263);
        public double FXForwardPrice(double Strike)
        {
            return EURGBP.ForwardRate(0.8736, -0.00257, 0.0099263) - Strike / (1 + EURGBP.DomesticInterestRate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FXForwardValuation DTG_3579748 = new FXForwardValuation();
            Console.WriteLine(DTG_3579748.FXForwardPrice(0.895683));
            Console.ReadKey();
        }
    }
}
