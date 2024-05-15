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
    // Form for interacting with a parrot in the zoo
    public partial class frmParrot : Form
    {
        private Parrot parrot;

        // Constructor to initialize the form with the parrot
        public frmParrot(Parrot parrot)
        {
            InitializeComponent();
            this.parrot = parrot;
            parrotCmbFeeder.DataSource = Enum.GetValues(typeof(FoodType)); // Populate the food combo box
        }

        // Event handler for loading the form
        private void frmParrot_Load(object sender, EventArgs e)
        {
            // Display the parrot information in the text box
            txtBoxDisplayParrotInfo.Text = Zoo.DisplayAnimalInfo(parrot);
        }

        // Event handler for submitting food for the parrot
        private void parrotFoodSubmitBtn_Click(object sender, EventArgs e)
        {
            // Feed the parrot with the selected food in the comboBox and display the result
            parrotFoodLbl.Text = parrot.Feed((FoodType)parrotCmbFeeder.SelectedValue);
            parrotFoodLbl.Show();
        }

        // Event handler for moving the parrot
        private void parrotMoveBtn_Click(object sender, EventArgs e)
        {
            // Display the movement of the parrot
            parrotMoveLbl.Text = parrot.Move();
            parrotMoveLbl.Show();
        }

        // Event handler for making the parrot sound
        private void parrotSoundBtn_Click(object sender, EventArgs e)
        {
            parrot.Speak(); // Make the parrot sound
        }

        // Event handler for going back to the previous form
        private void parrotBackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }
    }
}
