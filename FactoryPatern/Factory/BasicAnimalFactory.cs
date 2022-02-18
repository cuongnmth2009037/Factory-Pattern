using FactoryPatern.Animal;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Factory
{
    class BasicAnimalFactory : IAnimalFactory
    {
        int index = 0;
        public IAnimal createAnimal()
        {
            if (index == 0)
            {
                index++;
                return new Dog();

            }
            if (index == 1)
            {
                index++;
                return new Cat();
            }
            if (index == 2)
            {
                index = 0;
                return new Duck();
            }
            return null;           
        }
    }
}
