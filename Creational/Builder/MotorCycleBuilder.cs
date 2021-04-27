using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Builder
{
    internal class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("Motorcycle");
        }

        internal override void BuildDoors()
        {
            vehicle["Doors"] = "0";
        }

        internal override void BuildEngine()
        {
            vehicle["Engine"] = "500 CC";
        }

        internal override void BuildFrame()
        {
            vehicle["Frame"] = "Motorcycle Frame";
        }

        internal override void BuildWheels()
        {
            vehicle["Wheels"] = "2";
        }
    }
}
