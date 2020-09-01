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
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        List<int> Book_Search = new List<int>();
        public static Book Form1_Data;
        //String format = "{0, -10}{1, -60}{2, -60}";
        String format = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            books.Add(new Book("0201144719 9780201144710", "An introduction to database systems", 0, 1, "C J Date", Convert.ToDateTime("1 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015"), 0));
            books.Add(new Book("0805301453 9780805301458", "Fundamentals of database systems", 0, 1, "Ramez Elmasri; Sham Navathe", Convert.ToDateTime("10 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015"), 1));
            books.Add(new Book("1571690867 9781571690869", "Object oriented programming in Java", 1, 2, "Stephen Gilbert; Bill McCarty", Convert.ToDateTime("15 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015"), 2));
            books.Add(new Book("1842652478 9781842652473", "Object oriented programming using C++", 1, 2, "B Chandra", Convert.ToDateTime("16 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015"), 3));
            books.Add(new Book("0070522618 9780070522619", "Artificial intelligence", 2, 2, "Elaine Rich", Convert.ToDateTime("20 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015"), 4));
            books.Add(new Book("0865760047 9780865760042", "The Handbook of artificial intelligence", 2, 2, "	Avron Barr; Edward A Feigenbaum; Paul R Cohen", Convert.ToDateTime("22 jan 2015"), 2, true, "", Convert.ToDateTime("30 Nov 2015"), 5));
            read(books);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Book_Search.Clear();

            for (int x = 0; x < books.Count; x++)
            {
                if ((string.Compare(textBox1.Text, books[x].Title) == 0 || textBox1.TextLength == 0) && (comboBox1.SelectedIndex == books[x].catIndex || comboBox1.SelectedIndex == -1) && (checkBox1.Checked == books[x].isIssued))
                {
                    if (radioButton1.Checked && books[x].type == 0)
                    {
                        listBox1.Items.Add(books[x].Title);
                        Book_Search.Add(x);
                    }
                    else if (radioButton2.Checked && books[x].type == 1)
                    {
                        listBox1.Items.Add(books[x].Title);
                        Book_Search.Add(x);
                    }
                    else if (radioButton3.Checked && books[x].type == 2)
                    {
                        listBox1.Items.Add(books[x].Title);
                        Book_Search.Add(x);
                    }
                    else if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    {
                        listBox1.Items.Add(books[x].Title);
                        Book_Search.Add(x);
                    }
                }
            }
        }
        */

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this book?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Book_Search.Remove(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }




        private void read(List<Book> books)
        {
            foreach (Book p in books)
            {
                ListViewItem item = new ListViewItem();

                //String categoryName;
                if (p.catIndex == 0)
                {
                    p.catName = "Database Systems" + "\t\t";
                }
                else if (p.catIndex == 1)
                {
                    p.catName = "OOP" + "\t\t\t";
                }
                else if (p.catIndex == 2)
                {
                    p.catName = "Artificial Intelligence" + "\t\t";
                }
                format = p.ISBN + "\t\t" + p.catName + p.Title;
                listBox1.Items.Add(String.Format(format));
                //listBox1.Items.Add(item);
            }
        }


        /*
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        */

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
  
                //Form1_Data = books[Book_Search[listBox1.SelectedIndex]];
                Form1_Data = books[listBox1.SelectedIndex];
                Form2 View_Form = new Form2();
                View_Form.Show();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cat = comboBox1.SelectedIndex;
            bool check = checkBox1.Checked;
            int type;
            if (radioButton1.Checked)
            {
                type = 0;
            }

            else if (radioButton2.Checked)
            {
                type = 1;
            }

            else
            {
                type = 2;
            }

            string title = textBox1.Text;
            List<Book> Book_Search = new List<Book>();
            foreach (Book p in books)
            {

            }
            read(books);
            
        }
    }



    public class Book
    {
        public string ISBN;
        public string Title;
        public int catIndex;
        public String catName;
        public int subcatIndex;
        public string authors;
        public DateTime purchasedon;
        public int type;
        public bool isIssued;
        public string issuedTo;
        public DateTime issuedOn;
        public int original_index;

        public Book(string _ISBN, string _title, int _cat, int _subcat, string _authors, DateTime _purchasedOn, int _type, bool _isIssued, string _issuedTo, DateTime _issuedDate, int _original_index)
        {
            ISBN = _ISBN;
            Title = _title;
            catIndex = _cat;
            subcatIndex = _subcat;
            authors = _authors;
            purchasedon = _purchasedOn;
            type = _type;
            isIssued = _isIssued;
            issuedTo = _issuedTo;
            issuedOn = _issuedDate;
            original_index = _original_index;

        }
    }
}
