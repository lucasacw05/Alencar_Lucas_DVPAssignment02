using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactListDVP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Setting the view to the large image list
        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }


        //Setting the view to the small image list

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        //Class for people
        public People person
        {
            get
            {
                People p = new People();
                p.LastName = textBox1.Text;
                p.FirstName = textBox2.Text;
                p.EmailAddress = textBox3.Text;
                p.Number = textBox4.Text;
                if (radioButton1.Checked)
                {
                    p.ImageIndex = radioButton1.ImageIndex;
                } else if (radioButton2.Checked)
                {
                    p.ImageIndex = radioButton2.ImageIndex;
                } else if (radioButton3.Checked)
                {
                    p.ImageIndex = radioButton3.ImageIndex;
                }
                return p;

                //Setters for the information
            } set
            {
                //number
                textBox3.Text = value.Number;
                //email
                textBox4.Text = value.EmailAddress;
                //Last name
                textBox2.Text = value.LastName;
                //First name
                textBox1.Text = value.FirstName;
            }
        }

        //Add Button with all the code needed and validation
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("0") || textBox1.Text.Contains("1") || textBox1.Text.Contains("2") || textBox1.Text.Contains("3") || textBox1.Text.Contains("4") || textBox1.Text.Contains("5") || textBox1.Text.Contains("6") || textBox1.Text.Contains("7") || textBox1.Text.Contains("8") || textBox1.Text.Contains("9") && textBox2.Text.Contains("0") || textBox2.Text.Contains("1") || textBox2.Text.Contains("2") || textBox2.Text.Contains("3") || textBox2.Text.Contains("4") || textBox2.Text.Contains("5") || textBox2.Text.Contains("6") || textBox2.Text.Contains("7") || textBox2.Text.Contains("8") || textBox2.Text.Contains("9"))
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
            } else
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = person.ToString();
                lvi.ImageIndex = person.ImageIndex;
                lvi.Tag = person;
                listView1.Items.Add(lvi);
            }
            
        }

        //Delete button
        private void button3_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }

        }

        //Update button. I'm deleting the contact and adding a new one.
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
            ListViewItem lvi = new ListViewItem();
            lvi.Text = person.ToString();
            lvi.ImageIndex = person.ImageIndex;
            lvi.Tag = person;
            listView1.Items.Add(lvi);
        }
    }
}
