using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Sağlık_OCağı_Hasta_Takip_Sistemi
{  
    public partial class Form1 : Form
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-BF5FKOU\MSSQLSERVER1; Initial Catalog = saglikocak; Trusted_Connection=True");
        

        HastaProcess acil = new HastaProcess();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;

            this.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            polikliniktanıtma1.Visible = false;
            kullanıcıtanıtma1.Visible = false;            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "LOGIN";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
              try
              {
                  
                  string sql = "select * from kullanici where username=@username AND şifre=@şifre";
                  SqlParameter prm1 = new SqlParameter("username", textBox1.Text.Trim());
                  SqlParameter prm2 = new SqlParameter("şifre", textBox2.Text.Trim());
                  SqlCommand komut = new SqlCommand(sql, baglanti);
                  komut.Parameters.Add(prm1);
                  komut.Parameters.Add(prm2);
                  DataTable dt = new DataTable();
                  SqlDataAdapter da = new SqlDataAdapter(komut);
                  da.Fill(dt);
                  if (dt.Rows.Count > 0)
                  {
                      loginpanel.Visible = false;
                      menuStrip1.Enabled = true;
                  }
                else
                {
                    MessageBox.Show("hatalı giriş yaptınız!!");
                    
                }
                  baglanti.Close();
               
            }
              catch (Exception)
              {
                   
              }      

        }

        private void hastaKabulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acil.Hide();
            kullanıcıtanıtma1.Visible = false;
            polikliniktanıtma1.Visible = true;
            
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void referanslarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polikliniktanıtma1.Visible = false;
            kullanıcıtanıtma1.Visible = false;
            if (acil.IsDisposed)
            {
                 HastaProcess yeniacil= new HastaProcess();
                yeniacil.MdiParent = Form1.ActiveForm;
                yeniacil.Show();

            }
            else
            {
                acil.Show();
            }
            acil.MdiParent = this;
        
         

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void polikliniktanıtma1_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acil.Hide();
            
            polikliniktanıtma1.Visible = false;
            kullanıcıtanıtma1.Visible = true;
        }

        private void kullanıcıtanıtma1_Load(object sender, EventArgs e)
        {

        }
    }
}
