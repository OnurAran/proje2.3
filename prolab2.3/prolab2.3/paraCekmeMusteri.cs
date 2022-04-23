using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prolab2._3
{
    public partial class paraCekmeMusteri : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T43E7P1;Initial Catalog=prolab;Integrated Security=True");
        Form1 newForm1 = new Form1();
        public paraCekmeMusteri()
        {
            InitializeComponent();


            

        }

        DataSet1TableAdapters.TBLCONSUMERMONEYTableAdapter dt = new DataSet1TableAdapters.TBLCONSUMERMONEYTableAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.GetData();
        }

        private void paraCekButton_Click(object sender, EventArgs e)
        {
            int yeniBakiye;
            int bakiye;

            connection.Open();

            //MessageBox.Show((dt.GetConsumerMoney(newForm1.musteriNo)).ToString());

            bakiye = Convert.ToInt32(dt.GetMoneyWhereNumber(newForm1.musteriNo));

            yeniBakiye = bakiye - Convert.ToInt32(textBox1.Text);

            dt.UpdateQuery(yeniBakiye,newForm1.musteriNo);
                
        }
    }
}
