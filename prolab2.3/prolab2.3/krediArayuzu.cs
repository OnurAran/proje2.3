using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prolab2._3
{
    public partial class krediArayuzu : Form
    {
        public krediArayuzu()
        {
            InitializeComponent();
        }

        private void talepEtButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bankanızın Talebinizi Kabul Etmesi Halinde Size Uyarı Gelecektir.","Bilgi!");
        }
    }
}
