using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni2.Forms
{
    public partial class student : Form
    {
        List<ClsStudent> LstStudent;
        public student()
        {
            InitializeComponent();
            LstStudent=new List<ClsStudent>();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        

        private void KeyPress_letter(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsStudent std=new ClsStudent(); //create a object
            std.FName = textBox1.Text;
            std.LName = textBox2.Text;
            std.FatherName= textBox3.Text;
            std.ID = Convert.ToInt64(textBox4.Text);
            std.Grade=comboBox1.SelectedItem.ToString();
            std.Gender = radioButton1.Checked;
            std.IsMarrid = checkBox1.Checked;
            std.year= Convert.ToInt32(maskedTextBox1.Text);

            LstStudent.Add(std);

            dataGridView1.AutoGenerateColumns=false;
            dataGridView1.DataSource=LstStudent.ToList();



        }

        private void button3_Click(object sender, EventArgs e)
        {
    
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control allcontrol in Controls)
            {
                if (allcontrol is TextBox)
                    ((TextBox)allcontrol).Clear();
                else if (allcontrol is MaskedTextBox)
                    ((MaskedTextBox)allcontrol).Clear();

            }
        }
    }
}
