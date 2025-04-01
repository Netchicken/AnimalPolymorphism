namespace Polymorphism
{
    internal class Dog : Animal
    {
        // Constructor
        public Dog(string name) : base("Dog")
        {
            Name = name;
        }

        // Name property
        public string Name { get; set; }

        // MakeSound method

        public override string MakeSound()
        {
            return "Woof! Woof!";
        }
    }
}
