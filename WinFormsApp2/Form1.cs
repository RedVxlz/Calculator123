namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNum1 = textBox1.Text;
            string inputNum2 = textBox2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            int AddResult = iNum1 + iNum2;
            ResultBox.Text = AddResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputNum1 = textBox1.Text;
            string inputNum2 = textBox2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            int AddResult = iNum1 - iNum2;
            ResultBox.Text = AddResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputNum1 = textBox1.Text;
            string inputNum2 = textBox2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            int AddResult = iNum1 * iNum2;
            ResultBox.Text = AddResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputNum1 = textBox1.Text;
            string inputNum2 = textBox2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            int AddResult = iNum1 / iNum2;
            ResultBox.Text = AddResult.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResultBox.Clear();
        }
    }
}
