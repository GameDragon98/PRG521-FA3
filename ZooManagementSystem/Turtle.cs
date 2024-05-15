using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static ZooManagementSystem.Animal;

namespace ZooManagementSystem
{
    // Derived class (child) for Turtle
    // Turtle class inheriting from Animal and implementing IMovable, IFeedable and ISwimmable interfaces
    public class Turtle : Animal, IMovable, IFeedable, ISwimmable
    {
        // Information about the turtle's diet
        private DietInfo dietInfo;

        // Constructor to initialize the turtle
        public Turtle(string name, int age) : base(name, age, "Turtle") 
        {
            // Set species, food, and habitat characteristics
            this.Species = AnimalType.Reptile;
            this.Food = FoodType.Mixed;
            this.Habitat = HabitatType.Aquatic;
            // Initialize diet information about the turtle for the struct
            dietInfo = new DietInfo("Plants, fruits, insects, and small fish", "Once a day");
        }

        // Override methods for specific behaviors:

        // Override Eat method to specify turtle's eating behavior
        public override void Eat(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} enjoys a diverse diet, munching on plants, fruits, insects, and even small fish.");
        }

        // Override Sleep method to specify turtle's sleeping behavior
        public override void Sleep(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can sleep underwater for approximately 4 to 7 hours at a time.");
        }

        // Override Speak method to specify turtle's communication behavior
        //Using method overloading for method Speak(): 
        public override void Speak(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} communicates mainly through body language.");
        }

        // Override Speak method to play a breathing sound
        public override void Speak()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Audio\turtle_sound.wav");
            simpleSound.Play();
        }

        // Implement the Feed method from IFeedable interface to specify turtle's feeding behavior
        public override string Feed(FoodType food)
        {
            if (food == this.Food)
            { return base.Feed(food); }
            return $"{Name} does not eat {food}.";
        }

        // Implement the Move method from IMovable interface to specify turtle's movement
        public string Move()
        {
            return ($"{Name} is swimming gracefully.");
        }

        // Implement the Swim method from ISwimmable interface to specify turtle's swim behavior
        public string Swim(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} swim swiftly thanks to its streamlined shell and strong limbs.\n");
            return sb.ToString();
        }

        // Override method to display turtle-specific information
        public override void DisplayInfo(StringBuilder sb)
        {
            base.DisplayInfo(sb);
            Swim(sb);
            sb.AppendLine($"Dietary Requirements: {dietInfo.dietaryRequirements}");
            sb.AppendLine($"Feeding Schedule: {dietInfo.feedingSchedule}");
        }
    }
}
