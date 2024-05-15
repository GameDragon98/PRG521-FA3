using System.Text;

namespace ZooManagementSystem
{
    // Interface for animals that can be fed
    public interface IFeedable
    {
        public string Feed(FoodType food);
    }

    // Interface for animals that can move
    public interface IMovable
    {
        public string Move();
    }

    // Interface for animals that can climb
    public interface IClimbable
    {
        public string Climb(StringBuilder sb);
    }

    // Interface for animals that can fly
    public interface IFlyable
    {
        public string Fly(StringBuilder sb);
    }

    // Interface for animals that can swim
    public interface ISwimmable
    {
        public string Swim(StringBuilder sb);
    }

    

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}