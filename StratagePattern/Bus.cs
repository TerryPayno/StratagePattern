using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Bus : TravelStrategy
    {
        public Bus()
        {
            MilesCost = 10;
        }
        public override decimal Drive(int MilesToCover)
        {
            return MilesCost * MilesToCover;
        }
    }
}
