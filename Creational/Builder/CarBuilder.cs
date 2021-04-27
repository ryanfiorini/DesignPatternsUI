using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Builder
{
    internal class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        internal override void BuildDoors()
        {
            vehicle["Doors"] = "4";
        }

        internal override void BuildEngine()
        {
            vehicle["Engine"] = "2500 CC";
        }

        internal override void BuildFrame()
        {
            vehicle["Frame"] = "Car Frame";
        }

        internal override void BuildWheels()
        {
            vehicle["Wheels"] = "4";
        }
    }
}
