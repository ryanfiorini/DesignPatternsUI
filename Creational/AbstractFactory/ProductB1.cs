using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Creational
{
    internal class ProductB1 : AbstractProductB
    {
        internal override string Interact(AbstractProductA a)
        {
            return (this.GetType().Name +
                " interacts with " + a.GetType().Name);
        }
    }
}
