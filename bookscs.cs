using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace uni2
{
    public partial class bookscs : Form
    {
        List<clbookscscs> Lstbooks;
        public bookscs()
        {
            InitializeComponent();
            Lstbooks = new List<clbookscscs>();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void leter(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clbookscscs bcs = new clbookscscs(); 
            bcs.Name = textBox1.Text;
            bcs.Reshte = textBox2.Text;
            bcs.Code =Convert.ToInt16 (textBox4.Text);
            bcs.Topic = comboBox1.SelectedItem.ToString();
            bcs.Vahed = comboBox2.SelectedItem.ToString();


            Lstbooks.Add(bcs);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Lstbooks.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control allcontrol in Controls)
            {
                if (allcontrol is System.Windows.Forms.TextBox)
                    ((System.Windows.Forms.TextBox)allcontrol).Clear();
                else if (allcontrol is MaskedTextBox)
                    ((MaskedTextBox)allcontrol).Clear();

            }
        }
    }
}
