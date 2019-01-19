using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSafari
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new string[] { "Dog", "Cat", "Monkey" };

            Console.WriteLine("Greetings... I'm Orisa the computer, please tell me your name :)");
            string name = Console.ReadLine();

            Console.WriteLine($@"Oh cool, your name is {name}? Nice to meet you!");

            Console.WriteLine("We have a bunch of animals here, which one would you like to pick?");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{i}: {animals[i]}");
            }

            int selectedAnimalIndex;
            bool success = false;

            while (!success)
            {
                string selection = Console.ReadLine();

                success = int.TryParse(selection, out selectedAnimalIndex);

                if (success)
                {
                    Animal animal = new Animal(animals.ElementAt(selectedAnimalIndex));
                    Console.WriteLine($"You chose a {animal.GetName()}!");
                }
                else {
                    Console.WriteLine("That's not an animal you can choose!");
                }
            }

            Console.ReadLine();
        }
    }
}
