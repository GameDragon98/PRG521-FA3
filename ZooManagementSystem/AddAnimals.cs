using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    // Form for adding animals to the zoo
    public partial class frmAdd : Form
    {
        private Zoo zoo;

        // Constructor to initialize the form with the zoo
        public frmAdd(Zoo zoo)
        {
            InitializeComponent();
            this.zoo = zoo;
        }

        // Event handler for submitting the form
        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(nameTxtBox.Text) || string.IsNullOrWhiteSpace(ageTxtBox.Text) || string.IsNullOrWhiteSpace(typeCmbBox.Text))
            {
                MessageBox.Show("Please fill all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if age is a valid integer
            if (!int.TryParse(ageTxtBox.Text, out int age))
            {
                MessageBox.Show("Please enter a valid integer for age.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = nameTxtBox.Text;
            string type = typeCmbBox.Text;

            // Create an animal object based on the selected type and add it to the zoo
            switch (type)
            {
                case "Lion":
                    zoo.AddAnimal(new Lion(name, age));
                    break;
                case "Parrot":
                    zoo.AddAnimal(new Parrot(name, age));
                    break;
                case "Turtle":
                    zoo.AddAnimal(new Turtle(name, age));
                    break;
                default:
                    MessageBox.Show("Invalid animal type.", "Invalid Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            this.Close(); // Close the form after adding the animal
        }

        // Event handler for going back to the previous form
        private void backBtn1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }
    }
}
