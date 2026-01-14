using MarketOtomasyonu.controller;
using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace MarketOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result = controller.login(txt_kullaniciAdi.Text,txt_sifre.Text);
            
            if(result != null && result.status==LoginStatus.basarili && result.yetki.ToLower()=="admin")
            {
                // Admin sayfasına yönlendirme
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();

                this.Hide();
            }
            else if(result != null && result.status==LoginStatus.basarili && result.yetki.ToLower() == "kasiyer")
            {
                KasiyerPanel kasiyetPanel = new KasiyerPanel();
                kasiyetPanel.Show();

                this.Hide();
            }
            else if(result != null && result.status == LoginStatus.basarisiz)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik parametre hatası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl_sifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifreDegistirme SD = new SifreDegistirme();
            SD.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
