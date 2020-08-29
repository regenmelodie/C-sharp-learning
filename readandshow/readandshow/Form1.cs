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

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "HTML File|*.html";
            saveFileDialog.Title = "Save a HTML";
            saveFileDialog.RestoreDirectory = true; //保存对话框是否记忆上次打开的目录
            saveFileDialog.CheckPathExists = true; //检查目录
            saveFileDialog.FileName = "UntitledHTML"; //设置默认文件名
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                

                MessageBox.Show(this, "保存成功！", "提示");
            }


            int rowSize = dataGridView1.RowCount;
            for (int i=0; i<rowSize; i++)
            {
                
            }

            /*
            WebBrowser webBrowser1 = new WebBrowser();
            HtmlDocument doc = webBrowser1.Document;
            HtmlElement html = doc.CreateElement("html");
            doc.Body.AppendChild(html);

            HtmlElement head = doc.CreateElement("head");
            html.AppendChild(head);

            HtmlElement meta = doc.CreateElement("meta");
            meta.SetAttribute("http-equiv", "Content-Type");
            meta.SetAttribute("content", "text/html");
            meta.SetAttribute("charset", "UTF-8");
            head.AppendChild(meta);
            html.AppendChild(head);

            HtmlElement body = doc.CreateElement("body");
            HtmlElement div = doc.CreateElement("div");
            div.InnerText = "123";
            body.AppendChild(div);
            html.AppendChild(body);
            */
            

        }
    }
}
