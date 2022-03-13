using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_AutomatedNeedsTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { 
                checkBox2.Checked = false;
            }
            else
            {

            }


                
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = textBox1.Text;
            var type = "none";
            var rate = textBox3.Text;
            int num = Convert.ToInt32(textBox2.Text);


            if (checkBox1.Checked == true)
                type = "\'thirst\'";
            else if (checkBox2.Checked == true)
                type = "\'hunger\'";
            else
                type = "\'none\'";


            richTextBox1.Multiline = true;
            richTextBox1.Text = $"{richTextBox1.Text}\r\n" +
                                $"[\'{num}\'] = " + "{\r\n" +
                                $"      [\'item\'] = \'{item}\',\r\n" +
                                $"      [\'type\'] = {type},\r\n" +
                                $"      [\'rate\'] = {rate}\r\n" +
                                "},";
            num = num + 1;
            textBox2.Text = Convert.ToString(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            textBox1.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
