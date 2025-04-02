namespace Polymorphism
{
    public class Cat : Animal
    {
        // Constructor
        public Cat(string name) : base("Cat")
        {
            Name = name;
        }

        // Name property
        public string Name { get; set; }
        public string Victims { get; set; } = "Dog, cats and hands";

        // MakeSound method
        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
