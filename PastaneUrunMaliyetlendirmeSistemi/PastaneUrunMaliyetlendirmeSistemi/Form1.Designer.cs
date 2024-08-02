namespace PastaneUrunMaliyetlendirmeSistemi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.txtMalzemeNotlar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMalzemeFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMalzemeStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMalzemeAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMalzemeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunSFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunMFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUrunOlusturEkle = new System.Windows.Forms.Button();
            this.txtUrunOlusturMaliyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUrunOlusturMiktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnMalzemeListesi = new System.Windows.Forms.Button();
            this.btnUrunListesi = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbUrunOlusturUrun = new System.Windows.Forms.ComboBox();
            this.cmbUrunOlusturMalzeme = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetir);
            this.groupBox1.Controls.Add(this.btnMalzemeEkle);
            this.groupBox1.Controls.Add(this.txtMalzemeNotlar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMalzemeFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMalzemeStok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMalzemeAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMalzemeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Girişi";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(240, 78);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(89, 28);
            this.btnGetir.TabIndex = 3;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(75, 223);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(159, 31);
            this.btnMalzemeEkle.TabIndex = 7;
            this.btnMalzemeEkle.Text = "Malzeme Ekle";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // txtMalzemeNotlar
            // 
            this.txtMalzemeNotlar.Location = new System.Drawing.Point(75, 180);
            this.txtMalzemeNotlar.Name = "txtMalzemeNotlar";
            this.txtMalzemeNotlar.Size = new System.Drawing.Size(159, 28);
            this.txtMalzemeNotlar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notlar:";
            // 
            // txtMalzemeFiyat
            // 
            this.txtMalzemeFiyat.Location = new System.Drawing.Point(75, 146);
            this.txtMalzemeFiyat.Name = "txtMalzemeFiyat";
            this.txtMalzemeFiyat.Size = new System.Drawing.Size(159, 28);
            this.txtMalzemeFiyat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat:";
            // 
            // txtMalzemeStok
            // 
            this.txtMalzemeStok.Location = new System.Drawing.Point(75, 112);
            this.txtMalzemeStok.Name = "txtMalzemeStok";
            this.txtMalzemeStok.Size = new System.Drawing.Size(159, 28);
            this.txtMalzemeStok.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stok:";
            // 
            // txtMalzemeAd
            // 
            this.txtMalzemeAd.Location = new System.Drawing.Point(75, 78);
            this.txtMalzemeAd.Name = "txtMalzemeAd";
            this.txtMalzemeAd.Size = new System.Drawing.Size(159, 28);
            this.txtMalzemeAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // txtMalzemeID
            // 
            this.txtMalzemeID.Location = new System.Drawing.Point(75, 44);
            this.txtMalzemeID.Name = "txtMalzemeID";
            this.txtMalzemeID.Size = new System.Drawing.Size(159, 28);
            this.txtMalzemeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 207);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(831, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUrunGuncelle);
            this.groupBox3.Controls.Add(this.btnUrunEkle);
            this.groupBox3.Controls.Add(this.txtUrunSFiyat);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtUrunMFiyat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtUrunStok);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtUrunAd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtUrunID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(353, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 265);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Girişi";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(132, 223);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(102, 31);
            this.btnUrunGuncelle.TabIndex = 10;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(10, 223);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(102, 31);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunSFiyat
            // 
            this.txtUrunSFiyat.Location = new System.Drawing.Point(90, 180);
            this.txtUrunSFiyat.Name = "txtUrunSFiyat";
            this.txtUrunSFiyat.Size = new System.Drawing.Size(144, 28);
            this.txtUrunSFiyat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "S. Fiyat:";
            // 
            // txtUrunMFiyat
            // 
            this.txtUrunMFiyat.Location = new System.Drawing.Point(90, 146);
            this.txtUrunMFiyat.Name = "txtUrunMFiyat";
            this.txtUrunMFiyat.Size = new System.Drawing.Size(144, 28);
            this.txtUrunMFiyat.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "M. Fiyat:";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(90, 112);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(144, 28);
            this.txtUrunStok.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Stok:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(90, 78);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(144, 28);
            this.txtUrunAd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ad:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(90, 44);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(144, 28);
            this.txtUrunID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbUrunOlusturMalzeme);
            this.groupBox4.Controls.Add(this.cmbUrunOlusturUrun);
            this.groupBox4.Controls.Add(this.btnUrunOlusturEkle);
            this.groupBox4.Controls.Add(this.txtUrunOlusturMaliyet);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtUrunOlusturMiktar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(604, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 265);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Oluştur";
            // 
            // btnUrunOlusturEkle
            // 
            this.btnUrunOlusturEkle.Location = new System.Drawing.Point(10, 223);
            this.btnUrunOlusturEkle.Name = "btnUrunOlusturEkle";
            this.btnUrunOlusturEkle.Size = new System.Drawing.Size(101, 31);
            this.btnUrunOlusturEkle.TabIndex = 1;
            this.btnUrunOlusturEkle.Text = "Ekle";
            this.btnUrunOlusturEkle.UseVisualStyleBackColor = true;
            this.btnUrunOlusturEkle.Click += new System.EventHandler(this.btnUrunOlusturEkle_Click);
            // 
            // txtUrunOlusturMaliyet
            // 
            this.txtUrunOlusturMaliyet.Location = new System.Drawing.Point(97, 176);
            this.txtUrunOlusturMaliyet.Name = "txtUrunOlusturMaliyet";
            this.txtUrunOlusturMaliyet.Size = new System.Drawing.Size(137, 28);
            this.txtUrunOlusturMaliyet.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "Maliyet:";
            // 
            // txtUrunOlusturMiktar
            // 
            this.txtUrunOlusturMiktar.Location = new System.Drawing.Point(97, 132);
            this.txtUrunOlusturMiktar.Name = "txtUrunOlusturMiktar";
            this.txtUrunOlusturMiktar.Size = new System.Drawing.Size(137, 28);
            this.txtUrunOlusturMiktar.TabIndex = 5;
            this.txtUrunOlusturMiktar.TextChanged += new System.EventHandler(this.txtUrunOlusturMiktar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 22);
            this.label13.TabIndex = 4;
            this.label13.Text = "Miktar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 22);
            this.label14.TabIndex = 2;
            this.label14.Text = "Malzeme:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ürün:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCikis);
            this.groupBox5.Controls.Add(this.btnKasa);
            this.groupBox5.Controls.Add(this.btnMalzemeListesi);
            this.groupBox5.Controls.Add(this.btnUrunListesi);
            this.groupBox5.Location = new System.Drawing.Point(855, 283);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 207);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İşlemler";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(6, 173);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(233, 31);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnKasa
            // 
            this.btnKasa.Location = new System.Drawing.Point(6, 129);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(233, 31);
            this.btnKasa.TabIndex = 3;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnMalzemeListesi
            // 
            this.btnMalzemeListesi.Location = new System.Drawing.Point(6, 85);
            this.btnMalzemeListesi.Name = "btnMalzemeListesi";
            this.btnMalzemeListesi.Size = new System.Drawing.Size(233, 31);
            this.btnMalzemeListesi.TabIndex = 2;
            this.btnMalzemeListesi.Text = "Malzeme Listesi";
            this.btnMalzemeListesi.UseVisualStyleBackColor = true;
            this.btnMalzemeListesi.Click += new System.EventHandler(this.btnMalzemeListesi_Click);
            // 
            // btnUrunListesi
            // 
            this.btnUrunListesi.Location = new System.Drawing.Point(6, 41);
            this.btnUrunListesi.Name = "btnUrunListesi";
            this.btnUrunListesi.Size = new System.Drawing.Size(233, 31);
            this.btnUrunListesi.TabIndex = 1;
            this.btnUrunListesi.Text = "Ürün Listesi";
            this.btnUrunListesi.UseVisualStyleBackColor = true;
            this.btnUrunListesi.Click += new System.EventHandler(this.btnUrunListesi_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(855, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 265);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ürün Oluştur";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(3, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 238);
            this.listBox1.TabIndex = 0;
            // 
            // cmbUrunOlusturUrun
            // 
            this.cmbUrunOlusturUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunOlusturUrun.FormattingEnabled = true;
            this.cmbUrunOlusturUrun.Location = new System.Drawing.Point(97, 44);
            this.cmbUrunOlusturUrun.Name = "cmbUrunOlusturUrun";
            this.cmbUrunOlusturUrun.Size = new System.Drawing.Size(137, 30);
            this.cmbUrunOlusturUrun.TabIndex = 8;
            // 
            // cmbUrunOlusturMalzeme
            // 
            this.cmbUrunOlusturMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunOlusturMalzeme.FormattingEnabled = true;
            this.cmbUrunOlusturMalzeme.Location = new System.Drawing.Point(97, 88);
            this.cmbUrunOlusturMalzeme.Name = "cmbUrunOlusturMalzeme";
            this.cmbUrunOlusturMalzeme.Size = new System.Drawing.Size(137, 30);
            this.cmbUrunOlusturMalzeme.TabIndex = 9;
            this.cmbUrunOlusturMalzeme.SelectedIndexChanged += new System.EventHandler(this.cmbUrunOlusturMalzeme_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 502);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.TextBox txtMalzemeNotlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMalzemeFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMalzemeStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMalzemeAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMalzemeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunSFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrunMFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUrunOlusturEkle;
        private System.Windows.Forms.TextBox txtUrunOlusturMaliyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUrunOlusturMiktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnMalzemeListesi;
        private System.Windows.Forms.Button btnUrunListesi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbUrunOlusturMalzeme;
        private System.Windows.Forms.ComboBox cmbUrunOlusturUrun;
    }
}

