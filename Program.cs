using System;

namespace Inheritance
{
    // Base class
    class Animal
    {
        public string name;

        // Default constructor
        public Animal()
        {
            name = "";
        }

        // Parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    // First derived class
    class Cat : Animal
    {
        // Additional fields
        public int age;
        public string color;
        public bool isHungry;

        // Default constructor
        public Cat()
        {
            age = 0;
            color = "";
            isHungry = false;
        }

        // Parameterized constructor
        public Cat(string name, int age, string color, bool isHungry) : base(name)
        {
            this.age = age;
            this.color = color;
            this.isHungry = isHungry;
        }

        // Method to display cat information
        public void DisplayCatInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Hungry: {isHungry}");
        }
    }

    // Second derived class
    class Dog : Animal
    {
        // Additional fields
        public string breed;
        public string favoriteToy;
        public bool isTrained;

        // Default constructor
        public Dog()
        {
            breed = "";
            favoriteToy = "";
            isTrained = false;
        }

        // Parameterized constructor
        public Dog(string name, string breed, string favoriteToy, bool isTrained) : base(name)
        {
            this.breed = breed;
            this.favoriteToy = favoriteToy;
            this.isTrained = isTrained;
        }

        // Method to display dog information
        public void DisplayDogInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Breed: {breed}");
            Console.WriteLine($"Favorite Toy: {favoriteToy}");
            Console.WriteLine($"Trained: {isTrained}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object of first derived class (Cat) using default constructor
            Cat myCat = new Cat();
            myCat.name = "Whiskers";
            myCat.age = 3;
            myCat.color = "Grey";
            myCat.isHungry = true;

            // Display cat information
            Console.WriteLine("Cat Information using default constructor:");
            myCat.DisplayCatInfo();
            Console.WriteLine();

            // Object of first derived class (Cat) using parameterized constructor
            Cat myOtherCat = new Cat("Fluffy", 5, "White", false);

            // Display cat information
            Console.WriteLine("Cat Information using parameterized constructor:");
            myOtherCat.DisplayCatInfo();
            Console.WriteLine();

            // Object of second derived class (Dog) using default constructor
            Dog myDog = new Dog();
            myDog.name = "Buddy";
            myDog.breed = "Golden Retriever";
            myDog.favoriteToy = "Tennis Ball";
            myDog.isTrained = true;

            // Display dog information
            Console.WriteLine("Dog Information using default constructor:");
            myDog.DisplayDogInfo();
            Console.WriteLine();

            // Object of second derived class (Dog) using parameterized constructor
            Dog myOtherDog = new Dog("Max", "Labrador", "Frisbee", false);

            // Display dog information
            Console.WriteLine("Dog Information using parameterized constructor:");
            myOtherDog.DisplayDogInfo();
        }
    }
}
