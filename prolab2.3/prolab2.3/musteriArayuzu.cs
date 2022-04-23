using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prolab2._3
{
    public partial class musteriArayuzu : Form
    {


        public musteriArayuzu()
        {
            InitializeComponent();

            
        }

        private void paraCekmeButton_Click(object sender, EventArgs e)
        {
            paraCekmeMusteri paraCekmeMusteri = new paraCekmeMusteri();
            this.Hide();
            paraCekmeMusteri.Show();
        }
    }
}
