
namespace AbstractFactory2.Abstract
{
    public abstract class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int NoOfLegs { get; set; }

        protected Animal(string name, string type, int noOfLegs)
        {
            Type = type;
            Name = name;
            NoOfLegs = noOfLegs;
        }

        public abstract string  MakeSound();
        public abstract string Run();
    }
}
