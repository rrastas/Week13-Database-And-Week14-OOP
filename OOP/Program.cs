using System;

namespace OOP
{
    class Program
    {

        class Dog
        {
            string name;
            int spots;
            double levelOfHappines;

            //constructor
            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                levelOfHappines = 0;
                Console.WriteLine($"The dog {name} with {spots} spots has been created.");
            }

            //getter for name
            public string Name
            {
                get { return name; }
            }
            //getter for level of happines
            public double LevelOfHappines
            {
                get { return levelOfHappines; }
            }

            public void Bark()
            {
                levelOfHappines += 0.2; //levelOfHappines = levelOfHappines + 0.2
                Console.WriteLine($"{name} says: woof-woof!");
            }

            public void Wag()
            {
                Console.WriteLine("Wiggle-wiggle!");
            }

            public void ShowDogData()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Spots: {spots}");
                Console.WriteLine($"Level of happines: {levelOfHappines}");
            }

            public void Rename(string newName)
            {
                Console.WriteLine($"The dog {name} has been renamed to {newName}");
                name = newName;

            }
        }

        static void Main(string[] args)
        {
            Dog myDog = new Dog("Nelly", 25);

            Console.WriteLine($"{myDog.Name} is a good boy!");

            //myDog.name = "Good boy";
            myDog.Rename("Good Boy");

            while (myDog.LevelOfHappines < 1)
            {
                myDog.Bark();
            }

            myDog.Wag();

            myDog.ShowDogData();

        }
    }
}
