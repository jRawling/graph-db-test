using System;

namespace ConsoleApp1.Entities
{
    public class AppStore
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public AppStore(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}