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
            string[] animals = { "Dog", "Cat", "Monkey" };

            Console.WriteLine("Greetings... I'm Orisa the computer, please tell me your name :)");
            string name = Console.ReadLine();

            Console.WriteLine($"Oh cool, your name is {name}? Nice to meet you!");

            Console.WriteLine("We have a bunch of animals here, which one would you like to pick?");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{i}: {animals[i]}");
            }

            int selectedAnimalIndex = -1;
            string selectedAnimal = "";
            while (selectedAnimalIndex < 0)
            {
                try
                {
                    selectedAnimalIndex = Convert.ToInt32(Console.ReadLine());
                    selectedAnimal = animals.ElementAt(selectedAnimalIndex);
                    
                }
                catch
                {
                    Console.WriteLine("That's not an animal you can choose!");
                }
            }

            Animal animal = new Animal();
            animal.SetName(selectedAnimal);
            Console.WriteLine($"You chose a {animal.GetName()}!");

            Console.Read();
        }
    }
}
