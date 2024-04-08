using CS162_Practice8.Problems;

namespace CS162_Practice8
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void wordCounter(object sender, EventArgs e)
        {
            Form wordCounterForm = new WordCounter();
            wordCounterForm.Show();
        }

        private void sentanceCaptializer(object sender, EventArgs e)
        {
            Form sentanceCapitalizer = new SentanceCapitalizer();
            sentanceCapitalizer.Show();
        }

        private void vowesConstraints(object sender, EventArgs e)
        {
            Form vowesConstraints = new VowesConstraints();
            vowesConstraints.Show();
        }

        private void wordSpacer(object sender, EventArgs e)
        {
            Form wordSpacer = new WordSpacer();
            wordSpacer.Show();
        }
        
    }
}
