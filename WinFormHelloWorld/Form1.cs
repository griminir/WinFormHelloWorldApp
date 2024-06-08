using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GreetingButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show($@"please enter your full name",
                    $@"Blank textbox",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($@"Hello {FirstNameTextBox.Text} {LastNameTextBox.Text}",
                    $@"Welcome message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
            }
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            FirstNameTextBox.Focus();
        }
    }
}
