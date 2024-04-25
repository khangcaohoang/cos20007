using System.Runtime.CompilerServices;
using System.Transactions;

namespace SemTest
{
    public class Batch : Thing
    {
        private List<Transaction> _items;
        public Batch(string number, string name) 
        {
            _number = number;
            _name = name;
        }
    }
    public override void Print()
    {

    }
}
