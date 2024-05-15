using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    // Base class representing all animals in the zoo
    public abstract class Animal : IFeedable
    {
        private string name;
        private int age;
        private string type;
        private AnimalType species;
        private FoodType food;
        private HabitatType habitat;

        // Properties to access private fields
        public string Name { get => name; }
        public int Age { get => age; }
        public string Type { get => type; }
        public AnimalType Species { get => species; set => species = value; }
        public FoodType Food { get => food; set => food = value; }
        public HabitatType Habitat { get => habitat; set => habitat = value; }

        // Default constructor
        public Animal()
        {
            this.name = "";
            this.age = 0;
            this.type = "";
        }

        // Parameterized constructor
        public Animal(string name, int age, string type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
        }

        // Abstract methods to be implemented by derived classes
        public abstract void Eat(StringBuilder sb);
        public abstract void Sleep(StringBuilder sb);
        public abstract void Speak(StringBuilder sb);
        public abstract void Speak();

        // Property to get animal information
        public StringBuilder AnimalInfo
        {
            get
            {
                var sb = new StringBuilder();
                this.DisplayInfo(sb);
                return sb;
            }
        }

        // Virtual method to display animal information
        public virtual void DisplayInfo(StringBuilder sb)
        {
            sb.AppendLine($"Name: {Name}\nAge: {Age}\nSpecies: {Species}\nHabitat Type: {Habitat}\n");
            Eat(sb);
            Speak(sb);
            Sleep(sb);
        }

        // Virtual method to feed the animal
        public virtual string Feed(FoodType food)
        {
            return $"{Name} is eating {this.food}";
        }

        // Struct to hold diet information
        public struct DietInfo
        {
            public string dietaryRequirements;
            public string feedingSchedule;

            // Constructor
            public DietInfo(string dietaryRequirements, string feedingSchedule)
            {
                this.dietaryRequirements = dietaryRequirements;
                this.feedingSchedule = feedingSchedule;
            }
        }
    }

    // Enum representing different animal types
    public enum AnimalType
    {
        Mammal,
        Bird,
        Reptile,
    }

    // Enum representing different food types
    public enum FoodType
    {
        Meat,
        Vegetables,
        Mixed, // Mixed (Meat and Vegetables)
    }

    // Enum representing different habitat types
    public enum HabitatType
    {
        Grassland,
        Forest,
        Aquatic,
    }
}
