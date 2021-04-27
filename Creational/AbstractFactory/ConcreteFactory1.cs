using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Creational
{
    internal class ConcreteFactory1 : AbstractFactory
    {
        internal override AbstractProductA CreatProductA()
        {
            return new ProductA1();
        }

        internal override AbstractProductB CreatProductB()
        {
            return new ProductB1();
        }
    }
}
