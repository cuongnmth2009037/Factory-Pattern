using FactoryPatern.Animal;
using FactoryPatern.Factory;
using System;

namespace FactoryPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicAnimalFactory factory = new BasicAnimalFactory();
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());

            RandomAnimalFactory factoryRandom = new RandomAnimalFactory();
            Console.WriteLine(factoryRandom.createAnimal().GetName());           
            Console.WriteLine(factoryRandom.createAnimal().GetName());           
            Console.WriteLine(factoryRandom.createAnimal().GetName());           
            Console.WriteLine(factoryRandom.createAnimal().GetName());           
            Console.WriteLine(factoryRandom.createAnimal().GetName());           
        }
    }
}
