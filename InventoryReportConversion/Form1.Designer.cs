namespace InventoryReportConversion
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partNumberMid_1 = new System.Windows.Forms.Button();
            this.renameSort_1 = new System.Windows.Forms.Button();
            this.deleteUnusedColumns_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDaoru = new System.Windows.Forms.Button();
            this.txtDaoru = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.test = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 606);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.partNumberMid_1);
            this.panel1.Controls.Add(this.renameSort_1);
            this.panel1.Controls.Add(this.deleteUnusedColumns_1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonDaoru);
            this.panel1.Controls.Add(this.txtDaoru);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 134);
            this.panel1.TabIndex = 0;
            // 
            // partNumberMid_1
            // 
            this.partNumberMid_1.Location = new System.Drawing.Point(328, 35);
            this.partNumberMid_1.Name = "partNumberMid_1";
            this.partNumberMid_1.Size = new System.Drawing.Size(100, 23);
            this.partNumberMid_1.TabIndex = 7;
            this.partNumberMid_1.Text = "零件图号(mid)";
            this.partNumberMid_1.UseVisualStyleBackColor = true;
            this.partNumberMid_1.Click += new System.EventHandler(this.partNumberMid_1_Click);
            // 
            // renameSort_1
            // 
            this.renameSort_1.Location = new System.Drawing.Point(222, 35);
            this.renameSort_1.Name = "renameSort_1";
            this.renameSort_1.Size = new System.Drawing.Size(100, 23);
            this.renameSort_1.TabIndex = 6;
            this.renameSort_1.Text = "更名与排序";
            this.renameSort_1.UseVisualStyleBackColor = true;
            this.renameSort_1.Click += new System.EventHandler(this.renameSort_1_Click);
            // 
            // deleteUnusedColumns_1
            // 
            this.deleteUnusedColumns_1.Location = new System.Drawing.Point(116, 35);
            this.deleteUnusedColumns_1.Name = "deleteUnusedColumns_1";
            this.deleteUnusedColumns_1.Size = new System.Drawing.Size(100, 23);
            this.deleteUnusedColumns_1.TabIndex = 5;
            this.deleteUnusedColumns_1.Text = "删除无用列";
            this.deleteUnusedColumns_1.UseVisualStyleBackColor = true;
            this.deleteUnusedColumns_1.Click += new System.EventHandler(this.deleteUnusedColumns_1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "入库明细处理：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "出库明细处理：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "库存日报表处理：";
            // 
            // buttonDaoru
            // 
            this.buttonDaoru.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDaoru.Location = new System.Drawing.Point(626, 7);
            this.buttonDaoru.Name = "buttonDaoru";
            this.buttonDaoru.Size = new System.Drawing.Size(75, 23);
            this.buttonDaoru.TabIndex = 1;
            this.buttonDaoru.Text = "导入文件";
            this.buttonDaoru.UseVisualStyleBackColor = true;
            this.buttonDaoru.Click += new System.EventHandler(this.buttonDaoru_Click);
            // 
            // txtDaoru
            // 
            this.txtDaoru.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDaoru.Location = new System.Drawing.Point(350, 9);
            this.txtDaoru.Name = "txtDaoru";
            this.txtDaoru.ReadOnly = true;
            this.txtDaoru.Size = new System.Drawing.Size(270, 21);
            this.txtDaoru.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 420);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 569);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 34);
            this.panel3.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(148, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(488, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "导出文件";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(745, 7);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 8;
            this.test.Text = "测试功能";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 606);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存日报表数据格式转换";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDaoru;
        private System.Windows.Forms.TextBox txtDaoru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteUnusedColumns_1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button renameSort_1;
        private System.Windows.Forms.Button partNumberMid_1;
        private System.Windows.Forms.Button test;
    }
}

