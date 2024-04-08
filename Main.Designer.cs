namespace CS162_Practice8
{
    partial class Main
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
            wordCouner_Button = new Button();
            setanceCapitalizer_Button = new Button();
            voewsConstraints_Button = new Button();
            wordSpacer_Button = new Button();
            SuspendLayout();
            // 
            // wordCouner_Button
            // 
            wordCouner_Button.Location = new Point(12, 12);
            wordCouner_Button.Name = "wordCouner_Button";
            wordCouner_Button.Size = new Size(286, 23);
            wordCouner_Button.TabIndex = 0;
            wordCouner_Button.Text = "Word Counter";
            wordCouner_Button.UseVisualStyleBackColor = true;
            wordCouner_Button.Click += wordCounter;
            // 
            // setanceCapitalizer_Button
            // 
            setanceCapitalizer_Button.Location = new Point(12, 56);
            setanceCapitalizer_Button.Name = "setanceCapitalizer_Button";
            setanceCapitalizer_Button.Size = new Size(286, 23);
            setanceCapitalizer_Button.TabIndex = 1;
            setanceCapitalizer_Button.Text = "Sentence Capitalizer";
            setanceCapitalizer_Button.UseVisualStyleBackColor = true;
            setanceCapitalizer_Button.Click += sentanceCaptializer;
            // 
            // voewsConstraints_Button
            // 
            voewsConstraints_Button.Location = new Point(12, 100);
            voewsConstraints_Button.Name = "voewsConstraints_Button";
            voewsConstraints_Button.Size = new Size(286, 23);
            voewsConstraints_Button.TabIndex = 2;
            voewsConstraints_Button.Text = "Vowes and Constraints";
            voewsConstraints_Button.UseVisualStyleBackColor = true;
            voewsConstraints_Button.Click += vowesConstraints;
            // 
            // wordSpacer_Button
            // 
            wordSpacer_Button.Location = new Point(12, 144);
            wordSpacer_Button.Name = "wordSpacer_Button";
            wordSpacer_Button.Size = new Size(286, 23);
            wordSpacer_Button.TabIndex = 3;
            wordSpacer_Button.Text = "Word Spacer";
            wordSpacer_Button.UseVisualStyleBackColor = true;
            wordSpacer_Button.Click += wordSpacer;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 178);
            Controls.Add(wordSpacer_Button);
            Controls.Add(voewsConstraints_Button);
            Controls.Add(setanceCapitalizer_Button);
            Controls.Add(wordCouner_Button);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button wordCouner_Button;
        private Button setanceCapitalizer_Button;
        private Button voewsConstraints_Button;
        private Button wordSpacer_Button;
    }
}
