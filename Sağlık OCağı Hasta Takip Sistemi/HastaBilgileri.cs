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
    public partial class HastaBilgileri : Form
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-BF5FKOU\MSSQLSERVER1; Initial Catalog = saglikocak; Trusted_Connection=True");

        public HastaBilgileri()
        {
            InitializeComponent();
        }

        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            this.Name = "<Hasta Bilgileri>";
            textBox1.Text = HastaProcess.dosyano;
            string sql = "select" +
                " tckimlik," +
                " ad," +
                " soyad," +
                " dogumyeri," +
                " dogumtarihi," +
                " babaadi," +
                " anneadi," +
                " cinsiyet," +
                " kangrubu," +
                " medenihal," +
                " adres," +
                " tel," +
                " kurumsicilno," +
                " kurumadi," +
                " yakintel," +
                " yakinkurumsicilno," +
                " yakinkurumadi " +
                " from hasta where dosyano=@dosyano";



            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@dosyano", HastaProcess.dosyano);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text  = dr["ad"].ToString();
                textBox10.Text = dr["tckimlik"].ToString();
                textBox11.Text = dr["soyad"].ToString();
                textBox3.Text  = dr["dogumyeri"].ToString();
                textBox4.Text  = dr["babaadi"].ToString();
                textBox5.Text  = dr["anneadi"].ToString();
                textBox6.Text  = dr["adres"].ToString();
               dateTimePicker1.Value=  Convert.ToDateTime(dr["dogumtarihi"].ToString());
                comboBox2.Text = dr["cinsiyet"].ToString();
                comboBox1.Text = dr["medenihal"].ToString();
                comboBox3.Text = dr["kangrubu"].ToString();
                textBox7.Text  = dr["tel"].ToString();
                textBox8.Text  = dr["kurumsicilno"].ToString();
                textBox9.Text  = dr["kurumadi"].ToString();
                textBox13.Text = dr["yakintel"].ToString();
                textBox14.Text = dr["yakinkurumsicilno"].ToString();
                textBox15.Text = dr["yakinkurumadi"].ToString();

            }
            baglanti.Close();

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
                

            string sql = "update hasta set" +
                " tckimlik=@tckimlik," +
                " ad=@ad," +
                " soyad=@soyad," +
                " dogumyeri=@dogumyeri," +
                " dogumtarihi=@dogumtarihi," +
                " babaadi=@babaadi," +
                " anneadi=@anneadi," +
                " cinsiyet=@cinsiyet," +
                " kangrubu=@kangrubu," +
                " medenihal=@medenihal," +
                " adres=@adres," +
                " tel=@tel," +
                " kurumsicilno=@kurumsicilno," +
                " kurumadi=@kurumadi," +
                " yakintel=@yakintel," +
                " yakinkurumsicilno=yakinkurumsicilno," +
                " yakinkurumadi=@yakinkurumadi  " +
                " where " +
                " dosyano=@dosyano";


            textBox1.Text = HastaProcess.dosyano;

            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("dosyano", textBox1.Text);
            komut.Parameters.AddWithValue("ad", textBox2.Text);
            komut.Parameters.AddWithValue("soyad", textBox11.Text);
            komut.Parameters.AddWithValue("tckimlik", textBox10.Text);
            komut.Parameters.AddWithValue("dogumyeri", textBox3.Text);
            komut.Parameters.AddWithValue("dogumtarihi",Convert.ToDateTime(dateTimePicker1.Value));
            komut.Parameters.AddWithValue("babaadi", textBox4.Text);
            komut.Parameters.AddWithValue("anneadi", textBox5.Text);
            komut.Parameters.AddWithValue("cinsiyet", comboBox2.SelectedItem);
            komut.Parameters.AddWithValue("kangrubu", comboBox3.SelectedItem);
            komut.Parameters.AddWithValue("medenihal", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("adres", textBox6.Text);
            komut.Parameters.AddWithValue("tel", textBox7.Text);
            komut.Parameters.AddWithValue("kurumsicilno", textBox8.Text);
            komut.Parameters.AddWithValue("kurumadi", textBox9.Text);
            komut.Parameters.AddWithValue("yakintel", textBox13.Text);
            komut.Parameters.AddWithValue("yakinkurumsicilno", textBox14.Text);
            komut.Parameters.AddWithValue("yakinkurumadi", textBox15.Text);


            komut.ExecuteNonQuery();


            MessageBox.Show("hasta bilgileri güncellendi");


        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string sql = "insert into hasta(tckimlik, ad," +
                "soyad,dogumyeri,dogumtarihi,babaadi," +
                "anneadi,cinsiyet,kangrubu," +
                "medenihal,adres,tel," +
                "kurumsicilno,kurumadi," +
                "yakintel,yakinkurumsicilno," +
                "yakinkurumadi,dosyano)  values(@tckimlik, @ad," +
                "@soyad,@dogumyeri,@dogumtarihi,@babaadi," +
                "@anneadi,@cinsiyet,@kangrubu," +
                "@medenihal,@adres,@tel," +
                "@kurumsicilno,@kurumadi," +
                "@yakintel,@yakinkurumsicilno," +
                "@yakinkurumadi,@dosyano)";
            

                SqlCommand komut = new SqlCommand(sql, baglanti);

            komut.Parameters.AddWithValue("dosyano", textBox1.Text);
            komut.Parameters.AddWithValue("ad", textBox2.Text);
            komut.Parameters.AddWithValue("soyad", textBox11.Text);
            komut.Parameters.AddWithValue("tckimlik", textBox10.Text);
            komut.Parameters.AddWithValue("dogumyeri", textBox3.Text);
            komut.Parameters.AddWithValue("dogumtarihi", Convert.ToDateTime(dateTimePicker1.Value));
            komut.Parameters.AddWithValue("babaadi", textBox4.Text);
            komut.Parameters.AddWithValue("anneadi", textBox5.Text);
            komut.Parameters.AddWithValue("cinsiyet", comboBox2.SelectedItem);
            komut.Parameters.AddWithValue("kangrubu", comboBox3.SelectedItem);
            komut.Parameters.AddWithValue("medenihal", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("adres", textBox6.Text);
            komut.Parameters.AddWithValue("tel", textBox7.Text);
            komut.Parameters.AddWithValue("kurumsicilno", textBox8.Text);
            komut.Parameters.AddWithValue("kurumadi", textBox9.Text);
            komut.Parameters.AddWithValue("yakintel", textBox13.Text);
            komut.Parameters.AddWithValue("yakinkurumsicilno", textBox14.Text);
            komut.Parameters.AddWithValue("yakinkurumadi", textBox15.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("yeni kişi eklendi.");
        }

        private void HastaBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            baglanti.Close();
        }
    }
}
