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
    public partial class NewCatrij : Form
        {
            public NewCatrij()
            {
                this.components = null;
                this.InitializeComponent();
                this.dal = new DAL();
            }
            public NewCatrij(bool Flag, string idcatrij, string Model, string color, string type, string Status, string ot_str, string comment, string printI)
            {
                this.components = null;
                this.InitializeComponent();
                this.dal = new DAL();
                this.id = idcatrij;
                this.flag = Flag;
                this.textBox1.Text = Model;
                this.textBox6.Text = color;
                this.textBox7.Text = type;
                this.textBox2.Text = Status;
                this.textBox4.Text = ot_str;
                this.textBox5.Text = comment;
                this.textBox8.Text = printI;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    MainForm.index = Convert.ToInt32(this.textBox8.Text.Trim());
                }
                catch
                {
                }
                if (!this.flag)
                {
                    if (this.dal.SaveCatrij(this.textBox1.Text.Trim(), this.textBox6.Text.Trim(), this.textBox7.Text.Trim(), this.textBox2.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
                    {
                        base.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        base.DialogResult = DialogResult.No;
                    }
                }
                else if (this.dal.SaveEditCatrij(this.id, this.textBox1.Text.Trim(), this.textBox6.Text.Trim(), this.textBox7.Text.Trim(), this.textBox2.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim(), this.textBox8.Text.Trim()))
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