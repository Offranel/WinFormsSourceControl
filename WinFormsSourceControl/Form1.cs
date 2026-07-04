namespace WinFormsSourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcAreaAndPerimeterButton_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(LengthTextBox.Text);
            int width = Convert.ToInt32(widthTextBox.Text);

            int area = length * width;
            int perimeter = length * 2 + width * 2;

            areaTextBox.Text = "Area is: " + area;
            perimeterTextBox.Text = "Perimeter is: " + perimeter;


        }
    }
}
