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
    public partial class kt : Form
    {

        static SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-BF5FKOU\MSSQLSERVER1; Initial Catalog = saglikocak; Trusted_Connection=True");
        public kt()
        {
            InitializeComponent();
           
        }

        private void kt_Load(object sender, EventArgs e)
        {
            textBox1.Text = kullanıcıtanıtma.kullanicikodu;
            baglanti.Open();
            string sql = "select şifre,username,ad,soyad,yetki,evtel," +
                "ceptel,adres,unvan,isebaslama,maas,dogumyeri," +
                "annead,babaad,cinsiyet,kangrubu,medenihal,dogumtarihi," +
                "tckimlikno from kullanici where kodu=@kodu";
            SqlParameter prm1 = new SqlParameter("kodu",textBox1.Text);
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add(prm1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               
                textBox2.Text = dr["tckimlikno"].ToString();
                textBox3.Text = dr["dogumyeri"].ToString();
                textBox4.Text = dr["babaad"].ToString();
                textBox5.Text = dr["annead"].ToString();
                textBox6.Text = dr["ceptel"].ToString();
                textBox8.Text = dr["ad"].ToString();
                textBox9.Text = dr["soyad"].ToString();
                textBox10.Text = dr["maas"].ToString();
                textBox13.Text = dr["şifre"].ToString();
                textBox12.Text = dr["username"].ToString();
                comboBox2.Text = dr["cinsiyet"].ToString();
                comboBox3.Text = dr["medenihal"].ToString();
                comboBox4.Text = dr["kangrubu"].ToString();
                textBox15.Text = dr["dogumyeri"].ToString();

                

            }
            

            dr.Close();
            baglanti.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //temizle butonu
        {
             void ClearAll(Control ctl)
            {
                foreach (Control c in ctl.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                    if (c.Controls.Count > 0)
                    {
                        ClearAll(c);
                    }
                }
            }
            ClearAll(this);
        }

        private void kt_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           baglanti.Open();
            string sql = "update kullanici set " +
                " ad=@ad," +
                " soyad=@soyad," +
                " maas=@maas," +
                " şifre=@şifre," +
                " annead=@annead," +
                " tckimlikno=@tckimlikno," +
                " username=@username," +
                " babaad=@babaad," +
                " unvan=@unvan," +
                " isebaslama=@isebaslama, " +
                " adres=@adres," +
                " medenihal=@medenihal," +
                " dogumyeri=@dogumyeri," +
                " ceptel=@ceptel," +
                " cinsiyet =@cinsiyet," +
                " dogumtarihi=@dogumtarihi," +
                " kangrubu=@kangrubu" +
                " where kodu=@kodu";
               

            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@kodu", textBox1.Text);
            komut.Parameters.AddWithValue("@ad", textBox8.Text);
            komut.Parameters.AddWithValue("@soyad", textBox9.Text);
            komut.Parameters.AddWithValue("@tckimlikno", textBox2.Text);
            komut.Parameters.AddWithValue("@şifre", textBox13.Text);
            komut.Parameters.AddWithValue("@username", textBox12.Text);
            komut.Parameters.AddWithValue("@maas", textBox10.Text);
            komut.Parameters.AddWithValue("@babaad", textBox4.Text);
            komut.Parameters.AddWithValue("@annead", textBox5.Text);
            komut.Parameters.AddWithValue("@ceptel", textBox6.Text);
            komut.Parameters.AddWithValue("@adres", textBox11.Text);
            komut.Parameters.AddWithValue("@unvan", comboBox1.Text);
            komut.Parameters.AddWithValue("@isebaslama", textBox14.Text);
            komut.Parameters.AddWithValue("@dogumyeri", textBox3.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboBox2.Text);
            komut.Parameters.AddWithValue("@kangrubu", comboBox4.Text);
            komut.Parameters.AddWithValue("@dogumtarihi", textBox15.Text);
            komut.Parameters.AddWithValue("@medenihal", comboBox3.Text);



            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(textBox1.Text + "adlı kişi güncellendi");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "delete kullanici where kodu=@kodu";

            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@kodu", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(textBox1.Text + " adlı kodlu kullanıcı silindi");
            this.Close();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void kt_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ResetText();
            this.Close();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
