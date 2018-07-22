using AbstractFactory2.Abstract;

namespace AbstractFactory2.Concrete.Animals.Modern.Mammals
{
    public class Duck : Animal
    {
        public Duck(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "quak quak";
        }

        public override string Run()
        {
            return "very slow";
        }

    }
}
