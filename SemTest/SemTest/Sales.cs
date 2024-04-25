using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemTest
{
    public class Sales
    {
        private List<Batch> _orders;
        public Sales() {}
        public void Add(Batch orders)
        {
            _orders.Add(orders);
        }
        public void PrintOrders()
        {
            Console.WriteLine("Sales:");
            foreach (var items in _orders)
                _orders.Print();
        }
    }
}
