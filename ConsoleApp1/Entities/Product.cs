using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class Product
    {
        public string Name { get; private set; }
        public object NativeApp { get; private set; }
        public Product Requires { get; private set; }
        public IEnumerable<object> ThirdPartyApps { get; private set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}