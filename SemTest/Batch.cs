using System.Runtime.CompilerServices;
using System.Transactions;

namespace SemTest
{
    public class Batch : Thing
    {
        private List<Thing> _items;
        public Batch(string number, string name) : base(number, name) {}
        public void Add(Thing items)
        {
            _items.Add(items);
        }
        public override void Print()
        {
            foreach (var item in _items)
            {
                Console.WriteLine($"#{item.Number}, {item.Name}, ${item.Total()}");
            }
        }
        public override decimal Total()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.Total();
            }
            return total;
        }
    }
}
