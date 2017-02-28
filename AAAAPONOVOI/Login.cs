using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AAAAPONOVOI
{
    public partial class Login : Form
    {
        public string ConnectionParam { get; private set; }
        public Login()
        {
            InitializeComponent();
            textBox5.Text = "Data Source=; Initial Catalog=; uid=; pwd=;";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.Text = String.Format("Data Source={0}; Initial Catalog={1}; Integrated Security=True", textBox1.Text.Trim(), textBox2.Text.Trim());

            }
            else
                textBox5.Text = String.Format("Data Source={0}; Initial Catalog={1}; uid={2}; pwd={3}; ", textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.Text = String.Format("Data Source={0}; Initial Catalog={1}; Integrated Security=True", textBox1.Text.Trim(), textBox2.Text.Trim());
                textBox4.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog window = new OpenFileDialog();
            window.FileName = String.Empty;
            window.Filter = "File XML (.xml) |*.xml| All Files (*.*)|*.*";
            if (window.ShowDialog() == DialogResult.OK)
                textBox6.Text = window.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.ConnectionParam = this.textBox6.Text.Trim();
               
            }
            else
            {
                if (textBox1.Text.Trim().Length == 0 && textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Укажите корректные параметры!", "Error");
                    return;
                }
                if (!checkBox1.Checked)
                    if (textBox3.Text.Trim().Length == 0 || textBox4.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Задайте корректный лоин и пароль!", "Error");

                    }
                ConnectionParam = textBox5.Text.Trim();
  
                DialogResult = DialogResult.OK;
            }
        }
    }
}
