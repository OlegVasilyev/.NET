using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAAAPONOVOI
{
    public partial class MainForm : Form
    {
        private DAL dal;
        public static int index;
        private List<DataGridViewRow> listDataGrid;
        static MainForm()
        {
            index = 0;
        }
        public MainForm()
        {
            this.InitializeComponent();
            this.dal = new DAL();
            this.PrinterDGW.DataSource = this.dal.GetPrinter();
            this.settingPrinters();
            this.comboBox1.Items.Add("Принтеров");
            this.comboBox1.Items.Add("Катриджей");
            this.comboBox1.Items.Add("Тонеров");
            this.comboBox1.Items.Add("Локаций");
            this.comboBox1.Items.Add("Деталей");
            this.comboBox1.Items.Add("Покупок");
        }
        private void добавитьДетальToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.добавитьДетальToolStripMenuItem_Click(null, null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.PrinterDGW.DataSource = this.dal.GetPrinter();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.currendRow == (listDataGrid.Count - 1))
                {
                    this.currendRow = 0;
                }
                else
                {
                    this.currendRow++;
                }
                if (this.comboBox1.Text == "Принтеров")
                {
                    this.PrinterDGW.CurrentCell = this.listDataGrid[this.currendRow].Cells[0];
                }
                if (this.comboBox1.Text == "Катриджей")
                {
                    this.CatrijDGW.CurrentCell = this.listDataGrid[this.currendRow].Cells[0];
                }
                if (this.comboBox1.Text == "Тонеров")
                {
                    this.TonerDGW.CurrentCell = this.listDataGrid[this.currendRow].Cells[0];
                }
                if (this.comboBox1.Text == "Локаций")
                {
                    this.LocaleDGW.CurrentCell = this.listDataGrid[this.currendRow].Cells[0];
                }
                if (this.comboBox1.Text == "Деталей")
                {
                    this.DetalDGW.CurrentCell = this.listDataGrid[this.currendRow].Cells[0];
                }
                if (this.comboBox1.Text == "Покупок")
                {
                    this.ShopDGW.CurrentCell = this.listDataGrid[this.currendRow].Cells[0];
                }
            }
            catch { }
        }
        private void CatrijDGW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                this.CatrijDGW[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Aqua;
            }
        }
        private void CatrijDGW_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.TonerDGW.DataSource = this.dal.GetToner(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString());
            this.DetalDGW.DataSource = this.dal.GetDetal(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString());
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBox1.Checked)
                {
                    this.TonerDGW.DataSource = this.dal.needzapravka();
                    for (int i = 0; i < this.TonerDGW.RowCount; i++)
                    {
                        this.TonerDGW.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    }
                }
                else
                {
                    this.TonerDGW.DataSource = this.dal.GetToner(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString());
                }
            }
            catch
            {
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBox3.Checked)
                {
                    this.TonerDGW.DataSource = this.dal.needzapravka2(Convert.ToInt32(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString()));
                    for (int i = 0; i < this.TonerDGW.RowCount; i++)
                    {
                        this.TonerDGW.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    }
                }
                else
                {
                    this.TonerDGW.DataSource = this.dal.GetToner(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString());
                }
            }
            catch
            {
            }
        }




        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            this.comboBox2.Items.Clear();
            if (this.comboBox1.Text == "Принтеров")
            {
                this.comboBox2.Items.Add("ID");
                this.comboBox2.Items.Add("Модель");
                this.comboBox2.Items.Add("Статус");
                this.comboBox2.Items.Add("Дата");
                this.comboBox2.Items.Add("Отпечатано страниц");
                this.comboBox2.Items.Add("Комментарий");
            }
            if (this.comboBox1.Text == "Катриджей")
            {
                this.comboBox2.Items.Add("ID");
                this.comboBox2.Items.Add("Модель");
                this.comboBox2.Items.Add("Цвет");
                this.comboBox2.Items.Add("Вид");
                this.comboBox2.Items.Add("Статус");
                this.comboBox2.Items.Add("Отпечатано страниц");
                this.comboBox2.Items.Add("Принтер№");
            }
            if (this.comboBox1.Text == "Тонеров")
            {
                this.comboBox2.Items.Add("ID");
                this.comboBox2.Items.Add("Модель");
                this.comboBox2.Items.Add("Цвет");
                this.comboBox2.Items.Add("Количество заправок");
                this.comboBox2.Items.Add("Комментарий");
                this.comboBox2.Items.Add("Катридж№");
            }
            if (this.comboBox1.Text == "Локаций")
            {
                this.comboBox2.Items.Add("ID");
                this.comboBox2.Items.Add("Размерещение");
                this.comboBox2.Items.Add("Владелец");
                this.comboBox2.Items.Add("Комментарий");
                this.comboBox2.Items.Add("Принтер№");
            }
            if (this.comboBox1.Text == "Деталей")
            {
                this.comboBox2.Items.Add("ID");
                this.comboBox2.Items.Add("Барабан");
                this.comboBox2.Items.Add("DRUM");
                this.comboBox2.Items.Add("Фотобарабан");
                this.comboBox2.Items.Add("Комментарий");
                this.comboBox2.Items.Add("Катридж№");
            }
            if (this.comboBox1.Text == "Покупок")
            {
                this.comboBox2.Items.Add("ID");
                this.comboBox2.Items.Add("Название");
                this.comboBox2.Items.Add("Цена");
                this.comboBox2.Items.Add("Дата покупки");
                this.comboBox2.Items.Add("Адрес сайта");
                this.comboBox2.Items.Add("Комментарий");
                this.comboBox2.Items.Add("Тонер№");
            }
        }
        private void DetalDGW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                this.DetalDGW[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Aqua;
            }
        }
        private void LocaleDGW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                this.LocaleDGW[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Aqua;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение ?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.PrinterDGW.CellEnter += new DataGridViewCellEventHandler(this.PrinterDGW_CellEnter);
            this.CatrijDGW.CellEnter += new DataGridViewCellEventHandler(this.CatrijDGW_CellEnter);
            this.TonerDGW.CellEnter += new DataGridViewCellEventHandler(this.TonerDGW_CellEnter);
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string s = "";
            Font font = new Font("Tahoma", 12f, FontStyle.Bold);
            e.Graphics.DrawString(s, font, Brushes.Black, (float)0f, (float)0f);
        }
        private void PrinterDGW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                this.PrinterDGW[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Aqua;
            }
        }
        private void PrinterDGW_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.CatrijDGW.DataSource = this.dal.GetCatrij(this.PrinterDGW.CurrentRow.Cells["ID"].Value.ToString());
            this.LocaleDGW.DataSource = this.dal.GetLocale(this.PrinterDGW.CurrentRow.Cells["ID"].Value.ToString());
            if (this.CatrijDGW.CurrentRow == null)
            {
                this.ShopDGW.Rows.Clear();
                this.DetalDGW.Rows.Clear();
                this.TonerDGW.Rows.Clear();
            }
        }

        private void PrinterDGW_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.cellMouseEnter = e;
        }
        private void PrinterDGW_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object obj2 = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if ((obj2 == null) || !obj2.Equals(e.RowIndex + 1))
            {
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
            }
        }
        private void settingPrinters()
        {
            this.PrinterDGW.TopLeftHeaderCell.Value = "#";
            this.CatrijDGW.TopLeftHeaderCell.Value = "#";
            this.LocaleDGW.TopLeftHeaderCell.Value = "#";
            this.TonerDGW.TopLeftHeaderCell.Value = "#";
            this.DetalDGW.TopLeftHeaderCell.Value = "#";
            this.ShopDGW.TopLeftHeaderCell.Value = "#";
        }
        private void ShopDGW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                this.ShopDGW[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Aqua;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                try
                {
                    foreach (DataGridViewRow row in this.listDataGrid)
                    {
                        if (this.comboBox1.Text == "Принтеров")
                        {
                            this.PrinterDGW.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Катриджей")
                        {
                            this.CatrijDGW.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Тонеров")
                        {
                            this.TonerDGW.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Локаций")
                        {
                            this.LocaleDGW.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Деталей")
                        {
                            this.DetalDGW.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Покупок")
                        {
                            this.ShopDGW.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
                catch
                {
                }
                this.listDataGrid = new List<DataGridViewRow>();
                if (!this.checkBox1.Checked && (this.comboBox1.Text == "Принтеров"))
                {
                    try
                    {
                        foreach (DataGridViewRow row2 in PrinterDGW.Rows)
                        {
                            if (row2.Cells[this.comboBox2.Text.Trim()].FormattedValue.ToString().Contains(this.textBox1.Text.Trim()))
                            {
                                this.listDataGrid.Add(row2);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                if (this.checkBox1.Checked && (this.comboBox1.Text == "Принтеров"))
                {
                    ArrayList list = this.dal.SearchPrinter(this.textBox1.Text.Trim());
                    if ((list == null) && (list.Count <= 0))
                    {
                        this.PrinterDGW.DataSource = list;
                    }
                }
                if (!this.checkBox1.Checked && (this.comboBox1.Text == "Катриджей"))
                {
                    try
                    {
                        foreach (DataGridViewRow row3 in CatrijDGW.Rows)
                        {
                            if (row3.Cells[this.comboBox2.Text.Trim()].FormattedValue.ToString().Contains(this.textBox1.Text.Trim()))
                            {
                                this.listDataGrid.Add(row3);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                if (!this.checkBox1.Checked && (this.comboBox1.Text == "Тонеров"))
                {
                    try
                    {
                        foreach (DataGridViewRow row4 in (IEnumerable)this.TonerDGW.Rows)
                        {
                            if (row4.Cells[this.comboBox2.Text.Trim()].FormattedValue.ToString().Contains(this.textBox1.Text.Trim()))
                            {
                                this.listDataGrid.Add(row4);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                if (!this.checkBox1.Checked && (this.comboBox1.Text == "Локаций"))
                {
                    try
                    {
                        foreach (DataGridViewRow row5 in (IEnumerable)this.LocaleDGW.Rows)
                        {
                            if (row5.Cells[this.comboBox2.Text.Trim()].FormattedValue.ToString().Contains(this.textBox1.Text.Trim()))
                            {
                                this.listDataGrid.Add(row5);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                if (!this.checkBox1.Checked && (this.comboBox1.Text == "Деталей"))
                {
                    try
                    {
                        foreach (DataGridViewRow row6 in (IEnumerable)this.DetalDGW.Rows)
                        {
                            if (row6.Cells[this.comboBox2.Text.Trim()].FormattedValue.ToString().Contains(this.textBox1.Text.Trim()))
                            {
                                this.listDataGrid.Add(row6);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                if (!this.checkBox1.Checked && (this.comboBox1.Text == "Покупок"))
                {
                    try
                    {
                        foreach (DataGridViewRow row7 in (IEnumerable)this.ShopDGW.Rows)
                        {
                            if (row7.Cells[this.comboBox2.Text.Trim()].FormattedValue.ToString().Contains(this.textBox1.Text.Trim()))
                            {
                                this.listDataGrid.Add(row7);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                if (this.listDataGrid.Count > 0)
                {
                    foreach (DataGridViewRow row8 in this.listDataGrid)
                    {
                        if (this.comboBox1.Text == "Принтеров")
                        {
                            this.PrinterDGW.Rows[row8.Index].DefaultCellStyle.BackColor = Color.Green;
                        }
                        if (this.comboBox1.Text == "Катриджей")
                        {
                            this.CatrijDGW.Rows[row8.Index].DefaultCellStyle.BackColor = Color.Green;
                        }
                        if (this.comboBox1.Text == "Тонеров")
                        {
                            this.TonerDGW.Rows[row8.Index].DefaultCellStyle.BackColor = Color.Green;
                        }
                        if (this.comboBox1.Text == "Локаций")
                        {
                            this.LocaleDGW.Rows[row8.Index].DefaultCellStyle.BackColor = Color.Green;
                        }
                        if (this.comboBox1.Text == "Деталей")
                        {
                            this.DetalDGW.Rows[row8.Index].DefaultCellStyle.BackColor = Color.Green;
                        }
                        if (this.comboBox1.Text == "Покупок")
                        {
                            this.ShopDGW.Rows[row8.Index].DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                    this.button2.Enabled = true;
                    this.currendRow = -1;
                }
            }
            else
            {
                try {
                    foreach (DataGridViewRow row9 in this.listDataGrid)
                    {
                        if (this.comboBox1.Text == "Принтеров")
                        {
                            this.PrinterDGW.Rows[row9.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Катриджей")
                        {
                            this.CatrijDGW.Rows[row9.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Тонеров")
                        {
                            this.TonerDGW.Rows[row9.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Локаций")
                        {
                            this.LocaleDGW.Rows[row9.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Деталей")
                        {
                            this.DetalDGW.Rows[row9.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBox1.Text == "Покупок")
                        {
                            this.ShopDGW.Rows[row9.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                    
                }catch{ }
            }
        }
        private void TonerDGW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                this.TonerDGW[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Aqua;
            }
        }
        private void TonerDGW_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.ShopDGW.DataSource = this.dal.GetShop(this.TonerDGW.CurrentRow.Cells["ID"].Value.ToString());
        }
        private void базуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        private void добавитьДетальToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDetal detal = new NewDetal();
            if (detal.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Деталь внесена в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DetalDGW.DataSource = this.dal.GetDetal(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Деталь НЕ внесена в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void добавитьКатриджToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCatrij catrij = new NewCatrij();
            if (catrij.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Катридж внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.CatrijDGW.DataSource = this.dal.GetCatrij(this.PrinterDGW.CurrentRow.Cells["ID"].Value.ToString());
                int sum = 0;
                for (int i = 0; i < this.CatrijDGW.RowCount; i++)
                {
                    sum += Convert.ToInt32(this.CatrijDGW.Rows[i].Cells[5].Value.ToString());
                }
                this.dal.OtpechatanoStrinichek(Convert.ToInt32(this.PrinterDGW.Rows[index - 1].Cells[0].Value.ToString()), sum);
                this.PrinterDGW.DataSource = this.dal.GetPrinter();
            }
            else
            {
                MessageBox.Show("Катридж НЕ внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void добавитьКатриджToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.добавитьКатриджToolStripMenuItem_Click(null, null);
        }
        private void добавитьЛокациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocale locale = new NewLocale();
            if (locale.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новое расположение внесено в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.LocaleDGW.DataSource = this.dal.GetLocale(this.PrinterDGW.CurrentRow.Cells["ID"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Новое расположение НЕ внесено в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void добавитьЛокациюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.добавитьЛокациюToolStripMenuItem_Click(null, null);
        }
        private void добавитьПокупкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewShop shop = new NewShop();
            if (shop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Покупка внесена в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.ShopDGW.DataSource = this.dal.GetShop(this.TonerDGW.CurrentRow.Cells["ID"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Покупка НЕ внесена в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void добавитьПокупкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.добавитьПокупкуToolStripMenuItem_Click(null, null);
        }
        private void добавитьПринтерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPrinter printer = new NewPrinter();
            if (printer.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Принтер внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.PrinterDGW.DataSource = this.dal.GetPrinter();
            }
            else
            {
                MessageBox.Show("Принтер НЕ внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void добавитьТонерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToner toner = new NewToner();
            if (toner.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Катридж внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.TonerDGW.DataSource = this.dal.GetToner(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Катридж НЕ внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void добавитьТонерToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.добавитьТонерToolStripMenuItem_Click(null, null);
        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void закрытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new SaveDataBase().ShowDialog();
        }
        private void заправитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dal.zapravka(this.TonerDGW.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(this.TonerDGW.CurrentRow.Cells[3].Value.ToString())))
            {
                int index = this.TonerDGW.CurrentRow.Index;
                this.TonerDGW.DataSource = this.dal.GetToner(this.CatrijDGW.CurrentRow.Cells[0].Value.ToString());
                this.TonerDGW.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                this.label5.Text = "Заправлено";
            }
            else
            {
                this.TonerDGW.CurrentRow.Cells[3].Style.BackColor = Color.Red;
            }
        }
        private void заправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dal.zapravka(this.TonerDGW.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(this.TonerDGW.CurrentRow.Cells[3].Value.ToString())))
            {
                int index = this.TonerDGW.CurrentRow.Index;
                this.TonerDGW.DataSource = this.dal.GetToner(this.CatrijDGW.CurrentRow.Cells[0].Value.ToString());
                this.TonerDGW.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                this.label5.Text = "Заправлено";
            }
            else
            {
                this.TonerDGW.CurrentRow.Cells[3].Style.BackColor = Color.Red;
            }
        }
        private void подключенныеПринтерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "";
            PrinterSettings.StringCollection installedPrinters = PrinterSettings.InstalledPrinters;
            for (int i = 0; i < installedPrinters.Count; i++)
            {
                object[] objArray1 = new object[] { text, "№", i + 1, " ", installedPrinters[i].ToString(), "\n" };
                text = string.Concat(objArray1);
            }
            MessageBox.Show(text, "Printers");
        }
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocale locale = new NewLocale(true, this.LocaleDGW.CurrentRow.Cells[0].Value.ToString(), this.LocaleDGW.CurrentRow.Cells[1].Value.ToString(), this.LocaleDGW.CurrentRow.Cells[2].Value.ToString(), this.LocaleDGW.CurrentRow.Cells[3].Value.ToString(), this.LocaleDGW.CurrentRow.Cells[4].Value.ToString());
            if (locale.ShowDialog() == DialogResult.OK)
            {
                this.LocaleDGW.DataSource = this.dal.GetLocale(this.PrinterDGW.CurrentRow.Cells[0].Value.ToString());
                this.label5.Text = "Отредактировано";
            }
        }
        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewDetal detal = new NewDetal(true, this.DetalDGW.CurrentRow.Cells[0].Value.ToString(), this.DetalDGW.CurrentRow.Cells[1].Value.ToString(), this.DetalDGW.CurrentRow.Cells[2].Value.ToString(), this.DetalDGW.CurrentRow.Cells[3].Value.ToString(), this.DetalDGW.CurrentRow.Cells[4].Value.ToString(), this.DetalDGW.CurrentRow.Cells[5].Value.ToString());
            if (detal.ShowDialog() == DialogResult.OK)
            {
                this.DetalDGW.DataSource = this.dal.GetDetal(this.CatrijDGW.CurrentRow.Cells[0].Value.ToString());
                this.label5.Text = "Отредактировано";
            }
        }
        private void редактироватьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NewShop shop = new NewShop(true, this.ShopDGW.CurrentRow.Cells[0].Value.ToString(), this.ShopDGW.CurrentRow.Cells[1].Value.ToString(), this.ShopDGW.CurrentRow.Cells[2].Value.ToString(), this.ShopDGW.CurrentRow.Cells[3].Value.ToString(), this.ShopDGW.CurrentRow.Cells[4].Value.ToString(), this.ShopDGW.CurrentRow.Cells[5].Value.ToString(), this.ShopDGW.CurrentRow.Cells[6].Value.ToString());
            if (shop.ShowDialog() == DialogResult.OK)
            {
                this.ShopDGW.DataSource = this.dal.GetShop(this.TonerDGW.CurrentRow.Cells[0].Value.ToString());
                this.label5.Text = "Отредактировано";
            }
        }
        private void редактироватьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NewToner toner = new NewToner(true, this.TonerDGW.CurrentRow.Cells[0].Value.ToString(), this.TonerDGW.CurrentRow.Cells[1].Value.ToString(), this.TonerDGW.CurrentRow.Cells[2].Value.ToString(), this.TonerDGW.CurrentRow.Cells[3].Value.ToString(), this.TonerDGW.CurrentRow.Cells[4].Value.ToString(), this.TonerDGW.CurrentRow.Cells[5].Value.ToString());
            if (toner.ShowDialog() == DialogResult.OK)
            {
                this.TonerDGW.DataSource = this.dal.GetToner(this.CatrijDGW.CurrentRow.Cells[0].Value.ToString());
                this.label5.Text = "Отредактировано";
            }
        }
        private void редактироватьToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NewCatrij catrij = new NewCatrij(true, this.CatrijDGW.CurrentRow.Cells[0].Value.ToString(), this.CatrijDGW.CurrentRow.Cells[1].Value.ToString(), this.CatrijDGW.CurrentRow.Cells[2].Value.ToString(), this.CatrijDGW.CurrentRow.Cells[3].Value.ToString(), this.CatrijDGW.CurrentRow.Cells[4].Value.ToString(), this.CatrijDGW.CurrentRow.Cells[5].Value.ToString(), this.CatrijDGW.CurrentRow.Cells[6].Value.ToString(), this.CatrijDGW.CurrentRow.Cells[7].Value.ToString());
            if (catrij.ShowDialog() == DialogResult.OK)
            {
                this.CatrijDGW.DataSource = this.dal.GetCatrij(this.PrinterDGW.CurrentRow.Cells[0].Value.ToString());
                int sum = 0;
                for (int i = 0; i < this.CatrijDGW.RowCount; i++)
                {
                    sum += Convert.ToInt32(this.CatrijDGW.Rows[i].Cells[5].Value.ToString());
                }
                this.dal.OtpechatanoStrinichek(Convert.ToInt32(this.PrinterDGW.Rows[index - 1].Cells[0].Value.ToString()), sum);
                this.PrinterDGW.DataSource = this.dal.GetPrinter();
                this.label5.Text = "Отредактировано";
            }
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPrinter printer = new NewPrinter(true, this.PrinterDGW.CurrentRow.Cells[0].Value.ToString(), this.PrinterDGW.CurrentRow.Cells[1].Value.ToString(), this.PrinterDGW.CurrentRow.Cells[2].Value.ToString(), this.PrinterDGW.CurrentRow.Cells[3].Value.ToString(), this.PrinterDGW.CurrentRow.Cells[4].Value.ToString(), this.PrinterDGW.CurrentRow.Cells[5].Value.ToString());
            if (printer.ShowDialog() == DialogResult.OK)
            {
                this.PrinterDGW.DataSource = this.dal.GetPrinter();
                this.label5.Text = "Отредактировано";
            }
        }
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.dal.DeletePrinter(Convert.ToInt32(this.PrinterDGW.CurrentRow.Cells["ID"].Value.ToString())))
            {
                this.label5.Text = "Удалено";
            }
            this.PrinterDGW.DataSource = this.dal.GetPrinter();
        }
        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.dal.DeleteLocale(Convert.ToInt32(this.LocaleDGW.CurrentRow.Cells["ID"].Value.ToString())))
            {
                this.label5.Text = "Удалено";
            }
            this.LocaleDGW.DataSource = this.dal.GetLocale(this.PrinterDGW.CurrentRow.Cells["ID"].Value.ToString());
        }
        private void удалитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (this.dal.DeleteDetal(Convert.ToInt32(this.DetalDGW.CurrentRow.Cells["ID"].Value.ToString())))
            {
                this.label5.Text = "Удалено";
            }
            this.DetalDGW.DataSource = this.dal.GetDetal(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString());
        }
        private void удалитьToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (this.dal.DeleteShop(Convert.ToInt32(this.ShopDGW.CurrentRow.Cells["ID"].Value.ToString())))
            {
                this.label5.Text = "Удалено";
            }
            this.ShopDGW.DataSource = this.dal.GetShop(this.TonerDGW.CurrentRow.Cells["ID"].Value.ToString());
        }
        private void удалитьToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (this.dal.DeleteToner(Convert.ToInt32(this.TonerDGW.CurrentRow.Cells["ID"].Value.ToString())))
            {
                this.label5.Text = "Удалено";
            }
            this.TonerDGW.DataSource = this.dal.GetToner(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString());
        }
        private void удалитьToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (this.dal.DeleteCatrij(Convert.ToInt32(this.CatrijDGW.CurrentRow.Cells["ID"].Value.ToString())))
            {
                this.label5.Text = "Удалено";
            }
            this.CatrijDGW.DataSource = this.dal.GetCatrij(this.PrinterDGW.CurrentRow.Cells["ID"].Value.ToString());
        }
        private void удалитьТекущеюСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new AAAAPONOVOI.Login();
            login.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (this.comboBox1.Text == "Принтеров")
                {
                    this.PrinterDGW.DataSource = dal.search(comboBox1.Text.Trim(), comboBox2.Text.Trim(), textBox1.Text.Trim());
                }
                if (this.comboBox1.Text == "Катриджей")
                {
                    this.CatrijDGW.DataSource = dal.search(comboBox1.Text.Trim(), comboBox2.Text.Trim(), textBox1.Text.Trim());
                }
                if (this.comboBox1.Text == "Тонеров")
                {
                    this.TonerDGW.DataSource = dal.search(comboBox1.Text.Trim(), comboBox2.Text.Trim(), textBox1.Text.Trim());

                }
                if (this.comboBox1.Text == "Локаций")
                {
                    this.LocaleDGW.DataSource = dal.search(comboBox1.Text.Trim(), comboBox2.Text.Trim(), textBox1.Text.Trim());

                }
                if (this.comboBox1.Text == "Деталей")
                {
                    this.DetalDGW.DataSource = dal.search(comboBox1.Text.Trim(), comboBox2.Text.Trim(), textBox1.Text.Trim());

                }
                if (this.comboBox1.Text == "Покупок")
                {
                    this.ShopDGW.DataSource = dal.search(comboBox1.Text.Trim(), comboBox2.Text.Trim(), textBox1.Text.Trim());

                }
               
            } else
                {
                    this.PrinterDGW.DataSource = dal.GetPrinter();
                }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}
