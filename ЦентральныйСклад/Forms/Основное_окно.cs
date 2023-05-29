using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦентральныйСклад
{
    public partial class Основное_окно : Form
    {
        public Основное_окно()
        {
            InitializeComponent();
        }
        private DataTable table = new DataTable();

        public void GetListUsers()
        {
            using (MySqlConnection conn = sqlConn.conn)
            {
                string SelectedCategory = selectedCategory;
                conn.Open();
                BindingSource bSource = new BindingSource();
                if (Convert.ToInt32(Auth.auth_role) <= 10)
                {
                    new MySqlDataAdapter(new MySqlCommand($"SELECT ID AS ID, articleNumber AS Артикул, productName AS Товар, unitMeasurement AS `Единицы измерения`, quantity AS Количество, unitPrice AS `Цена за единицу` FROM remains WHERE categoryID = '{Auth.auth_role}';", conn)
                        ).Fill(table);
                }
                else
                {
                    new MySqlDataAdapter(new MySqlCommand($"SELECT ID AS ID, articleNumber AS Артикул, productName AS Товар, unitMeasurement AS `Единицы измерения`, quantity AS Количество, unitPrice AS `Цена за единицу` FROM remains WHERE categoryID = '{selectedCategory}';", conn)
                        ).Fill(table);
                }
                dataGridView1.DataSource = bSource.DataSource = table;
                conn.Close();

                if (dataGridView1.Columns.Count < 7)
                {
                    dataGridView1.Columns.Add("amount", "Сумма");
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[6].ReadOnly = true;
                    dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
                dataGridView1.Columns[5].Visible = true;

                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ColumnHeadersVisible = true;

                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                decimal a;
                decimal b;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    a = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                    b = Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);

                    Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value = a * b);
                }
            }
        }

        public void reload_list()
        {
            this.table.Clear();
            if (dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.Rows.Clear();
            }
            this.GetListUsers();
        }
        private void ПриходButton_Click(object sender, EventArgs e)
        {
            Приход приход = new Приход();
            приход.ShowDialog();
        }

        private void РасходButton_Click(object sender, EventArgs e)
        {
            Расход расход = new Расход();
            расход.ShowDialog();
        }

        private void ОтчётButton_Click(object sender, EventArgs e)
        {
            /*Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = exApp.ActiveSheet;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView1[j, i].Value?.ToString() ?? "";
                }
            }
            exApp.Visible = true;*/
        }

        private void Основное_окно_Load(object sender, EventArgs e)
        {
            Авторизация авторизация = new Авторизация();
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            авторизация.ShowDialog();

            if (Auth.auth)
            {
                this.Show();
                GetListUsers();
            }
            else
            {
                this.Close();
            }

            if (Auth.auth_role == "11") 
            {
                ПросмотрDropDownButton.Visible = true;
                ПросмотрDropDownButton.Enabled = true;
            }
        }
        public static string selectedCategory;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectedCategory = "1";
            reload_list();
        }

        private void полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCategory = "2";
            reload_list();
        }

        private void топливоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCategory = "3";
            reload_list();
        }

        private void тараИТарныеМатериалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCategory = "4";
            reload_list();
        }

        private void запасныеЧастиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCategory = "5";
            reload_list();
        }

        private void прочиеМатериалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCategory = "6";
            reload_list();
        }

        private void материалыПереданныеВПереработкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCategory = "7";
            reload_list();
        }

        private void строительныеМатериалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCategory = "8";
            reload_list();
        }

        private void спецоснасткаИСпецодеждаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCategory = "10";
            reload_list();
        }

        private void инвентарьИХозпринадлежностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCategory = "9";
            reload_list();
        }
    }
}
