namespace ZooManagementSystem
{
    partial class frmTurtle
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
            pictureBox1 = new PictureBox();
            turtleTitleLbl1 = new Label();
            turtleTitleLbl2 = new Label();
            turtleTitleLbl3 = new Label();
            turtleFoodSubmitBtn = new Button();
            turtleFoodLbl = new Label();
            turtleTitleLbl4 = new Label();
            turtleMoveBtn = new Button();
            turtleMoveLbl = new Label();
            turtleBackBtn = new Button();
            turtleSoundBtn = new Button();
            txtBoxDisplayTurtleInfo = new RichTextBox();
            turtleCmbFeeder = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Turtle;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-142, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(944, 478);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // turtleTitleLbl1
            // 
            turtleTitleLbl1.BackColor = Color.DarkKhaki;
            turtleTitleLbl1.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            turtleTitleLbl1.Location = new Point(431, 9);
            turtleTitleLbl1.Name = "turtleTitleLbl1";
            turtleTitleLbl1.Size = new Size(357, 22);
            turtleTitleLbl1.TabIndex = 1;
            turtleTitleLbl1.Text = "Fun Facts:";
            turtleTitleLbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // turtleTitleLbl2
            // 
            turtleTitleLbl2.BackColor = Color.DarkKhaki;
            turtleTitleLbl2.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            turtleTitleLbl2.Location = new Point(431, 183);
            turtleTitleLbl2.Name = "turtleTitleLbl2";
            turtleTitleLbl2.Size = new Size(357, 22);
            turtleTitleLbl2.TabIndex = 3;
            turtleTitleLbl2.Text = "Invoke Behaviours:";
            turtleTitleLbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // turtleTitleLbl3
            // 
            turtleTitleLbl3.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turtleTitleLbl3.Location = new Point(431, 215);
            turtleTitleLbl3.Name = "turtleTitleLbl3";
            turtleTitleLbl3.Size = new Size(357, 19);
            turtleTitleLbl3.TabIndex = 4;
            turtleTitleLbl3.Text = "Enter food to feed the Lion";
            turtleTitleLbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // turtleFoodSubmitBtn
            // 
            turtleFoodSubmitBtn.BackColor = Color.SandyBrown;
            turtleFoodSubmitBtn.Cursor = Cursors.Hand;
            turtleFoodSubmitBtn.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turtleFoodSubmitBtn.Location = new Point(700, 235);
            turtleFoodSubmitBtn.Name = "turtleFoodSubmitBtn";
            turtleFoodSubmitBtn.Size = new Size(88, 29);
            turtleFoodSubmitBtn.TabIndex = 6;
            turtleFoodSubmitBtn.Text = "Submit";
            turtleFoodSubmitBtn.UseVisualStyleBackColor = false;
            turtleFoodSubmitBtn.Click += turtleFoodSubmitBtn_Click;
            // 
            // turtleFoodLbl
            // 
            turtleFoodLbl.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turtleFoodLbl.Location = new Point(431, 267);
            turtleFoodLbl.Name = "turtleFoodLbl";
            turtleFoodLbl.Size = new Size(357, 25);
            turtleFoodLbl.TabIndex = 7;
            turtleFoodLbl.Text = "Food";
            turtleFoodLbl.TextAlign = ContentAlignment.MiddleLeft;
            turtleFoodLbl.Visible = false;
            // 
            // turtleTitleLbl4
            // 
            turtleTitleLbl4.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turtleTitleLbl4.Location = new Point(431, 303);
            turtleTitleLbl4.Name = "turtleTitleLbl4";
            turtleTitleLbl4.Size = new Size(357, 19);
            turtleTitleLbl4.TabIndex = 8;
            turtleTitleLbl4.Text = "Press the button!";
            turtleTitleLbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // turtleMoveBtn
            // 
            turtleMoveBtn.BackColor = Color.SandyBrown;
            turtleMoveBtn.Cursor = Cursors.Hand;
            turtleMoveBtn.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turtleMoveBtn.Location = new Point(431, 325);
            turtleMoveBtn.Name = "turtleMoveBtn";
            turtleMoveBtn.Size = new Size(357, 29);
            turtleMoveBtn.TabIndex = 9;
            turtleMoveBtn.Text = "Move";
            turtleMoveBtn.UseVisualStyleBackColor = false;
            turtleMoveBtn.Click += turtleMoveBtn_Click;
            // 
            // turtleMoveLbl
            // 
            turtleMoveLbl.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turtleMoveLbl.Location = new Point(431, 357);
            turtleMoveLbl.Name = "turtleMoveLbl";
            turtleMoveLbl.Size = new Size(357, 25);
            turtleMoveLbl.TabIndex = 10;
            turtleMoveLbl.Text = "Move";
            turtleMoveLbl.TextAlign = ContentAlignment.MiddleLeft;
            turtleMoveLbl.Visible = false;
            // 
            // turtleBackBtn
            // 
            turtleBackBtn.BackColor = Color.MediumAquamarine;
            turtleBackBtn.Cursor = Cursors.Hand;
            turtleBackBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turtleBackBtn.Location = new Point(677, 394);
            turtleBackBtn.Name = "turtleBackBtn";
            turtleBackBtn.Size = new Size(111, 44);
            turtleBackBtn.TabIndex = 12;
            turtleBackBtn.Text = "Back";
            turtleBackBtn.UseVisualStyleBackColor = false;
            turtleBackBtn.Click += turtleBackBtn_Click;
            // 
            // turtleSoundBtn
            // 
            turtleSoundBtn.BackColor = Color.Crimson;
            turtleSoundBtn.Cursor = Cursors.Hand;
            turtleSoundBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turtleSoundBtn.Location = new Point(12, 394);
            turtleSoundBtn.Name = "turtleSoundBtn";
            turtleSoundBtn.Size = new Size(111, 44);
            turtleSoundBtn.TabIndex = 11;
            turtleSoundBtn.Text = "Sound";
            turtleSoundBtn.UseVisualStyleBackColor = false;
            turtleSoundBtn.Click += turtleSoundBtn_Click;
            // 
            // txtBoxDisplayTurtleInfo
            // 
            txtBoxDisplayTurtleInfo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDisplayTurtleInfo.Location = new Point(431, 40);
            txtBoxDisplayTurtleInfo.Name = "txtBoxDisplayTurtleInfo";
            txtBoxDisplayTurtleInfo.ReadOnly = true;
            txtBoxDisplayTurtleInfo.Size = new Size(357, 130);
            txtBoxDisplayTurtleInfo.TabIndex = 2;
            txtBoxDisplayTurtleInfo.Text = "Information";
            // 
            // turtleCmbFeeder
            // 
            turtleCmbFeeder.FormattingEnabled = true;
            turtleCmbFeeder.Location = new Point(431, 237);
            turtleCmbFeeder.Name = "turtleCmbFeeder";
            turtleCmbFeeder.Size = new Size(263, 28);
            turtleCmbFeeder.TabIndex = 5;
            // 
            // frmTurtle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(turtleCmbFeeder);
            Controls.Add(txtBoxDisplayTurtleInfo);
            Controls.Add(turtleSoundBtn);
            Controls.Add(turtleBackBtn);
            Controls.Add(turtleMoveLbl);
            Controls.Add(turtleMoveBtn);
            Controls.Add(turtleTitleLbl4);
            Controls.Add(turtleFoodLbl);
            Controls.Add(turtleFoodSubmitBtn);
            Controls.Add(turtleTitleLbl3);
            Controls.Add(turtleTitleLbl2);
            Controls.Add(turtleTitleLbl1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmTurtle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTurtle";
            Load += frmTurtle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label turtleTitleLbl1;
        private Label turtleTitleLbl2;
        private Label turtleTitleLbl3;
        private Button turtleFoodSubmitBtn;
        private Label turtleFoodLbl;
        private Label turtleTitleLbl4;
        private Button turtleMoveBtn;
        private Label turtleMoveLbl;
        private Button turtleBackBtn;
        private Button turtleSoundBtn;
        private RichTextBox txtBoxDisplayTurtleInfo;
        private ComboBox turtleCmbFeeder;
    }
}