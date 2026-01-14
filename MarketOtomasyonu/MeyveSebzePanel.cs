using AForge.Video.DirectShow;
using MarketOtomasyonu.controller;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MarketOtomasyonu
{
    public partial class MeyveSebzePanel : Form
    {
        int sayi1;
        int sayi2;
        int islemTip;

        public MeyveSebzePanel()
        {
            InitializeComponent();
            txt_islem.Text = 0.ToString();
        }


        private void MeyveSebzePanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_saat.Text = DateTime.Now.Hour.ToString()+":";
            lbl_dakika.Text=DateTime.Now.Minute.ToString()+":";
            lbl_saniye.Text= DateTime.Now.Second.ToString();

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic)
            {
                comboBox_kamera.Items.Add(camera.Name);
            }
        }

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        private void btn_bir_Click(object sender, EventArgs e)
        {
            if(txt_islem.Text == "0")
            {
                txt_islem.Text = "";
            }
            txt_islem.Text += ((Button)sender).Text;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_islem.Text = "0";
        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            islemTip = 1; //artiyi temsil etsin.
            sayi1 = Convert.ToInt32(txt_islem.Text);
            txt_islem.Text = "0";

        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (islemTip == 1)
            {
                sayi2 =Convert.ToInt32(txt_islem.Text);
                txt_islem.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTip == 2)
            {
                sayi2 = Convert.ToInt32(txt_islem.Text);
                txt_islem.Text = (sayi1 - sayi2).ToString();
            }
            else if(islemTip == 3)
            {
                sayi2 = Convert.ToInt32(txt_islem.Text);
                txt_islem.Text = (sayi1 * sayi2).ToString();
            }
            else if (islemTip == 4)
            {
                sayi2 = Convert.ToInt32(txt_islem.Text);
                txt_islem.Text = (sayi1 / sayi2).ToString();
            }
        }

        private void btn_cikarma_Click(object sender, EventArgs e)
        {
            islemTip = 2; // eksiyi temsil etsin
            sayi1 = Convert.ToInt32(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            islemTip = 3; // çarpıyı temsil etsin
            sayi1 = Convert.ToInt32(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            islemTip = 4; // bölmeyi temsil etsin
            sayi1 = Convert.ToInt32(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_geriGel_Click(object sender, EventArgs e)
        {
            txt_islem.Text = txt_islem.Text.Substring(0, txt_islem.Text.Length - 1);
            if (txt_islem.Text == "")
            {
                txt_islem.Text = "0";
            }
        }

        private void comboBox_kamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_kameraAc_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[comboBox_kamera.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            qrkodTimer.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox_Kamera.Image= (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pictureBox_Kamera.Image = Image.FromFile("D:\\Enes Bayram SQL\\MarketOtomasyonu\\Resimler\\camera.ico");
        }

        private void qrkodTimer_Tick(object sender, EventArgs e)
        {
            if (pictureBox_Kamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox_Kamera.Image);

                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    qrkodTimer.Stop();
                }
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            Urun tUrun = controller.urunuGetir(textBox1.Text);
            txt_islem.Text = tUrun.fiyat.ToString();
            lbl_urunIsim.Text = tUrun.urunIsim.ToString();
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "barkod.wav";
            ses.Play();

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            KasiyerPanel kasiyerPanel = new KasiyerPanel();
            kasiyerPanel.Show();
            this.Hide();
        }
    }
}
