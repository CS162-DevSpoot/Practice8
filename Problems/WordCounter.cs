namespace CS162_Practice8.Problems
{
    public partial class WordCounter : Form
    {
        public WordCounter()
        {
            InitializeComponent();
        }
        
        private string[] tokenalizeSentance(string sentance)
        {
            string[] tokens = sentance.Trim().Split(null);

            return tokens;
        }

        private decimal getAverageLettersPerToken(string[] tokens)
        {
            decimal numberOfLetters = 0m;

            foreach (var token in tokens)
            {
                char[] characters = token.ToCharArray();

                int lettersInToken = 0;
                
                foreach (char c in characters)
                {
                    if (char.IsPunctuation(c))
                    {
                        continue;
                    }
                    else
                    {
                        lettersInToken++;
                    }
                }

                numberOfLetters += lettersInToken;
            }

            return numberOfLetters/tokens.Length;
        }

        private void processString(object sender, EventArgs eventArgs)
        {
            try
            {
                string[] tokens = tokenalizeSentance(string_TextBox.Text);
                decimal averageLettersPerWord = getAverageLettersPerToken(tokens);

                words_Label.Text = $"{tokens.Length}";
                letters_Label.Text = averageLettersPerWord.ToString("f2");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EXIT(object sender, EventArgs eventArgs)
        {
            Application.Exit();
        }
    }
}
