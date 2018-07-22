using AbstractFactory2.Abstract;

namespace AbstractFactory2.Concrete.Animals.Modern.Reptiles
{
    public class Snake : Animal
    {
        public Snake(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "zzzzzz";
        }

        public override string Run()
        {
            return "slow";
        }
    }
}
