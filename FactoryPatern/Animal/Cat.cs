using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Animal
{
    class Cat : IAnimal
    {
        public string GetName()
        {
            return "I am Cat";
        }
    }
}
