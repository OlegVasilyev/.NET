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
    public partial class NewLocale : Form
    {
        public NewLocale()
        {
            this.components = null;
            this.InitializeComponent();
            this.dal = new DAL();
        }
        public NewLocale(bool Flag, string id, string locale, string vladel, string comment, string prnterID)
        {
            this.components = null;
            this.InitializeComponent();
            this.dal = new DAL();
            this.textBox1.Text = locale;
            this.textBox2.Text = vladel;
            this.textBox5.Text = comment;
            this.textBox8.Text = prnterID;
            this.flag = Flag;
            this.idLocale = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.flag)
            {
                if (this.dal.SaveLocale(this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
                {
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.No;
                }
            }
            else if (this.dal.SaveEditLocale(this.idLocale, this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
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
