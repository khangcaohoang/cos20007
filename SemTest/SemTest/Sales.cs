using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemTest
{
    public class Sales
    {
        private List<Thing> _orders;
        public Sales() {}
        public void Add(Thing orders)
        {
            _orders.Add(orders);
        }

    }
}
