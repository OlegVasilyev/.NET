using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace AAAAPONOVOI
{
    partial class MainForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrinterDGW = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатриджToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЛокациюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CatrijDGW = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТонерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДетальToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TonerDGW = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.заправитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПокупкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LocaleDGW = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DetalDGW = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ShopDGW = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.приложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.базуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распечататьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключенныеПринтерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущеюСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.принтерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПринтерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.катриджиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатриджToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тонерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТонерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.локацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЛокациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДетальToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПокупкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterDGW)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatrijDGW)).BeginInit();
            this.contextMenuStrip6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TonerDGW)).BeginInit();
            this.contextMenuStrip5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocaleDGW)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalDGW)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDGW)).BeginInit();
            this.contextMenuStrip4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrinterDGW);
            this.groupBox1.Location = new System.Drawing.Point(24, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Принтеры";
            // 
            // PrinterDGW
            // 
            this.PrinterDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrinterDGW.ContextMenuStrip = this.contextMenuStrip1;
            this.PrinterDGW.Location = new System.Drawing.Point(3, 16);
            this.PrinterDGW.Name = "PrinterDGW";
            this.PrinterDGW.Size = new System.Drawing.Size(637, 181);
            this.PrinterDGW.TabIndex = 0;
            this.PrinterDGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrinterDGW_CellDoubleClick);
            this.PrinterDGW.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrinterDGW_CellMouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.удалитьToolStripMenuItem1,
            this.добавитьКатриджToolStripMenuItem1,
            this.добавитьЛокациюToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 92);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.удалитьToolStripMenuItem.Text = "Редактировать";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // добавитьКатриджToolStripMenuItem1
            // 
            this.добавитьКатриджToolStripMenuItem1.Name = "добавитьКатриджToolStripMenuItem1";
            this.добавитьКатриджToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.добавитьКатриджToolStripMenuItem1.Text = "Добавить катридж";
            this.добавитьКатриджToolStripMenuItem1.Click += new System.EventHandler(this.добавитьКатриджToolStripMenuItem1_Click);
            // 
            // добавитьЛокациюToolStripMenuItem1
            // 
            this.добавитьЛокациюToolStripMenuItem1.Name = "добавитьЛокациюToolStripMenuItem1";
            this.добавитьЛокациюToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.добавитьЛокациюToolStripMenuItem1.Text = "Добавить локацию";
            this.добавитьЛокациюToolStripMenuItem1.Click += new System.EventHandler(this.добавитьЛокациюToolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CatrijDGW);
            this.groupBox2.Location = new System.Drawing.Point(27, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Катриджи принтера";
            // 
            // CatrijDGW
            // 
            this.CatrijDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatrijDGW.ContextMenuStrip = this.contextMenuStrip6;
            this.CatrijDGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatrijDGW.Location = new System.Drawing.Point(3, 16);
            this.CatrijDGW.Name = "CatrijDGW";
            this.CatrijDGW.Size = new System.Drawing.Size(637, 181);
            this.CatrijDGW.TabIndex = 0;
            this.CatrijDGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatrijDGW_CellDoubleClick);
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem4,
            this.удалитьToolStripMenuItem6,
            this.добавитьТонерToolStripMenuItem1,
            this.добавитьДетальToolStripMenuItem1});
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(166, 92);
            // 
            // редактироватьToolStripMenuItem4
            // 
            this.редактироватьToolStripMenuItem4.Name = "редактироватьToolStripMenuItem4";
            this.редактироватьToolStripMenuItem4.Size = new System.Drawing.Size(165, 22);
            this.редактироватьToolStripMenuItem4.Text = "Редактировать";
            this.редактироватьToolStripMenuItem4.Click += new System.EventHandler(this.редактироватьToolStripMenuItem4_Click);
            // 
            // удалитьToolStripMenuItem6
            // 
            this.удалитьToolStripMenuItem6.Name = "удалитьToolStripMenuItem6";
            this.удалитьToolStripMenuItem6.Size = new System.Drawing.Size(165, 22);
            this.удалитьToolStripMenuItem6.Text = "Удалить";
            this.удалитьToolStripMenuItem6.Click += new System.EventHandler(this.удалитьToolStripMenuItem6_Click);
            // 
            // добавитьТонерToolStripMenuItem1
            // 
            this.добавитьТонерToolStripMenuItem1.Name = "добавитьТонерToolStripMenuItem1";
            this.добавитьТонерToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.добавитьТонерToolStripMenuItem1.Text = "Добавить тонер";
            this.добавитьТонерToolStripMenuItem1.Click += new System.EventHandler(this.добавитьТонерToolStripMenuItem1_Click);
            // 
            // добавитьДетальToolStripMenuItem1
            // 
            this.добавитьДетальToolStripMenuItem1.Name = "добавитьДетальToolStripMenuItem1";
            this.добавитьДетальToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.добавитьДетальToolStripMenuItem1.Text = "Добавить деталь";
            this.добавитьДетальToolStripMenuItem1.Click += new System.EventHandler(this.добавитьДетальToolStripMenuItem1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TonerDGW);
            this.groupBox3.Location = new System.Drawing.Point(30, 536);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тонеры катриджа";
            // 
            // TonerDGW
            // 
            this.TonerDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TonerDGW.ContextMenuStrip = this.contextMenuStrip5;
            this.TonerDGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TonerDGW.Location = new System.Drawing.Point(3, 16);
            this.TonerDGW.Name = "TonerDGW";
            this.TonerDGW.Size = new System.Drawing.Size(634, 181);
            this.TonerDGW.TabIndex = 0;
            this.TonerDGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TonerDGW_CellDoubleClick);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem3,
            this.удалитьToolStripMenuItem5,
            this.заправитьToolStripMenuItem,
            this.добавитьПокупкуToolStripMenuItem1});
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(175, 92);
            // 
            // редактироватьToolStripMenuItem3
            // 
            this.редактироватьToolStripMenuItem3.Name = "редактироватьToolStripMenuItem3";
            this.редактироватьToolStripMenuItem3.Size = new System.Drawing.Size(174, 22);
            this.редактироватьToolStripMenuItem3.Text = "Редактировать";
            this.редактироватьToolStripMenuItem3.Click += new System.EventHandler(this.редактироватьToolStripMenuItem3_Click);
            // 
            // удалитьToolStripMenuItem5
            // 
            this.удалитьToolStripMenuItem5.Name = "удалитьToolStripMenuItem5";
            this.удалитьToolStripMenuItem5.Size = new System.Drawing.Size(174, 22);
            this.удалитьToolStripMenuItem5.Text = "Удалить";
            this.удалитьToolStripMenuItem5.Click += new System.EventHandler(this.удалитьToolStripMenuItem5_Click);
            // 
            // заправитьToolStripMenuItem
            // 
            this.заправитьToolStripMenuItem.Name = "заправитьToolStripMenuItem";
            this.заправитьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.заправитьToolStripMenuItem.Text = "Заправить";
            this.заправитьToolStripMenuItem.Click += new System.EventHandler(this.заправитьToolStripMenuItem_Click);
            // 
            // добавитьПокупкуToolStripMenuItem1
            // 
            this.добавитьПокупкуToolStripMenuItem1.Name = "добавитьПокупкуToolStripMenuItem1";
            this.добавитьПокупкуToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.добавитьПокупкуToolStripMenuItem1.Text = "Добавить покупку";
            this.добавитьПокупкуToolStripMenuItem1.Click += new System.EventHandler(this.добавитьПокупкуToolStripMenuItem1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LocaleDGW);
            this.groupBox4.Location = new System.Drawing.Point(673, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 200);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Локация принтера";
            // 
            // LocaleDGW
            // 
            this.LocaleDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocaleDGW.ContextMenuStrip = this.contextMenuStrip2;
            this.LocaleDGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocaleDGW.Location = new System.Drawing.Point(3, 16);
            this.LocaleDGW.Name = "LocaleDGW";
            this.LocaleDGW.Size = new System.Drawing.Size(526, 181);
            this.LocaleDGW.TabIndex = 0;
            this.LocaleDGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LocaleDGW_CellDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(155, 48);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DetalDGW);
            this.groupBox5.Location = new System.Drawing.Point(673, 333);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(529, 200);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Детали катриджа";
            // 
            // DetalDGW
            // 
            this.DetalDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalDGW.ContextMenuStrip = this.contextMenuStrip3;
            this.DetalDGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetalDGW.Location = new System.Drawing.Point(3, 16);
            this.DetalDGW.Name = "DetalDGW";
            this.DetalDGW.Size = new System.Drawing.Size(523, 181);
            this.DetalDGW.TabIndex = 0;
            this.DetalDGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalDGW_CellDoubleClick);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem1,
            this.удалитьToolStripMenuItem3});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(155, 48);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem3
            // 
            this.удалитьToolStripMenuItem3.Name = "удалитьToolStripMenuItem3";
            this.удалитьToolStripMenuItem3.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem3.Text = "Удалить";
            this.удалитьToolStripMenuItem3.Click += new System.EventHandler(this.удалитьToolStripMenuItem3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ShopDGW);
            this.groupBox6.Location = new System.Drawing.Point(673, 539);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(529, 197);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Покупка";
            // 
            // ShopDGW
            // 
            this.ShopDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopDGW.ContextMenuStrip = this.contextMenuStrip4;
            this.ShopDGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShopDGW.Location = new System.Drawing.Point(3, 16);
            this.ShopDGW.Name = "ShopDGW";
            this.ShopDGW.Size = new System.Drawing.Size(523, 178);
            this.ShopDGW.TabIndex = 0;
            this.ShopDGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShopDGW_CellDoubleClick);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem2,
            this.удалитьToolStripMenuItem4});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(155, 48);
            // 
            // редактироватьToolStripMenuItem2
            // 
            this.редактироватьToolStripMenuItem2.Name = "редактироватьToolStripMenuItem2";
            this.редактироватьToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem2.Text = "Редактировать";
            this.редактироватьToolStripMenuItem2.Click += new System.EventHandler(this.редактироватьToolStripMenuItem2_Click);
            // 
            // удалитьToolStripMenuItem4
            // 
            this.удалитьToolStripMenuItem4.Name = "удалитьToolStripMenuItem4";
            this.удалитьToolStripMenuItem4.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem4.Text = "Удалить";
            this.удалитьToolStripMenuItem4.Click += new System.EventHandler(this.удалитьToolStripMenuItem4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приложениеToolStripMenuItem,
            this.принтерыToolStripMenuItem,
            this.катриджиToolStripMenuItem,
            this.тонерыToolStripMenuItem,
            this.локацииToolStripMenuItem,
            this.деталиToolStripMenuItem,
            this.покупкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // приложениеToolStripMenuItem
            // 
            this.приложениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.закрытьToolStripMenuItem1,
            this.распечататьToolStripMenuItem,
            this.подключенныеПринтерыToolStripMenuItem,
            this.удалитьТекущеюСтрокуToolStripMenuItem});
            this.приложениеToolStripMenuItem.Name = "приложениеToolStripMenuItem";
            this.приложениеToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.приложениеToolStripMenuItem.Text = "Приложение";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.закрытьToolStripMenuItem.Text = "Сохранить";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click_1);
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базуДанныхToolStripMenuItem,
            this.таблицуToolStripMenuItem});
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.закрытьToolStripMenuItem1.Text = "Распечатать";
            // 
            // базуДанныхToolStripMenuItem
            // 
            this.базуДанныхToolStripMenuItem.Name = "базуДанныхToolStripMenuItem";
            this.базуДанныхToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.базуДанныхToolStripMenuItem.Text = "Базу данных";
            this.базуДанныхToolStripMenuItem.Click += new System.EventHandler(this.базуДанныхToolStripMenuItem_Click);
            // 
            // таблицуToolStripMenuItem
            // 
            this.таблицуToolStripMenuItem.Name = "таблицуToolStripMenuItem";
            this.таблицуToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.таблицуToolStripMenuItem.Text = "Таблицу";
            // 
            // распечататьToolStripMenuItem
            // 
            this.распечататьToolStripMenuItem.Name = "распечататьToolStripMenuItem";
            this.распечататьToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.распечататьToolStripMenuItem.Text = "Закрыть";
            this.распечататьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // подключенныеПринтерыToolStripMenuItem
            // 
            this.подключенныеПринтерыToolStripMenuItem.Name = "подключенныеПринтерыToolStripMenuItem";
            this.подключенныеПринтерыToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.подключенныеПринтерыToolStripMenuItem.Text = "Подключенные принтеры";
            this.подключенныеПринтерыToolStripMenuItem.Click += new System.EventHandler(this.подключенныеПринтерыToolStripMenuItem_Click);
            // 
            // удалитьТекущеюСтрокуToolStripMenuItem
            // 
            this.удалитьТекущеюСтрокуToolStripMenuItem.Name = "удалитьТекущеюСтрокуToolStripMenuItem";
            this.удалитьТекущеюСтрокуToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.удалитьТекущеюСтрокуToolStripMenuItem.Text = "Подключить источнык данных";
            this.удалитьТекущеюСтрокуToolStripMenuItem.Click += new System.EventHandler(this.удалитьТекущеюСтрокуToolStripMenuItem_Click);
            // 
            // принтерыToolStripMenuItem
            // 
            this.принтерыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПринтерToolStripMenuItem});
            this.принтерыToolStripMenuItem.Name = "принтерыToolStripMenuItem";
            this.принтерыToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.принтерыToolStripMenuItem.Text = "Принтеры";
            // 
            // добавитьПринтерToolStripMenuItem
            // 
            this.добавитьПринтерToolStripMenuItem.Name = "добавитьПринтерToolStripMenuItem";
            this.добавитьПринтерToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.добавитьПринтерToolStripMenuItem.Text = "Добавить принтер";
            this.добавитьПринтерToolStripMenuItem.Click += new System.EventHandler(this.добавитьПринтерToolStripMenuItem_Click);
            // 
            // катриджиToolStripMenuItem
            // 
            this.катриджиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатриджToolStripMenuItem,
            this.заправкаToolStripMenuItem});
            this.катриджиToolStripMenuItem.Name = "катриджиToolStripMenuItem";
            this.катриджиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.катриджиToolStripMenuItem.Text = "Катриджи";
            // 
            // добавитьКатриджToolStripMenuItem
            // 
            this.добавитьКатриджToolStripMenuItem.Name = "добавитьКатриджToolStripMenuItem";
            this.добавитьКатриджToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.добавитьКатриджToolStripMenuItem.Text = "Добавить катридж";
            this.добавитьКатриджToolStripMenuItem.Click += new System.EventHandler(this.добавитьКатриджToolStripMenuItem_Click);
            // 
            // заправкаToolStripMenuItem
            // 
            this.заправкаToolStripMenuItem.Name = "заправкаToolStripMenuItem";
            this.заправкаToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.заправкаToolStripMenuItem.Text = "Заправка";
            this.заправкаToolStripMenuItem.Click += new System.EventHandler(this.заправкаToolStripMenuItem_Click);
            // 
            // тонерыToolStripMenuItem
            // 
            this.тонерыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТонерToolStripMenuItem});
            this.тонерыToolStripMenuItem.Name = "тонерыToolStripMenuItem";
            this.тонерыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.тонерыToolStripMenuItem.Text = "Тонеры";
            // 
            // добавитьТонерToolStripMenuItem
            // 
            this.добавитьТонерToolStripMenuItem.Name = "добавитьТонерToolStripMenuItem";
            this.добавитьТонерToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.добавитьТонерToolStripMenuItem.Text = "Добавить тонер";
            this.добавитьТонерToolStripMenuItem.Click += new System.EventHandler(this.добавитьТонерToolStripMenuItem_Click);
            // 
            // локацииToolStripMenuItem
            // 
            this.локацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЛокациюToolStripMenuItem});
            this.локацииToolStripMenuItem.Name = "локацииToolStripMenuItem";
            this.локацииToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.локацииToolStripMenuItem.Text = "Локации";
            // 
            // добавитьЛокациюToolStripMenuItem
            // 
            this.добавитьЛокациюToolStripMenuItem.Name = "добавитьЛокациюToolStripMenuItem";
            this.добавитьЛокациюToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.добавитьЛокациюToolStripMenuItem.Text = "Добавить локацию";
            this.добавитьЛокациюToolStripMenuItem.Click += new System.EventHandler(this.добавитьЛокациюToolStripMenuItem_Click);
            // 
            // деталиToolStripMenuItem
            // 
            this.деталиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьДетальToolStripMenuItem});
            this.деталиToolStripMenuItem.Name = "деталиToolStripMenuItem";
            this.деталиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.деталиToolStripMenuItem.Text = "Детали";
            // 
            // добавитьДетальToolStripMenuItem
            // 
            this.добавитьДетальToolStripMenuItem.Name = "добавитьДетальToolStripMenuItem";
            this.добавитьДетальToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.добавитьДетальToolStripMenuItem.Text = "Добавить деталь";
            this.добавитьДетальToolStripMenuItem.Click += new System.EventHandler(this.добавитьДетальToolStripMenuItem_Click);
            // 
            // покупкиToolStripMenuItem
            // 
            this.покупкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПокупкуToolStripMenuItem});
            this.покупкиToolStripMenuItem.Name = "покупкиToolStripMenuItem";
            this.покупкиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.покупкиToolStripMenuItem.Text = "Покупки";
            // 
            // добавитьПокупкуToolStripMenuItem
            // 
            this.добавитьПокупкуToolStripMenuItem.Name = "добавитьПокупкуToolStripMenuItem";
            this.добавитьПокупкуToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.добавитьПокупкуToolStripMenuItem.Text = "Добавить покупку";
            this.добавитьПокупкуToolStripMenuItem.Click += new System.EventHandler(this.добавитьПокупкуToolStripMenuItem_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.comboBox2);
            this.groupBox7.Controls.Add(this.checkBox2);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Location = new System.Drawing.Point(21, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(643, 94);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поиск";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(565, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "столбец:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(218, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(468, 30);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Искать в БД";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "текст:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(673, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(365, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Отобразить тонеры с заканчивающейся заправкой в базе данных";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(673, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(330, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Отобразить тонеры с заканчивающейся заправкой в гриде";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(673, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Статус:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(743, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Просмотр";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 742);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrinterDGW)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatrijDGW)).EndInit();
            this.contextMenuStrip6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TonerDGW)).EndInit();
            this.contextMenuStrip5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LocaleDGW)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalDGW)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShopDGW)).EndInit();
            this.contextMenuStrip4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button button2;
        private DataGridView CatrijDGW;
        private DataGridViewCellEventArgs cellMouseEnter;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ContextMenuStrip contextMenuStrip4;
        private ContextMenuStrip contextMenuStrip5;
        private ContextMenuStrip contextMenuStrip6;
        private int currendRow;
        private DataGridView DetalDGW;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView LocaleDGW;
        private MenuStrip menuStrip1;
        private PrintDialog printDialog1;
        private PrintDocument printDocument1;
        private DataGridView PrinterDGW;
        private DataGridView ShopDGW;
        private TextBox textBox1;
        private DataGridView TonerDGW;
        private ToolStripMenuItem базуДанныхToolStripMenuItem;
        private ToolStripMenuItem деталиToolStripMenuItem;
        private ToolStripMenuItem добавитьДетальToolStripMenuItem;
        private ToolStripMenuItem добавитьКатриджToolStripMenuItem;
        private ToolStripMenuItem добавитьДетальToolStripMenuItem1;
        private ToolStripMenuItem добавитьКатриджToolStripMenuItem1;
        private ToolStripMenuItem добавитьЛокациюToolStripMenuItem;
        private ToolStripMenuItem добавитьЛокациюToolStripMenuItem1;
        private ToolStripMenuItem добавитьПокупкуToolStripMenuItem;
        private ToolStripMenuItem добавитьПокупкуToolStripMenuItem1;
        private ToolStripMenuItem добавитьПринтерToolStripMenuItem;
        private ToolStripMenuItem добавитьТонерToolStripMenuItem;
        private ToolStripMenuItem добавитьТонерToolStripMenuItem1;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private ToolStripMenuItem закрытьToolStripMenuItem1;
        private ToolStripMenuItem заправитьToolStripMenuItem;
        private ToolStripMenuItem заправкаToolStripMenuItem;
        private ToolStripMenuItem катриджиToolStripMenuItem;
        private ToolStripMenuItem локацииToolStripMenuItem;
        private ToolStripMenuItem подключенныеПринтерыToolStripMenuItem;
        private ToolStripMenuItem покупкиToolStripMenuItem;
        private ToolStripMenuItem приложениеToolStripMenuItem;
        private ToolStripMenuItem принтерыToolStripMenuItem;
        private ToolStripMenuItem распечататьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem1;
        private ToolStripMenuItem редактироватьToolStripMenuItem2;
        private ToolStripMenuItem редактироватьToolStripMenuItem3;
        private ToolStripMenuItem редактироватьToolStripMenuItem4;
        private ToolStripMenuItem таблицуToolStripMenuItem;
        private ToolStripMenuItem тонерыToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
        private ToolStripMenuItem удалитьToolStripMenuItem2;
        private ToolStripMenuItem удалитьToolStripMenuItem3;
        private ToolStripMenuItem удалитьToolStripMenuItem4;
        private ToolStripMenuItem удалитьToolStripMenuItem5;
        private ToolStripMenuItem удалитьToolStripMenuItem6;
        private ToolStripMenuItem удалитьТекущеюСтрокуToolStripMenuItem;
        #endregion

        private NotifyIcon notifyIcon1;
    }
}

