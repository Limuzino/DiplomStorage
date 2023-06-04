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
    public partial class Расход : Form
    {
        public Расход()
        {
            InitializeComponent();
        }
        Основное_окно основное_окно = new Основное_окно();
        DataTable table = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Вы не ввели артикул");
                return;
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Вы не ввели количество");
                return;
            }

            using (MySqlConnection conn = sqlConn.conn)
            {
                conn.Open();
                table.Clear();

                new MySqlDataAdapter(new MySqlCommand($"SELECT * " +
                    $"FROM remains " +
                    $"WHERE articleNumber = {textBox1.Text} AND quantity > {textBox2.Text.Replace('.', ',')}", conn)
                        ).Fill(table);
                if (textBox1.Text.Length < 11)
                {
                    MessageBox.Show("Артикул слишком короткий!");
                }
                else
                {
                    if (table.Rows.Count == 1)
                    {


                        if (Convert.ToInt32(Auth.auth_role) <= 10)
                        {
                            try
                            {
                                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO expense (articleNumber, productName, unitMeasurement, quantity, unitPrice) " +
                                    "SELECT articleNumber, productName, unitMeasurement, @param2, unitPrice " +
                                    "FROM remains " +
                                    "WHERE remains.articleNumber = @param1 AND remains.categoryID = @param3", conn)
                                {
                                    Parameters =
                            {
                                new MySqlParameter("@param1", Convert.ToString(textBox1.Text)),
                                new MySqlParameter("@param2", Convert.ToDecimal(textBox2.Text.Replace('.', ','))),
                                new MySqlParameter("@param3", Convert.ToString(Auth.auth_role))
                            }
                                };
                                cmd1.ExecuteNonQuery();

                                MySqlCommand cmd2 = new MySqlCommand("UPDATE remains " +
                                    "SET quantity = quantity-@param2 " +
                                    "WHERE articleNumber = @param1 AND categoryID = @param3", conn)
                                {
                                    Parameters =
                            {
                                new MySqlParameter("@param1", Convert.ToString(textBox1.Text)),
                                new MySqlParameter("@param2", Convert.ToDecimal(textBox2.Text.Replace('.', ','))),
                                new MySqlParameter("@param3", Convert.ToString(Auth.auth_role))
                            }
                                };
                                cmd2.ExecuteNonQuery();
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
                                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO expense (articleNumber, productName, unitMeasurement, quantity, unitPrice) " +
                                    "SELECT articleNumber, productName, unitMeasurement, @param2, unitPrice " +
                                    "FROM remains " +
                                    "WHERE remains.articleNumber = @param1 AND remains.categoryID = @param3", conn)
                                {
                                    Parameters =
                            {
                                new MySqlParameter("@param1", Convert.ToString(textBox1.Text)),
                                new MySqlParameter("@param2", Convert.ToDecimal(textBox2.Text.Replace('.', ','))),
                                new MySqlParameter("@param3", Convert.ToString(Auth.selectedCategory))
                            }
                                };
                                cmd1.ExecuteNonQuery();

                                MySqlCommand cmd2 = new MySqlCommand("UPDATE remains " +
                                    "SET quantity = quantity-@param2 " +
                                    "WHERE articleNumber = @param1 AND categoryID = @param3", conn)
                                {
                                    Parameters =
                            {
                                new MySqlParameter("@param1", Convert.ToString(textBox1.Text)),
                                new MySqlParameter("@param2", Convert.ToDecimal(textBox2.Text.Replace('.', ','))),
                                new MySqlParameter("@param3", Convert.ToString(Auth.selectedCategory))
                            }
                                };
                                cmd2.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }


                    }
                    else
                    {
                        MessageBox.Show("Вы не можете израсходовать больше чем имеется на складе!");
                    }
                }
                conn.Close();
                основное_окно.GetListUsers();
            }

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            this.Close();
        }
    }
}
