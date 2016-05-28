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

namespace AlencarLucas_GroceryList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This is for the application to exit.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Method to add the written label into the Need list
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            //Clear selections
            listBox1.ClearSelected();
        }

        //Method to add the written label into the Have list
        private void button22_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
            textBox1.Text = "";
            //Clear selections
            listBox2.ClearSelected();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //If both items from the list are selected, swap them.
            if (listBox1.SelectedItem != null && listBox2.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);

                //If only one is selected, move it to the other list
            } else if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);
                
                //If only one is selected, move it to the other list
            }
            else if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            }
            //Clear both selections
            listBox1.ClearSelected();
            listBox2.ClearSelected();
        }

        //Delete Button
        private void button4_Click(object sender, EventArgs e)
        {
            //If both are selected, delete both
             if (listBox1.SelectedItem != null && listBox2.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);

                //If one item from the Have list is selected, delete it
            } else if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);

                //If one item from the Need list is selected, delete it
            } else if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                  
                //Clear selections 
            } else
            {
                listBox1.ClearSelected();
                listBox2.ClearSelected();
                textBox1.Text = "";
            }
            textBox1.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code to save the file as a ew File Dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save a file";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != null)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    
                    //This is to proper organize the file when saved.
                    foreach (String needs in listBox1.Items)
                    { sw.WriteLine("Need: " + needs);}
                    foreach (String haves in listBox2.Items)
                    { sw.WriteLine("Have: " + haves);}
                    sw.Close();
                }
            }
        }
    }
}
