using MarketOtomasyonu.controller;
using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class SifreDegistirme : Form
    {
        int code;
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            List<LoginTable>  loginTableList = controller.getLoginTable();
            groupBox_mailAlani.Enabled = false;
            groupBox_sifreDegistirmeAlani.Enabled=false;

            foreach(LoginTable lt in loginTableList)
            {
                comboBox_guvenlikSorusu.Items.Add(lt.guvenlikSorusu.ToString());
            }
            comboBox_guvenlikSorusu.SelectedIndex = 0;

        }

        private void btn_dogrulamaKodu_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            string emailAdres= controller.checkEmailAddress(txt_kullaniciAdi.Text);
            try
            {
                if (emailAdres == txt_emailAdres.Text)
                {

                    Random rnd = new Random();
                    code = rnd.Next(111111, 999999);

                    MailAddress mailAlan = new MailAddress(txt_emailAdres.Text, txt_kullaniciAdi.Text);
                    MailAddress mailGonderen = new MailAddress("marketotomasyonumail@gmail.com", "Eren Çıtak");

                    MailMessage mesaj = new MailMessage();
                    mesaj.To.Add(mailAlan);
                    mesaj.From = mailGonderen;
                    mesaj.Subject = "Şifre Değiştirme";
                    mesaj.Body = "Şifrenizi değiştirmek için doğrulama kodunuz :" + code;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("marketotomasyonumail@gmail.com", "cvodrkcnhibjonzo");
                    smtp.Send(mesaj);
                    MessageBox.Show("Doğrulama kodu gönderildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hesabınıza bağlı mail adresini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            
            catch (Exception ex)
                {
                MessageBox.Show(ex.ToString(), "HATA DETAYI");
               }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            LoginStatus result = controller.doAuthentication(txt_kullaniciAdi.Text.Trim().ToLower(),comboBox_guvenlikSorusu.SelectedItem.ToString(),txt_guvenlikCevabi.Text.ToLower());

            if (result == LoginStatus.basarili)
            {
                groupBox_mailAlani.Enabled = true;
            }
            else if(result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Girdiğiniz bilgileri kontrol ediniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_dogrulamaOnayla_Click(object sender, EventArgs e)
        {
            if(txt_dogrulamaKodu.Text == code.ToString())
            {
                groupBox_sifreDegistirmeAlani.Enabled=true;
            }
            else
            {
                MessageBox.Show("Doğrulama kodunuz yanlıştır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sifreDegistir_Click(object sender, EventArgs e)
        {
            Controller controller =new Controller();

            if(txt_yeniSifre.Text == txt_yeniSifreTekrar.Text)
            {
                LoginStatus result = controller.changePassword(txt_kullaniciAdi.Text, txt_yeniSifreTekrar.Text);
                
                if(result == LoginStatus.basarili)
                {
                    MessageBox.Show("Şifreniz değiştirilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f1 = new Form1();
                    f1.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("İki şifre birbirleriyle aynı değil!!.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();
        }
    }
}
