using System;

public class Cat
{
    // Attributes (Properties)
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Age { get; set; }

    // Constructor
    public Cat(string name, string breed, string age)
    {
        Name = name;
        Breed = breed;
        Age = age;
    }

    // Methods
    public void Eat()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping");
    }
}

class Program
{
    static void Main()
    {
        // Persian is an instance of CAT
        Cat persian = new Cat("Dog", "Persian", "5-month");
    }
}
