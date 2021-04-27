using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatternsUI2.Structural.Bridge
{
    internal class CustomersData : DataObject
    {
        private List<string> _customers = new List<string>();
        private int _current = 0;

        public CustomersData()
        {
            _customers.Add("Jim Jones");
            _customers.Add("Samual Jackson");
            _customers.Add("Allen Good");
            _customers.Add("Ann Stills");
            _customers.Add("Lis Giolani");
        }

        public override void AddRecord(string name)
        {
            _customers.Add(name);
        }

        public override void DeleteRecord(string name)
        {
            _customers.Remove(name);
        }

        public override void NextRecord()
        {
            if (_current <= _customers.Count -1)
            {
                _current++;
            }
        }

        public override void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }

        public override void ShowAllRecord()
        {
            foreach (var customer in _customers)
            {
                Debug.WriteLine(" " + customer);
            };
        }

        public override void ShowRecord()
        {
            Debug.WriteLine(_customers[_current]);
        }
    }
}
