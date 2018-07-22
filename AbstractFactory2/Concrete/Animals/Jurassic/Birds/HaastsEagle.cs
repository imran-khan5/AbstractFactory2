using AbstractFactory2.Abstract;

namespace AbstractFactory2.Concrete.Animals.Jurassic.Birds
{
    public class HaastsEagle : Animal
    {
        public HaastsEagle(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "jrrrr";
        }

        public override string Run()
        {
            return "fast";
        }
    }
}
