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
    public partial class DosyaBul : Form
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-BF5FKOU\MSSQLSERVER1; Initial Catalog = saglikocak; Trusted_Connection=True");
        
        public DosyaBul()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (comboBox1.SelectedItem == "Ad")
            {
                
                string sql = "select * from hasta where ad=@ad";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("ad", textBox1.Text);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                SqlDataReader dr = komut.ExecuteReader();
            }
            else if(comboBox1.SelectedItem == "Dosyano")
            {
                string sql = "select * from hasta where dosyano=@dosyano";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("dosyano", textBox1.Text);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                SqlDataReader dr = komut.ExecuteReader();
            }
            else if (comboBox1.SelectedItem == "Kimlikno")
            {
                string sql = "select * from hasta where tckimlik=@tckimlik";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("tckimlik", textBox1.Text);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                SqlDataReader dr = komut.ExecuteReader();
            }
            else if (comboBox1.SelectedItem == "KurumSicilNo")
            {
                string sql = "select * from hasta where kurumsicilno=@kurumsicilno";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("kurumsicilno", textBox1.Text);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                SqlDataReader dr = komut.ExecuteReader();
            }






            baglanti.Close();
        }
    }
}
