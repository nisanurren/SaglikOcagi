using System;
using System.Collections;
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
    public partial class HastaProcess : Form
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-BF5FKOU\MSSQLSERVER1; Initial Catalog = saglikocak; Trusted_Connection=True");

        HastaBilgileri hb = new HastaBilgileri();
        public HastaProcess()
        {
            InitializeComponent();
        }

        private void HastaProcess_Load(object sender, EventArgs e)
        {
            this.Name = "Hasta İşlemleri";
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
            dr.Close();

            string sql2 = "select islemadi from islem";
            SqlCommand komut2=new SqlCommand(sql2, baglanti);
            DataTable dta = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(komut2);
            daa.Fill(dta);

            SqlDataReader drr;
            drr = komut2.ExecuteReader();

            while (drr.Read())
            {
                comboBox2.Items.Add(drr.GetString(0));
            }
            drr.Close();
            baglanti.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        public static string dosyano;
        private void button3_Click(object sender, EventArgs e)
        {

            dosyano = textBox1.Text;
            hb.MdiParent = Form1.ActiveForm;
            if (hb.IsDisposed)
            {
                
                HastaBilgileri hb2 = new HastaBilgileri();
                hb2.MdiParent = Form1.ActiveForm;
                hb2.Show();

               
            }
            else
            {
                hb.Show();
            }
            

        }

        private void HastaProcess_FormClosed(object sender, FormClosedEventArgs e)
        {
            baglanti.Close();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string dosyano = textBox1.Text;

            /* string sql = "select * from hasta where dosyano=@dosyano ";


             SqlCommand komut = new SqlCommand(sql, baglanti);
             komut.Parameters.AddWithValue("@dosyano", dosyano);
             SqlDataAdapter da = new SqlDataAdapter(komut);

             DataTable dt = new DataTable();
             da.Fill(dt);

             dataGridView1.DataSource = dt;
             //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.*/

            if (textBox1.Text == "")
            {
                DosyaBul dosyabul = new DosyaBul();
                dosyabul.MdiParent = Form1.ActiveForm;
                dosyabul.Show();
            }




            string sql2 = "select ad,soyad,tckimlik,kurumadi from hasta where dosyano=@dosyano ";

         
            SqlCommand komut2 = new SqlCommand(sql2, baglanti);
            komut2.Parameters.AddWithValue("@dosyano", dosyano);



            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text= dr["ad"].ToString();
                textBox3.Text = dr["soyad"].ToString();
                textBox4.Text = dr["kurumadi"].ToString();


            }

            baglanti.Close();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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
            HastaBilgileri hb3 = new HastaBilgileri();
            if (hb3.IsDisposed)
            {

                HastaBilgileri hb4= new HastaBilgileri();
                hb4.MdiParent = Form1.ActiveForm;
               
                hb4.Show();
                ClearAll(hb4);
            }
            else
            {
            
            hb3.MdiParent =Form1.ActiveForm;
            hb3.Show();
            ClearAll(hb3);
            }
            
            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static string toplamtutar;
        private void button2_Click(object sender, EventArgs e)
        {
            dosyano = textBox1.Text;
            baglanti.Open();
            string sql = "select poliklinik,sira,saat,yapilanislem,miktar,birimfiyat" +
                " from sevk where dosyano=@dosyano";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@dosyano", dosyano);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dataGridView1.DataSource = dt;
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            { 
            int birimfiyat = Convert.ToInt32(dr["birimfiyat"]);
            int miktar = Convert.ToInt32(dr["miktar"]);


            textBox7.Text=( birimfiyat*miktar).ToString();
                

            }


            toplamtutar = textBox7.Text;



            baglanti.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            taburcusohats tbr = new taburcusohats();
            if (tbr.IsDisposed)
            {

                taburcusohats tbr2 = new taburcusohats();
                tbr2.MdiParent = Form1.ActiveForm;

                tbr2.Show();
                
            }
            else


            {

               tbr.MdiParent = Form1.ActiveForm;
                tbr.Show();
                
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "insert into sevk(poliklinik,yapilanislem,drkod,miktar,birimfiyat,dosyano,sevktarihi)" +
                "values(@poliklinik,@yapilanislem,@drkod,@miktar,@birimfiyat,@dosyano,@sevktarihi) ";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add("dosyano", dosyano);
            komut.Parameters.AddWithValue("sevktarihi","12122012");
            komut.Parameters.AddWithValue("poliklinik", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("yapilanislem", comboBox2.SelectedItem);
            komut.Parameters.AddWithValue("drkod", textBox9.Text);
            komut.Parameters.AddWithValue("miktar",numericUpDown1.Value);
            komut.Parameters.AddWithValue("birimfiyat", textBox6.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("işlem eklendi");
            
            




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "select birimfiyat from islem where islemadi=@islemadi ";
            SqlCommand komut = new SqlCommand(sql,baglanti);
            komut.Parameters.AddWithValue("islemadi", comboBox2.SelectedItem);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
             textBox6.Text= dr["birimfiyat"].ToString();
            }

            baglanti.Close();
        }
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView1.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Çıktı Başlığı", new Font(dataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new Font(dataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(dataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new Font(new Font(dataGridView1.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
          

            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView1.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PrintDialog yazdir = new PrintDialog();
            yazdir.Document = printDocument1;
            yazdir.UseEXDialog = true;
            if (yazdir.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
