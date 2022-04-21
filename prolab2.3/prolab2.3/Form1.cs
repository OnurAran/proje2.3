using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2._3
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T43E7P1;Initial Catalog=prolab;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '•';

        }

        private void musteriButton_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;

            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLUSER where id=@V1 AND sifre =@V2", connection);
            komut.Parameters.AddWithValue("@V1", textBox1.Text);
            komut.Parameters.AddWithValue("@V2", textBox2.Text);
            string kullanici = textBox1.Text;
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giris basarili..", "Bilgilendirme");
                musteriArayuzu musteriArayuzu = new musteriArayuzu();
                this.Hide();
                musteriArayuzu.Show();
            }
            else
            {
                MessageBox.Show("Girdiginiz degerlere karsilik bir kullanici bulunamadi..", "Giriste Hata");
            }
            connection.Close();

        }

        private void temsilciButton_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;

            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLUSER where id=@V1 AND sifre =@V2", connection);
            komut.Parameters.AddWithValue("@V1", textBox1.Text);
            komut.Parameters.AddWithValue("@V2", textBox2.Text);
            string kullanici = textBox1.Text;
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giris basarili..", "Bilgilendirme");
                temsilciArayuzu temsilciArayuzu = new temsilciArayuzu();
                this.Hide();
                temsilciArayuzu.Show();
            }
            else
            {
                MessageBox.Show("Girdiginiz degerlere karsilik bir kullanici bulunamadi..", "Giriste Hata");
            }
            connection.Close();
        }

        private void mudurButton_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;

            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLUSER where id=@V1 AND sifre =@V2", connection);
            komut.Parameters.AddWithValue("@V1", textBox1.Text);
            komut.Parameters.AddWithValue("@V2", textBox2.Text);
            string kullanici = textBox1.Text;
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giris basarili..", "Bilgilendirme");
                mudurArayuzu mudurArayuzu = new mudurArayuzu();
                this.Hide();
                mudurArayuzu.Show();
            }
            else
            {
                MessageBox.Show("Girdiginiz degerlere karsilik bir kullanici bulunamadi..", "Giriste Hata");
            }
            connection.Close();
            
        }

    }
}
