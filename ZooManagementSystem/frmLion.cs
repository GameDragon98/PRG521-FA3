using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    // Form for interacting with a lion in the zoo
    public partial class frmLion : Form
    {
        private Lion lion;

        // Constructor to initialize the form with the lion
        public frmLion(Lion lion)
        {
            InitializeComponent();
            this.lion = lion;
            lionCmbFeeder.DataSource = Enum.GetValues(typeof(FoodType)); // Populate the food combo box
        }

        // Event handler for loading the form
        private void frmLion_Load(object sender, EventArgs e)
        {
            // Display the lion information in the text box
            txtBoxDisplayLionInfo.Text = Zoo.DisplayAnimalInfo(lion);
        }

        // Event handler for submitting food for the lion
        private void lionFoodSubmitBtn_Click(object sender, EventArgs e)
        {
            // Feed the lion with the selected food in the comboBox and display the result
            lionFoodLbl.Text = lion.Feed((FoodType)lionCmbFeeder.SelectedValue);
            lionFoodLbl.Show();
        }

        // Event handler for moving the lion
        private void lionMoveBtn_Click(object sender, EventArgs e)
        {
            // Display the movement of the lion
            lionMoveLbl.Text = lion.Move();
            lionMoveLbl.Show();
        }

        // Event handler for making the lion sound
        private void lionSoundBtn_Click(object sender, EventArgs e)
        {
            lion.Speak(); // Make the lion sound
        }

        // Event handler for going back to the previous form
        private void lionBackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }
    }
}
