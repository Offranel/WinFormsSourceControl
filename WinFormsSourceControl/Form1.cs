namespace WinFormsSourceControl;

public partial class Form1 : Form
{
public Form1()
{
    InitializeComponent();
}

private void Form1_Load(object sender, EventArgs e)
{
        if(!int.TryParse("Please enter for length", out int length))
        {
            MessageBox.Show("Please enter a valid integer for length.", "Input Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            return;
        }
        if(!int.TryParse(widthTextBox.Text, out int width))
        {
            MessageBox.Show("Please enter a valid interger for width.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }


}

private void CalcAreaAndPerimeterButton_Click(object sender, EventArgs e)
{
    int length = Convert.ToInt32(LengthTextBox.Text);
    int width = Convert.ToInt32(widthTextBox.Text);

    int area = length * width;
    int perimeter = length * 2 + width * 2;

    areaTextBox.Text = "Area is: " + area;
    perimeterTextBox.Text = "Perimeter is: " + perimeter;


  }
}
