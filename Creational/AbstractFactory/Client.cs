/*
 *  https://dofactory.com/net/abstract-factory-design-pattern 
 *   Frequency of use: 5 High
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUI.Creational.Creational
{
    internal class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreatProductA();
            _abstractProductB = factory.CreatProductB();
        }

        public string Run()
        {
            return _abstractProductB.Interact(_abstractProductA);
        }
    }
}
