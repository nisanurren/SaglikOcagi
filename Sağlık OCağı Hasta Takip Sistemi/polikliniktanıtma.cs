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

namespace Sağlık_OCağı_Hasta_Takip_Sistemi
{
    public partial class polikliniktanıtma : UserControl
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-BF5FKOU\MSSQLSERVER1; Initial Catalog = saglikocak; Trusted_Connection=True");
        Poliklinik pl = new Poliklinik();
        public polikliniktanıtma()
        {
            InitializeComponent();
        }
       
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        public static string poliklinikadi;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from poliklinik where poliklinikadi=@poliklinikadi";
            SqlParameter prm1 = new SqlParameter("poliklinikadi", comboBox1.Text);
            SqlCommand komut = new SqlCommand(sql, baglanti);

            poliklinikadi = comboBox1.Text;
            string[] poliklinikler = new string[comboBox1.Items.Count];
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                poliklinikler[i] = comboBox1.Items.ToString();

            }
            if (poliklinikler.Contains(comboBox1.Items.ToString()))
            {
                if (pl.IsDisposed)
                {
                    Poliklinik pl2 = new Poliklinik();
                    pl2.MdiParent = Form1.ActiveForm;
                    pl2.Show();
                    this.Hide();
                }
                else
                {
                pl.MdiParent = Form1.ActiveForm;

                pl.Show();
                this.Hide();
                }
                

            }
        }

        private void polikliniktanıtma_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "select poliklinikadi  from poliklinik ";
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
    }
}
