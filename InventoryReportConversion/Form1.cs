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
        private DataSet data_souce = null;  //要处理的表放在这里，程序中最重要的变量

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

        //用于跨线程将数据表传递到dataGridView中
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
                this.dataGridView1.DataSource = dt;
            }
        }

        //把EXCEL转换成一个数据源来进行数据的 读取 操作
        public void ExcelToDS(object Path)
        {
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
            data_souce = new DataSet();
            myCommand.Fill(data_souce, "table1");
            conn.Close();
            //dataGridView1.DataSource = data_souce.Tables[0];  //将跨线程传递数据的代码换成使用委托
            SetDT(data_souce.Tables[0]);
            /*进度条*/this.progressBar1.BeginInvoke((Action)delegate { this.progressBar1.Visible = false; });
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

        private void deleteUnusedColumns_Click(object sender, EventArgs e)
        {

        }
    }
}
