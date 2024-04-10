namespace CS162_Practice8.Problems
{
    partial class WordSpacer
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
            exitButton = new Button();
            processButton = new Button();
            groupBox2 = new GroupBox();
            displayLabel = new Label();
            groupBox1 = new GroupBox();
            stringTextBox = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(12, 157);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(318, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButtonClicked;
            // 
            // processButton
            // 
            processButton.BackColor = Color.ForestGreen;
            processButton.ForeColor = SystemColors.ControlLightLight;
            processButton.Location = new Point(12, 128);
            processButton.Name = "processButton";
            processButton.Size = new Size(318, 23);
            processButton.TabIndex = 6;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = false;
            processButton.Click += processButtonClicked;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(displayLabel);
            groupBox2.Location = new Point(12, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 52);
            groupBox2.TabIndex = 5;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(stringTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 52);
            groupBox1.TabIndex = 4;
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
            // WordSpacer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 192);
            Controls.Add(exitButton);
            Controls.Add(processButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WordSpacer";
            Text = "WordSpacer";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private Button processButton;
        private GroupBox groupBox2;
        private Label displayLabel;
        private GroupBox groupBox1;
        private TextBox stringTextBox;
    }
}