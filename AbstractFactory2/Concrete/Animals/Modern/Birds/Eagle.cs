using AbstractFactory2.Abstract;

namespace AbstractFactory2.Concrete.Animals.Modern.Birds
{
    public class Eagle : Animal
    {
        public Eagle(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "cheeeeee";
        }

        public override string Run()
        {
            return "fast";
        }
    }
}
