/*
 *  https://dofactory.com/net/composite-design-pattern 
 *   Frequency of use: 4 Medium
 * 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatternsUI2.Structural.Composite
{
    internal class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements = new List<DrawingElement>();

        public CompositeElement(string name)
            : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Display(int indent)
        {
            Debug.WriteLine(new String('-', indent) + "+ " + _name);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
    }
}
