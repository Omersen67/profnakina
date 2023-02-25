namespace profnakina
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Firma = new System.Windows.Forms.TextBox();
            this.Ttutar = new System.Windows.Forms.TextBox();
            this.KDVoran = new System.Windows.Forms.TextBox();
            this.KDVtutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KDVsiztutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kayit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sil = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.tarih1 = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.t = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Projead = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.güncel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.icerik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Firma
            // 
            resources.ApplyResources(this.Firma, "Firma");
            this.Firma.Name = "Firma";
            // 
            // Ttutar
            // 
            resources.ApplyResources(this.Ttutar, "Ttutar");
            this.Ttutar.Name = "Ttutar";
            this.Ttutar.TextChanged += new System.EventHandler(this.Ttutar_TextChanged);
            this.Ttutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ttutar_KeyPress);
            // 
            // KDVoran
            // 
            resources.ApplyResources(this.KDVoran, "KDVoran");
            this.KDVoran.Name = "KDVoran";
            this.KDVoran.TextChanged += new System.EventHandler(this.KDVoran_TextChanged);
            this.KDVoran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KDVoran_KeyPress);
            // 
            // KDVtutar
            // 
            resources.ApplyResources(this.KDVtutar, "KDVtutar");
            this.KDVtutar.Name = "KDVtutar";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // KDVsiztutar
            // 
            resources.ApplyResources(this.KDVsiztutar, "KDVsiztutar");
            this.KDVsiztutar.Name = "KDVsiztutar";
            this.KDVsiztutar.TextChanged += new System.EventHandler(this.KDVsiztutar_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // kayit
            // 
            resources.ApplyResources(this.kayit, "kayit");
            this.kayit.Name = "kayit";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            this.kayit.Enter += new System.EventHandler(this.kayit_Click);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Sil
            // 
            resources.ApplyResources(this.Sil, "Sil");
            this.Sil.Name = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Güncelle
            // 
            resources.ApplyResources(this.Güncelle, "Güncelle");
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // tarih1
            // 
            resources.ApplyResources(this.tarih1, "tarih1");
            this.tarih1.Name = "tarih1";
            this.tarih1.TextChanged += new System.EventHandler(this.tarih_TextChanged);
            this.tarih1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tarih1_KeyPress);
            // 
            // tarih
            // 
            resources.ApplyResources(this.tarih, "tarih");
            this.tarih.Name = "tarih";
            // 
            // t
            // 
            resources.ApplyResources(this.t, "t");
            this.t.Name = "t";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // Projead
            // 
            resources.ApplyResources(this.Projead, "Projead");
            this.Projead.Name = "Projead";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // güncel
            // 
            resources.ApplyResources(this.güncel, "güncel");
            this.güncel.Name = "güncel";
            this.güncel.UseVisualStyleBackColor = true;
            this.güncel.Click += new System.EventHandler(this.güncel_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // duzenle
            // 
            resources.ApplyResources(this.duzenle, "duzenle");
            this.duzenle.Name = "duzenle";
            this.duzenle.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // icerik
            // 
            resources.ApplyResources(this.icerik, "icerik");
            this.icerik.Name = "icerik";
            this.icerik.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.icerik);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.güncel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Projead);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.t);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.tarih1);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KDVsiztutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KDVtutar);
            this.Controls.Add(this.KDVoran);
            this.Controls.Add(this.Ttutar);
            this.Controls.Add(this.Firma);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.TextChanged += new System.EventHandler(this.tarih_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Firma;
        private TextBox Ttutar;
        private TextBox KDVoran;
        private TextBox KDVtutar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox KDVsiztutar;
        private Label label6;
        private Button kayit;
        private DataGridView dataGridView1;
        private Button Sil;
        private Button Güncelle;
        private TextBox tarih1;
        private DateTimePicker tarih;
        private Label t;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox Projead;
        private Label label9;
        private Button button1;
        private TextBox textBox5;
        private Label label10;
        private Button güncel;
        private Button button2;
        private Button duzenle;
        private SaveFileDialog saveFileDialog1;
        private TextBox icerik;
        private Label label7;
    }
}