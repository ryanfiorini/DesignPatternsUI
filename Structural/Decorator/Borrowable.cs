using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatternsUI.Structural.Decorator
{
    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name) {
            borrowers.Add(name);
            _libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            _libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers)
            {
                Debug.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
