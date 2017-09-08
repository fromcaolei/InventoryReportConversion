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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time_3 = new System.Windows.Forms.Button();
            this.CustomerNumber_3 = new System.Windows.Forms.Button();
            this.receiveCustomerNumber_3 = new System.Windows.Forms.Button();
            this.manufacturerCodeMid_3 = new System.Windows.Forms.Button();
            this.partNumberMid_3 = new System.Windows.Forms.Button();
            this.renameSort_3 = new System.Windows.Forms.Button();
            this.deleteUnusedColumns_3 = new System.Windows.Forms.Button();
            this.time_2 = new System.Windows.Forms.Button();
            this.orderNumber_2 = new System.Windows.Forms.Button();
            this.manufacturerCodeMid_2 = new System.Windows.Forms.Button();
            this.partNumberMid_2 = new System.Windows.Forms.Button();
            this.renameSort_2 = new System.Windows.Forms.Button();
            this.deleteUnusedColumns_2 = new System.Windows.Forms.Button();
            this.manufacturerCodeMid_1 = new System.Windows.Forms.Button();
            this.environmentalDetection = new System.Windows.Forms.Button();
            this.partNumberMid_1 = new System.Windows.Forms.Button();
            this.renameSort_1 = new System.Windows.Forms.Button();
            this.deleteUnusedColumns_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.importFile = new System.Windows.Forms.Button();
            this.txtDaoru = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numberRows = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.exportFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.panel1.Controls.Add(this.time_3);
            this.panel1.Controls.Add(this.CustomerNumber_3);
            this.panel1.Controls.Add(this.receiveCustomerNumber_3);
            this.panel1.Controls.Add(this.manufacturerCodeMid_3);
            this.panel1.Controls.Add(this.partNumberMid_3);
            this.panel1.Controls.Add(this.renameSort_3);
            this.panel1.Controls.Add(this.deleteUnusedColumns_3);
            this.panel1.Controls.Add(this.time_2);
            this.panel1.Controls.Add(this.orderNumber_2);
            this.panel1.Controls.Add(this.manufacturerCodeMid_2);
            this.panel1.Controls.Add(this.partNumberMid_2);
            this.panel1.Controls.Add(this.renameSort_2);
            this.panel1.Controls.Add(this.deleteUnusedColumns_2);
            this.panel1.Controls.Add(this.manufacturerCodeMid_1);
            this.panel1.Controls.Add(this.environmentalDetection);
            this.panel1.Controls.Add(this.partNumberMid_1);
            this.panel1.Controls.Add(this.renameSort_1);
            this.panel1.Controls.Add(this.deleteUnusedColumns_1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.importFile);
            this.panel1.Controls.Add(this.txtDaoru);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 134);
            this.panel1.TabIndex = 0;
            // 
            // time_3
            // 
            this.time_3.Location = new System.Drawing.Point(752, 99);
            this.time_3.Name = "time_3";
            this.time_3.Size = new System.Drawing.Size(100, 23);
            this.time_3.TabIndex = 22;
            this.time_3.Text = "DATE(DATE)";
            this.time_3.UseVisualStyleBackColor = true;
            this.time_3.Click += new System.EventHandler(this.time_3_Click);
            // 
            // CustomerNumber_3
            // 
            this.CustomerNumber_3.Location = new System.Drawing.Point(646, 99);
            this.CustomerNumber_3.Name = "CustomerNumber_3";
            this.CustomerNumber_3.Size = new System.Drawing.Size(100, 23);
            this.CustomerNumber_3.TabIndex = 21;
            this.CustomerNumber_3.Text = "PO_NO(mid)";
            this.CustomerNumber_3.UseVisualStyleBackColor = true;
            this.CustomerNumber_3.Click += new System.EventHandler(this.CustomerNumber_3_Click);
            // 
            // receiveCustomerNumber_3
            // 
            this.receiveCustomerNumber_3.Location = new System.Drawing.Point(540, 99);
            this.receiveCustomerNumber_3.Name = "receiveCustomerNumber_3";
            this.receiveCustomerNumber_3.Size = new System.Drawing.Size(100, 23);
            this.receiveCustomerNumber_3.TabIndex = 20;
            this.receiveCustomerNumber_3.Text = "入库单号(mid)";
            this.receiveCustomerNumber_3.UseVisualStyleBackColor = true;
            this.receiveCustomerNumber_3.Click += new System.EventHandler(this.receiveCustomerNumber_3_Click);
            // 
            // manufacturerCodeMid_3
            // 
            this.manufacturerCodeMid_3.Location = new System.Drawing.Point(434, 99);
            this.manufacturerCodeMid_3.Name = "manufacturerCodeMid_3";
            this.manufacturerCodeMid_3.Size = new System.Drawing.Size(100, 23);
            this.manufacturerCodeMid_3.TabIndex = 19;
            this.manufacturerCodeMid_3.Text = "厂家代码(mid)";
            this.manufacturerCodeMid_3.UseVisualStyleBackColor = true;
            this.manufacturerCodeMid_3.Click += new System.EventHandler(this.manufacturerCodeMid_3_Click);
            // 
            // partNumberMid_3
            // 
            this.partNumberMid_3.Location = new System.Drawing.Point(328, 99);
            this.partNumberMid_3.Name = "partNumberMid_3";
            this.partNumberMid_3.Size = new System.Drawing.Size(100, 23);
            this.partNumberMid_3.TabIndex = 18;
            this.partNumberMid_3.Text = "零件图号(mid)";
            this.partNumberMid_3.UseVisualStyleBackColor = true;
            this.partNumberMid_3.Click += new System.EventHandler(this.partNumberMid_3_Click);
            // 
            // renameSort_3
            // 
            this.renameSort_3.Location = new System.Drawing.Point(222, 99);
            this.renameSort_3.Name = "renameSort_3";
            this.renameSort_3.Size = new System.Drawing.Size(100, 23);
            this.renameSort_3.TabIndex = 17;
            this.renameSort_3.Text = "更名与排序";
            this.renameSort_3.UseVisualStyleBackColor = true;
            this.renameSort_3.Click += new System.EventHandler(this.renameSort_3_Click);
            // 
            // deleteUnusedColumns_3
            // 
            this.deleteUnusedColumns_3.Location = new System.Drawing.Point(116, 99);
            this.deleteUnusedColumns_3.Name = "deleteUnusedColumns_3";
            this.deleteUnusedColumns_3.Size = new System.Drawing.Size(100, 23);
            this.deleteUnusedColumns_3.TabIndex = 16;
            this.deleteUnusedColumns_3.Text = "删除无用列";
            this.deleteUnusedColumns_3.UseVisualStyleBackColor = true;
            this.deleteUnusedColumns_3.Click += new System.EventHandler(this.deleteUnusedColumns_3_Click);
            // 
            // time_2
            // 
            this.time_2.Location = new System.Drawing.Point(646, 67);
            this.time_2.Name = "time_2";
            this.time_2.Size = new System.Drawing.Size(100, 23);
            this.time_2.TabIndex = 15;
            this.time_2.Text = "时间(DATE)";
            this.time_2.UseVisualStyleBackColor = true;
            this.time_2.Click += new System.EventHandler(this.time_2_Click);
            // 
            // orderNumber_2
            // 
            this.orderNumber_2.Location = new System.Drawing.Point(540, 67);
            this.orderNumber_2.Name = "orderNumber_2";
            this.orderNumber_2.Size = new System.Drawing.Size(100, 23);
            this.orderNumber_2.TabIndex = 14;
            this.orderNumber_2.Text = "订单号(mid)";
            this.orderNumber_2.UseVisualStyleBackColor = true;
            this.orderNumber_2.Click += new System.EventHandler(this.orderNumber_2_Click);
            // 
            // manufacturerCodeMid_2
            // 
            this.manufacturerCodeMid_2.Location = new System.Drawing.Point(434, 67);
            this.manufacturerCodeMid_2.Name = "manufacturerCodeMid_2";
            this.manufacturerCodeMid_2.Size = new System.Drawing.Size(100, 23);
            this.manufacturerCodeMid_2.TabIndex = 13;
            this.manufacturerCodeMid_2.Text = "厂家代码(mid)";
            this.manufacturerCodeMid_2.UseVisualStyleBackColor = true;
            this.manufacturerCodeMid_2.Click += new System.EventHandler(this.manufacturerCodeMid_2_Click);
            // 
            // partNumberMid_2
            // 
            this.partNumberMid_2.Location = new System.Drawing.Point(328, 67);
            this.partNumberMid_2.Name = "partNumberMid_2";
            this.partNumberMid_2.Size = new System.Drawing.Size(100, 23);
            this.partNumberMid_2.TabIndex = 12;
            this.partNumberMid_2.Text = "零件图号(mid)";
            this.partNumberMid_2.UseVisualStyleBackColor = true;
            this.partNumberMid_2.Click += new System.EventHandler(this.partNumberMid_2_Click);
            // 
            // renameSort_2
            // 
            this.renameSort_2.Location = new System.Drawing.Point(222, 67);
            this.renameSort_2.Name = "renameSort_2";
            this.renameSort_2.Size = new System.Drawing.Size(100, 23);
            this.renameSort_2.TabIndex = 11;
            this.renameSort_2.Text = "更名与排序";
            this.renameSort_2.UseVisualStyleBackColor = true;
            this.renameSort_2.Click += new System.EventHandler(this.renameSort_2_Click);
            // 
            // deleteUnusedColumns_2
            // 
            this.deleteUnusedColumns_2.Location = new System.Drawing.Point(116, 67);
            this.deleteUnusedColumns_2.Name = "deleteUnusedColumns_2";
            this.deleteUnusedColumns_2.Size = new System.Drawing.Size(100, 23);
            this.deleteUnusedColumns_2.TabIndex = 10;
            this.deleteUnusedColumns_2.Text = "删除无用列";
            this.deleteUnusedColumns_2.UseVisualStyleBackColor = true;
            this.deleteUnusedColumns_2.Click += new System.EventHandler(this.deleteUnusedColumns_2_Click);
            // 
            // manufacturerCodeMid_1
            // 
            this.manufacturerCodeMid_1.Location = new System.Drawing.Point(434, 35);
            this.manufacturerCodeMid_1.Name = "manufacturerCodeMid_1";
            this.manufacturerCodeMid_1.Size = new System.Drawing.Size(100, 23);
            this.manufacturerCodeMid_1.TabIndex = 9;
            this.manufacturerCodeMid_1.Text = "厂家代码(mid)";
            this.manufacturerCodeMid_1.UseVisualStyleBackColor = true;
            this.manufacturerCodeMid_1.Click += new System.EventHandler(this.manufacturerCodeMid_1_Click);
            // 
            // environmentalDetection
            // 
            this.environmentalDetection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.environmentalDetection.Location = new System.Drawing.Point(745, 7);
            this.environmentalDetection.Name = "environmentalDetection";
            this.environmentalDetection.Size = new System.Drawing.Size(75, 23);
            this.environmentalDetection.TabIndex = 8;
            this.environmentalDetection.Text = "环境检测";
            this.environmentalDetection.UseVisualStyleBackColor = true;
            this.environmentalDetection.Click += new System.EventHandler(this.environmentalDetection_Click);
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
            // importFile
            // 
            this.importFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.importFile.Location = new System.Drawing.Point(626, 7);
            this.importFile.Name = "importFile";
            this.importFile.Size = new System.Drawing.Size(75, 23);
            this.importFile.TabIndex = 1;
            this.importFile.Text = "导入文件";
            this.importFile.UseVisualStyleBackColor = true;
            this.importFile.Click += new System.EventHandler(this.importFile_Click);
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
            this.panel3.Controls.Add(this.numberRows);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.exportFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 569);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 34);
            this.panel3.TabIndex = 2;
            // 
            // numberRows
            // 
            this.numberRows.AutoSize = true;
            this.numberRows.Location = new System.Drawing.Point(9, 8);
            this.numberRows.Name = "numberRows";
            this.numberRows.Size = new System.Drawing.Size(29, 12);
            this.numberRows.TabIndex = 1;
            this.numberRows.Text = "行数";
            this.numberRows.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(854, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(148, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // exportFile
            // 
            this.exportFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportFile.Location = new System.Drawing.Point(488, 3);
            this.exportFile.Name = "exportFile";
            this.exportFile.Size = new System.Drawing.Size(75, 23);
            this.exportFile.TabIndex = 0;
            this.exportFile.Text = "导出文件";
            this.exportFile.UseVisualStyleBackColor = true;
            this.exportFile.Click += new System.EventHandler(this.exportFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 606);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button importFile;
        private System.Windows.Forms.TextBox txtDaoru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exportFile;
        private System.Windows.Forms.Button deleteUnusedColumns_1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button renameSort_1;
        private System.Windows.Forms.Button partNumberMid_1;
        private System.Windows.Forms.Button environmentalDetection;
        private System.Windows.Forms.Button manufacturerCodeMid_1;
        private System.Windows.Forms.Button deleteUnusedColumns_2;
        private System.Windows.Forms.Button renameSort_2;
        private System.Windows.Forms.Button orderNumber_2;
        private System.Windows.Forms.Button manufacturerCodeMid_2;
        private System.Windows.Forms.Button partNumberMid_2;
        private System.Windows.Forms.Button time_2;
        private System.Windows.Forms.Button time_3;
        private System.Windows.Forms.Button CustomerNumber_3;
        private System.Windows.Forms.Button receiveCustomerNumber_3;
        private System.Windows.Forms.Button manufacturerCodeMid_3;
        private System.Windows.Forms.Button partNumberMid_3;
        private System.Windows.Forms.Button renameSort_3;
        private System.Windows.Forms.Button deleteUnusedColumns_3;
        private System.Windows.Forms.Label numberRows;
    }
}

