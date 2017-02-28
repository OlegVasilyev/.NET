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
    public partial class NewToner : Form
    {
        public NewToner()
        {
            InitializeComponent();
        }
        public NewToner(bool Flag, string idtoner, string Model, string color, string ot_zap, string comment, string catrijID)
        {
            this.components = null;
            this.InitializeComponent();
            this.dal = new DAL();
            this.flag = Flag;
            this.id = idtoner;
            this.textBox1.Text = Model;
            this.textBox2.Text = color;
            this.textBox4.Text = ot_zap;
            this.textBox5.Text = comment;
            this.textBox8.Text = catrijID;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.flag)
            {
                if (this.dal.SaveToner(this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
                {
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.No;
                }
            }
            else if (this.dal.SaveEditToner(this.id, this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
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
