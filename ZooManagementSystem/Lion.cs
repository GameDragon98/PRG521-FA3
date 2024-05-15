using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooManagementSystem
{
    // Derived class (child) for Lion
    // Lion class inheriting from Animal and implementing IMovable, IFeedable and IClimbable interfaces
    public class Lion : Animal, IMovable, IFeedable, IClimbable
    {
        // Information about the turtle's diet
        private DietInfo dietInfo;

        // Constructor to initialize the lion
        public Lion(string name, int age) : base(name, age, "Lion") 
        {
            // Set species, food, and habitat characteristics
            this.Species = AnimalType.Mammal;
            this.Food = FoodType.Meat;
            this.Habitat = HabitatType.Grassland;
            // Initialize diet information about the lion for the struct
            dietInfo = new DietInfo("Meat", "Once a day");
        }

        // Override methods for specific behaviors:

        // Override Eat method to specify lion's eating behavior
        public override void Eat(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can consume up to 40kg of meat in a single meal, which is around a quarter of his body weight.");
        }

        // Override Sleep method to specify lion's sleeping behavior
        public override void Sleep(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can sleep for up to 20 hours a day.");
        }

        // Override Speak method to specify lion's roaring behavior
        //Using method overloading for method Speak():
        public override void Speak(StringBuilder sb)
        {
            sb.AppendLine($"•{Name}'s roar can be heard from a distance of up to 8 kilometers (5 miles)!");
        }

        // Override Speak method to play a roaring sound
        public override void Speak()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Audio\lion_sound.wav");
            simpleSound.Play();
        }

        // Implement the Feed method from IFeedable interface to specify lion's feeding behavior
        public override string Feed(FoodType food)
        {
            if (food == this.Food)
            { return base.Feed(food); }
            return $"{Name} does not eat {food}.";
        }

        // Implement the Move method from IMovable interface to specify lion's movement
        public string Move()
        {
            return ($"{Name} is walking through the long grass.");
        }

        // Implement the Climb method from IClimbable interface to specify lion's climb behavior
        public string Climb(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} climbs trees to scout prey and monitor its territory.\n");
            return sb.ToString();
        }

        // Override method to display lion-specific information
        public override void DisplayInfo(StringBuilder sb)
        {
            base.DisplayInfo(sb);
            Climb(sb);
            sb.AppendLine($"Dietary Requirements: {dietInfo.dietaryRequirements}");
            sb.AppendLine($"Feeding Schedule: {dietInfo.feedingSchedule}");
        }
    }
}
