using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Car : TravelStrategy
    {
        public Car()
        {
            MilesCost = 20;
        }
        public override decimal Drive(int MilesToCover)
        {
            return MilesCost * MilesToCover;
        }
    }
}
