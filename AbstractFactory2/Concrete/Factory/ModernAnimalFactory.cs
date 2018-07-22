using AbstractFactory2.Abstract;
using AbstractFactory2.Concrete.Animals.Modern.Birds;
using AbstractFactory2.Concrete.Animals.Modern.Mammals;
using AbstractFactory2.Concrete.Animals.Modern.Reptiles;

namespace AbstractFactory2.Concrete.Factory
{
    public class ModernAnimalFactory : AnimalFactory
    {
        public override Animal CreateMammals(string animalType)
        {
            if (animalType == "Cat")
            {
                return new Cat(type: animalType, name: "kitty", noOfLegs: 4);
            }
            else if (animalType == "Dog")
            {
                return new Dog(type: animalType, name: "tommy", noOfLegs: 4);
            }
            else if (animalType == "Duck")
            {
                return new Duck(type: animalType, name: "quacky", noOfLegs: 2);
            }
            else
            {
                return null;
            }
        }

        public override Animal CreateReptiles(string animalType)
        {
            if (animalType == "Snake")
            {
                return new Snake(type: animalType, name: "Cobra Baboo", noOfLegs: 0);
            }
            else
            {
                return null;
            }
        }

        public override Animal CreateBirds(string animalType)
        {
            if (animalType == "Eagle")
            {
                return new Eagle(type: animalType, name: "Shaheen", noOfLegs: 2);
            }
            else
            {
                return null;
            }
        }
    }
}
