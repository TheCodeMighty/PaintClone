namespace WinFormsLab
{
    public partial class NewCanvasForm : Form
    {
        public Color NewBackgroundColor { get; private set; } = Color.White;
        public int SelectedWidth { get; private set; } = 800;
        public int SelectedHeight { get; private set; } = 600;

        public NewCanvasForm()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
            widthUpDown.Value = SelectedWidth;
            heightUpDown.Value = SelectedHeight;
        }

        private void colorDialogButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                NewBackgroundColor = colorDialog.Color;
                colorDialogButton.BackColor = NewBackgroundColor;
            }
        }

        private void newCanvasButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void widthUpDown_ValueChanged(object sender, EventArgs e)
        {
            SelectedWidth = (int)widthUpDown.Value;
        }

        private void heightUpDown_ValueChanged(object sender, EventArgs e)
        {
            SelectedHeight = (int)heightUpDown.Value;
        }
    }
}
