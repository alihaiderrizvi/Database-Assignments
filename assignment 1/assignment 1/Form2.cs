using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
            textBox3.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ERD");
                comboBox2.Items.Add("SQL");
                comboBox2.Items.Add("OLAP");
                comboBox2.Items.Add("Datamining");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("C#");
                comboBox2.Items.Add("Java");
                comboBox2.Items.Add("Web Programming");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Machine Learing");
                comboBox2.Items.Add("Robotics");
                comboBox2.Items.Add("Computer Vision");
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.Form1_Data.ISBN;
            textBox2.Text = Form1.Form1_Data.Title;
            dateTimePicker1.Value = Form1.Form1_Data.purchasedon;
            comboBox1.SelectedIndex = Form1.Form1_Data.catIndex;
            comboBox2.SelectedIndex = Form1.Form1_Data.subcatIndex;
            string[] Author_List = Form1.Form1_Data.authors.Split(';');
            for (int x = 0; x < Author_List.Length; x++)
            {
                listBox1.Items.Add(Author_List[x].Trim());
            }
            if (Form1.Form1_Data.type == 0)
            {
                radioButton1.Select();
            }
            else if (Form1.Form1_Data.type == 1)
            {
                radioButton2.Select();
            }
            else if (Form1.Form1_Data.type == 2)
            {
                radioButton3.Select();
            }
            if (Form1.Form1_Data.isIssued == true)
            {
                checkBox1.Checked = true;
                textBox4.Text = Form1.Form1_Data.issuedTo;
                dateTimePicker2.Value = Form1.Form1_Data.issuedOn;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            listBox1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            button1.Enabled = false;
            checkBox1.Enabled = false;
            checkBox1.Checked = Form1.Form1_Data.isIssued;
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Enabled = true;
                dateTimePicker2.Enabled = true;
                textBox4.Text = Form1.Form1_Data.issuedTo;
                dateTimePicker2.Value = Form1.Form1_Data.issuedOn;
            }
            else
            {
                textBox4.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
