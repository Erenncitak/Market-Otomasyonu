namespace MarketOtomasyonu
{
    partial class KasiyerPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerPanel));
            this.btn_et = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_sut = new System.Windows.Forms.Button();
            this.btn_baklagil = new System.Windows.Forms.Button();
            this.btn_meyveSebze = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.buttonİcon = new System.Windows.Forms.ImageList(this.components);
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_et
            // 
            this.btn_et.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_et.ImageIndex = 1;
            this.btn_et.ImageList = this.ımageList1;
            this.btn_et.Location = new System.Drawing.Point(27, 55);
            this.btn_et.Name = "btn_et";
            this.btn_et.Size = new System.Drawing.Size(175, 150);
            this.btn_et.TabIndex = 0;
            this.btn_et.UseVisualStyleBackColor = true;
            this.btn_et.Click += new System.EventHandler(this.btn_et_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "beans_4418243.ico");
            this.ımageList1.Images.SetKeyName(1, "Google-Noto-Emoji-Food-Drink-32380-cut-of-meat.ico");
            this.ımageList1.Images.SetKeyName(2, "healthy-food_10845253.ico");
            this.ımageList1.Images.SetKeyName(3, "Microsoft-Fluentui-Emoji-Mono-Cow-Face.ico");
            // 
            // btn_sut
            // 
            this.btn_sut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sut.ImageIndex = 3;
            this.btn_sut.ImageList = this.ımageList1;
            this.btn_sut.Location = new System.Drawing.Point(208, 55);
            this.btn_sut.Name = "btn_sut";
            this.btn_sut.Size = new System.Drawing.Size(175, 150);
            this.btn_sut.TabIndex = 1;
            this.btn_sut.UseVisualStyleBackColor = true;
            this.btn_sut.Click += new System.EventHandler(this.btn_sut_Click);
            // 
            // btn_baklagil
            // 
            this.btn_baklagil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_baklagil.ImageIndex = 0;
            this.btn_baklagil.ImageList = this.ımageList1;
            this.btn_baklagil.Location = new System.Drawing.Point(27, 211);
            this.btn_baklagil.Name = "btn_baklagil";
            this.btn_baklagil.Size = new System.Drawing.Size(175, 150);
            this.btn_baklagil.TabIndex = 2;
            this.btn_baklagil.UseVisualStyleBackColor = true;
            this.btn_baklagil.Click += new System.EventHandler(this.btn_baklagil_Click);
            // 
            // btn_meyveSebze
            // 
            this.btn_meyveSebze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_meyveSebze.ImageIndex = 2;
            this.btn_meyveSebze.ImageList = this.ımageList1;
            this.btn_meyveSebze.Location = new System.Drawing.Point(208, 211);
            this.btn_meyveSebze.Name = "btn_meyveSebze";
            this.btn_meyveSebze.Size = new System.Drawing.Size(175, 150);
            this.btn_meyveSebze.TabIndex = 3;
            this.btn_meyveSebze.UseVisualStyleBackColor = true;
            this.btn_meyveSebze.Click += new System.EventHandler(this.btn_meyveSebze_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis.ImageIndex = 0;
            this.btn_cikis.ImageList = this.buttonİcon;
            this.btn_cikis.Location = new System.Drawing.Point(27, 367);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cikis.Size = new System.Drawing.Size(101, 36);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // buttonİcon
            // 
            this.buttonİcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonİcon.ImageStream")));
            this.buttonİcon.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonİcon.Images.SetKeyName(0, "Custom-Icon-Design-Flatastic-1-Delete.ico");
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(316, 20);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(24, 17);
            this.lbl_saat.TabIndex = 5;
            this.lbl_saat.Text = "00";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakika.Location = new System.Drawing.Point(337, 20);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(24, 17);
            this.lbl_dakika.TabIndex = 6;
            this.lbl_dakika.Text = "00";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.Location = new System.Drawing.Point(359, 20);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(24, 17);
            this.lbl_saniye.TabIndex = 6;
            this.lbl_saniye.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 415);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_meyveSebze);
            this.Controls.Add(this.btn_sut);
            this.Controls.Add(this.btn_baklagil);
            this.Controls.Add(this.btn_et);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KasiyerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasiyerPanel";
            this.Load += new System.EventHandler(this.KasiyerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_et;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_sut;
        private System.Windows.Forms.Button btn_baklagil;
        private System.Windows.Forms.Button btn_meyveSebze;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList buttonİcon;
    }
}