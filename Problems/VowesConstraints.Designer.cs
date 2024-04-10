namespace CS162_Practice8.Problems
{
    partial class VowesConstraints
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
            groupBox1 = new GroupBox();
            stringTextBox = new TextBox();
            groupBox2 = new GroupBox();
            vowelsLabel = new Label();
            groupBox3 = new GroupBox();
            constantsLabel = new Label();
            processButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stringTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 49);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Your String:";
            // 
            // stringTextBox
            // 
            stringTextBox.Location = new Point(6, 18);
            stringTextBox.Name = "stringTextBox";
            stringTextBox.Size = new Size(348, 23);
            stringTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(vowelsLabel);
            groupBox2.Location = new Point(12, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 53);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vowels";
            // 
            // vowelsLabel
            // 
            vowelsLabel.BackColor = SystemColors.ControlLight;
            vowelsLabel.Location = new Point(6, 19);
            vowelsLabel.Name = "vowelsLabel";
            vowelsLabel.Size = new Size(168, 23);
            vowelsLabel.TabIndex = 0;
            vowelsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(constantsLabel);
            groupBox3.Location = new Point(192, 67);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(180, 53);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Constants";
            // 
            // constantsLabel
            // 
            constantsLabel.BackColor = SystemColors.ControlLight;
            constantsLabel.Location = new Point(6, 19);
            constantsLabel.Name = "constantsLabel";
            constantsLabel.Size = new Size(168, 23);
            constantsLabel.TabIndex = 0;
            constantsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // processButton
            // 
            processButton.BackColor = Color.ForestGreen;
            processButton.ForeColor = SystemColors.ControlLightLight;
            processButton.Location = new Point(18, 126);
            processButton.Name = "processButton";
            processButton.Size = new Size(162, 23);
            processButton.TabIndex = 3;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = false;
            processButton.Click += processButtonClicked;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(198, 126);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(168, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButtonClicked;
            // 
            // VowesConstraints
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 159);
            Controls.Add(exitButton);
            Controls.Add(processButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "VowesConstraints";
            Text = "VowesConstraints";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox stringTextBox;
        private Label vowelsLabel;
        private Label constantsLabel;
        private Button processButton;
        private Button exitButton;
    }
}