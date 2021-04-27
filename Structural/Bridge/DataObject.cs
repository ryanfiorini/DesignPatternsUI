using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsUI2.Structural.Bridge
{
    internal abstract class DataObject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract void ShowRecord();
        public abstract void ShowAllRecord();
    }
}
