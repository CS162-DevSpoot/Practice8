namespace CS162_Practice8.Problems
{
    public partial class SentanceCapitalizer : Form
    {
        public SentanceCapitalizer()
        {
            InitializeComponent();
        }

        private string captializeString(string oldString)
        {
            string newString = "";

            string[] oldStringSplit = oldString.Split(null);

            int oldIndex = 0;
            bool lastWasPunc = false;
            foreach (string s in oldStringSplit)
            {
                char[] tokenalizeString = s.ToCharArray();
                char[] newToken = new char[tokenalizeString.Length];
                int charIndex = 0;
                foreach(char c in tokenalizeString)
                {
                    if((oldIndex == 0 && charIndex == 0 ) || lastWasPunc == true)
                    {
                        newString += char.ToUpper(c); ;
                        newToken[charIndex] = char.ToUpper(c);
                        lastWasPunc = false;
                    }
                    else
                    {
                        newString += c;
                        newToken[charIndex] = c;
                    }

                    if(charIndex == tokenalizeString.Length-1)
                    {
                        if(char.IsPunctuation(c))
                        {
                            lastWasPunc = true;
                        }
                        else
                        {
                            lastWasPunc = false;
                        }
                    }
                    charIndex++;
                }

                newString += " ";
                oldIndex++;
            }

            return newString;
        }

        private void capitializeButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string newString = captializeString(stringTextBox.Text);

                displayLabel.Text = newString;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
