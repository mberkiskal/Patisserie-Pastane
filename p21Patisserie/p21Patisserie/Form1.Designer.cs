namespace p21Patisserie
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.txtMalzemeNot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMalzemeFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.txtUrunSatis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunMaliyet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbMalzeme = new System.Windows.Forms.ComboBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.btnUrunOlustur = new System.Windows.Forms.Button();
            this.txtMaliyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnMalzemeListesi = new System.Windows.Forms.Button();
            this.btnUrunListesi = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetir);
            this.groupBox1.Controls.Add(this.btnMalzemeEkle);
            this.groupBox1.Controls.Add(this.txtMalzemeNot);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMalzemeFiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMalzemeStok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMalzemeAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMalzemeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MALZEME GİRİŞİ";
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGetir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetir.Location = new System.Drawing.Point(307, 127);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(45, 33);
            this.btnGetir.TabIndex = 11;
            this.btnGetir.Text = "...";
            this.btnGetir.UseVisualStyleBackColor = false;
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMalzemeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMalzemeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMalzemeEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMalzemeEkle.Location = new System.Drawing.Point(74, 405);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(227, 41);
            this.btnMalzemeEkle.TabIndex = 10;
            this.btnMalzemeEkle.Text = "Malzeme Ekle";
            this.btnMalzemeEkle.UseVisualStyleBackColor = false;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // txtMalzemeNot
            // 
            this.txtMalzemeNot.Location = new System.Drawing.Point(128, 329);
            this.txtMalzemeNot.Name = "txtMalzemeNot";
            this.txtMalzemeNot.Size = new System.Drawing.Size(173, 33);
            this.txtMalzemeNot.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(36, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOTLAR:";
            // 
            // txtMalzemeFiyat
            // 
            this.txtMalzemeFiyat.Location = new System.Drawing.Point(128, 263);
            this.txtMalzemeFiyat.Name = "txtMalzemeFiyat";
            this.txtMalzemeFiyat.Size = new System.Drawing.Size(173, 33);
            this.txtMalzemeFiyat.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(59, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "FİYAT:";
            // 
            // txtMalzemeStok
            // 
            this.txtMalzemeStok.Location = new System.Drawing.Point(128, 196);
            this.txtMalzemeStok.Name = "txtMalzemeStok";
            this.txtMalzemeStok.Size = new System.Drawing.Size(173, 33);
            this.txtMalzemeStok.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "STOK:";
            // 
            // txtMalzemeAd
            // 
            this.txtMalzemeAd.Location = new System.Drawing.Point(128, 127);
            this.txtMalzemeAd.Name = "txtMalzemeAd";
            this.txtMalzemeAd.Size = new System.Drawing.Size(173, 33);
            this.txtMalzemeAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(81, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // txtMalzemeID
            // 
            this.txtMalzemeID.Location = new System.Drawing.Point(128, 61);
            this.txtMalzemeID.Name = "txtMalzemeID";
            this.txtMalzemeID.Size = new System.Drawing.Size(173, 33);
            this.txtMalzemeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 513);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1098, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1092, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUrunGuncelle);
            this.groupBox3.Controls.Add(this.btnUrunEkle);
            this.groupBox3.Controls.Add(this.txtUrunSatis);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtUrunMaliyet);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtUrunStok);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtUrunAd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtUrunID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(381, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 494);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÜRÜN GİRİŞİ";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUrunGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(60, 434);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(225, 41);
            this.btnUrunGuncelle.TabIndex = 12;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUrunEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunEkle.Location = new System.Drawing.Point(60, 387);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(225, 41);
            this.btnUrunEkle.TabIndex = 11;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunSatis
            // 
            this.txtUrunSatis.Location = new System.Drawing.Point(120, 329);
            this.txtUrunSatis.Name = "txtUrunSatis";
            this.txtUrunSatis.Size = new System.Drawing.Size(173, 33);
            this.txtUrunSatis.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(51, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "SATIŞ:";
            // 
            // txtUrunMaliyet
            // 
            this.txtUrunMaliyet.Location = new System.Drawing.Point(120, 263);
            this.txtUrunMaliyet.Name = "txtUrunMaliyet";
            this.txtUrunMaliyet.Size = new System.Drawing.Size(173, 33);
            this.txtUrunMaliyet.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(24, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "MALİYET:";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(120, 196);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(173, 33);
            this.txtUrunStok.TabIndex = 5;
            this.txtUrunStok.TextChanged += new System.EventHandler(this.txtUrunStok_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(53, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "STOK:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(120, 127);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(173, 33);
            this.txtUrunAd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(73, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "AD:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(120, 61);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(173, 33);
            this.txtUrunID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(80, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbMalzeme);
            this.groupBox4.Controls.Add(this.cmbUrun);
            this.groupBox4.Controls.Add(this.btnUrunOlustur);
            this.groupBox4.Controls.Add(this.txtMaliyet);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtMiktar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(726, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 494);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ÜRÜN OLUŞTUR";
            // 
            // cmbMalzeme
            // 
            this.cmbMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMalzeme.FormattingEnabled = true;
            this.cmbMalzeme.Location = new System.Drawing.Point(116, 128);
            this.cmbMalzeme.Name = "cmbMalzeme";
            this.cmbMalzeme.Size = new System.Drawing.Size(173, 33);
            this.cmbMalzeme.TabIndex = 14;
            this.cmbMalzeme.SelectedIndexChanged += new System.EventHandler(this.cmbMalzeme_SelectedIndexChanged);
            // 
            // cmbUrun
            // 
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(116, 61);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(173, 33);
            this.cmbUrun.TabIndex = 13;
            // 
            // btnUrunOlustur
            // 
            this.btnUrunOlustur.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUrunOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunOlustur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunOlustur.Location = new System.Drawing.Point(48, 332);
            this.btnUrunOlustur.Name = "btnUrunOlustur";
            this.btnUrunOlustur.Size = new System.Drawing.Size(227, 41);
            this.btnUrunOlustur.TabIndex = 12;
            this.btnUrunOlustur.Text = "Ekle";
            this.btnUrunOlustur.UseVisualStyleBackColor = false;
            this.btnUrunOlustur.Click += new System.EventHandler(this.btnUrunOlustur_Click);
            // 
            // txtMaliyet
            // 
            this.txtMaliyet.Location = new System.Drawing.Point(116, 263);
            this.txtMaliyet.Name = "txtMaliyet";
            this.txtMaliyet.Size = new System.Drawing.Size(173, 33);
            this.txtMaliyet.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(20, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "MALİYET:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(116, 196);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(173, 33);
            this.txtMiktar.TabIndex = 5;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(28, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "MİKTAR:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(8, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "MALZEME:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(43, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "ÜRÜN:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCikis);
            this.groupBox6.Controls.Add(this.btnKasa);
            this.groupBox6.Controls.Add(this.btnMalzemeListesi);
            this.groupBox6.Controls.Add(this.btnUrunListesi);
            this.groupBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(1120, 513);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(251, 242);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(6, 186);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(239, 41);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKasa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKasa.Location = new System.Drawing.Point(6, 133);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(239, 41);
            this.btnKasa.TabIndex = 15;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = false;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnMalzemeListesi
            // 
            this.btnMalzemeListesi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMalzemeListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMalzemeListesi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMalzemeListesi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMalzemeListesi.Location = new System.Drawing.Point(6, 80);
            this.btnMalzemeListesi.Name = "btnMalzemeListesi";
            this.btnMalzemeListesi.Size = new System.Drawing.Size(239, 41);
            this.btnMalzemeListesi.TabIndex = 14;
            this.btnMalzemeListesi.Text = "Malzeme Listesi";
            this.btnMalzemeListesi.UseVisualStyleBackColor = false;
            this.btnMalzemeListesi.Click += new System.EventHandler(this.btnMalzemeListesi_Click);
            // 
            // btnUrunListesi
            // 
            this.btnUrunListesi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUrunListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunListesi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunListesi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunListesi.Location = new System.Drawing.Point(6, 27);
            this.btnUrunListesi.Name = "btnUrunListesi";
            this.btnUrunListesi.Size = new System.Drawing.Size(239, 41);
            this.btnUrunListesi.TabIndex = 13;
            this.btnUrunListesi.Text = "Ürün Listesi";
            this.btnUrunListesi.UseVisualStyleBackColor = false;
            this.btnUrunListesi.Click += new System.EventHandler(this.btnUrunListesi_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(1053, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 494);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ÜRÜN OLUŞTUR";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(3, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 462);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1383, 767);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "MBI Pastaneleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.TextBox txtMalzemeNot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMalzemeFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMalzemeStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMalzemeAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMalzemeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUrunSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunMaliyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMaliyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunOlustur;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnMalzemeListesi;
        private System.Windows.Forms.Button btnUrunListesi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbMalzeme;
        private System.Windows.Forms.ComboBox cmbUrun;
    }
}

