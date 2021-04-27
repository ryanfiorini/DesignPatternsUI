using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.FactoryMethod
{
    internal abstract class Document
    {
        private List<Page> _pages = new List<Page>();
        internal Document()
        {
            this.CreatePages();
        }

        internal List<Page> Pages
        {
            get { return _pages; }
        }

        internal abstract void CreatePages();
    }
}
