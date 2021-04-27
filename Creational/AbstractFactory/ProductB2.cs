using System;

namespace DesignPatternsUI.Creational.Creational
{
    internal class ProductB2 : AbstractProductB
    {
        internal override string Interact(AbstractProductA a)
        {
            return (this.GetType().Name +
                " interacts with " + a.GetType().Name);
        }
    }
}