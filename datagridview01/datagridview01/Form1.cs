using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string dbstr = "server=.; uid=root; pwd=QJ&-(2cp*2ej"

            //2)定义查询SQL语句

            //第三：把查询的结果，填充到DataSet对象中

            //第四：读取DataSet对象中的数据
        }
    }
}
