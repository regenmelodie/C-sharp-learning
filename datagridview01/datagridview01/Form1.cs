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

namespace datagridview01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //第一：创建DataSet对象
            DataSet set = new DataSet();

            //第二：创建SQLDataAdapter对象
            //1)定义连接对象
            string conStr = "server=127.0.0.1; port=3306; user=root; password=QJ&-(2cp*2ej; database=analysis_tool";
            MySqlConnection conn = new MySqlConnection(conStr);
            conn.Open();

            //2)定义查询SQL语句
            string sql = "select studentID, calcLines from week3";

            //3)创建适配对象
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            //第三：把查询的结果，填充到DataSet对象中
            adapter.Fill(set);

            //第四：关闭连接对象
            conn.Close();

            //第五：读取DataSet对象中的数据
            string studentID = set.Tables[0].Rows[0][0].ToString(); //第一张表 第一行 第一列
            MessageBox.Show(studentID);

            //注意：一般DataSet、SqlDataAdapter和DataGridView控件一起使用
        }
    }
}
