namespace ZooManagementSystem
{
    // The main form of the Zoo Management System application
    public partial class frmMain : Form
    {
        private Zoo zoo;
        private Animal selectedAnimal;

        // Constructor for the main form
        public frmMain()
        {
            InitializeComponent();
            zoo = new Zoo();
        }

        // Event handler for the "Add" button click
        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false; // Hide the main form

            // Open the form to add a new animal to the zoo
            frmAdd form = new frmAdd(zoo);
            form.ShowDialog();

            this.Visible = true; // Show the main form again
        }

        // Event handler for the "Interact" button click
        private void interactBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false; // Hide the main form

            // Open the form to interact with a selected animal
            frmInteract form = new frmInteract(zoo, selectedAnimal);
            form.ShowDialog();

            this.Visible = true; // Show the main form again
        }

        // Event handler for the "Exit" button click
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
