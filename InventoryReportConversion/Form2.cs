using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryReportConversion
{
    public partial class Form2 : Form
    {
        private string old_time = null;
        private string new_time = null;

        public string OldTime
        {
            set { old_time = value; }
            get { return old_time; }
        }

        public string NewTime
        {
            set { new_time = value; }
            get { return new_time; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            oldTime.Text = this.OldTime;
            newTime.Text = this.NewTime;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.NewTime = newTime.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
