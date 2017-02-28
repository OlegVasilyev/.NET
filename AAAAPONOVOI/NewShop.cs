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
    public partial class NewShop : Form
    {
        public NewShop()
        {
            this.components = null;
            this.InitializeComponent();
            this.dal = new DAL();
        }
        public NewShop(bool Flag, string idshop, string name, string price, string date, string site, string comment, string tonerID)
        {
            this.components = null;
            this.InitializeComponent();
            this.dal = new DAL();
            this.id = idshop;
            this.flag = Flag;
            this.textBox1.Text = name;
            this.textBox2.Text = site;
            this.textBox5.Text = comment;
            this.textBox6.Text = price;
            this.textBox7.Text = date;
            this.textBox8.Text = tonerID;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.flag)
            {
                if (this.dal.SaveShop(this.textBox1.Text.Trim(), this.textBox6.Text.Trim(), this.textBox7.Text.Trim(), this.textBox2.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
                {
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.No;
                }
            }
            else if (this.dal.SaveEditShop(this.id, this.textBox1.Text.Trim(), this.textBox6.Text.Trim(), this.textBox7.Text.Trim(), this.textBox2.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
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
