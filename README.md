"# C-sharp-learning" 



## WinForm 案例

##### 【WindowsFormsApp2】用户输入身高（CM），计算用户的标准体重（斤）。标准体重 = （身高 - 105) * 2。



##### 【WindowsFormsApp3】模拟用户登录。窗体在中间；密码以星号显示；弹出登录成功窗口时隐藏登录窗体。

​					this代表主窗体。在主窗体被隐藏时，可以调用Application.Exit()方法退出程序。



##### 【database】连接mysql数据库。

​					安装MySql.Data包：工具-NuGet包管理器-程序包管理器控制台：PM>Install-Package MySql.Data -Version 8.0.21。

```c#
        using MySql.Data.MySqlClient;
        
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
```


##### 【DataGridView-01】DataSet: 存储数据的容器；数据存储在内存中；独立于数据库；类似于临时的仓库。

​					DataAdapter: 用于管理与数据库的连接、执行命令并填充数据集和更新数据库；数据库与DataSet之间的桥梁。

![image-20200810201431348](C:\Users\Regen\AppData\Roaming\Typora\typora-user-images\image-20200810201431348.png)

```c#
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
```








## DataGridView 常用属性

· SelectionMode：选择模式（如可以选中整行单元格）

· Cursor：显示光标

· BackGroundColor：背景颜色

· BorderStyle：边框样式

· AllowUserToAddRows：是否允许添加新行

· RowHeadersVisible：是否显示行标题的列

· MultiSelect：是否选择多行、列、单元格

· AllowUserToResizeRowS：设置是否允许改变行高

· AllowUserToResizeColumns：设置是否允许改变列宽

· ReadOnly：只读，不可编辑

· ColumnHeadersDefaultCellStyle：设置列标题样式

· DefaultCellStyle：设置单元格式样式

· Columns：编辑列

​	· DataPropertyName：绑定数据表字段名

​	· HeaderName：列名

​	· Resizable

· CurrentRow：选中当前行

· Rows：行的集合

· SelectedRows：选中行的集合

· DataSource：数据源















