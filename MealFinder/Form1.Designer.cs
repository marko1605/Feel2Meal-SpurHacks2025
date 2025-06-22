
namespace MealFinder
{
    partial class MealFinderApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealFinderApp));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            userTextBox = new RichTextBox();
            pictureBox2 = new PictureBox();
            friendTextBox = new RichTextBox();
            addUserButton = new Button();
            label2 = new Label();
            dollar1Sign = new Button();
            dollar2Sign = new Button();
            dollar3Sign = new Button();
            dollar4Sign = new Button();
            goButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(198, 28);
            label1.Name = "label1";
            label1.Size = new Size(127, 27);
            label1.TabIndex = 3;
            label1.Text = "Feel2Meal";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(49, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(110, 84);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(373, 67);
            userTextBox.TabIndex = 5;
            userTextBox.Text = " ";
            userTextBox.Enter += userTextBox_Enter_1;
            userTextBox.Leave += userTextBox_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(49, 195);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // friendTextBox
            // 
            friendTextBox.Location = new Point(110, 180);
            friendTextBox.Name = "friendTextBox";
            friendTextBox.Size = new Size(373, 67);
            friendTextBox.TabIndex = 7;
            friendTextBox.Text = "";
            friendTextBox.Enter += friendTextBox_Enter;
            friendTextBox.Leave += friendTextBox_Leave;
            // 
            // addUserButton
            // 
            addUserButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUserButton.Location = new Point(298, 270);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(185, 53);
            addUserButton.TabIndex = 8;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 354);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 10;
            label2.Text = "Price";
            // 
            // dollar1Sign
            // 
            dollar1Sign.Location = new Point(110, 354);
            dollar1Sign.Name = "dollar1Sign";
            dollar1Sign.Size = new Size(102, 29);
            dollar1Sign.TabIndex = 11;
            dollar1Sign.Text = "$";
            dollar1Sign.UseVisualStyleBackColor = true;
            dollar1Sign.Click += dollar1Sign_Click_1;
            // 
            // dollar2Sign
            // 
            dollar2Sign.Location = new Point(209, 354);
            dollar2Sign.Name = "dollar2Sign";
            dollar2Sign.Size = new Size(94, 29);
            dollar2Sign.TabIndex = 12;
            dollar2Sign.Text = "$$";
            dollar2Sign.UseVisualStyleBackColor = true;
            dollar2Sign.Click += dollar2Sign_Click;
            // 
            // dollar3Sign
            // 
            dollar3Sign.Location = new Point(298, 354);
            dollar3Sign.Name = "dollar3Sign";
            dollar3Sign.Size = new Size(94, 29);
            dollar3Sign.TabIndex = 13;
            dollar3Sign.Text = "$$$";
            dollar3Sign.UseVisualStyleBackColor = true;
            dollar3Sign.Click += dollar3Sign_Click;
            // 
            // dollar4Sign
            // 
            dollar4Sign.Location = new Point(389, 354);
            dollar4Sign.Name = "dollar4Sign";
            dollar4Sign.Size = new Size(94, 29);
            dollar4Sign.TabIndex = 14;
            dollar4Sign.Text = "+";
            dollar4Sign.UseVisualStyleBackColor = true;
            dollar4Sign.Click += dollar4Sign_Click;
            // 
            // goButton
            // 
            goButton.BackColor = Color.LimeGreen;
            goButton.Location = new Point(110, 416);
            goButton.Name = "goButton";
            goButton.Size = new Size(373, 66);
            goButton.TabIndex = 15;
            goButton.Text = "GO";
            goButton.UseVisualStyleBackColor = false;
            goButton.Click += goButton_Click;
            // 
            // MealFinderApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 533);
            Controls.Add(goButton);
            Controls.Add(dollar4Sign);
            Controls.Add(dollar3Sign);
            Controls.Add(dollar2Sign);
            Controls.Add(dollar1Sign);
            Controls.Add(label2);
            Controls.Add(addUserButton);
            Controls.Add(friendTextBox);
            Controls.Add(pictureBox2);
            Controls.Add(userTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "MealFinderApp";
            Text = "Feel2Meal";
            Load += MealFinderApp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void removePlaceholder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private RichTextBox userTextBox;
        private PictureBox pictureBox2;
        private RichTextBox friendTextBox;
        private Button addUserButton;
        private Label label2;
        private Button dollar1Sign;
        private Button dollar2Sign;
        private Button dollar3Sign;
        private Button dollar4Sign;
        private Button goButton;
    }
}
