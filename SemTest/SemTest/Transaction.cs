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
        public Transaction(string number, string name) : base(name, number)
        {
           
        }
        public override void Print()
        {
            Console.WriteLine($"#{Number}, { Name},{ _amount}");
        }
        public override decimal Total()
        {
            return _amount;
        }
    }

}
