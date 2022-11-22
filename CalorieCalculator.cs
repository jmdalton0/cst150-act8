using System;
using System.Windows.Forms;

namespace Act8
{
    // WinForm to calculate the number of calories in user specified numbers of grams of fat and carbs
    public partial class CalorieCalculator : Form
    {
        public CalorieCalculator()
        {
            InitializeComponent();
        }

        // calculate calories
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numGramsFat = 0;
            int numGramsCarbs = 0;

            // if the user entered valid integer values for both grams of fat and carbs
            if (int.TryParse(numGramsFatTextBox.Text, out numGramsFat) &&
                int.TryParse(numGramsCarbsTextBox.Text, out numGramsCarbs))
            {
                // update results
                numCalsFatTextBox.Text = calculateCaloriesFromFat(numGramsFat).ToString();
                numCalsCarbsTextBox.Text = calculateCaloriesFromCarbs(numGramsCarbs).ToString();
            }
            else
            {
                MessageBox.Show("Please enter an integer for the number of grams of fat and carbs.");
            }
        }

        // calculate the number of calories in grams of fat
        private int calculateCaloriesFromFat(int numGramsFat)
        {
            return numGramsFat * 9;
        }

        // calculate the number of calories in grams of carbs
        private int calculateCaloriesFromCarbs(int numGramsCarbs)
        {
            return numGramsCarbs * 4;
        }

        // close form
        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
