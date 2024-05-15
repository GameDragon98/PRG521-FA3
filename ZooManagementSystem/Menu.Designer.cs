namespace ZooManagementSystem
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            wcLabel = new Label();
            optLabel = new Label();
            addBtn = new Button();
            interactBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // wcLabel
            // 
            wcLabel.BackColor = Color.Transparent;
            wcLabel.Dock = DockStyle.Fill;
            wcLabel.Font = new Font("Algerian", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            wcLabel.ForeColor = SystemColors.ControlText;
            wcLabel.Location = new Point(0, 0);
            wcLabel.Name = "wcLabel";
            wcLabel.Size = new Size(1020, 516);
            wcLabel.TabIndex = 0;
            wcLabel.Text = "Welcome to the Virtual Zoo \r\n\r\n\r\n";
            wcLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // optLabel
            // 
            optLabel.AutoSize = true;
            optLabel.BackColor = Color.Transparent;
            optLabel.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            optLabel.Location = new Point(400, 114);
            optLabel.Name = "optLabel";
            optLabel.Size = new Size(207, 22);
            optLabel.TabIndex = 0;
            optLabel.Text = "Choose an option:\r\n";
            optLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.SandyBrown;
            addBtn.Cursor = Cursors.Hand;
            addBtn.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(400, 139);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(207, 45);
            addBtn.TabIndex = 1;
            addBtn.Text = "1. Add an animal";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // interactBtn
            // 
            interactBtn.BackColor = Color.SandyBrown;
            interactBtn.Cursor = Cursors.Hand;
            interactBtn.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interactBtn.Location = new Point(400, 190);
            interactBtn.Name = "interactBtn";
            interactBtn.Size = new Size(207, 45);
            interactBtn.TabIndex = 2;
            interactBtn.Text = "2. Interact with an animal";
            interactBtn.UseVisualStyleBackColor = false;
            interactBtn.Click += interactBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.SandyBrown;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(400, 241);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(207, 45);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "3. Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Zoo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 516);
            Controls.Add(exitBtn);
            Controls.Add(interactBtn);
            Controls.Add(addBtn);
            Controls.Add(optLabel);
            Controls.Add(wcLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label wcLabel;
        private Label optLabel;
        private Button addBtn;
        private Button interactBtn;
        private Button exitBtn;
    }
}
