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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ЦентральныйСклад
{
    public partial class Приход : Form
    {
        public Приход()
        {
            InitializeComponent();
        }
        Основное_окно основное_окно = new Основное_окно();

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = sqlConn.conn)
            {
                conn.Open();
                if (Convert.ToInt32(Auth.auth_role) <= 10)
                {
                    if (String.IsNullOrEmpty(textBox1.Text))
                    {
                        MessageBox.Show("Вы не ввели артикул");
                        return;
                    }
                    else if (String.IsNullOrEmpty(textBox2.Text))
                    {
                        MessageBox.Show("Вы не ввели наименование");
                        return;
                    }
                    else if (String.IsNullOrEmpty(textBox3.Text))
                    {
                        MessageBox.Show("Вы не ввели единицы измерения");
                        return;
                    }
                    else if (String.IsNullOrEmpty(textBox4.Text))
                    {
                        MessageBox.Show("Вы не ввели количество");
                        return;
                    }
                    else if (String.IsNullOrEmpty(textBox5.Text))
                    {
                        MessageBox.Show("Вы не ввели цену за единицу");
                        return;
                    }

                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO remains (articleNumber, productName, unitMeasurement, quantity, unitPrice, categoryID) VALUES (@param1, @param2, @param3, @param4, @param5, @param6)", conn)
                        {
                            Parameters =
                            {
                                new MySqlParameter("@param1", Convert.ToString(textBox1.Text)),
                                new MySqlParameter("@param2", Convert.ToString(textBox2.Text)),
                                new MySqlParameter("@param3", Convert.ToString(textBox3.Text)),
                                new MySqlParameter("@param4", Convert.ToDecimal(textBox4.Text)),
                                new MySqlParameter("@param5", Convert.ToDecimal(textBox5.Text)),
                                new MySqlParameter("@param6", Convert.ToString(Auth.auth_role))
                            }
                        };
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO remains (articleNumber, productName, unitMeasurement, quantity, unitPrice, categoryID) VALUES (@param1, @param2, @param3, @param4, @param5, @param6)", conn)
                        {
                            Parameters =
                            {
                                new MySqlParameter("@param1", Convert.ToString(textBox1.Text)),
                                new MySqlParameter("@param2", Convert.ToString(textBox2.Text)),
                                new MySqlParameter("@param3", Convert.ToString(textBox3.Text)),
                                new MySqlParameter("@param4", Convert.ToDecimal(textBox4.Text)),
                                new MySqlParameter("@param5", Convert.ToDecimal(textBox5.Text)),
                                new MySqlParameter("@param6", Convert.ToString(Основное_окно.selectedCategory))
                            }
                        };
                        cmd.ExecuteNonQuery();
                        основное_окно.reload_list();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conn.Close();
                 
            }
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            this.Close();
        }

        private void Приход_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Auth.auth_role) == 11)
            {
                MessageBox.Show("Напоминание: добавление записи будет произведено к категории товара отображенной в таблице!");
            }
        }
    }
}
