namespace MarketOtomasyonu
{
    partial class KullaniciPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_kullanici = new System.Windows.Forms.GroupBox();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.comboBox_bolge = new System.Windows.Forms.ComboBox();
            this.comboBox_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.comboBox_yetki = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_guvenlikCevap = new System.Windows.Forms.TextBox();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.txt_emailAdres = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_kullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(965, 176);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // groupBox_kullanici
            // 
            this.groupBox_kullanici.Controls.Add(this.btn_kayitSil);
            this.groupBox_kullanici.Controls.Add(this.btn_geri);
            this.groupBox_kullanici.Controls.Add(this.btn_kayitGuncelle);
            this.groupBox_kullanici.Controls.Add(this.btn_kayitEkle);
            this.groupBox_kullanici.Controls.Add(this.comboBox_bolge);
            this.groupBox_kullanici.Controls.Add(this.comboBox_guvenlikSorusu);
            this.groupBox_kullanici.Controls.Add(this.comboBox_yetki);
            this.groupBox_kullanici.Controls.Add(this.label4);
            this.groupBox_kullanici.Controls.Add(this.label1);
            this.groupBox_kullanici.Controls.Add(this.label2);
            this.groupBox_kullanici.Controls.Add(this.lbl_sifre);
            this.groupBox_kullanici.Controls.Add(this.txt_sifre);
            this.groupBox_kullanici.Controls.Add(this.label5);
            this.groupBox_kullanici.Controls.Add(this.label3);
            this.groupBox_kullanici.Controls.Add(this.txt_guvenlikCevap);
            this.groupBox_kullanici.Controls.Add(this.label6);
            this.groupBox_kullanici.Controls.Add(this.lbl_kullaniciAdi);
            this.groupBox_kullanici.Controls.Add(this.txt_emailAdres);
            this.groupBox_kullanici.Controls.Add(this.txt_id);
            this.groupBox_kullanici.Controls.Add(this.txt_kullaniciAdi);
            this.groupBox_kullanici.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_kullanici.Location = new System.Drawing.Point(12, 194);
            this.groupBox_kullanici.Name = "groupBox_kullanici";
            this.groupBox_kullanici.Size = new System.Drawing.Size(776, 316);
            this.groupBox_kullanici.TabIndex = 1;
            this.groupBox_kullanici.TabStop = false;
            this.groupBox_kullanici.Text = "Kullanıcı Paneli";
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.Location = new System.Drawing.Point(409, 262);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(349, 37);
            this.btn_kayitSil.TabIndex = 9;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = true;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(18, 219);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(323, 37);
            this.btn_kayitGuncelle.TabIndex = 8;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = true;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.Location = new System.Drawing.Point(409, 218);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(349, 38);
            this.btn_kayitEkle.TabIndex = 7;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.UseVisualStyleBackColor = true;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // comboBox_bolge
            // 
            this.comboBox_bolge.FormattingEnabled = true;
            this.comboBox_bolge.Location = new System.Drawing.Point(110, 167);
            this.comboBox_bolge.Name = "comboBox_bolge";
            this.comboBox_bolge.Size = new System.Drawing.Size(231, 25);
            this.comboBox_bolge.TabIndex = 3;
            // 
            // comboBox_guvenlikSorusu
            // 
            this.comboBox_guvenlikSorusu.FormattingEnabled = true;
            this.comboBox_guvenlikSorusu.Location = new System.Drawing.Point(528, 107);
            this.comboBox_guvenlikSorusu.Name = "comboBox_guvenlikSorusu";
            this.comboBox_guvenlikSorusu.Size = new System.Drawing.Size(230, 25);
            this.comboBox_guvenlikSorusu.TabIndex = 5;
            // 
            // comboBox_yetki
            // 
            this.comboBox_yetki.FormattingEnabled = true;
            this.comboBox_yetki.Location = new System.Drawing.Point(110, 129);
            this.comboBox_yetki.Name = "comboBox_yetki";
            this.comboBox_yetki.Size = new System.Drawing.Size(231, 25);
            this.comboBox_yetki.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(406, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Güvenlik Sorusu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölge:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yetki:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(15, 98);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(42, 17);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(110, 95);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(231, 25);
            this.txt_sifre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(406, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Güvenlik Cevabı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(406, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email Adres:";
            // 
            // txt_guvenlikCevap
            // 
            this.txt_guvenlikCevap.Location = new System.Drawing.Point(528, 149);
            this.txt_guvenlikCevap.Name = "txt_guvenlikCevap";
            this.txt_guvenlikCevap.Size = new System.Drawing.Size(230, 25);
            this.txt_guvenlikCevap.TabIndex = 6;
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(15, 70);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(89, 17);
            this.lbl_kullaniciAdi.TabIndex = 1;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txt_emailAdres
            // 
            this.txt_emailAdres.Location = new System.Drawing.Point(528, 67);
            this.txt_emailAdres.Name = "txt_emailAdres";
            this.txt_emailAdres.Size = new System.Drawing.Size(230, 25);
            this.txt_emailAdres.TabIndex = 4;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(110, 67);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(231, 25);
            this.txt_kullaniciAdi.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(110, 36);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(231, 25);
            this.txt_id.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID:";
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(18, 262);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(69, 37);
            this.btn_geri.TabIndex = 8;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // KullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 522);
            this.Controls.Add(this.groupBox_kullanici);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullaniciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciPanel";
            this.Load += new System.EventHandler(this.KullaniciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_kullanici.ResumeLayout(false);
            this.groupBox_kullanici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_kullanici;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.ComboBox comboBox_bolge;
        private System.Windows.Forms.ComboBox comboBox_guvenlikSorusu;
        private System.Windows.Forms.ComboBox comboBox_yetki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_guvenlikCevap;
        private System.Windows.Forms.TextBox txt_emailAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_geri;
    }
}