/*
 *  https://dofactory.com/net/bridge-design-pattern 
 *   Frequency of use: 3 Medium
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsUI2.Structural.Bridge
{
    internal class Customer : CustomersBase
    {
        public Customer(string group)
            : base(group)
        {
        }

        public override void ShowAll()
        {
            base.ShowAll();
        }

    }
}
