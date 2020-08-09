using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //第一：定义连接数据库的字符串：包含连接数据库的相关信息
            string conStr = "server=127.0.0.1; port=3306; user=root; password=QJ&-(2cp*2ej; database=analysis_tool";

            //第二：创建连接对象，并指定连接字符串
            MySqlConnection conn = new MySqlConnection(conStr);

            //第三：打开连接
            conn.Open();

            //第四：判断是否连接成功
            if (conn.State==ConnectionState.Open)
            {
                MessageBox.Show("连接成功！");
            }
            else
            {
                MessageBox.Show("连接失败！");
            }
        }
    }
}
