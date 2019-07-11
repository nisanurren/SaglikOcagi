using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Sağlık_OCağı_Hasta_Takip_Sistemi
{
    public partial class kullanıcıtanıtma : UserControl
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-BF5FKOU\MSSQLSERVER1; Initial Catalog = saglikocak; Trusted_Connection=True");
        public kullanıcıtanıtma()
        {
            InitializeComponent();
        }
        kt kullanici_tanitim = new kt();
        private void kullanıcıtanıtma_Load(object sender, EventArgs e)
        {

           baglanti.Open();
            string sql = "select kodu  from kullanici ";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            SqlDataReader dr;
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0));
            }
            


            baglanti.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static String kullanicikodu;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from kullanici where kodu=@kodu";
            SqlParameter prm1 = new SqlParameter("kodu", comboBox1.Text);
            SqlCommand komut = new SqlCommand(sql, baglanti);
            
            kullanicikodu=comboBox1.Text;
            string[] kullanicilar= new string[comboBox1.Items.Count];
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                kullanicilar[i] = comboBox1.Items.ToString();
                
            }
            if (kullanicilar.Contains(comboBox1.Items.ToString()))
            {
                
                kullanici_tanitim.MdiParent =Form1.ActiveForm;

                if (kullanici_tanitim.IsDisposed)
                {
                    kt kullanici_tanitim2 = new kt();
                    kullanici_tanitim2.MdiParent = Form1.ActiveForm;
                    kullanicikodu = comboBox1.Text;
                    kullanici_tanitim2.Show();

                }
                else
                {
                    kullanici_tanitim.Show();
                }
                

                this.Hide();

                
               
            }
    }
        string yazacak_kul_kod;
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string sql = "insert into kullanici(kodu) values(@kodu)  ";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@kodu", comboBox1.Text);
            yazacak_kul_kod = comboBox1.Text;
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            kullanicikodu = comboBox1.Text;
            kullanici_tanitim.MdiParent = Form1.ActiveForm;

            kullanici_tanitim.Show();
            


            this.Hide();

        }
    }
}
