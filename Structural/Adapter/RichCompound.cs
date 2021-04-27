using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsUI2.Structural.Adapter
{
    /// The 'Adapter' class
    internal class RichCompound : Compound
    {
        private ChemicalDatabank _bank;

        public RichCompound(string name)
            : base(name)
        {
        }

        public override string Display()
        {
            // The Adaptee
            _bank = new ChemicalDatabank();

            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);

            base.Display();
            var returnStr = " Formula: {0}" + _molecularFormula + Environment.NewLine;
            returnStr += " Weight : {0}" + _molecularWeight + Environment.NewLine;
            returnStr += " Melting Pt: {0}" + _meltingPoint + Environment.NewLine;
            returnStr += " Boiling Pt: {0}" + _boilingPoint + Environment.NewLine;

            return returnStr;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
