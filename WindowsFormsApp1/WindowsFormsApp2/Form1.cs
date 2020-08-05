using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        //绑定事件，生成的事件方法
        private void button1_Click(object sender, EventArgs e)
        {
            //第一：获取文本框中的内容
            int height = int.Parse(textBox1.Text); //Parse转换类型为int

            //第二：对文本框中的内容进行加工处理
            int weight = (height - 105) * 2;

            //第三：显示结果
            label2.Text = weight.ToString();
        }
    }
}
