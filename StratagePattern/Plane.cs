using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            MilesCost = 50;
        }
        public override decimal Drive(int MilesToCover)
        {
            if (MilesToCover > 1000)
            {
                MilesCost = 15;
            }
            return MilesCost * MilesToCover;
        }

    }
}
