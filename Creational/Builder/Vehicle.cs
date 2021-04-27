using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Builder
{
    internal class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public string Show()
        {
            var strResponse = ("\n---------------------------") + Environment.NewLine;
            strResponse += ("Vehicle Type: {0}", _vehicleType) + Environment.NewLine;
            strResponse += (" Frame : {0}", _parts["Frame"]) + Environment.NewLine;
            strResponse += (" Engine : {0}", _parts["Engine"]) + Environment.NewLine;
            strResponse += (" #Wheels: {0}", _parts["Wheels"]) + Environment.NewLine;
            strResponse += (" #Doors : {0}", _parts["Doors"]) + Environment.NewLine;

            return strResponse;
        }
    }
}
