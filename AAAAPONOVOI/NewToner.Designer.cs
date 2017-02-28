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
    partial class NewToner
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
            this.label6 = new Label();
            this.label13 = new Label();
            this.label4 = new Label();
            this.textBox8 = new TextBox();
            this.label8 = new Label();
            this.label2 = new Label();
            this.textBox5 = new TextBox();
            this.textBox1 = new TextBox();
            this.textBox4 = new TextBox();
            this.label3 = new Label();
            this.textBox2 = new TextBox();
            this.label5 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.button1.Location = new Point(0x3a, 0x9e);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x94, 0x1f);
            this.button1.TabIndex = 0x10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(250, 0x8f);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            this.label6.AutoSize = true;
            this.label6.ForeColor = Color.Red;
            this.label6.Location = new Point(0xeb, 0x73);
            this.label6.Name = "label6";
            this.label6.Size = new Size(11, 13);
            this.label6.TabIndex = 0x17;
            this.label6.Text = "*";
            this.label13.AutoSize = true;
            this.label13.ForeColor = Color.Red;
            this.label13.Location = new Point(0xeb, 0x43);
            this.label13.Name = "label13";
            this.label13.Size = new Size(11, 13);
            this.label13.TabIndex = 0x16;
            this.label13.Text = "*";
            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.Red;
            this.label4.Location = new Point(0xeb, 14);
            this.label4.Name = "label4";
            this.label4.Size = new Size(11, 13);
            this.label4.TabIndex = 0x11;
            this.label4.Text = "*";
            this.textBox8.Location = new Point(0x81, 0x74);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(100, 20);
            this.textBox8.TabIndex = 0x10;
            this.label8.AutoSize = true;
            this.label8.Location = new Point(0x3a, 0x77);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Катридж№:";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x4a, 14);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модель:";
            this.textBox5.Location = new Point(0x81, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(100, 20);
            this.textBox5.TabIndex = 10;
            this.textBox1.Location = new Point(0x81, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox4.Location = new Point(0x81, 0x40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(0x58, 0x29);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цвет:";
            this.textBox2.Location = new Point(0x81, 0x26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(0x2b, 0x5d);
            this.label5.Name = "label5";
            this.label5.Size = new Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Комментарий:";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(3, 0x43);
            this.label1.Name = "label1";
            this.label1.Size = new Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество заправок:";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x11c, 0xc6);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.groupBox1);
            base.Name = "NewToner";
            this.Text = "Toner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }
        // Fields
        private Button button1;
        private DAL dal;
        private bool flag;
        private GroupBox groupBox1;
        private string id;
        private Label label1;
        private Label label13;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox8;
        #endregion
    }
}