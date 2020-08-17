using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace readandshow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //定义DataSet对象
            DataSet set = new DataSet();
            //创建一个表的对象
            DataTable table = new DataTable();
            set.Tables.Add(table);
            //创建一个列的对象,并把列放入datatable
            DataColumn dc = table.Columns.Add("column1", typeof(string));
             
            String path = "C:\\Users\\Regen\\Desktop\\C-sharp-learning\\htmlFiles\\strings.txt";
            StreamReader sr = new StreamReader(path);
            String line;

            //创建行向表中填充数据
            DataRow dr;
            while ((line = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line.ToString());
                dr = table.NewRow();
                dr["column1"] = line.ToString();
                table.Rows.Add(dr);
            }
            
            dataGridView1.DataSource = set.Tables[0];

        }
    }
}
