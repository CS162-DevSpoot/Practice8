namespace CS162_Practice8.Problems
{
    partial class SentanceCapitalizer
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
            displayLabel = new Label();
            captializeButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stringTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 52);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Your String";
            // 
            // stringTextBox
            // 
            stringTextBox.Location = new Point(6, 22);
            stringTextBox.Name = "stringTextBox";
            stringTextBox.Size = new Size(305, 23);
            stringTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(displayLabel);
            groupBox2.Location = new Point(12, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 52);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.Location = new Point(6, 19);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(305, 23);
            displayLabel.TabIndex = 0;
            displayLabel.Text = "So it goes'...";
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // captializeButton
            // 
            captializeButton.BackColor = Color.ForestGreen;
            captializeButton.ForeColor = SystemColors.ControlLightLight;
            captializeButton.Location = new Point(12, 128);
            captializeButton.Name = "captializeButton";
            captializeButton.Size = new Size(318, 23);
            captializeButton.TabIndex = 2;
            captializeButton.Text = "Captialize";
            captializeButton.UseVisualStyleBackColor = false;
            captializeButton.Click += capitializeButtonClicked;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(12, 157);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(318, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButtonClicked;
            // 
            // SentanceCapitalizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 192);
            Controls.Add(exitButton);
            Controls.Add(captializeButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SentanceCapitalizer";
            Text = "SentanceCapitalizer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox stringTextBox;
        private Label displayLabel;
        private Button captializeButton;
        private Button exitButton;
    }
}