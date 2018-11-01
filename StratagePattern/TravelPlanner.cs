using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class TravelPlanner
    {
        private TravelStrategy _travelStrategy;

        public void SetTravelStrategy(TravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }
        public void Drive(int MilesToCover)
        {
            var Cost = _travelStrategy.Drive(MilesToCover);
            Console.WriteLine("Cost of the drive: " + Cost);

        }
    }
}
