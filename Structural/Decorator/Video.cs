using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatternsUI.Structural.Decorator
{
    public class Video : LibraryItem
    {
        private string _director;
        private string _title;
        private int _playTime;

        public Video(string director, string title, int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Debug.WriteLine("\nVideo ----- ");
            Debug.WriteLine(" Director: {0}", _director);
            Debug.WriteLine(" Title: {0}", _title);
            Debug.WriteLine(" # Copies: {0}", NumCopies);
            Debug.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }
}
