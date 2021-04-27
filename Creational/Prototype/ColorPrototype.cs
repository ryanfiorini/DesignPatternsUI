using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Prototype
{
    internal abstract class ColorPrototype 
    {
        internal abstract ColorPrototype Clone();
    }
}
