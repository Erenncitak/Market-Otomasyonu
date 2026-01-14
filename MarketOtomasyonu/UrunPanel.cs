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
    public partial class UrunPanel : Form
    {
        Controller controller = new Controller();
        public UrunPanel()
        {
            InitializeComponent();
        }

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            tumUrunleriGetir();
            defaultAlanlariDoldur();
        }

        public void tumUrunleriGetir()
        {
            dataGridView1.DataSource = controller.tumUrunleriGetir();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();

            this.Hide();
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.id = txt_id.Text;
            urun.qrkod = txt_qrkod.Text;
            urun.barkodKod = txt_barkodKod.Text;
            urun.olusturulma_Tarih = datetime_olusturmaTarih.Value;
            urun.guncellenme_Tarih = datetime_guncellemeTarih.Value;
            urun.urunIsim = comboBox_urunİsim.SelectedItem.ToString();
            urun.kilo = Convert.ToInt32(txt_kilo.Text);
            urun.fiyat = Convert.ToInt32(txt_fiyat.Text);
            urun.ciro= Convert.ToInt32(txt_ciro.Text);
            LoginStatus sonuc = controller.urunEkle(urun);
            if(sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün eklendi.","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumUrunleriGetir();
                parametreleriTemizle();
            }
            else if (sonuc == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün eklenemedi!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void defaultAlanlariDoldur()
        {
            comboBox_urunİsim.Items.Add("Brokoli");
            comboBox_urunİsim.Items.Add("Çilek");
            comboBox_urunİsim.Items.Add("Elma");
            comboBox_urunİsim.Items.Add("Lahana");
            comboBox_urunİsim.Items.Add("Muz");
            comboBox_urunİsim.Items.Add("Portakal");
            comboBox_urunİsim.Items.Add("Üzüm");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_qrkod.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_barkodKod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            datetime_olusturmaTarih.Value=Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            datetime_guncellemeTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            comboBox_urunİsim.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_kilo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_fiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_ciro.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.id = txt_id.Text;
            urun.qrkod = txt_qrkod.Text;
            urun.barkodKod = txt_barkodKod.Text;
            urun.olusturulma_Tarih = datetime_olusturmaTarih.Value;
            urun.guncellenme_Tarih = datetime_guncellemeTarih.Value;
            urun.urunIsim = comboBox_urunİsim.SelectedItem.ToString();
            urun.kilo = Convert.ToInt32(txt_kilo.Text);
            urun.fiyat = Convert.ToInt32(txt_fiyat.Text);
            urun.ciro= Convert.ToInt32(txt_ciro.Text);
            LoginStatus sonuc = controller.urunGuncelle(urun);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumUrunleriGetir();
                parametreleriTemizle();
            }
            else if (sonuc == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün güncellenirken bir hata oluştu!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
               LoginStatus sonuc = controller.urunSil(txt_id.Text);
                if(sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Ürün başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumUrunleriGetir();
                    parametreleriTemizle();
                }
                else
                {
                    MessageBox.Show("Ürün silinirken bir hata oluştu!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void parametreleriTemizle()
        {
            txt_id.Text = string.Empty;
            txt_qrkod.Text = string.Empty;
            txt_barkodKod.Text = string.Empty;
            datetime_olusturmaTarih.Value= DateTime.Now;
            datetime_guncellemeTarih.Value = DateTime.Now;
            comboBox_urunİsim.Text=string.Empty;
            txt_kilo.Text = string.Empty;
            txt_fiyat.Text = string.Empty;
            txt_ciro.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parametreleriTemizle();
        }
    }
}
