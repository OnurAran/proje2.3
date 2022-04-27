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
    public partial class hesapAcmaMusteri : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T43E7P1;Initial Catalog=prolab;Integrated Security=True");

        

        public hesapAcmaMusteri()
        {
            InitializeComponent();
        }

        private void hesapAcButton_Click(object sender, EventArgs e)
        {
            if (sifreText1 != null && isimText1 != null && soyisimText1 != null && telefonText1 != null && adresText1 != null)
            {



                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into TBLCONSUMER (SIFRE, ISIM, SOYISIM, TELEFON, ADRES)" +
                    "VALUES('" + (sifreText1.Text).ToString() + "','" + isimText1.Text + "','" + soyisimText1.Text + "','" + (telefonText1.Text).ToString() + "','" + adresText1.Text + "')";

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesap Acildi." , "Basarili.");
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message.ToString(), "Error Message");
                }

            }
        }

        private void hesapSilButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLCONSUMERMONEYTableAdapter dt = new DataSet1TableAdapters.TBLCONSUMERMONEYTableAdapter();
            DataSet1TableAdapters.DELETECONSUMERTableAdapter deleteTable = new DataSet1TableAdapters.DELETECONSUMERTableAdapter();

            


            if (Convert.ToInt32(dt.GetConsumerMoney(Form1.musteriNo))==0)
            {
                deleteTable.DeleteQuery(Form1.musteriNo);
                deleteTable.DeleteMoney(Form1.musteriNo);
                MessageBox.Show("Hesap Silme Basarili..", "Bilgilendirme");

                Form1 newForm1 = new Form1();
                this.Close();
                newForm1.Show();
            }
            else
            {
                MessageBox.Show("Silmek İstenilen Hesabın Bakiyesi Bulunmaktadır.", "Hata!");
            }
            connection.Close();


        }

        private void hesabiGosterButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLCONSUMERTableAdapter dt = new DataSet1TableAdapters.TBLCONSUMERTableAdapter();

            dataGridView1.DataSource = dt.GetData();

        }

        private void hesapGuncelleButton_Click(object sender, EventArgs e)
        {

            DataSet1TableAdapters.TBLCONSUMERTableAdapter dt = new DataSet1TableAdapters.TBLCONSUMERTableAdapter();


            if (guncelleSifre.Text.Equals(""))
            {
                guncelleSifre.Text = (dt.FillBySifre(Form1.musteriNo)).ToString();
            }
            if (guncelleisim.Text.Equals(""))
            {
                guncelleisim.Text = (dt.FillByisim(Form1.musteriNo)).ToString();
            }
            if (guncelleSoyisim.Text.Equals(""))
            {
                guncelleSoyisim.Text = (dt.FillBySoyisim(Form1.musteriNo)).ToString();
            }
            if (guncelleTelefon.Text.Equals(""))
            {
                guncelleTelefon.Text = (dt.FillByTelefon(Form1.musteriNo)).ToString();
            }
            if (guncelleAdres.Text.Equals(""))
            {
                guncelleAdres.Text = (dt.FillByAdres(Form1.musteriNo)).ToString();
            }



            dt.UpdateQuery(guncelleSifre.Text, guncelleisim.Text, guncelleSoyisim.Text, guncelleTelefon.Text, guncelleAdres.Text, Form1.musteriNo, Form1.musteriNo);

        }
    }
}
