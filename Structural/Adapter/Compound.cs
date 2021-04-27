using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsUI2.Structural.Adapter
{
    internal class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        public Compound(string chemical)
        {
            _chemical = chemical;
        }

        public virtual string Display()
        {
            return "Compound: {0} ------ " + _chemical;
        }
    }
}
