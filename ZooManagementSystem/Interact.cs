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
    // Form for interacting with selected animals in the zoo
    public partial class frmInteract : Form
    {
        private Zoo zoo;
        private Animal selectedAnimal;

        // Constructor to initialize the form with the zoo and selected animal
        public frmInteract(Zoo zoo, Animal selectedAnimal)
        {
            InitializeComponent();
            this.zoo = zoo;
            this.selectedAnimal = selectedAnimal;
            PopulateComboBoxes();
        }

        // Method to populate the combo boxes with animal names
        private void PopulateComboBoxes()
        {
            // Add lion names to the lion combo box
            foreach (var lion in zoo.GetLions())
            {
                lionCmbBox.Items.Add(lion.Name);
            }

            // Add parrot names to the parrot combo box
            foreach (var parrot in zoo.GetParrots())
            {
                parrotCmbBox.Items.Add(parrot.Name);
            }

            // Add turtle names to the turtle combo box
            foreach (var turtle in zoo.GetTurtles())
            {
                turtleCmbBox.Items.Add(turtle.Name);
            }
        }

        // Event handler for selecting a lion from the lion combo box
        private void lionCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lionCmbBox.SelectedItem != null)
            {
                // Set the selected animal to the selected lion
                selectedAnimal = zoo.GetLions().FirstOrDefault(l => l.Name == lionCmbBox.SelectedItem.ToString());
                EnableSubmitButton();
                // Disable selection for other animal types
                parrotCmbBox.Enabled = false;
                turtleCmbBox.Enabled = false;
            }
        }

        // Event handler for selecting a parrot from the parrot combo box
        private void parrotCmbBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (parrotCmbBox.SelectedItem != null)
            {
                // Set the selected animal to the selected parrot
                selectedAnimal = zoo.GetParrots().FirstOrDefault(p => p.Name == parrotCmbBox.SelectedItem.ToString());
                EnableSubmitButton();
                // Disable selection for other animal types
                lionCmbBox.Enabled = false;
                turtleCmbBox.Enabled = false;
            }
        }

        // Event handler for selecting a turtle from the turtle combo box
        private void turtleCmbBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (turtleCmbBox.SelectedItem != null)
            {
                // Set the selected animal to the selected turtle
                selectedAnimal = zoo.GetTurtles().FirstOrDefault(t => t.Name == turtleCmbBox.SelectedItem.ToString());
                EnableSubmitButton();
                // Disable selection for other animal types
                lionCmbBox.Enabled = false;
                parrotCmbBox.Enabled = false;
            }
        }

        // Method to enable the submit button when an animal is selected
        private void EnableSubmitButton()
        {
            interactSubmitBtn.Enabled = selectedAnimal != null;
        }

        // Event handler for the "Reset" button click
        private void resetBtn_Click(object sender, EventArgs e)
        {
            // Reset combo boxes and selected animal
            lionCmbBox.Enabled = true;
            parrotCmbBox.Enabled = true;
            turtleCmbBox.Enabled = true;
            lionCmbBox.SelectedIndex = -1;
            parrotCmbBox.SelectedIndex = -1;
            turtleCmbBox.SelectedIndex = -1;
            selectedAnimal = null;
            EnableSubmitButton();
        }

        // Event handler for the "Submit" button click
        private void submitBtn2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form

            if (selectedAnimal == null)
            {
                // Show a warning if no animal is selected
                MessageBox.Show("Please select an animal.", "No Animal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();
                return;
            }

            // Open the corresponding form based on the selected animal type
            if (zoo.GetLions().Any(l => l.Name == selectedAnimal.Name))
            {
                frmLion lionForm = new frmLion((Lion)selectedAnimal);
                lionForm.ShowDialog();
            }
            else if (zoo.GetParrots().Any(p => p.Name == selectedAnimal.Name))
            {
                frmParrot parrotForm = new frmParrot((Parrot)selectedAnimal);
                parrotForm.ShowDialog();
            }
            else if (zoo.GetTurtles().Any(t => t.Name == selectedAnimal.Name))
            {
                frmTurtle turtleForm = new frmTurtle((Turtle)selectedAnimal);
                turtleForm.ShowDialog();
            }
            else
            {
                // Show a warning if the selected animal is not recognized
                MessageBox.Show("Selected animal is not recognized.", "Invalid Animal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Show(); // Show the current form again
        }

        // Event handler for the "Back" button click
        private void backBtn3_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }
    }
}
