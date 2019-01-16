using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDP
{
    class Dog
    {
        private Animal _animal = new Animal();

        public Dog(string name, int age)
        {
            _animal.setAnimalName(name);
            _animal.setAnimalAge(age);
        }

        public string getDogName()
        {
            return _animal.getAnimalName();
        }

        public int getDogAge()
        {
            return _animal.getAnimalAge();
        }
    }
}
