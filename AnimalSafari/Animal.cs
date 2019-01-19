using System;

namespace AnimalSafari
{
    public class Animal
    {
        public string Name { private get; set ;}

        public Animal (string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}

