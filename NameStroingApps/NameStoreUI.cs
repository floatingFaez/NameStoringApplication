using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NameStroingApps
{
    public partial class NameStoringForm : Form
    {
        public NameStoringForm()
        {
            InitializeComponent();
        }

        List<string> nameList = new List<string>();
        int i = 0;
        int count = 0;

        private void showAllMethod()
        {
            showNameListBox.Items.Clear();
            foreach (string aName in nameList)
            {
                showNameListBox.Items.Add(aName);
            }
        }

        private void NameStoringForm_Load(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            showAllButton.Enabled = false;
            resetButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            nameList.Add(addNameTextBox.Text);
            countingResultLabel.Text = Convert.ToString(++i);
            addNameTextBox.Text = "";
            if (i == count)
            {
                addButton.Enabled = false;
                showAllMethod();

                //showNameListBox.Items.Clear();
                //for (int j = 0; j < i; j++)
                //{   
                //    showNameListBox.Items.Add(nameList[j]);
                //}
            }
        }

        

        private void showAllButton_Click(object sender, EventArgs e)
        {
            showAllMethod();

            //showNameListBox.Items.Clear();
            //for (int j = 0; j <i; j++)
            //{
            //    showNameListBox.Items.Clear();
            //    showNameListBox.Items.Add(nameList[j]);
            //}
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            i = 0;
            count = 0;
            nameList = new List<string>();
            addNameTextBox.Text = "";
            countingResultLabel.Text = "";
            showNameListBox.Items.Clear();
            addButton.Enabled = false;
            showAllButton.Enabled = false;
            resetButton.Enabled = false;
            setButton.Enabled = true;
            
            
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(countTextBox.Text);
            countTextBox.Text = "";
            addButton.Enabled = true;
            showAllButton.Enabled = true;
            resetButton.Enabled = true;
            setButton.Enabled = false;

        }



        


    }
}
