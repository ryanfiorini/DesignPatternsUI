using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Builder
{
    internal abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        internal abstract void BuildFrame();
        internal abstract void BuildEngine();
        internal abstract void BuildWheels();
        internal abstract void BuildDoors();

    }
}
