namespace Polymorphism
{
    internal class Cat : Animal
    {
        // Constructor
        public Cat(string name) : base("Cat")
        {
            Name = name;
        }

        // Name property
        public string Name { get; set; }

        // MakeSound method
        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
