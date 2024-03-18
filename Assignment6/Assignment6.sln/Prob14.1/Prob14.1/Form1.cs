namespace Prob14._1
{
    public partial class Form1 : Form
    {
        private List<int> randomIntegers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Read random integers from the file
            ReadRandomIntegersFromFile();

            // Remove negative numbers
            randomIntegers.RemoveAll(num => num < 0);

            // Create a second list with values in the range [1, 10]
            List<int> secondList = randomIntegers.FindAll(num => num >= 1 && num <= 10);

            // Display the second list in the ListBox
            foreach (int value in secondList)
            {
                listBox2.Items.Add(value);
            }
        }

        private void ReadRandomIntegersFromFile()
        {
            try
            {
                string filePath = @"C:\Users\karla\source\repos\CS-392-Assignments\Assignment6\Assignment6.sln\Prob14.1\Prob14.1\random.txt";
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int intValue))
                    {
                        randomIntegers.Add(intValue);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}