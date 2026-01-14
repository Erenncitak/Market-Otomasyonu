namespace MarketOtomasyonu
{
    partial class SifreDegistirme
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
            this.groupBox_guvenlikSorusu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_sifreDegistirmeAlani = new System.Windows.Forms.GroupBox();
            this.btn_sifreDegistir = new System.Windows.Forms.Button();
            this.txt_yeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_mailAlani = new System.Windows.Forms.GroupBox();
            this.btn_dogrulamaOnayla = new System.Windows.Forms.Button();
            this.btn_mailGonderme = new System.Windows.Forms.Button();
            this.txt_dogrulamaKodu = new System.Windows.Forms.TextBox();
            this.txt_emailAdres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_guvenlikSorusu.SuspendLayout();
            this.groupBox_sifreDegistirmeAlani.SuspendLayout();
            this.groupBox_mailAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_guvenlikSorusu
            // 
            this.groupBox_guvenlikSorusu.Controls.Add(this.button1);
            this.groupBox_guvenlikSorusu.Controls.Add(this.comboBox_guvenlikSorusu);
            this.groupBox_guvenlikSorusu.Controls.Add(this.txt_guvenlikCevabi);
            this.groupBox_guvenlikSorusu.Controls.Add(this.txt_kullaniciAdi);
            this.groupBox_guvenlikSorusu.Controls.Add(this.label3);
            this.groupBox_guvenlikSorusu.Controls.Add(this.label2);
            this.groupBox_guvenlikSorusu.Controls.Add(this.label1);
            this.groupBox_guvenlikSorusu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_guvenlikSorusu.Location = new System.Drawing.Point(12, 12);
            this.groupBox_guvenlikSorusu.Name = "groupBox_guvenlikSorusu";
            this.groupBox_guvenlikSorusu.Size = new System.Drawing.Size(351, 229);
            this.groupBox_guvenlikSorusu.TabIndex = 0;
            this.groupBox_guvenlikSorusu.TabStop = false;
            this.groupBox_guvenlikSorusu.Text = "Güvenlik Sorusu İle Değiştir";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_guvenlikSorusu
            // 
            this.comboBox_guvenlikSorusu.FormattingEnabled = true;
            this.comboBox_guvenlikSorusu.Location = new System.Drawing.Point(134, 88);
            this.comboBox_guvenlikSorusu.Name = "comboBox_guvenlikSorusu";
            this.comboBox_guvenlikSorusu.Size = new System.Drawing.Size(189, 25);
            this.comboBox_guvenlikSorusu.TabIndex = 1;
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(134, 133);
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(189, 25);
            this.txt_guvenlikCevabi.TabIndex = 2;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(134, 42);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(189, 25);
            this.txt_kullaniciAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik Cevabı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik Sorusu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // groupBox_sifreDegistirmeAlani
            // 
            this.groupBox_sifreDegistirmeAlani.Controls.Add(this.btn_sifreDegistir);
            this.groupBox_sifreDegistirmeAlani.Controls.Add(this.txt_yeniSifreTekrar);
            this.groupBox_sifreDegistirmeAlani.Controls.Add(this.label5);
            this.groupBox_sifreDegistirmeAlani.Controls.Add(this.txt_yeniSifre);
            this.groupBox_sifreDegistirmeAlani.Controls.Add(this.label4);
            this.groupBox_sifreDegistirmeAlani.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_sifreDegistirmeAlani.Location = new System.Drawing.Point(397, 259);
            this.groupBox_sifreDegistirmeAlani.Name = "groupBox_sifreDegistirmeAlani";
            this.groupBox_sifreDegistirmeAlani.Size = new System.Drawing.Size(396, 159);
            this.groupBox_sifreDegistirmeAlani.TabIndex = 4;
            this.groupBox_sifreDegistirmeAlani.TabStop = false;
            this.groupBox_sifreDegistirmeAlani.Text = "Şifre Değiştir";
            // 
            // btn_sifreDegistir
            // 
            this.btn_sifreDegistir.Location = new System.Drawing.Point(250, 104);
            this.btn_sifreDegistir.Name = "btn_sifreDegistir";
            this.btn_sifreDegistir.Size = new System.Drawing.Size(140, 29);
            this.btn_sifreDegistir.TabIndex = 2;
            this.btn_sifreDegistir.Text = "Değiştir";
            this.btn_sifreDegistir.UseVisualStyleBackColor = true;
            this.btn_sifreDegistir.Click += new System.EventHandler(this.btn_sifreDegistir_Click);
            // 
            // txt_yeniSifreTekrar
            // 
            this.txt_yeniSifreTekrar.Location = new System.Drawing.Point(141, 73);
            this.txt_yeniSifreTekrar.Name = "txt_yeniSifreTekrar";
            this.txt_yeniSifreTekrar.Size = new System.Drawing.Size(249, 25);
            this.txt_yeniSifreTekrar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yeni Şifre Tekrar:";
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.Location = new System.Drawing.Point(141, 36);
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.Size = new System.Drawing.Size(249, 25);
            this.txt_yeniSifre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yeni Şifre:";
            // 
            // groupBox_mailAlani
            // 
            this.groupBox_mailAlani.Controls.Add(this.btn_dogrulamaOnayla);
            this.groupBox_mailAlani.Controls.Add(this.btn_mailGonderme);
            this.groupBox_mailAlani.Controls.Add(this.txt_dogrulamaKodu);
            this.groupBox_mailAlani.Controls.Add(this.txt_emailAdres);
            this.groupBox_mailAlani.Controls.Add(this.label7);
            this.groupBox_mailAlani.Controls.Add(this.label6);
            this.groupBox_mailAlani.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_mailAlani.Location = new System.Drawing.Point(397, 12);
            this.groupBox_mailAlani.Name = "groupBox_mailAlani";
            this.groupBox_mailAlani.Size = new System.Drawing.Size(396, 229);
            this.groupBox_mailAlani.TabIndex = 1;
            this.groupBox_mailAlani.TabStop = false;
            this.groupBox_mailAlani.Text = "Mail Bilgileri";
            // 
            // btn_dogrulamaOnayla
            // 
            this.btn_dogrulamaOnayla.Location = new System.Drawing.Point(250, 173);
            this.btn_dogrulamaOnayla.Name = "btn_dogrulamaOnayla";
            this.btn_dogrulamaOnayla.Size = new System.Drawing.Size(140, 29);
            this.btn_dogrulamaOnayla.TabIndex = 2;
            this.btn_dogrulamaOnayla.Text = "Onayla";
            this.btn_dogrulamaOnayla.UseVisualStyleBackColor = true;
            this.btn_dogrulamaOnayla.Click += new System.EventHandler(this.btn_dogrulamaOnayla_Click);
            // 
            // btn_mailGonderme
            // 
            this.btn_mailGonderme.Location = new System.Drawing.Point(198, 88);
            this.btn_mailGonderme.Name = "btn_mailGonderme";
            this.btn_mailGonderme.Size = new System.Drawing.Size(192, 29);
            this.btn_mailGonderme.TabIndex = 2;
            this.btn_mailGonderme.Text = "Doğrulama Kodu Gönder";
            this.btn_mailGonderme.UseVisualStyleBackColor = true;
            this.btn_mailGonderme.Click += new System.EventHandler(this.btn_dogrulamaKodu_Click);
            // 
            // txt_dogrulamaKodu
            // 
            this.txt_dogrulamaKodu.Location = new System.Drawing.Point(136, 136);
            this.txt_dogrulamaKodu.Name = "txt_dogrulamaKodu";
            this.txt_dogrulamaKodu.Size = new System.Drawing.Size(254, 25);
            this.txt_dogrulamaKodu.TabIndex = 0;
            // 
            // txt_emailAdres
            // 
            this.txt_emailAdres.Location = new System.Drawing.Point(136, 45);
            this.txt_emailAdres.Name = "txt_emailAdres";
            this.txt_emailAdres.Size = new System.Drawing.Size(254, 25);
            this.txt_emailAdres.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doğrulama Kodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Adresiniz:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox_sifreDegistirmeAlani);
            this.Controls.Add(this.groupBox_mailAlani);
            this.Controls.Add(this.groupBox_guvenlikSorusu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistirme";
            this.Load += new System.EventHandler(this.SifreDegistirme_Load);
            this.groupBox_guvenlikSorusu.ResumeLayout(false);
            this.groupBox_guvenlikSorusu.PerformLayout();
            this.groupBox_sifreDegistirmeAlani.ResumeLayout(false);
            this.groupBox_sifreDegistirmeAlani.PerformLayout();
            this.groupBox_mailAlani.ResumeLayout(false);
            this.groupBox_mailAlani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_guvenlikSorusu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_sifreDegistirmeAlani;
        private System.Windows.Forms.Button btn_sifreDegistir;
        private System.Windows.Forms.TextBox txt_yeniSifreTekrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_guvenlikSorusu;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_mailAlani;
        private System.Windows.Forms.TextBox txt_emailAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_mailGonderme;
        private System.Windows.Forms.TextBox txt_dogrulamaKodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_dogrulamaOnayla;
        private System.Windows.Forms.Button button2;
    }
}