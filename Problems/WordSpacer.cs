namespace CS162_Practice8.Problems
{
    public partial class WordSpacer : Form
    {
        public WordSpacer()
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
                char[] tokenalize = (stringTextBox.Text).ToCharArray();
                string newString = "";

                for (int i = 0; i < tokenalize.Length; i++)
                {
                    int length = tokenalize.Length - 1;
                    char character = tokenalize[length - i];
                    if (char.IsUpper(character)){
                        newString = $" {character}" + newString;
                    }
                    else
                    {
                        newString = character + newString;
                    }
                }

                displayLabel.Text = newString;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
