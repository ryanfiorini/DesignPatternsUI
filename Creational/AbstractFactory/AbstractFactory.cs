using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Creational
{
    internal abstract class AbstractFactory
    {
        internal abstract AbstractProductA CreatProductA();
        internal abstract AbstractProductB CreatProductB();
    }
}
