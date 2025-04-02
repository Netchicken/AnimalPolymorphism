namespace Polymorphism
{
    public abstract class Animal
    {
        public Animal(string species)
        {
            Species = species;
        }

        // Species property
        public string Species { get; set; }

        // MakeSound method
        public abstract string MakeSound();
        //{
        //    return "weird animal noise";
        //}
    }
}
