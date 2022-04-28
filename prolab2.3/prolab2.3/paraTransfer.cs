using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prolab2._3
{
    public partial class paraTransfer : Form
    {
        string kaynakBakiye;
        string hedefBakiye;

        public paraTransfer()
        {
            InitializeComponent();
            comboBox1.Items.Add("TL");
            comboBox1.Items.Add("Dolar");
            comboBox1.Items.Add("Euro");
        }

        private void paraGonderButton_Click(object sender, EventArgs e)
        {

            if(comboBox1.Text.Equals("TL"))
            {
                
            }
            else if (comboBox1.Text.Equals("Dolar"))
            {
                textBox2.Text = (Convert.ToInt32(textBox2.Text) * Form1.DolarKuru).ToString();
            }
            else if (comboBox1.Text.Equals("Euro"))
            {
                textBox2.Text = (Convert.ToInt32(textBox2.Text) * Form1.EuroKuru).ToString();
            }

            DataSet1TableAdapters.TBLCONSUMERMONEYTableAdapter dt = new DataSet1TableAdapters.TBLCONSUMERMONEYTableAdapter();

            kaynakBakiye = (dt.GetConsumerMoney(Form1.musteriNo)).ToString();
            hedefBakiye = (dt.GetConsumerMoney(Convert.ToInt32(textBox1.Text))).ToString();


            if((Convert.ToInt32(kaynakBakiye) - Convert.ToInt32(textBox2.Text))<0)
            {
                MessageBox.Show("Yetersiz Bakiyeniz Olduğu İçin Transfer Gerçekleştirilemedi.", "Hata!");
            }
            else
            {
                kaynakBakiye = (Convert.ToInt32(kaynakBakiye) - Convert.ToInt32(textBox2.Text)).ToString();
                hedefBakiye = (Convert.ToInt32(hedefBakiye) + Convert.ToInt32(textBox2.Text)).ToString();

                dt.UpdateQuery(Convert.ToInt32(kaynakBakiye),Form1.musteriNo);
                dt.UpdateQuery(Convert.ToInt32(hedefBakiye), Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Para Transferi İşlemi Başarılı.","Gönderim Başarılı!");

            }


            


        }
    }
}
