using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFinancialClass
{
    public abstract class AbstractFinancialInstrument
    {
        private string marketType;
        private int tenor;

        public AbstractFinancialInstrument(string marketType, int tenor)
        {
            this.marketType = marketType;
            this.tenor = tenor;
        }

        public string GetMarketType()
        {
            return marketType;
        }

        public int GetTenor()
        {
            return tenor;
        }
    }
   
      
    public class LiquidInstrument : AbstractFinancialInstrument
    {
        public LiquidInstrument(string marketType, int tenor) : base(marketType, tenor)
        {

        }
    }
    public class ILLiquidInstrument : AbstractFinancialInstrument
    {
        public ILLiquidInstrument(string marketType, int tenor) : base(marketType, tenor)
        {

        }
    }
}

