using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace ЦентральныйСклад
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        //шифрование sha256
        static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = sqlConn.conn)
            {
                conn.Open();
                DataTable table = new DataTable();
                new MySqlDataAdapter(new MySqlCommand("SELECT * FROM users WHERE login = @un and password = @up", conn)
                {
                    Parameters = { new MySqlParameter("@un", textBox1.Text), new MySqlParameter("@up", sha256(textBox2.Text)) }
                }).Fill(table);
                conn.Close();

                if (table.Rows.Count > 0)
                {
                    Auth.auth = true;
                    Auth.auth_role = table.Rows[0]["roleID"].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверные данные авторизации!");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
