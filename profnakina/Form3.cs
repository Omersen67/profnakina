using System.Data;
using System.Data.SqlClient;

namespace profnakina
{
    public partial class Form3 : Form
    {
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
            dataGridView1.Columns[8].HeaderText = "Fatura İçeriği";

        }
        public void sil(int id)
        {
            baglanti.Open();
            string sil = "delete from veriler where FirmaNO =@id";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                //  baglanti.Open();
                //if(tarih ==
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into veriler (FirmaAd,ProjeAdi,Toplamtutar,KdvOrani,Kdv,Kdvsiz,Tarih,icerik,FaturaNo)values(@FirmaAdi,@projead,@Toptutar,@Kdvoran,@KdvT,@KdvsizT,@Tarih,@icerikk,@FatNo)", baglanti);

                komut.Parameters.AddWithValue("@FirmaAdi", Firma.Text);
                komut.Parameters.AddWithValue("@FatNo", faturano.Text);
                komut.Parameters.AddWithValue("@projead", Projead.Text);
                komut.Parameters.AddWithValue("@Toptutar", Ttutar.Text = Ttutar.Text.Replace(',', '.'));
                komut.Parameters.AddWithValue("@Kdvoran", KDVoran.Text);
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
                MessageBox.Show("Veri Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !!! Lütfen girdiğiniz değerleri kontol ediniz...");//+ex.ToString());

            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();

            }
        }


        private void label9_Click(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            double toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
            }
            textBox9.Text = toplam.ToString();

            double toplam1 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
            }
            textBox8.Text = toplam1.ToString();

            double toplam2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam2 += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            textBox10.Text = toplam2.ToString();
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
            try
            {

                double sonuc;
                double b;
                double a;

                //   double tfatura = Convert.ToInt64(Ttutar.Text);
                // double kdvoranı = Convert.ToInt64(KDVoran.Text);
                double tfatura;
                tfatura = double.Parse(Ttutar.Text);
                double kdvoranı;
                kdvoranı = double.Parse(KDVoran.Text);

                b = kdvoranı / 100;
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
                d = Math.Round(d, 2);
                v = Math.Round(v, 2);



                KDVtutar.Text = v.ToString();

                KDVsiztutar.Text = sonuc.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata !!! Lütfen girdiğiniz değerleri kontol ediniz...");//+ex.ToString());

            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();

            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ara_TextChanged(object sender, EventArgs e)
        {


        }

        private void güncel_Click(object sender, EventArgs e)
        {
            try
            {
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
                if (baglanti != null)
                    baglanti.Close();


            }
        }


        private void Sil_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    sil(id);
                    verilerigoster("select*from veriler");
                    MessageBox.Show("Veri silindi");
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

        private void duzenle_Click(object sender, EventArgs e)
        {

        }

        private void Ara_Enter(object sender, EventArgs e)
        {

        }

        private void aramak_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

            printDocument1.Print();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("calibre", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                e.Graphics.DrawString($"Tarih : {DateTime.Now.ToString("dd.MM.yy")}", font, firca, 60, 25);
                e.Graphics.DrawString("Fatura listesi", font, firca, 300, 70);
                int i = 0;
                int y = 210;
                while (i <= dataGridView1.Rows.Count - 1)
                {
                    font = new Font("Ariel", 14);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), font, firca, 60, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), font, firca, 280, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), font, firca, 420, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), font, firca, 550, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), font, firca, 700, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), font, firca, 850, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), font, firca, 1000, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].Value.ToString(), font, firca, 1150, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[8].Value.ToString(), font, firca, 1300, y);


                    y = y + 55;
                    i = i + 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from veriler where ProjeAdi like'%" + Arama.Text + "%'", baglanti);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ads = new DataSet();
                sda.Fill(ads);
                dataGridView1.DataSource = ads.Tables[0];

                SqlCommand acmd = new SqlCommand("select * from veriler where Toplamtutar like'%" + Arama.Text + "%'", baglanti);
                SqlDataAdapter ssda = new SqlDataAdapter(acmd);
                DataSet sads = new DataSet();
                ssda.Fill(sads);
                dataGridView1.DataSource = sads.Tables[0];


                SqlCommand sacmd = new SqlCommand("select * from veriler where FaturaNo like'%" + Arama.Text + "%'", baglanti);
                SqlDataAdapter sssda = new SqlDataAdapter(sacmd);
                DataSet ssads = new DataSet();
                sssda.Fill(ssads);
                dataGridView1.DataSource = ssads.Tables[0];
                baglanti.Close();


            }

            catch (Exception)
            {
                MessageBox.Show("Hata..!Arama işlemi başarsız lütfen tekrar deneyiniz..!");//+ex.ToString());

            }
            finally
            {
                if (baglanti != null)
                {


                }


            }
        }
    }
}






