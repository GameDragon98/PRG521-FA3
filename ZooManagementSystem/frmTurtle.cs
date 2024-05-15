using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    // Form for interacting with a turtle in the zoo
    public partial class frmTurtle : Form
    {
        private Turtle turtle;

        // Constructor to initialize the form with the turtle
        public frmTurtle(Turtle turtle)
        {
            InitializeComponent();
            this.turtle = turtle;
            turtleCmbFeeder.DataSource = Enum.GetValues(typeof(FoodType)); // Populate the food combo box
        }

        // Event handler for loading the form
        private void frmTurtle_Load(object sender, EventArgs e)
        {
            // Display the turtle information in the text box
            txtBoxDisplayTurtleInfo.Text = Zoo.DisplayAnimalInfo(turtle);
        }

        // Event handler for submitting food for the turtle
        private void turtleFoodSubmitBtn_Click(object sender, EventArgs e)
        {
            // Feed the turtle with the selected food in the comboBox and display the result
            turtleFoodLbl.Text = turtle.Feed((FoodType)turtleCmbFeeder.SelectedValue);
            turtleFoodLbl.Show();
        }

        // Event handler for moving the turtle
        private void turtleMoveBtn_Click(object sender, EventArgs e)
        {
            // Display the movement of the turtle
            turtleMoveLbl.Text = turtle.Move();
            turtleMoveLbl.Show();
        }

        // Event handler for making the turtle sound
        private void turtleSoundBtn_Click(object sender, EventArgs e)
        {
            turtle.Speak(); // Make the turtle sound
        }

        // Event handler for going back to the previous form
        private void turtleBackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }
    }
}
