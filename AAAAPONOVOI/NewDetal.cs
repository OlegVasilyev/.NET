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
    public partial class NewDetal : Form
    {
        private DAL dal;
        private bool flag;
        private string iddetal;
        public NewDetal()
        {
            this.components = null;
            this.InitializeComponent();
            this.dal = new DAL();
        }
        public NewDetal(bool fflag, string id, string bar, string drum, string photobar, string comment, string catrijID)
        {
            this.components = null;
            this.InitializeComponent();
            this.dal = new DAL();
            this.iddetal = id;
            this.flag = fflag;
            this.textBox1.Text = bar;
            this.textBox2.Text = drum;
            this.textBox4.Text = photobar;
            this.textBox5.Text = comment;
            this.textBox8.Text = catrijID;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.flag)
            {
                if (this.dal.SaveDetal(this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
                {
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.No;
                }
            }
            else if (this.dal.SaveEditDetal(this.iddetal, this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
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
