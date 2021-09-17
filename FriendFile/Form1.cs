using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FriendFile
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

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable
                StreamWriter outputFile;

                //Create a file and get a StreamWriter object
                outputFile = File.CreateText("Friend.txt");

                // Write the friend's name tot the file
                outputFile.WriteLine(nameTextBox.Text);

                //Close the file
                outputFile.Close();

                //Let the user know the name was written
                MessageBox.Show("The name was written");
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
