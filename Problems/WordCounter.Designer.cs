namespace CS162_Practice8.Problems
{
    partial class WordCounter
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
            string_TextBox = new TextBox();
            groupBox2 = new GroupBox();
            words_Label = new Label();
            groupBox3 = new GroupBox();
            letters_Label = new Label();
            process_Button = new Button();
            exit_Button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(string_TextBox);
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(656, 57);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Your String.";
            // 
            // string_TextBox
            // 
            string_TextBox.Location = new Point(6, 22);
            string_TextBox.Name = "string_TextBox";
            string_TextBox.Size = new Size(644, 23);
            string_TextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(words_Label);
            groupBox2.Location = new Point(12, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 53);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Number of Words";
            // 
            // words_Label
            // 
            words_Label.BackColor = SystemColors.ControlLight;
            words_Label.Location = new Point(6, 19);
            words_Label.Name = "words_Label";
            words_Label.Size = new Size(188, 23);
            words_Label.TabIndex = 0;
            words_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(letters_Label);
            groupBox3.Location = new Point(218, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(213, 53);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Average amount of Letters Per Word";
            // 
            // letters_Label
            // 
            letters_Label.BackColor = SystemColors.ControlLight;
            letters_Label.Location = new Point(6, 19);
            letters_Label.Name = "letters_Label";
            letters_Label.Size = new Size(201, 23);
            letters_Label.TabIndex = 0;
            letters_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // process_Button
            // 
            process_Button.BackColor = Color.OliveDrab;
            process_Button.ForeColor = SystemColors.ButtonHighlight;
            process_Button.Location = new Point(437, 77);
            process_Button.Name = "process_Button";
            process_Button.Size = new Size(231, 53);
            process_Button.TabIndex = 3;
            process_Button.Text = "Process";
            process_Button.UseVisualStyleBackColor = false;
            process_Button.Click += processString;
            // 
            // exit_Button
            // 
            exit_Button.BackColor = Color.Tomato;
            exit_Button.ForeColor = SystemColors.ButtonHighlight;
            exit_Button.Location = new Point(12, 136);
            exit_Button.Name = "exit_Button";
            exit_Button.Size = new Size(657, 28);
            exit_Button.TabIndex = 4;
            exit_Button.Text = "EXIT";
            exit_Button.UseVisualStyleBackColor = false;
            exit_Button.Click += EXIT;
            // 
            // WordCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 172);
            Controls.Add(exit_Button);
            Controls.Add(process_Button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WordCounter";
            Text = "WordCounter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox string_TextBox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button process_Button;
        private Button exit_Button;
        private Label words_Label;
        private Label letters_Label;
    }
}