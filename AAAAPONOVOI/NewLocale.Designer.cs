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
    partial class NewLocale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.groupBox1 = new GroupBox();
            this.label7 = new Label();
            this.label6 = new Label();
            this.label4 = new Label();
            this.textBox8 = new TextBox();
            this.label8 = new Label();
            this.label2 = new Label();
            this.textBox5 = new TextBox();
            this.textBox1 = new TextBox();
            this.label3 = new Label();
            this.textBox2 = new TextBox();
            this.label5 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.button1.Location = new Point(0x3a, 0x8d);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x94, 0x1f);
            this.button1.TabIndex = 0x12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(250, 0x7b);
            this.groupBox1.TabIndex = 0x11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            this.label7.AutoSize = true;
            this.label7.ForeColor = Color.Red;
            this.label7.Location = new Point(0xe9, 0x29);
            this.label7.Name = "label7";
            this.label7.Size = new Size(11, 13);
            this.label7.TabIndex = 0x18;
            this.label7.Text = "*";
            this.label6.AutoSize = true;
            this.label6.ForeColor = Color.Red;
            this.label6.Location = new Point(0xe9, 0x5d);
            this.label6.Name = "label6";
            this.label6.Size = new Size(11, 13);
            this.label6.TabIndex = 0x17;
            this.label6.Text = "*";
            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.Red;
            this.label4.Location = new Point(0xe9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new Size(11, 13);
            this.label4.TabIndex = 0x11;
            this.label4.Text = "*";
            this.textBox8.Location = new Point(0x81, 90);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(100, 20);
            this.textBox8.TabIndex = 0x10;
            this.label8.AutoSize = true;
            this.label8.Location = new Point(0x3a, 0x5d);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Принтер№:";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x2b, 14);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Расположение:";
            this.textBox5.Location = new Point(0x81, 0x40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(100, 20);
            this.textBox5.TabIndex = 10;
            this.textBox1.Location = new Point(0x81, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(0x40, 0x29);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x3b, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Владелец:";
            this.textBox2.Location = new Point(0x81, 0x26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(0x2b, 0x43);
            this.label5.Name = "label5";
            this.label5.Size = new Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Комментарий:";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x115, 0xb8);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.groupBox1);
            base.Name = "NewLocale";
            this.Text = "NewLocale";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }
        private Button button1;
        private DAL dal;
        private bool flag;
        private GroupBox groupBox1;
        private string idLocale;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox8;
        #endregion
    }
}