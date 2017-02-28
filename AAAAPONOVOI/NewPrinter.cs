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
    public partial class NewPrinter : Form
    {
        public NewPrinter()
        {
            this.components = null;
            this.InitializeComponent();
            this.dal = new DAL();
        }
        public NewPrinter(bool Flag, string id, string Model, string Status, string data, string ot_str, string comment)
        {
            this.components = null;
            this.InitializeComponent();
            this.buttonFlag = Flag;
            this.idPrinter = id;
            this.textBox1.Text = Model;
            this.textBox2.Text = Status;
            this.textBox3.Text = data;
            this.textBox4.Text = ot_str;
            this.textBox5.Text = comment;
            this.dal = new DAL();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.buttonFlag)
            {
                if (this.dal.SavePrinter(this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox3.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim()))
                {
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.No;
                }
            }
            else if (this.dal.SaveEditPrinter(this.idPrinter, this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox3.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim()))
            {
                base.DialogResult = DialogResult.OK;
            }
            else
            {
                base.DialogResult = DialogResult.No;
            }
        }
    
    }
}
