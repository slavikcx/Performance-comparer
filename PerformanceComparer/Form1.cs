using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceComparer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int amountOfValues;
        Compare<int> compare;

        private void radioButtonStack_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonStack.Checked)
            {
                comboBoxMethodList.Items.Clear();
                comboBoxMethodList.Items.Add("Push");
                comboBoxMethodList.Items.Add("Pop");
                comboBoxMethodList.Items.Add("Print");
                comboBoxMethodList.SelectedItem = "Push";
            }
        }

        private void comboBoxMethodList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonQueue_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonQueue.Checked)
            {
                comboBoxMethodList.Items.Clear();
                comboBoxMethodList.Items.Add("Enqueue");
                comboBoxMethodList.Items.Add("Dequeue");
                comboBoxMethodList.Items.Add("Print");
                comboBoxMethodList.SelectedItem = "Enqueue";
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            string caseSwitch = comboBoxMethodList.SelectedItem.ToString();
            long timeElapsedStandard, timeElapsedUser;

            switch (caseSwitch)
            {
                case "Push":
                    compare = new Compare<int>();
                    listBoxResults.Items.Add("Push Method selected for comparing.");
                    
                    compare.StackPushCompare(amountOfValues, out timeElapsedStandard, out timeElapsedUser);

                    listBoxResults.Items.Add("Elapsed time for Pushing " + amountOfValues + " values into Standard Stack: " + timeElapsedStandard.ToString() + " milliseconds");
                    listBoxResults.Items.Add("Elapsed time for Pushing " + amountOfValues + " values into User Stack: " + timeElapsedUser.ToString() + " milliseconds");
                    listBoxResults.Items.Add("");
                    listBoxResults.SelectedIndex = listBoxResults.Items.Count - 1;

                    break;

                case "Pop":
                    compare = new Compare<int>();
                    listBoxResults.Items.Add("Pop Method selected for comparing.");

                    compare.StackPopCompare(amountOfValues, out timeElapsedStandard, out timeElapsedUser);

                    listBoxResults.Items.Add("Elapsed time for Poping " + amountOfValues + " values from Standard Stack: " + timeElapsedStandard.ToString() + " milliseconds");
                    listBoxResults.Items.Add("Elapsed time for Poping " + amountOfValues + " values from User Stack: " + timeElapsedUser.ToString() + " milliseconds");
                    listBoxResults.Items.Add("");
                    listBoxResults.SelectedIndex = listBoxResults.Items.Count - 1;

                    break;

                case "Enqueue":
                    compare = new Compare<int>();
                    listBoxResults.Items.Add("Enqueue Method selected for comparing.");

                    compare.QueueEnqueueCompare(amountOfValues, out timeElapsedStandard, out timeElapsedUser);

                    listBoxResults.Items.Add("Elapsed time for Enqueing " + amountOfValues + " values to Standard Queue: " + timeElapsedStandard.ToString() + " milliseconds");
                    listBoxResults.Items.Add("Elapsed time for Enqueing " + amountOfValues + " values to User Queue: " + timeElapsedUser.ToString() + " milliseconds");
                    listBoxResults.Items.Add("");
                    listBoxResults.SelectedIndex = listBoxResults.Items.Count - 1;
                    break;

                case "Dequeue":
                    compare = new Compare<int>();
                    listBoxResults.Items.Add("Dequeue Method selected for comparing.");
                    
                    compare.QueueDequeueCompare(amountOfValues, out timeElapsedStandard, out timeElapsedUser);

                    listBoxResults.Items.Add("Elapsed time for Dequeing " + amountOfValues + " values from Standard Queue: " + timeElapsedStandard.ToString() + " milliseconds");
                    listBoxResults.Items.Add("Elapsed time for Dequeing " + amountOfValues + " values from User Queue: " + timeElapsedUser.ToString() + " milliseconds");
                    listBoxResults.Items.Add("");
                    listBoxResults.SelectedIndex = listBoxResults.Items.Count - 1;
                    break;

                case "Print":

                    if (radioButtonStack.Checked)
                    {
                        listBoxResults.Items.Add("User Stack is printing: ");
                    }

                    if (radioButtonQueue.Checked)
                    {
                        listBoxResults.Items.Add("User Queue is printing: ");
                    }

                    foreach (int value in compare.Print())
                    {
                        listBoxResults.Items.Add(" "+ value);
                    }
                    listBoxResults.Items.Add("");
                    listBoxResults.SelectedIndex = listBoxResults.Items.Count - 1;

                    break;

                default:
                   
                    break;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxTextBoxAmountOfValues_TextChanged(object sender, EventArgs e)
        {
            bool parseSuccess = false;
            
            parseSuccess =  Int32.TryParse(textBoxTextBoxAmountOfValues.Text, out amountOfValues);
            
            if (parseSuccess == false)
            {
                listBoxResults.Items.Add("Please enter correct value into Amount of values field");
                listBoxResults.SelectedIndex = listBoxResults.Items.Count - 1;
            }

            if (amountOfValues > 1000000)
            {
                listBoxResults.Items.Add("Please enter value less than 1 million");
                listBoxResults.SelectedIndex = listBoxResults.Items.Count - 1;
            }
        }
    }
}
