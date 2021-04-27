using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatternsUI2.Structural.Composite
{
    internal class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name)
            : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            Debug.WriteLine("Cannont add to a primitiveElement");
        }

        public override void Display(int indent)
        {
            Debug.WriteLine(new String('-', indent) + " " + _name);
        }

        public override void Remove(DrawingElement d)
        {
            Debug.WriteLine("Cannot remove from a PrimitiveElement");
        }
    }
}
