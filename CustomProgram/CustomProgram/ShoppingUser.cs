using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProgram
{
    public class User
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public ShoppingCart Cart { get; set; } = new ShoppingCart();

        public User(string userId, string name)
        {
            UserID = userId;
            Name = name;
        }
    }
}
