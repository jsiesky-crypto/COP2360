// Dog.cs
// Demonstrates: properties, constructors, constants, static readonly, and method overloading

using System;

public class Dog
{
    // Auto-properties (encapsulation)
    public string Name { get; private set; }
    public string Breed { get; set; }
    public int Age { get; set; }

    // Constant (all dogs share this species)
    public const string Species = "Canis lupus familiaris";

    // Static readonly field (all dogs have 4 legs)
    public static readonly int Legs = 4;

    // Default constructor
    public Dog()
    {
        Name = "Unknown";
        Breed = "Mixed";
        Age = 0;
    }

    // Parameterized constructor
    public Dog(string name, string breed, int age)
    {
        Name = name;
        Breed = breed;
        Age = age;
    }

    // Overloaded methods
    public void Bark()
    {
        Console.WriteLine($"{Name} barks once: Woof!");
    }

    public void Bark(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine($"{Name} barks: Woof!");
        }
    }

    // Helper method
    public void Describe()
    {
        Console.WriteLine($"{Name} is a {Age}-year-old {Breed}. Species: {Species}, Legs: {Legs}");
    }
}

// Example runner
public static class Program
{
    public static void Main()
    {
        // Using default constructor
        Dog dog1 = new Dog();
        dog1.Describe();
        dog1.Bark();

        // Using parameterized constructor
        Dog dog2 = new Dog("Buddy", "Golden Retriever", 3);
        dog2.Describe();
        dog2.Bark(3);
    }
}
