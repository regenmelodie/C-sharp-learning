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

            /*
            //第五：读取DataSet对象中的数据
            string studentID = set.Tables[0].Rows[0][0].ToString(); //第一张表 第一行 第一列
            MessageBox.Show(studentID);
            */

            /*
            //读取一个数据
            //1.获取DataSet数据库中第一张表（DataTable）
            DataTable dt = set.Tables[0];

            //2.获取DataTable中某行
            //集合可以通过中括号+下标来访问
            DataRow row = dt.Rows[0];

            //3.获取当前行的各列的数据
            //string id = row[0].ToString();//第一列
            string id = row["studentID"].ToString();
            MessageBox.Show(id);
            */


            DataTable dt = set.Tables[0];

            for(int i=0; i<dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
            }
            

            //注意：一般DataSet、SqlDataAdapter和DataGridView控件一起使用
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //第一：定义DataSet对象
            DataSet set = new DataSet();

            //第二：定义连接字符串
            string dbStr = "server=127.0.0.1; port=3306; user=root; password=QJ&-(2cp*2ej; database=analysis_tool";

            //第三：定义查询语句
            string sql = "select studentID, calcLines from week3";

            //第四：定义SqlDataAdapter
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbStr);

            //第五：填充数据
            adapter.Fill(set);

            //第六：绑定DataGridView控件
            dataGridView1.DataSource = set.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int len = dataGridView1.Rows.Count;
            MessageBox.Show(len.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ForeColor = System.Drawing.Color.Blue;
        }
    }
}
