namespace Polymorphism
{
    internal class Animal
    {
        // Constructor
        public Animal(string species)
        {
            Species = species;
        }

        // Species property
        public string Species { get; set; }

        // MakeSound method
        public virtual string MakeSound()
        {
            return "Grrrrrrr";
        }
    }
}
