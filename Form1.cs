using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uni2.Forms;

namespace uni2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void دانشجویانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student sform=new student();
            sform.Show();
           
            //MessageBox.Show("Hello!");
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void اساتیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
           master master=new master();
            master.Show();
           
        }

        private void دروسToolStripMenuItem_Click(object sender, EventArgs e)
        {
           bookscs bookscs = new bookscs();
            bookscs.Show();

        }
    }
}
