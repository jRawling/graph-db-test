using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class Brand
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Brand(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
