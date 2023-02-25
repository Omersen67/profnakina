using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace profnakina
{
    public partial class Form2 : Form
    {
        //  public string file_path = @"C:\\Users\\omers\\source\\repos\\profnakina\\profmak.xlsx";

        SqlConnection baglanti = new SqlConnection(@"Data Source=AYLDZ67\SQLEXPRESS06;Initial Catalog=profmak;Integrated Security=True");

            
           
        public void verilerigoster(string verileri)
        {
            SqlDataAdapter da = new SqlDataAdapter(verileri, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //  da.SelectCommand.Parameters.AddWithValue("@Tarih", tarih.Value);
            dataGridView1.Columns[0].HeaderText = "Firma Numarası";
            dataGridView1.Columns[1].HeaderText = "Firma Adı";
            dataGridView1.Columns[2].HeaderText = "Tarih";
            dataGridView1.Columns[3].HeaderText = "Proje Adı ";
            dataGridView1.Columns[4].HeaderText = "Toplam Tutar";
            dataGridView1.Columns[5].HeaderText = "Kdv Oranı";
            dataGridView1.Columns[6].HeaderText = "Kdv";
            dataGridView1.Columns[7].HeaderText = "Net Tutar";
        }
        public void sil(int id)
        {
            baglanti.Open();
            string sil = "delete from veriler where FirmaNO =@id";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            komut.Parameters.AddWithValue("@id",id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public Form2()
        {
            InitializeComponent();

           // tarih.Value = Date;
            //tarih Format(tarih, "dd.mm.yyyy");
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kayit_Click(object sender, EventArgs e)
        {
             try
            {
                if (Convert.ToInt32(KDVoran.Text) < 0 || Convert.ToInt32(KDVoran.Text) > 60)
                {
                    MessageBox.Show("KDV oranı çok yüksek...!");
                    KDVoran.Text = "";  
                }
            }
            catch
            {
                MessageBox.Show("KDV oranı hatalı...!!!");
                KDVoran.Text = "";
                KDVoran.Focus();
            }
            try { 

            double sonuc;
            double b;
            double a;
               
            //   double tfatura = Convert.ToInt64(Ttutar.Text);
            // double kdvoranı = Convert.ToInt64(KDVoran.Text);
            double tfatura;
            tfatura = double.Parse(Ttutar.Text);
            double kdvoranı;
            kdvoranı = double.Parse(KDVoran.Text);
               
                b = kdvoranı /100 ;
            a = 1 + b;
            sonuc = tfatura / a;
          //  float para;
         //   para = float.Parse(textBox1.Text);

            double c = sonuc;
            a = Math.Round(a, 2);
            b = Math.Round(b, 2);
            sonuc = Math.Round(sonuc, 2);
         


            double d = tfatura;
            double v = tfatura - sonuc;
            d= Math.Round(d, 2);
            v= Math.Round(v, 2);



            KDVtutar.Text = v.ToString();

            KDVsiztutar.Text = sonuc.ToString();

        }
            catch (Exception)
            {
                MessageBox.Show("Hata !!! Lütfen girdiğiniz değerleri kontol ediniz...");//+ex.ToString());

            }
            finally
            {
                if(baglanti!=null)
                baglanti.Close();

            }
        }

            // Form3 frm3 = new Form3();
            // frm3.Show();

            /* excel.Application app = new excel.Application();
             app.Visible= true;  
             Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
             Worksheet sayfa = (Worksheet)kitap.Sheets[1];
             for (int i = 0; i < dataGridView1.Columns.Count; i++)
             {
                Range alan = (Range)sayfa.Cells[1,1];
                 alan.Cells[1,i + 1]=dataGridView1.Columns[i].HeaderText;
                   Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
        Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
        Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
        
            ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat
            CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
            CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı

            for (int i = 0; i < 1000; i++)
            {
                CalismaSayfasi0.Cells[1 + i, 1] = Firma.Text;                                // dataya yaz (satır, sutun)
                CalismaSayfasi0.Cells[1 + i, 2] = Ttutar.Text;                                // dataya yaz
                CalismaSayfasi0.Cells[1 + i, 3] = KDVoran.Text;
                ExcelUygulama0.Quit(); 
              // ExcelUygulama0.Visible = false;                 // excel' i görünür yap

                // excel uygulamasını kapa
                // if else kullan ........
            
            }*/
        

        private void Ttutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ttutar_KeyPress(object sender, KeyPressEventArgs e)
        {

           e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void KDVoran_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           


        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            try
            {

                //  baglanti.Open();
                //if(tarih ==
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into veriler (FirmaAd,ProjeAdı,Toplamtutar,KdvOrani,Kdv,Kdvsiz,Tarih,icerik)values(@FirmaAdi,@projead,@Toptutar,@Kdvoran,@KdvT,@KdvsizT,@Tarih,@icerikk)", baglanti);

                komut.Parameters.AddWithValue("@FirmaAdi", Firma.Text);
                // komut.Parameters.AddWithValue("@FatNo", FaturaID.Text);
                komut.Parameters.AddWithValue("@projead", Projead.Text);
                komut.Parameters.AddWithValue("@Toptutar", Ttutar.Text = Ttutar.Text.Replace(',', '.'));
                komut.Parameters.AddWithValue("@Kdvoran", KDVoran.Text );
                komut.Parameters.AddWithValue("@KdvT", KDVtutar.Text = KDVtutar.Text.Replace(',', '.'));
                komut.Parameters.AddWithValue("@KdvsizT", KDVsiztutar.Text = KDVsiztutar.Text.Replace(',', '.'));
                komut.Parameters.AddWithValue("@Tarih", tarih1.Text);
                komut.Parameters.AddWithValue("@icerikk", icerik.Text);
                //tarih.Text =dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Ttutar.Text = Ttutar.Text.ToString().Replace('.', ',');

                komut.ExecuteNonQuery();
                verilerigoster("select*from veriler");
                baglanti.Close();
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hata !!! Lütfen girdiğiniz değerleri kontol ediniz...");//+ex.ToString());

            }
            finally
            {
                if(baglanti!=null)
                baglanti.Close();

            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KDVsiztutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            try { 
            /*  baglanti.Open();
              SqlCommand komut = new SqlCommand("delete from veriler where (FirmaAd,FaturaNo,ProjeAdı,Toplamtutar,KdvOrani,Kdv,Kdvsiz,Tarih)values(@FirmaAdi,@FatNo,@projead,@Toptutar,@Kdvoran,@KdvT,@KdvsizT,@Tarih)", baglanti);
              komut.Connection = baglanti;
              komut.ExecuteNonQuery();
              baglanti.Close();
              verilerigoster("select * from veriler");
            */
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                sil(id);
                verilerigoster("select*from veriler");
            }
        }
    
            catch (Exception)
            {
                MessageBox.Show("Hata..! Fatura Silinemedi...!");//+ex.ToString());

            }
            finally
{
    if (baglanti != null)
        baglanti.Close();

}
        }

        private void tarih_TextChanged(object sender, EventArgs e)
        {

       

        }

        private void tarih1_KeyPress(object sender, KeyPressEventArgs e)
        {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        
                
        }

        private void güncel_Click(object sender, EventArgs e)
        {
            try { 
           // baglanti.Open();
            verilerigoster("select*from veriler");
            //  baglanti.Close();

        }
            catch (Exception)
            {
                MessageBox.Show("Hata. . . ! Faturalar getirilemedi lütfen tekrar deneyiniz..");//+ex.ToString());

            }
            finally
            {
                if(baglanti!=null)
                baglanti.Close();

            
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                decimal toplama = 0;

                for (int index = 0; index <= dataGridView1.RowCount - 1; index++)
                {
                    toplama += Convert.ToDecimal(dataGridView1.Rows[index].Cells[5].Value); // hangi column ise onun indexi yazılacak 

                }
                textBox1.Text = toplama.ToString();
                    
                    

            }

            // try
            // {
            /*  decimal toplam = 0;
              for (int i = 0; i < dataGridView1.Rows.Count + 1; ++i)
              {
                  toplam = +Convert.ToDecimal(dataGridView1.Rows[i].Cells[4]);
              }
              textBox1.Text = toplam.ToString();*/

            /*  decimal toplam1 = 0;
              for (int i = 0; i < dataGridView1.Rows.Count; ++i)
              {
                  toplam1 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
              }

              textBox3.Text = toplam1.ToString();
              /*
              decimal toplam2 = 0;
              for (int i = 0; i < dataGridView1.Rows.Count; ++i)
              {
                  toplam2 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
              }
              textBox4.Text = toplam2.ToString();
              */
            /* }
             catch (Exception)
             {
                 MessageBox.Show("Hata !!! Toplama işlemi yapılamadı lütfen tekrar deneyiniz");//+ex.ToString());

             }
             finally
             {
                 if (baglanti != null)
                     baglanti.Close();

             }*/
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void KDVoran_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        /*  private void KDVoran_Leave(object sender, EventArgs e)
          {

          }*/
    }

      
    }

    

     
        
    

        
    
