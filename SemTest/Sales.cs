using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemTest
{
    public class Sales
    {
        private List<Thing>_orders;
        public Sales() {}
        public void Add(Thing items)
        {
            _orders.Add(items);
        }
        public void PrintOrders()
        {
            Console.WriteLine("Sales:");
            foreach (var items in _orders)
            items.Print();
        }
    }
}
