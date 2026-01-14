using MarketOtomasyonu.dao;
using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.controller
{
    public class Controller
    {
        Repository repository;

        public Controller()
        {
            repository = new Repository();
        }

        public User login(string kullaniciAdi, string sifre)
        {
            User result;
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                result = repository.login(kullaniciAdi, sifre);
                return result;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.eksikParametre;
                return user;
            }
        }


        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> loginTableList = repository.getLoginTable();
            return loginTableList;
        }

        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(guvenlikCevabi) && !string.IsNullOrEmpty(guvenlikCevabi))
            {
                LoginStatus result = repository.doAuthentication(kullaniciAdi, guvenlikSorusu, guvenlikCevabi);

                if (result == LoginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }
            else
            {
                return LoginStatus.eksikParametre;
            }

        }

        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return repository.changePassword(kullaniciAdi, sifre);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public string checkEmailAddress(string kullaniciAdi)
        {
            return repository.checkEmailAddress(kullaniciAdi);
        }

        public Urun urunuGetir(string barkod)
        {
            if (!string.IsNullOrEmpty(barkod))
            {
                return repository.urunuGetir(barkod);
            }
            else
            {
                return null;
            }
        }

        public List<User> tumKullanicilariGetir()
        {
            Controller controller = new Controller();
            return repository.tumKullanicilariGetir();
        }

        public LoginStatus kullaniciEkle(User user)
        {

            if (!string.IsNullOrEmpty(user.kullaniciAdi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.yetki) && !string.IsNullOrEmpty(user.emialAdres) && !string.IsNullOrEmpty(user.guvenlikSorusu) && !string.IsNullOrEmpty(user.guvenlikCevabi))
            {
                return repository.kullaniciEkle(user);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus kullaniciGuncelle(User user)
        {
            return repository.kullaniciGuncelle(user);
        }

        public LoginStatus kullaniciSil(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                 return repository.kullaniciSil(id);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public List<Urun> tumUrunleriGetir()
        {
            return repository.tumUrunleriGetir();
        }

        public LoginStatus urunEkle(Urun urun)
        {
            if(!string.IsNullOrEmpty(urun.id) && !string.IsNullOrEmpty(urun.barkodKod) && !string.IsNullOrEmpty(urun.urunIsim))
            {
                return repository.urunEkle(urun);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
            
        }

        public LoginStatus urunGuncelle(Urun urun)
        {
            if (!string.IsNullOrEmpty(urun.id) && !string.IsNullOrEmpty(urun.barkodKod) && !string.IsNullOrEmpty(urun.urunIsim))
            {
                return repository.urunGuncelle(urun);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus urunSil(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return repository.urunSil(id);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
    }
}
