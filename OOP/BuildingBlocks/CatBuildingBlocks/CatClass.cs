using System;

namespace CatBuildingBlocks
{
    public class CatClass
    {
        // Attributes (Properties)
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Age { get; set; }

        // Constructor
        public CatClass(string name, string breed, string age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        // Methods
        public void Meow()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }
}
