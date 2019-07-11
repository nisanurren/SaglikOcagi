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

namespace Sağlık_OCağı_Hasta_Takip_Sistemi
{
    public partial class Poliklinik : Form
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-BF5FKOU\MSSQLSERVER1; Initial Catalog = saglikocak; Trusted_Connection=True");

        public Poliklinik()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Poliklinik_Load(object sender, EventArgs e)
        {
           
            textBox1.Text = polikliniktanıtma.poliklinikadi;
           
            baglanti.Open();
            String sql = "select durum,aciklama from poliklinik where poliklinikadi=@poliklinikadi";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlParameter prm1 = new SqlParameter("poliklinikadi", textBox1.Text);
            komut.Parameters.Add(prm1);
            


           
            SqlDataReader dr = komut.ExecuteReader();


            while (dr.Read())
            {            
            if (dr["durum"].ToString() == "1")
            {
                checkBox1.Checked= true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            textBox2.Text = dr["aciklama"].ToString();
            }
            baglanti.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string durum;
            string aciklama = textBox2.Text;
            baglanti.Open();
            if (checkBox1.Checked)
            {
                durum ="1";
            }
            else
            {
                durum = "0";
            }
            string sql = "update poliklinik set aciklama=@aciklama,durum=@durum" +
                         " where poliklinikadi=@poliklinikadi";
           
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@poliklinikadi", textBox1.Text);
            komut.Parameters.AddWithValue("@aciklama", textBox2.Text);
            komut.Parameters.AddWithValue("@durum", durum);
            komut.ExecuteNonQuery();
            MessageBox.Show(textBox1.Text + "adlı poliklinik güncellendi");

            baglanti.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "delete poliklinik where poliklinikadi=@poliklinikadi";

            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@poliklinikadi", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(textBox1.Text+" adlı poliklinik silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
