using FactoryPatern.Animal;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Factory
{
    interface IAnimalFactory
    {
        IAnimal createAnimal();
    }
}
