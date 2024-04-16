namespace PaintClone
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            InitializeDescription();
        }

        private void InitializeDescription()
        {
            descriptionTextBox.Text = "This project was created by Arsenii Ostapyk as part of the " +
                "Programming in Graphical Environment university course.\n\nProject represents a clone " +
                "of MS Paint with basic features such as Pen, Line and Selection tools, " +
                "as well as image invertion functionality";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
