using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prolab2._3
{
    public partial class aylikOzetGoruntuleme : Form
    {

        DataSet1TableAdapters.TBLCONSUMERCREDITableAdapter dt = new DataSet1TableAdapters.TBLCONSUMERCREDITableAdapter();

        public aylikOzetGoruntuleme()
        {
            InitializeComponent();
        }

        private void borcGosterButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.GetData();
        }
    }
}
