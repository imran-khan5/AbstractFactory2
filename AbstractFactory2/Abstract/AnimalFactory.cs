namespace AbstractFactory2.Abstract
{
    public abstract class AnimalFactory
    {
        public abstract Animal CreateMammals(string animalType);
        public abstract Animal CreateReptiles(string animalType);
        public abstract Animal CreateBirds(string animalType);
    }
}
