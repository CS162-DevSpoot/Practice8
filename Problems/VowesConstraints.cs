namespace CS162_Practice8.Problems
{
    public partial class VowesConstraints : Form
    {
        public VowesConstraints()
        {
            InitializeComponent();
        }

        private void exitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void processButtonClicked(object sender, EventArgs e)
        {
            try
            {
                //a, e, i, o, u
                int vowels = 0;
                int constants = 0
;                char[] tokenalize = stringTextBox.Text.ToCharArray();
                foreach (char c in tokenalize)
                {
                    char lowerCased = char.ToLower(c);
                    if ((lowerCased == 'a') || (lowerCased == 'e') || (lowerCased == 'i') || (lowerCased == 'o') || (lowerCased == 'u') || (lowerCased == 'y'))
                    {
                        vowels++;
                    }
                    else if (lowerCased == ' ' || char.IsPunctuation(c)) {
                        continue;
                    }else
                    {
                        constants++;
                    }
                }

                vowelsLabel.Text = vowels.ToString();
                constantsLabel.Text = constants.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
