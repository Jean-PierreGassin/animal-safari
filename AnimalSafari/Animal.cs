using System;

namespace AnimalSafari
{
    public class Animal
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}

