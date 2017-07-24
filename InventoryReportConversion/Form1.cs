using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace InventoryReportConversion
{
    public partial class Form1 : Form
    {
        private string filename = "Untitled";  //选中的文件路径
        private DataTable data_source = null;  //要处理的表放在这里，程序中最重要的变量

        private delegate void SetDtCallback(DataTable dt);  //创建一个委托，用于解决从不是创建控件的线程访问问题

        public Form1()
        {
            InitializeComponent();

            string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  //用Environment.SpecialFolder枚举一个特定的系统文件夹
            //openFileDialog1.InitialDirectory = dir;  //初始化openFileDialog1的初始打开位置
            openFileDialog1.InitialDirectory = @"C:\Users\Administrator\Desktop\InventoryReportConversion\原表";
            openFileDialog1.FileName = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        #region 被事件处理函数调用的众多方法

        /// <summary>
        /// 用于跨线程将数据表传递到dataGridView中
        /// </summary>
        private void SetDT(DataTable dt)
        {
            // InvokeRequired需要比较调用线程ID和创建线程ID不相同则返回true
            if (this.dataGridView1.InvokeRequired)
            {
                SetDtCallback d = new SetDtCallback(SetDT);
                this.Invoke(d, new object[] { dt });  //在拥有控件的基础窗口句柄的线程上，用指定的参数列表执行指定委托。
            }
            else
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = dt;
            }
        }

        /// <summary>
        /// 把EXCEL转换成一个数据源来进行数据的 读取 操作，非主线程方法
        /// </summary>
        private void ExcelToDS(object Path)
        {
            DataSet ds = new DataSet();
            //string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";
            //string strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + Path + ";Extended Properties='Excel 8.0; HDR=NO; IMEX=1'"; //此连接只能操作Excel2007之前(.xls)文件
            string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + (string)Path + ";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'";  //此连接可以操作.xls与.xlsx文件
            /*进度条*/this.progressBar1.BeginInvoke((Action)delegate { this.progressBar1.Visible = true; });
            /*进度条*/this.progressBar1.BeginInvoke((Action)delegate { this.progressBar1.Value = 0; });
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            /*进度条*/this.progressBar1.BeginInvoke((Action)delegate { this.progressBar1.Value = 10; });
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            strExcel = "select * from [sheet1$]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            /*进度条*/this.progressBar1.BeginInvoke((Action)delegate { this.progressBar1.Value = 100; });
            myCommand.Fill(ds, "table1");
            data_source = ds.Tables["table1"];
            conn.Close();

            for (int i = 0; i < data_source.Columns.Count; i++)  //为每一列设置列名
            {
                data_source.Columns[i].ColumnName = data_source.Rows[0][i].ToString() + "(" + i.ToString() + ")";
            }

            //dataGridView1.DataSource = data_souce.Tables[0];  //将跨线程传递数据的代码换成使用委托
            SetDT(data_source);
            /*进度条*/this.progressBar1.BeginInvoke((Action)delegate { this.progressBar1.Visible = false; });
        }

        /// <summary>
        /// 打印当前导入表格DataTable中的最大长度，并在超过指定长度时警告,超长返回false
        /// 参数列表：1、所查询列的列名；2、用来做警告的最大长度；
        /// </summary>
        private bool GetMaxLength(string target_str, int notice_length)
        {
            int max_length = 0;
            bool only_once = true;
            string error_str = null;
            for (int i = 0; i < data_source.Rows.Count; i++)
            {
                if (data_source.Rows[i][target_str].ToString().Length > max_length)
                {
                    max_length = data_source.Rows[i][target_str].ToString().Length;
                    if (max_length > notice_length && only_once == true)
                    {
                        error_str = data_source.Rows[i][target_str].ToString();
                        only_once = false;
                    }
                }
            }

            if (error_str == null)
            {
                MessageBox.Show(target_str + " 列最长长度为：" + max_length, "提示");
                return true;
            }
            else
            {
                MessageBox.Show(target_str + " 列最长长度为：" + max_length + "。警告！第一个超长的单元格内容为：" + error_str, "提示");
                return false;
            }
        }

        /// <summary>
        /// 按设定的长度裁剪一列，超长部分舍弃
        /// 参数列表：1、要求的列长度；
        /// </summary>
        private void SubColumn(int sub_length)
        {
            for (int i = 0; i < data_source.Rows.Count; i++)
            {
                if (data_source.Rows[i][0].ToString().Length > sub_length)
                    data_source.Rows[i][0] = data_source.Rows[i][0].ToString().Substring(0, sub_length);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data_source;
        }

        #endregion

        //测试按钮
        private void test_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("你确定要添加用户名为：“" + txt_yonghuming.Value + "” 的用户吗？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes

            //string a = "-123456789-123456789-123456789-123456789";
            //string b = null;
            ////b = a.Substring(0,30);
            //b = a.Remove(30);
            //MessageBox.Show("A: " + a + "\nB: " + b);


            DataTable dt = new DataTable();

            dt.Columns.Add("id", typeof(string));
            for (int i = 0; i < 30; i++)
                dt.LoadDataRow(new object[] { "-123456789-123456789" }, true);

            for (int j = 0; j < dt.Rows.Count; j++)
            {
                if (dt.Rows[j][0].ToString().Length > 5)
                    dt.Rows[j][0] = dt.Rows[j][0].ToString().Substring(0, 5);
            }
            
            dataGridView1.DataSource = dt;
        }

        //导入需要更改的文件
        private void buttonDaoru_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                if (filename.IndexOf(".xlsx", filename.Length - 5, 5) == -1)
                {
                    MessageBox.Show("错误：导入的文件非xlsx类型的文件！");
                    return;
                }
                txtDaoru.Text = filename;

                Thread ds_thread = new Thread(new ParameterizedThreadStart(ExcelToDS));  //使用一个线程调用ExcelToDS方法
                ds_thread.IsBackground = true;  //设置为后台线程，关闭主线程后，会自动关闭不会占用系统资源
                ds_thread.Name = "ExcelToDSThread";
                //CheckForIllegalCrossThreadCalls = false;  //为从不是创建控件的线程访问，关闭非法线程交叉调用检查，这不是标准做法！
                ds_thread.Start(filename);
            }
        }

        //删除无用列
        private void deleteUnusedColumns_1_Click(object sender, EventArgs e)
        {
            if (data_source != null)
            {
                data_source.Columns.Remove("物资类别名称(0)");  //设置要删除的列名
                data_source.Columns.Remove("结存时间(6)");
                data_source.Columns.Remove("库管员(7)");
                data_source.Columns.Remove("零件类别(8)");
                data_source.Columns.Remove("库位(9)");
                data_source.Columns.Remove("标准包装(10)");
                data_source.Columns.Remove("标准包装单位(11)");
                data_source.Columns.Remove("有效期(12)");

                dataGridView1.DataSource = null;  //没有这一行，dataGridView的列在重新导入时，将无法恢复，每次给DataSource修改数据时最好都写上
                dataGridView1.DataSource = data_source;
            }
            else
                MessageBox.Show("请先导入库存日报表文件！");
        }

        //更名与排序
        private void renameSort_1_Click(object sender, EventArgs e)
        {
            data_source.Rows[0]["零件编号(1)"] = "零件图号";
            data_source.Rows[0]["供应商编号(3)"] = "厂家代码";
            data_source.Rows[0]["供应商名称(4)"] = "厂家名称";
            data_source.Rows[0]["库存(5)"] = "数量";
        }

        //零件图号(mid)
        private void partNumberMid_1_Click(object sender, EventArgs e)
        {
            int overlength_length = 30;  //此处设定列超长时的长度，查找关键字：参数

            if (GetMaxLength("零件编号(1)", overlength_length) == false)
                SubColumn(overlength_length);
        }
    }
}
