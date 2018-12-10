using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class FixedIncome
    {
        public double InterestRate { get; set; }
        public string Issuer { get; set; }
        public int Maturity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FixedIncome[] InstrumentList = new FixedIncome[3] 
            {
                new FixedIncome { InterestRate = 5.5, Issuer = "Italy", Maturity = 10},
                new FixedIncome { InterestRate = 6.75, Issuer = "Germany", Maturity = 8},
                new FixedIncome { InterestRate = 3.6, Issuer = "USA", Maturity = 8}
            };

            var issuer = InstrumentList.Select(s => new {s.Issuer }).ToList();
            var lowyield = InstrumentList.Where(s => s.InterestRate < 5).Select(s => new { s.InterestRate } ).ToList();
            var instrumentsGroupedByMaturity = InstrumentList.GroupBy(s => s.Maturity).OrderBy(s1 => s1.Key).Select(s1 => new { s1, s1.Key }).ToList();

            for (int i = 0; i < issuer.Count; i++)
            {
                Console.WriteLine(issuer[i].Issuer);
            }
            for (int i = 0; i < lowyield.Count; i++)
            {
                Console.WriteLine(lowyield[i].InterestRate);
            }
            Console.ReadKey();

        }
    }
}
