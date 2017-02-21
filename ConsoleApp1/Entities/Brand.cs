using System;

namespace ConsoleApp1.Entities
{
    public class Brand
    {
        public static string Label = "Brand";
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Brand(string name)
        {
            Id = Guid.NewGuid();
            Name = name;            
        }
    }
}