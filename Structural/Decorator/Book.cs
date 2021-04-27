/*
 *  https://dofactory.com/net/decorator-design-pattern 
 *   Frequency of use: 3 Medium
 * 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatternsUI.Structural.Decorator
{
    public class Book : LibraryItem
    {
        private string _author;
        private string _title;
        private int _numCopies;

        public Book(string author, string title, int numCopies)
        {
            this._author = author;
            this._title = title;
            this._numCopies = numCopies;
        }

        public override void Display()
        {
            Debug.WriteLine("\nBook ------ ");
            Debug.WriteLine(" Author: {0}", _author);
            Debug.WriteLine(" Title: {0}", _title);
            Debug.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}
