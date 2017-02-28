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
    public partial class SaveDataBase : Form
    {
        public SaveDataBase()
        {
            this.components = null;
            this.InitializeComponent();
            this.dal = new DAL();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = dialog.Filter = "Text files(*.csv)|*.csv|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = dialog.FileName;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.dal.SaveInFilePrinter(this.textBox1.Text);
                MessageBox.Show("Записано!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (this.checkBox2.Checked)
            {
                this.dal.SaveInFileCatrij(this.textBox1.Text);
                MessageBox.Show("Записано!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (this.checkBox3.Checked)
            {
                this.dal.SaveInFileToner(this.textBox1.Text);
                MessageBox.Show("Записано!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (this.checkBox4.Checked)
            {
                this.dal.SaveInFileLocale(this.textBox1.Text);
                MessageBox.Show("Записано!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (this.checkBox5.Checked)
            {
                this.dal.SaveInFileDetal(this.textBox1.Text);
                MessageBox.Show("Записано!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (this.checkBox6.Checked)
            {
                this.dal.SaveInFileShop(this.textBox1.Text);
                MessageBox.Show("Записано!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

    }
}
