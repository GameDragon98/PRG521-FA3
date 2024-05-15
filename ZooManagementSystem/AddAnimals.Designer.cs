namespace ZooManagementSystem
{
    partial class frmAdd
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
            nameLabel = new Label();
            nameTxtBox = new TextBox();
            ageLabel = new Label();
            ageTxtBox = new TextBox();
            animalLabel = new Label();
            typeCmbBox = new ComboBox();
            addSubmitBtn = new Button();
            addBackBtn = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(248, 204);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(160, 16);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Enter animal name:";
            // 
            // nameTxtBox
            // 
            nameTxtBox.BackColor = SystemColors.ScrollBar;
            nameTxtBox.Cursor = Cursors.IBeam;
            nameTxtBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxtBox.Location = new Point(414, 198);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(125, 27);
            nameTxtBox.TabIndex = 1;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.Transparent;
            ageLabel.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageLabel.Location = new Point(248, 244);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(150, 16);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "Enter animal age:";
            // 
            // ageTxtBox
            // 
            ageTxtBox.BackColor = SystemColors.ScrollBar;
            ageTxtBox.Cursor = Cursors.IBeam;
            ageTxtBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageTxtBox.Location = new Point(414, 238);
            ageTxtBox.Name = "ageTxtBox";
            ageTxtBox.Size = new Size(125, 27);
            ageTxtBox.TabIndex = 3;
            // 
            // animalLabel
            // 
            animalLabel.AutoSize = true;
            animalLabel.BackColor = Color.Transparent;
            animalLabel.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            animalLabel.Location = new Point(248, 284);
            animalLabel.Name = "animalLabel";
            animalLabel.Size = new Size(163, 16);
            animalLabel.TabIndex = 4;
            animalLabel.Text = "Select animal type:\r\n";
            // 
            // typeCmbBox
            // 
            typeCmbBox.BackColor = SystemColors.ScrollBar;
            typeCmbBox.Cursor = Cursors.Hand;
            typeCmbBox.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeCmbBox.FormattingEnabled = true;
            typeCmbBox.Items.AddRange(new object[] { "Lion", "Parrot", "Turtle" });
            typeCmbBox.Location = new Point(414, 278);
            typeCmbBox.Name = "typeCmbBox";
            typeCmbBox.Size = new Size(151, 24);
            typeCmbBox.TabIndex = 5;
            // 
            // addSubmitBtn
            // 
            addSubmitBtn.BackColor = Color.SandyBrown;
            addSubmitBtn.Cursor = Cursors.Hand;
            addSubmitBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addSubmitBtn.Location = new Point(352, 394);
            addSubmitBtn.Name = "addSubmitBtn";
            addSubmitBtn.Size = new Size(111, 44);
            addSubmitBtn.TabIndex = 6;
            addSubmitBtn.Text = "Submit";
            addSubmitBtn.UseVisualStyleBackColor = false;
            addSubmitBtn.Click += submitBtn_Click;
            // 
            // addBackBtn
            // 
            addBackBtn.BackColor = Color.MediumAquamarine;
            addBackBtn.Cursor = Cursors.Hand;
            addBackBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBackBtn.Location = new Point(677, 394);
            addBackBtn.Name = "addBackBtn";
            addBackBtn.Size = new Size(111, 44);
            addBackBtn.TabIndex = 7;
            addBackBtn.Text = "Back";
            addBackBtn.UseVisualStyleBackColor = false;
            addBackBtn.Click += backBtn1_Click;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Add_Animals;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(addBackBtn);
            Controls.Add(addSubmitBtn);
            Controls.Add(typeCmbBox);
            Controls.Add(animalLabel);
            Controls.Add(ageTxtBox);
            Controls.Add(ageLabel);
            Controls.Add(nameTxtBox);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Animals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTxtBox;
        private Label ageLabel;
        private TextBox ageTxtBox;
        private Label animalLabel;
        private ComboBox typeCmbBox;
        private Button addSubmitBtn;
        private Button addBackBtn;
    }
}