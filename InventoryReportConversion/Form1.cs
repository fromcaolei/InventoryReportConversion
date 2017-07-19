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
        private string filename = "Untitled";
        private DataSet data_souce;
        Thread t1;

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
            t1 = new Thread(new ParameterizedThreadStart(ExcelToDS));
            t1.IsBackground = true;  //设置为后台线程，关闭主线程后，会自动关闭不会占用系统资源
            //CheckForIllegalCrossThreadCalls = false;  //为从不是创建控件的线程访问，关闭非法线程交叉调用检查，这不是标准做法！
        }

        //把EXCEL文件当做一个数据源来进行数据的读取操作
        public void ExcelToDS(object Path)
        {
            //string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";
            //string strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + Path + ";Extended Properties='Excel 8.0; HDR=NO; IMEX=1'"; //此连接只能操作Excel2007之前(.xls)文件
            string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + (string)Path + ";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'";  //此连接可以操作.xls与.xlsx文件
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            strExcel = "select * from [sheet1$]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");
            data_souce = ds;
            dataGridView1.DataSource = data_souce.Tables[0];
        }

        //先导入需要更改的文件
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

                //object a = filename as object;
                t1.Start(filename);

                //ExcelToDS(filename);
                //dataGridView1.DataSource = data_souce.Tables[0];
            }
        }
    }
}
