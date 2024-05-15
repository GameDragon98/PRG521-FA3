namespace ZooManagementSystem
{
    partial class frmInteract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleInteractLbl = new Label();
            interacTypeLbl1 = new Label();
            lionCmbBox = new ComboBox();
            interacTypeLbl2 = new Label();
            parrotCmbBox = new ComboBox();
            interacTypeLbl3 = new Label();
            turtleCmbBox = new ComboBox();
            interactBackBtn = new Button();
            interactSubmitBtn = new Button();
            resetBtn = new Button();
            SuspendLayout();
            // 
            // titleInteractLbl
            // 
            titleInteractLbl.BackColor = Color.Transparent;
            titleInteractLbl.Dock = DockStyle.Top;
            titleInteractLbl.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleInteractLbl.Location = new Point(0, 0);
            titleInteractLbl.Name = "titleInteractLbl";
            titleInteractLbl.Size = new Size(800, 32);
            titleInteractLbl.TabIndex = 0;
            titleInteractLbl.Text = "Select a animal you want to interact with:";
            titleInteractLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // interacTypeLbl1
            // 
            interacTypeLbl1.BackColor = Color.DarkKhaki;
            interacTypeLbl1.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interacTypeLbl1.Location = new Point(33, 136);
            interacTypeLbl1.Name = "interacTypeLbl1";
            interacTypeLbl1.Size = new Size(151, 25);
            interacTypeLbl1.TabIndex = 1;
            interacTypeLbl1.Text = "Lion";
            interacTypeLbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lionCmbBox
            // 
            lionCmbBox.Cursor = Cursors.Hand;
            lionCmbBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionCmbBox.FormattingEnabled = true;
            lionCmbBox.Location = new Point(33, 187);
            lionCmbBox.Name = "lionCmbBox";
            lionCmbBox.Size = new Size(151, 25);
            lionCmbBox.TabIndex = 2;
            lionCmbBox.SelectedIndexChanged += lionCmbBox_SelectedIndexChanged;
            // 
            // interacTypeLbl2
            // 
            interacTypeLbl2.BackColor = Color.DarkKhaki;
            interacTypeLbl2.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interacTypeLbl2.Location = new Point(330, 136);
            interacTypeLbl2.Name = "interacTypeLbl2";
            interacTypeLbl2.Size = new Size(151, 25);
            interacTypeLbl2.TabIndex = 3;
            interacTypeLbl2.Text = "Parrot";
            interacTypeLbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parrotCmbBox
            // 
            parrotCmbBox.Cursor = Cursors.Hand;
            parrotCmbBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotCmbBox.FormattingEnabled = true;
            parrotCmbBox.Location = new Point(330, 187);
            parrotCmbBox.Name = "parrotCmbBox";
            parrotCmbBox.Size = new Size(151, 25);
            parrotCmbBox.TabIndex = 4;
            parrotCmbBox.SelectedIndexChanged += parrotCmbBox_SelectedIndexChanged_1;
            // 
            // interacTypeLbl3
            // 
            interacTypeLbl3.BackColor = Color.DarkKhaki;
            interacTypeLbl3.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interacTypeLbl3.Location = new Point(616, 136);
            interacTypeLbl3.Name = "interacTypeLbl3";
            interacTypeLbl3.Size = new Size(151, 25);
            interacTypeLbl3.TabIndex = 5;
            interacTypeLbl3.Text = "Turtle";
            interacTypeLbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // turtleCmbBox
            // 
            turtleCmbBox.Cursor = Cursors.Hand;
            turtleCmbBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turtleCmbBox.FormattingEnabled = true;
            turtleCmbBox.Location = new Point(616, 187);
            turtleCmbBox.Name = "turtleCmbBox";
            turtleCmbBox.Size = new Size(151, 25);
            turtleCmbBox.TabIndex = 7;
            turtleCmbBox.SelectedIndexChanged += turtleCmbBox_SelectedIndexChanged_1;
            // 
            // interactBackBtn
            // 
            interactBackBtn.BackColor = Color.MediumAquamarine;
            interactBackBtn.Cursor = Cursors.Hand;
            interactBackBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interactBackBtn.Location = new Point(677, 394);
            interactBackBtn.Name = "interactBackBtn";
            interactBackBtn.Size = new Size(111, 44);
            interactBackBtn.TabIndex = 9;
            interactBackBtn.Text = "Back";
            interactBackBtn.UseVisualStyleBackColor = false;
            interactBackBtn.Click += backBtn3_Click;
            // 
            // interactSubmitBtn
            // 
            interactSubmitBtn.BackColor = Color.SandyBrown;
            interactSubmitBtn.Cursor = Cursors.Hand;
            interactSubmitBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interactSubmitBtn.Location = new Point(352, 394);
            interactSubmitBtn.Name = "interactSubmitBtn";
            interactSubmitBtn.Size = new Size(111, 44);
            interactSubmitBtn.TabIndex = 8;
            interactSubmitBtn.Text = "Submit";
            interactSubmitBtn.UseVisualStyleBackColor = false;
            interactSubmitBtn.Click += submitBtn2_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.MediumAquamarine;
            resetBtn.Cursor = Cursors.Hand;
            resetBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.Location = new Point(12, 394);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(111, 44);
            resetBtn.TabIndex = 10;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // frmInteract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ZooMap1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(resetBtn);
            Controls.Add(interactSubmitBtn);
            Controls.Add(interactBackBtn);
            Controls.Add(turtleCmbBox);
            Controls.Add(interacTypeLbl3);
            Controls.Add(parrotCmbBox);
            Controls.Add(interacTypeLbl2);
            Controls.Add(lionCmbBox);
            Controls.Add(interacTypeLbl1);
            Controls.Add(titleInteractLbl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmInteract";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interact with Animals";
            ResumeLayout(false);
        }

        #endregion

        private Label titleInteractLbl;
        private Label interacTypeLbl1;
        private ComboBox lionCmbBox;
        private Label interacTypeLbl2;
        private ComboBox parrotCmbBox;
        private Label interacTypeLbl3;
        private ComboBox turtleCmbBox;
        private Button interactBackBtn;
        private Button interactSubmitBtn;
        private Button resetBtn;
    }
}