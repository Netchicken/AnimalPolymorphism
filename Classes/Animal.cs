namespace Polymorphism
{
    internal class Animal
    {
        // Constructor
        // pass in the species in the instantiation var myDog = new Dog("Fido");

        public Animal(string species)
        {
            Species = species;
        }

        // Species property
        public string Species { get; set; }

        // MakeSound method
        public virtual string MakeSound()
        {
            return "weird animal noise";
        }
    }
}
