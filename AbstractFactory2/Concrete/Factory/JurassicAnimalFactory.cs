using AbstractFactory2.Abstract;
using AbstractFactory2.Concrete.Animals.Jurassic.Birds;
using AbstractFactory2.Concrete.Animals.Jurassic.Mammals;
using AbstractFactory2.Concrete.Animals.Jurassic.Reptiles;

namespace AbstractFactory2.Concrete.Factory
{
    public class JurassicAnimalFactory : AnimalFactory
    {
        public override Animal CreateMammals(string animalType)
        {
            if (animalType == "Herbivores")
            {
                return new Herbivores(type: animalType, name: "jolly", noOfLegs: 4);
            }
            else
            {
                return null;
            }
        }

        public override Animal CreateReptiles(string animalType)
        {
            if (animalType == "Dinosaur")
            {
                return new Dinosaur(type: animalType, name: "Dino", noOfLegs: 2);
            }
            else
            {
                return null;
            }
        }

        public override Animal CreateBirds(string animalType)
        {
            if (animalType == "HaastsEagle")
            {
                return new HaastsEagle(type: animalType, name: "Oldy", noOfLegs: 2);
            }
            else
            {
                return null;
            }
        }
    }
}
