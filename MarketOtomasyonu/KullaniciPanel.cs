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

namespace MarketOtomasyonu
{
    public partial class KullaniciPanel : Form
    {
        Controller controller = new Controller();
        public KullaniciPanel()
        {
            InitializeComponent();
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            defaultDegerleriDoldur();
            tumKullanicilariDoldur();
        }

        private void defaultDegerleriDoldur()
        {
            comboBox_yetki.Items.Add("admin");
            comboBox_yetki.Items.Add("kasiyer");
            comboBox_yetki.SelectedIndex = 0;

            comboBox_bolge.Items.Add("Adalar");
            comboBox_bolge.Items.Add("Arnavutköy");
            comboBox_bolge.Items.Add("Ataşehir");
            comboBox_bolge.Items.Add("Avcılar");
            comboBox_bolge.Items.Add("Bağcılar");
            comboBox_bolge.Items.Add("Bakırköy");
            comboBox_bolge.Items.Add("Beyoğlu");
            comboBox_bolge.Items.Add("Çatalca");
            comboBox_bolge.Items.Add("Çekmeköy");
            comboBox_bolge.Items.Add("Sancaktepe");
            comboBox_bolge.SelectedIndex = 0;

            comboBox_guvenlikSorusu.Items.Add("En sevdiğiniz hayvan nedir");
            comboBox_guvenlikSorusu.Items.Add("En sevdiğiniz araba?");
            comboBox_guvenlikSorusu.Items.Add("Birinci sınıf öğretmeninizin ismi?");
            comboBox_guvenlikSorusu.Items.Add("En sevdiğiniz hayvanınızın ismi?");
            comboBox_guvenlikSorusu.Items.Add("Annenizin kızlık soyadı nedir?");
            comboBox_guvenlikSorusu.Items.Add("Hangi şehirde doğdunuz?");
            comboBox_guvenlikSorusu.Items.Add("Babanızın ortanca ismi nedir?");
            comboBox_guvenlikSorusu.Items.Add("Çocukluk lakabınız nedir?");
            comboBox_guvenlikSorusu.Items.Add("İlk telefonunuzun modeli nedir?");
            comboBox_guvenlikSorusu.SelectedIndex = 0;
        }

        private void tumKullanicilariDoldur()
        {
            List<User> userList = controller.tumKullanicilariGetir();
            dataGridView1.DataSource =userList;
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = comboBox_yetki.SelectedItem.ToString();
            user.bolge = comboBox_bolge.SelectedItem.ToString();
            user.emialAdres = txt_emailAdres.Text;
            user.guvenlikSorusu = comboBox_guvenlikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_guvenlikCevap.Text;

            LoginStatus sonuc = controller.kullaniciEkle(user);

            if(sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Gerekli alanların hepsini doldurun !","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox_bolge.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_emailAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox_guvenlikSorusu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_guvenlikCevap.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id =Convert.ToInt32(txt_id.Text);
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = comboBox_yetki.SelectedItem.ToString();
            user.bolge = comboBox_bolge.SelectedItem.ToString();
            user.emialAdres = txt_emailAdres.Text;
            user.guvenlikSorusu = comboBox_guvenlikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_guvenlikCevap.Text;
            LoginStatus sonuc =  controller.kullaniciGuncelle(user);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu!!! !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                LoginStatus sonuc = controller.kullaniciSil(int.Parse(txt_id.Text));
                if (sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Kayıt silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumKullanicilariGetir();
                }
                else if (sonuc == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Kayıt silinirken bir hata oluştu!!! !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz id değerini giriniz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz id değerini giriniz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();

            this.Hide();
        }
    }
}
