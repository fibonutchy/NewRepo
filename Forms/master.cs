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
    public partial class master : Form
    {
        List<clmaster>Lstmaster;
        public master()
        {
            InitializeComponent();
            Lstmaster = new List<clmaster>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void letter(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clmaster mst = new clmaster();
                mst.FName = textBox1.Text;
                mst.LName = textBox2.Text;
                mst.FatherName = textBox3.Text;
                mst.Meli = Convert.ToInt64(textBox4.Text);
                mst.Grade = comboBox1.SelectedItem.ToString();
                mst.Gender = radioButton1.Checked;
                mst.IsMarrid = checkBox1.Checked;
                mst.pers = Convert.ToInt64(maskedTextBox1.Text);
                mst.date = Convert.ToInt32(maskedTextBox2.Text);
                Lstmaster.Add(mst);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = Lstmaster.ToList();
            }
            catch {

                DialogResult result = MessageBox.Show("شما هنوز فیلد های مورد نظر را پر نکرده اید!آیا می خواهید از برنامه خارج شوید ؟ ", "warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    Application.Exit();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
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

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private TextBox GetTextBox4()
        {
            return textBox4;
        }

        private void textBox4_TextChanged(object sender, EventArgs e, TextBox textBox4)
        {
             string a = textBox4.Text;
            if (a.Length==10)
            {
                return;
            }
            else
            {

                DialogResult result = MessageBox.Show("تعداد اعداد در فیلد کد ملی بیشتر از 10 رقم است آیا می خواهید ویرایش کنید؟ ", "warning", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void master_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        //private void textBox4_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (textBox4.Text.Length == 10)
        //    {
        //        textBox4.Enabled = true;
        //    }
        //    else
        //    {
        //        textBox4.Enabled = false;
        //    }
        //}
    }
}

    