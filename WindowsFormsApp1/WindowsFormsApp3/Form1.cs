using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //第一：获取文本框中的内容
            string username = textBox1.Text;
            string password = textBox2.Text;

            //第二：逻辑判断是否合法
            if (username=="admin" && password=="123")
            {
                //创建窗体对象Form2
                Form2 fm = new Form2();
                //显示窗体对象Form2
                fm.Show();
                //隐藏登录窗体
                this.Hide();
            }
            else
            {
                MessageBox.Show("对不起，您的账号或密码错误！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
