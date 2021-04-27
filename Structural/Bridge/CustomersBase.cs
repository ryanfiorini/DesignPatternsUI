using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatternsUI2.Structural.Bridge
{
    internal class CustomersBase
    {
        protected string group;

        public CustomersBase(string group)
        {
            this.group = group;
        }

        private DataObject _dataObject;
        public DataObject Data
        {
            get { return _dataObject; }
            set { _dataObject = value; }
        }

        public virtual void Next()
        {
            _dataObject.NextRecord();
        }

        public virtual void Prior()
        {
            _dataObject.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            _dataObject.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            _dataObject.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            _dataObject.ShowRecord();
        }

        public virtual void ShowAll()
        {
            Debug.WriteLine("------------------------");
            _dataObject.ShowAllRecord();
            Debug.WriteLine("------------------------");
        }
    }
}
