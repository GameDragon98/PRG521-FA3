using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    // Derived class (child) for Parrot
    // Parrot class inheriting from Animal and implementing IMovable, IFeedable and IFlyable interfaces
    public class Parrot : Animal, IMovable, IFeedable, IFlyable
    {
        // Information about the parrot's diet
        private DietInfo dietInfo;

        // Constructor to initialize the parrot
        public Parrot(string name, int age) : base(name, age, "Parrot") 
        {
            // Set species, food, and habitat characteristics
            this.Species = AnimalType.Bird;
            this.Food = FoodType.Vegetables;
            this.Habitat = HabitatType.Forest;
            // Initialize diet information about the parrot for the struct
            dietInfo = new DietInfo("Fruits, nuts, seeds, and veggies", "Multiple times a day");
        }

        // Override methods for specific behaviors:

        // Override Eat method to specify parrot's eating behavior
        public override void Eat(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} enjoys a colorful diet, munching on fruits, nuts, seeds, and veggies.");
        }

        // Override Sleep method to specify parrot's sleeping behavior
        public override void Sleep(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can sleep with one eye open to stay alert.");
        }

        // Override Speak method to specify parrot's speaking behavior
        //Using method overloading for method Speak():
        public override void Speak(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can learn hundreds of words and phrases to communicate.");
        }

        // Override Speak method to play a squawking sound
        public override void Speak()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Audio\parrot_sound.wav");
            simpleSound.Play();
        }

        // Implement the Feed method from IFeedable interface to specify parrot's feeding behavior
        public override string Feed(FoodType food)
        {
            if (food == this.Food)
            { return base.Feed(food); }
            return $"{Name} does not eat {food}.";
        }

        // Implement the Move method from IMovable interface to specify parrot's movement
        public string Move()
        {
            return ($"{Name} is flying over the trees.");
        }

        // Implement the Fly method from IFlyable interface to specify parrot's fly behavior
        public string Fly(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can typically fly at between 35 and 40 miles per hour.\n");
            return sb.ToString();
        }

        // Override method to display parrot-specific information
        public override void DisplayInfo(StringBuilder sb)
        {
            base.DisplayInfo(sb);
            Fly(sb);
            sb.AppendLine($"Dietary Requirements: {dietInfo.dietaryRequirements}");
            sb.AppendLine($"Feeding Schedule: {dietInfo.feedingSchedule}");
        }
    }
}
