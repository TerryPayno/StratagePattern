using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelPlanner travelPlanner = new TravelPlanner();
            travelPlanner.SetTravelStrategy(new Car());
            travelPlanner.Drive(1100);

            Console.ReadLine();
        }
    }
}
