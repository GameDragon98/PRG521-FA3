namespace ZooManagementSystem
{
    partial class frmLion
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
            lionBackBtn = new Button();
            lionTitleLbl1 = new Label();
            lionTitleLbl2 = new Label();
            lionTitleLbl3 = new Label();
            lionFoodSubmitBtn = new Button();
            lionFoodLbl = new Label();
            lionTitleLbl4 = new Label();
            lionMoveBtn = new Button();
            lionMoveLbl = new Label();
            lionSoundBtn = new Button();
            lionCmbFeeder = new ComboBox();
            txtBoxDisplayLionInfo = new RichTextBox();
            SuspendLayout();
            // 
            // lionBackBtn
            // 
            lionBackBtn.BackColor = Color.MediumAquamarine;
            lionBackBtn.Cursor = Cursors.Hand;
            lionBackBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionBackBtn.Location = new Point(677, 394);
            lionBackBtn.Name = "lionBackBtn";
            lionBackBtn.Size = new Size(111, 44);
            lionBackBtn.TabIndex = 12;
            lionBackBtn.Text = "Back";
            lionBackBtn.UseVisualStyleBackColor = false;
            lionBackBtn.Click += lionBackBtn_Click;
            // 
            // lionTitleLbl1
            // 
            lionTitleLbl1.BackColor = Color.DarkKhaki;
            lionTitleLbl1.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lionTitleLbl1.Location = new Point(431, 9);
            lionTitleLbl1.Name = "lionTitleLbl1";
            lionTitleLbl1.Size = new Size(357, 22);
            lionTitleLbl1.TabIndex = 1;
            lionTitleLbl1.Text = "Fun Facts:";
            lionTitleLbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lionTitleLbl2
            // 
            lionTitleLbl2.BackColor = Color.DarkKhaki;
            lionTitleLbl2.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lionTitleLbl2.Location = new Point(431, 183);
            lionTitleLbl2.Name = "lionTitleLbl2";
            lionTitleLbl2.Size = new Size(357, 22);
            lionTitleLbl2.TabIndex = 3;
            lionTitleLbl2.Text = "Invoke Behaviours:\r\n";
            lionTitleLbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lionTitleLbl3
            // 
            lionTitleLbl3.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionTitleLbl3.Location = new Point(431, 215);
            lionTitleLbl3.Name = "lionTitleLbl3";
            lionTitleLbl3.Size = new Size(357, 19);
            lionTitleLbl3.TabIndex = 4;
            lionTitleLbl3.Text = "Enter food to feed the Lion";
            lionTitleLbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lionFoodSubmitBtn
            // 
            lionFoodSubmitBtn.BackColor = Color.SandyBrown;
            lionFoodSubmitBtn.Cursor = Cursors.Hand;
            lionFoodSubmitBtn.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionFoodSubmitBtn.Location = new Point(700, 235);
            lionFoodSubmitBtn.Name = "lionFoodSubmitBtn";
            lionFoodSubmitBtn.Size = new Size(88, 29);
            lionFoodSubmitBtn.TabIndex = 6;
            lionFoodSubmitBtn.Text = "Submit";
            lionFoodSubmitBtn.UseVisualStyleBackColor = false;
            lionFoodSubmitBtn.Click += lionFoodSubmitBtn_Click;
            // 
            // lionFoodLbl
            // 
            lionFoodLbl.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionFoodLbl.Location = new Point(431, 267);
            lionFoodLbl.Name = "lionFoodLbl";
            lionFoodLbl.Size = new Size(357, 25);
            lionFoodLbl.TabIndex = 7;
            lionFoodLbl.Text = "Food";
            lionFoodLbl.TextAlign = ContentAlignment.MiddleLeft;
            lionFoodLbl.Visible = false;
            // 
            // lionTitleLbl4
            // 
            lionTitleLbl4.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionTitleLbl4.Location = new Point(431, 303);
            lionTitleLbl4.Name = "lionTitleLbl4";
            lionTitleLbl4.Size = new Size(357, 19);
            lionTitleLbl4.TabIndex = 8;
            lionTitleLbl4.Text = "Press the button!";
            lionTitleLbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lionMoveBtn
            // 
            lionMoveBtn.BackColor = Color.SandyBrown;
            lionMoveBtn.Cursor = Cursors.Hand;
            lionMoveBtn.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionMoveBtn.Location = new Point(431, 325);
            lionMoveBtn.Name = "lionMoveBtn";
            lionMoveBtn.Size = new Size(357, 29);
            lionMoveBtn.TabIndex = 9;
            lionMoveBtn.Text = "Move";
            lionMoveBtn.UseVisualStyleBackColor = false;
            lionMoveBtn.Click += lionMoveBtn_Click;
            // 
            // lionMoveLbl
            // 
            lionMoveLbl.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionMoveLbl.Location = new Point(431, 357);
            lionMoveLbl.Name = "lionMoveLbl";
            lionMoveLbl.Size = new Size(357, 25);
            lionMoveLbl.TabIndex = 10;
            lionMoveLbl.Text = "Move";
            lionMoveLbl.TextAlign = ContentAlignment.MiddleLeft;
            lionMoveLbl.Visible = false;
            // 
            // lionSoundBtn
            // 
            lionSoundBtn.BackColor = Color.Crimson;
            lionSoundBtn.Cursor = Cursors.Hand;
            lionSoundBtn.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionSoundBtn.Location = new Point(12, 394);
            lionSoundBtn.Name = "lionSoundBtn";
            lionSoundBtn.Size = new Size(111, 44);
            lionSoundBtn.TabIndex = 11;
            lionSoundBtn.Text = "Sound";
            lionSoundBtn.UseVisualStyleBackColor = false;
            lionSoundBtn.Click += lionSoundBtn_Click;
            // 
            // lionCmbFeeder
            // 
            lionCmbFeeder.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lionCmbFeeder.FormattingEnabled = true;
            lionCmbFeeder.Location = new Point(431, 237);
            lionCmbFeeder.Name = "lionCmbFeeder";
            lionCmbFeeder.Size = new Size(263, 27);
            lionCmbFeeder.TabIndex = 5;
            // 
            // txtBoxDisplayLionInfo
            // 
            txtBoxDisplayLionInfo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDisplayLionInfo.Location = new Point(431, 40);
            txtBoxDisplayLionInfo.Name = "txtBoxDisplayLionInfo";
            txtBoxDisplayLionInfo.ReadOnly = true;
            txtBoxDisplayLionInfo.Size = new Size(357, 130);
            txtBoxDisplayLionInfo.TabIndex = 2;
            txtBoxDisplayLionInfo.Text = "Information";
            // 
            // frmLion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lion;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxDisplayLionInfo);
            Controls.Add(lionCmbFeeder);
            Controls.Add(lionSoundBtn);
            Controls.Add(lionMoveLbl);
            Controls.Add(lionMoveBtn);
            Controls.Add(lionTitleLbl4);
            Controls.Add(lionFoodLbl);
            Controls.Add(lionFoodSubmitBtn);
            Controls.Add(lionTitleLbl3);
            Controls.Add(lionTitleLbl2);
            Controls.Add(lionTitleLbl1);
            Controls.Add(lionBackBtn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmLion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLion";
            Load += frmLion_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button lionBackBtn;
        private Label lionTitleLbl1;
        private Label lionTitleLbl2;
        private Label lionTitleLbl3;
        private Button lionFoodSubmitBtn;
        private Label lionFoodLbl;
        private Label lionTitleLbl4;
        private Button lionMoveBtn;
        private Label lionMoveLbl;
        private Button lionSoundBtn;
        private ComboBox lionCmbFeeder;
        private RichTextBox txtBoxDisplayLionInfo;
    }
}