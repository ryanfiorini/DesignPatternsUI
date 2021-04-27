using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsUI.Structural.Decorator
{
    public abstract class LibraryItem
    {
        public int NumCopies { get; set; }

        public abstract void Display();
    }
}
