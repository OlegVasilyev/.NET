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
    partial class SaveDataBase
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
            this.textBox1 = new TextBox();
            this.label1 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            this.checkBox1 = new CheckBox();
            this.checkBox2 = new CheckBox();
            this.checkBox3 = new CheckBox();
            this.checkBox4 = new CheckBox();
            this.checkBox5 = new CheckBox();
            this.checkBox6 = new CheckBox();
            this.label2 = new Label();
            this.label3 = new Label();
            base.SuspendLayout();
            this.textBox1.Location = new Point(0xb7, 0x1f);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0xbc, 20);
            this.textBox1.TabIndex = 6;
            this.label1.AutoSize = true;
            this.label1.BackColor = SystemColors.AppWorkspace;
            this.label1.Font = new Font("Arial Black", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label1.Location = new Point(5, 0x20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0xac, 0x11);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите путь к файлу:";
            this.button1.Location = new Point(0x179, 30);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x25, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.Location = new Point(12, 0x9f);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x91, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBox1.Location = new Point(15, 0x58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(0x4c, 0x13);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Принтеры";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBox2.Location = new Point(15, 0x6f);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(0x4c, 0x13);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Катриджи";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBox3.Location = new Point(15, 0x86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new Size(0x40, 0x13);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Тонеры";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBox4.Location = new Point(0x62, 0x58);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new Size(0x44, 0x13);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Локации";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBox5.Location = new Point(0x62, 0x6f);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new Size(0x3e, 0x13);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Детали";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new Font("Impact", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBox6.Location = new Point(0x62, 0x86);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new Size(0x43, 0x13);
            this.checkBox6.TabIndex = 15;
            this.checkBox6.Text = "Покупки";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = SystemColors.AppWorkspace;
            this.label2.Font = new Font("Arial Black", 10f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label2.ForeColor = Color.Teal;
            this.label2.Location = new Point(4, 0x42);
            this.label2.Name = "label2";
            this.label2.Size = new Size(410, 0x13);
            this.label2.TabIndex = 0x10;
            this.label2.Text = "Укажите какие таблицы Вы хотите внести в файл:";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(0xca, 9);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x9d, 13);
            this.label3.TabIndex = 0x11;
            this.label3.Text = "Путь к файлу не обязателен. ";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(420, 210);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.checkBox6);
            base.Controls.Add(this.checkBox5);
            base.Controls.Add(this.checkBox4);
            base.Controls.Add(this.checkBox3);
            base.Controls.Add(this.checkBox2);
            base.Controls.Add(this.checkBox1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.textBox1);
            base.Name = "SaveDataBase";
            this.Text = "SaveDataBase";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        // Fields
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private DAL dal;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;

        #endregion
    }
}