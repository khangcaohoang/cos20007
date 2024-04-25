using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace SemTest
{
    public class Transaction: Thing
    {
        private decimal _amount;
        public Batch(string number, string name) : base(name)
        {
            _number = number;
            _name = name;
        }
    }
}
