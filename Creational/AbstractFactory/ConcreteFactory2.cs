using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Creational
{
    internal class ConcreteFactory2 : AbstractFactory
    {
        internal override AbstractProductA CreatProductA()
        {
            return new ProductA2();
        }

        internal override AbstractProductB CreatProductB()
        {
            return new ProductB2();
        }
    }
}
