using System;
using AbstractFactory2.Abstract;
using AbstractFactory2.Concrete.Factory;

namespace AbstractFactory2
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal mammal = null;
            Animal reptile = null;
            Animal bird = null;

            Console.WriteLine("Select historic period \nJurassic , Modern");
            string period = Console.ReadLine();

            if (!string.IsNullOrEmpty(period))
            {
                if (period == "Modern")
                {
                    var modernAnimalFactory = new ModernAnimalFactory();
                    Console.WriteLine("Select which mammal from {0} period you want to create Dog , Cat, Duck?", period);
                    string mammalChoice = Console.ReadLine();
                    mammal = modernAnimalFactory.CreateMammals(mammalChoice);

                    Console.WriteLine("Select which Reptile from {0} period you want to create Snake, lizard?", period);
                    string reptileChoice = Console.ReadLine();
                    reptile = modernAnimalFactory.CreateReptiles(reptileChoice);

                    Console.WriteLine("Select which bird  from {0} period you want to create Parrot, Eagle?", period);
                    string birdChoice = Console.ReadLine();
                    bird = modernAnimalFactory.CreateBirds(birdChoice);
                }
                else if (period == "Jurassic")
                {
                    var jurassicAnimalFactory = new JurassicAnimalFactory();
                    Console.WriteLine("Select which mammal from {0} period you want to create Dinosaur, Brachiosaurus?", period);
                    string mammalChoice = Console.ReadLine();
                    mammal = jurassicAnimalFactory.CreateMammals(mammalChoice);

                    Console.WriteLine("Select which mammal from {0} period you want to create Herbivores?", period);
                    string reptileChoice = Console.ReadLine();
                    reptile = jurassicAnimalFactory.CreateReptiles(reptileChoice);

                    Console.WriteLine("Select which bird  from {0} period you want to create HaastsEagle?", period);
                    string birdChoice = Console.ReadLine();
                    bird = jurassicAnimalFactory.CreateBirds(birdChoice);
                }
            }

            if (mammal != null || reptile != null || bird != null)
            {
                if (mammal != null)
                {
                    Console.WriteLine("\nHere is your {0} " +
                                      "\nName: {1}" +
                                      "\nNoOfLegs: {2}" +
                                      "\nSound: {3}" +
                                      "\nRunning: {4}"
                        , mammal.Type, mammal.Name, mammal.NoOfLegs, mammal.MakeSound(), mammal.Run());
                }

                if (reptile != null)
                {
                    Console.WriteLine("\nHere is your {0} " +
                                      "\nName: {1}" +
                                      "\nNoOfLegs: {2}" +
                                      "\nSound: {3}" +
                                      "\nRunning: {4}"
                        , reptile.Type, reptile.Name, reptile.NoOfLegs, reptile.MakeSound(), reptile.Run());
                }

                if (bird != null)
                {
                    Console.WriteLine("\nHere is your {0} " +
                                      "\nName: {1}" +
                                      "\nNoOfLegs: {2}" +
                                      "\nSound: {3}" +
                                      "\nRunning: {4}"
                        , bird.Type, bird.Name, bird.NoOfLegs, bird.MakeSound(), bird.Run());
                }
            }
            else
            {
                Console.WriteLine("This animal group didnt exist in our system");
            }

            Console.ReadLine();
        }

    }
}
