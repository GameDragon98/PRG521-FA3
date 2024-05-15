using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    public class Zoo
    {
        // Lists to store different types of animals
        private List<Animal> animals;
        private List<Lion> lions;
        private List<Parrot> parrots;
        private List<Turtle> turtles;

        // Constructor to initialize the lists
        public Zoo()
        {
            animals = new List<Animal>();
            lions = new List<Lion>();
            parrots = new List<Parrot>();
            turtles = new List<Turtle>();
        }

        // Method to add an animal to the zoo
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            if (animal is Lion lion)
            {
                lions.Add(lion);
            }
            else if (animal is Parrot parrot)
            {
                parrots.Add(parrot);
            }
            else if (animal is Turtle turtle)
            {
                turtles.Add(turtle);
            }

            MessageBox.Show($"Added {animal.Name} to the zoo.", "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to get a list of lions in the zoo
        public List<Lion> GetLions()
        {
            return lions;
        }

        // Method to get a list of parrots in the zoo
        public List<Parrot> GetParrots()
        {
            return parrots;
        }

        // Method to get a list of turtles in the zoo
        public List<Turtle> GetTurtles()
        {
            return turtles;
        }

        // Method to display information about a selected animal
        public static string DisplayAnimalInfo(Animal SelectedAnimal)
        {
            StringBuilder sb = new StringBuilder();
            return SelectedAnimal.AnimalInfo.ToString();
        }

    }
}
