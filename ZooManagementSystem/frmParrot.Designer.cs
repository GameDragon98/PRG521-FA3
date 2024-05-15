namespace ZooManagementSystem
{
    partial class frmParrot
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
            parrotTitleLbl1 = new Label();
            parrotTitleLbl2 = new Label();
            parrotTitleLbl3 = new Label();
            parrotFoodSubmitBtn = new Button();
            parrotFoodLbl = new Label();
            parrotTitleLbl4 = new Label();
            parrotMoveBtn = new Button();
            parrotMoveLbl = new Label();
            parrotBackBtn = new Button();
            parrotSoundBtn = new Button();
            txtBoxDisplayParrotInfo = new RichTextBox();
            parrotCmbFeeder = new ComboBox();
            SuspendLayout();
            // 
            // parrotTitleLbl1
            // 
            parrotTitleLbl1.BackColor = Color.DarkKhaki;
            parrotTitleLbl1.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotTitleLbl1.ImageAlign = ContentAlignment.TopLeft;
            parrotTitleLbl1.Location = new Point(431, 9);
            parrotTitleLbl1.Name = "parrotTitleLbl1";
            parrotTitleLbl1.Size = new Size(357, 22);
            parrotTitleLbl1.TabIndex = 1;
            parrotTitleLbl1.Text = "Fun Facts:";
            parrotTitleLbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parrotTitleLbl2
            // 
            parrotTitleLbl2.BackColor = Color.DarkKhaki;
            parrotTitleLbl2.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotTitleLbl2.Location = new Point(431, 183);
            parrotTitleLbl2.Name = "parrotTitleLbl2";
            parrotTitleLbl2.Size = new Size(357, 22);
            parrotTitleLbl2.TabIndex = 3;
            parrotTitleLbl2.Text = "Invoke Behaviours:";
            parrotTitleLbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parrotTitleLbl3
            // 
            parrotTitleLbl3.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotTitleLbl3.Location = new Point(431, 215);
            parrotTitleLbl3.Name = "parrotTitleLbl3";
            parrotTitleLbl3.Size = new Size(357, 19);
            parrotTitleLbl3.TabIndex = 4;
            parrotTitleLbl3.Text = "Enter food to feed the Lion";
            parrotTitleLbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parrotFoodSubmitBtn
            // 
            parrotFoodSubmitBtn.BackColor = Color.SandyBrown;
            parrotFoodSubmitBtn.Cursor = Cursors.Hand;
            parrotFoodSubmitBtn.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotFoodSubmitBtn.Location = new Point(700, 235);
            parrotFoodSubmitBtn.Name = "parrotFoodSubmitBtn";
            parrotFoodSubmitBtn.Size = new Size(88, 29);
            parrotFoodSubmitBtn.TabIndex = 6;
            parrotFoodSubmitBtn.Text = "Submit";
            parrotFoodSubmitBtn.UseVisualStyleBackColor = false;
            parrotFoodSubmitBtn.Click += parrotFoodSubmitBtn_Click;
            // 
            // parrotFoodLbl
            // 
            parrotFoodLbl.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotFoodLbl.Location = new Point(431, 267);
            parrotFoodLbl.Name = "parrotFoodLbl";
            parrotFoodLbl.Size = new Size(357, 25);
            parrotFoodLbl.TabIndex = 7;
            parrotFoodLbl.Text = "Food";
            parrotFoodLbl.TextAlign = ContentAlignment.MiddleLeft;
            parrotFoodLbl.Visible = false;
            // 
            // parrotTitleLbl4
            // 
            parrotTitleLbl4.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotTitleLbl4.Location = new Point(431, 303);
            parrotTitleLbl4.Name = "parrotTitleLbl4";
            parrotTitleLbl4.Size = new Size(357, 19);
            parrotTitleLbl4.TabIndex = 8;
            parrotTitleLbl4.Text = "Press the button!";
            parrotTitleLbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parrotMoveBtn
            // 
            parrotMoveBtn.BackColor = Color.SandyBrown;
            parrotMoveBtn.Cursor = Cursors.Hand;
            parrotMoveBtn.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotMoveBtn.Location = new Point(431, 325);
            parrotMoveBtn.Name = "parrotMoveBtn";
            parrotMoveBtn.Size = new Size(357, 29);
            parrotMoveBtn.TabIndex = 9;
            parrotMoveBtn.Text = "Move";
            parrotMoveBtn.UseVisualStyleBackColor = false;
            parrotMoveBtn.Click += parrotMoveBtn_Click;
            // 
            // parrotMoveLbl
            // 
            parrotMoveLbl.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotMoveLbl.Location = new Point(431, 357);
            parrotMoveLbl.Name = "parrotMoveLbl";
            parrotMoveLbl.Size = new Size(357, 25);
            parrotMoveLbl.TabIndex = 10;
            parrotMoveLbl.Text = "Move";
            parrotMoveLbl.TextAlign = ContentAlignment.MiddleLeft;
            parrotMoveLbl.Visible = false;
            // 
            // parrotBackBtn
            // 
            parrotBackBtn.BackColor = Color.MediumAquamarine;
            parrotBackBtn.Cursor = Cursors.Hand;
            parrotBackBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotBackBtn.Location = new Point(677, 394);
            parrotBackBtn.Name = "parrotBackBtn";
            parrotBackBtn.Size = new Size(111, 44);
            parrotBackBtn.TabIndex = 12;
            parrotBackBtn.Text = "Back";
            parrotBackBtn.UseVisualStyleBackColor = false;
            parrotBackBtn.Click += parrotBackBtn_Click;
            // 
            // parrotSoundBtn
            // 
            parrotSoundBtn.BackColor = Color.Crimson;
            parrotSoundBtn.Cursor = Cursors.Hand;
            parrotSoundBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotSoundBtn.Location = new Point(12, 394);
            parrotSoundBtn.Name = "parrotSoundBtn";
            parrotSoundBtn.Size = new Size(111, 44);
            parrotSoundBtn.TabIndex = 11;
            parrotSoundBtn.Text = "Sound";
            parrotSoundBtn.UseVisualStyleBackColor = false;
            parrotSoundBtn.Click += parrotSoundBtn_Click;
            // 
            // txtBoxDisplayParrotInfo
            // 
            txtBoxDisplayParrotInfo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDisplayParrotInfo.Location = new Point(431, 40);
            txtBoxDisplayParrotInfo.Name = "txtBoxDisplayParrotInfo";
            txtBoxDisplayParrotInfo.ReadOnly = true;
            txtBoxDisplayParrotInfo.Size = new Size(357, 130);
            txtBoxDisplayParrotInfo.TabIndex = 2;
            txtBoxDisplayParrotInfo.Text = "Information";
            // 
            // parrotCmbFeeder
            // 
            parrotCmbFeeder.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotCmbFeeder.FormattingEnabled = true;
            parrotCmbFeeder.Location = new Point(431, 237);
            parrotCmbFeeder.Name = "parrotCmbFeeder";
            parrotCmbFeeder.Size = new Size(263, 27);
            parrotCmbFeeder.TabIndex = 5;
            // 
            // frmParrot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Parrot;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(parrotCmbFeeder);
            Controls.Add(txtBoxDisplayParrotInfo);
            Controls.Add(parrotSoundBtn);
            Controls.Add(parrotBackBtn);
            Controls.Add(parrotMoveLbl);
            Controls.Add(parrotMoveBtn);
            Controls.Add(parrotTitleLbl4);
            Controls.Add(parrotFoodLbl);
            Controls.Add(parrotFoodSubmitBtn);
            Controls.Add(parrotTitleLbl3);
            Controls.Add(parrotTitleLbl2);
            Controls.Add(parrotTitleLbl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmParrot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmParrot";
            Load += frmParrot_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label parrotTitleLbl1;
        private Label parrotTitleLbl2;
        private Label parrotTitleLbl3;
        private Button parrotFoodSubmitBtn;
        private Label parrotFoodLbl;
        private Label parrotTitleLbl4;
        private Button parrotMoveBtn;
        private Label parrotMoveLbl;
        private Button parrotBackBtn;
        private Button parrotSoundBtn;
        private RichTextBox txtBoxDisplayParrotInfo;
        private ComboBox parrotCmbFeeder;
    }
}