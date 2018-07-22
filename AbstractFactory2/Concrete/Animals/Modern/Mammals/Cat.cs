using AbstractFactory2.Abstract;

namespace AbstractFactory2.Concrete.Animals.Modern.Mammals
{
    public class Cat : Animal
    {

        public Cat(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "miaoooon";
        }

        public override string Run()
        {
            return "very fast";
        }
    }
}
