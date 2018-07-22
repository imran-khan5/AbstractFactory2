using AbstractFactory2.Abstract;

namespace AbstractFactory2.Concrete.Animals.Modern.Mammals
{
    public class Dog : Animal
    {
        public Dog(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "woof wooof";
        }

        public override string Run()
        {
            return "fast";
        }
    }
}
