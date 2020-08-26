﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        List<Book> books = new List<Book>();

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this book?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            books.Add(new Book("0201144719 9780201144710", "An introduction to database systems", 1, 1, "C J Date", Convert.ToDateTime("1 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("0805301453 9780805301458", "Fundamentals of database systems", 1, 1, "Ramez Elmasri; Sham Navathe", Convert.ToDateTime("10 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("1571690867 9781571690869", "Object oriented programming in Java", 2, 2, "Stephen Gilbert; Bill McCarty", Convert.ToDateTime("15 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("1842652478 9781842652473", "Object oriented programming using C++", 2, 2, "B Chandra", Convert.ToDateTime("16 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("0070522618 9780070522619", "Artificial intelligence", 2, 2, "Elaine Rich", Convert.ToDateTime("20 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("0865760047 9780865760042", "The Handbook of artificial intelligence", 2, 2, "	Avron Barr; Edward A Feigenbaum; Paul R Cohen", Convert.ToDateTime("22 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015")));
            read();
        }

        private void read()
        {
            foreach (Book p in books)
            {
                ListViewItem item = new ListViewItem();
                item.Text = p.Title;
                item.SubItems.Add(p.ISBN);
                item.SubItems.Add(p.catIndex.ToString());
                item.SubItems.Add(p.subcatIndex.ToString());
                item.SubItems.Add(p.authors);
                item.SubItems.Add(p.purchasedon.ToString());
                item.SubItems.Add(p.type.ToString());
                item.SubItems.Add(p.isIssued.ToString());
                item.SubItems.Add(p.issuedTo);
                item.SubItems.Add(p.issuedOn.ToString());
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            
        }
    }



    public class Book
    {
        public string ISBN;
        public string Title;
        public int catIndex;
        public int subcatIndex;
        public string authors;
        public DateTime purchasedon;
        public int type;
        public bool isIssued;
        public string issuedTo;
        public DateTime issuedOn;

        public Book(string _ISBN, string _title, int _cat, int _subcat, string _authors, DateTime _purchasedOn, int _type, bool _isIssued, string _issuedTo, DateTime _issuedDate)
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

        }
    }
}
