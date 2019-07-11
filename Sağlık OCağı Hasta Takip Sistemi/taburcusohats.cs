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
    public partial class taburcusohats : Form
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-BF5FKOU\MSSQLSERVER1; Initial Catalog = saglikocak; Trusted_Connection=True");

        public taburcusohats()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void taburcusohats_Load(object sender, EventArgs e)
        {
            textBox1.Text = HastaProcess.dosyano;
            textBox2.Text = HastaProcess.toplamtutar;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "update sevk set taburcu=@taburcu where dosyano=@dosyano";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("dosyano", textBox1.Text);
            komut.Parameters.AddWithValue("taburcu", "tabucu edildi");
            MessageBox.Show("hasta taburcu edildi!");
            komut.ExecuteNonQuery();
        }
    }
}
