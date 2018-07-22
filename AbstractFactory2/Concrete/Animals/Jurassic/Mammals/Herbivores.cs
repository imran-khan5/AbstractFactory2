using AbstractFactory2.Abstract;

namespace AbstractFactory2.Concrete.Animals.Jurassic.Mammals
{
    public class Herbivores : Animal
    {
        public Herbivores(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "taaaaaaanneee";
        }

        public override string Run()
        {
            return "very slow";
        }
    }
}
