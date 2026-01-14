using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ZXing.QrCode.Internal;

namespace MarketOtomasyonu.dao
{
    public class Repository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<LoginTable> loginTableList;
        public Repository() 
        {
            con = new SqlConnection("Data Source=localhost;Initial Catalog=market;User ID=sa;Encrypt=False;password=1");
        }

        public void baglantiAyarla()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        public User login(string kullaniciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select * from loginTable where kullaniciAdi=@kulad and sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            dr = cmd.ExecuteReader();
            
            if(dr.Read())
            {
                User user = new User();
                user.id =Convert.ToInt32(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.emialAdres = dr["emailAdres"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                user.status = LoginStatus.basarili;
                return user;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.basarisiz;
                return user;
            }
        }

        public List<LoginTable> getLoginTable()
        {
            loginTableList = new List<LoginTable>();
            try
            {
                con.Open();
                cmd = new SqlCommand("guvenlikSorusuGetir_sp", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    LoginTable loginTable = new LoginTable();
                    loginTable.id = Convert.ToInt32(dr["id"].ToString());
                    loginTable.kullaniciAdi = dr["kullaniciAdi"].ToString();
                    loginTable.sifre = dr["sifre"].ToString();
                    loginTable.yetki = dr["yetki"].ToString();
                    loginTable.emailAdres = dr["emailAdres"].ToString();
                    loginTable.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                    loginTable.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                    loginTableList.Add(loginTable);
                }
                con.Close();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return loginTableList;
        }


        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from loginTable where kullaniciAdi=@kulad and guvenlikSorusu=@guvSorusu and guvenlikCevabi=@guvCevabi",con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@guvSorusu", guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvCevabi", guvenlikCevabi);
            returnvalue=Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("sifreGuncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            return LoginStatus.basarili;
        }

        public string checkEmailAddress(string kullaniciAdi)
        {
            con.Open();
            cmd = new SqlCommand("select emailAdres from loginTable where kullaniciAdi=@kulad", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            string emailAdres =(string)cmd.ExecuteScalar();
            con.Close();

            return emailAdres;
        }

        public Urun urunuGetir(string barkod)
        {
            con.Open();
            cmd = new SqlCommand("select * from urun where barkodKod=@code", con);
            cmd.Parameters.AddWithValue("@code", barkod);
            dr= cmd.ExecuteReader();
            Urun urun = new Urun();
            while (dr.Read())
            {
                urun.id = dr["id"].ToString();
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodKod = dr["barkodKod"].ToString();
                //urun.olusturulma_Tarih =Convert.ToDateTime(dr["olusturulma_Tarih"].ToString());
                //urun.guncellenme_Tarih = Convert.ToDateTime(dr["guncellenme_Tarih"].ToString());
                urun.urunIsim = dr["urunIsim"].ToString();
                urun.kilo =Convert.ToInt32(dr["kilo"].ToString());
                urun.fiyat = Convert.ToInt32(dr["fiyat"].ToString());
                //urun.ciro = Convert.ToInt32(dr["ciro"].ToString());            
            }
            con.Close();

            return urun;
        }

        public List<User> tumKullanicilariGetir()
        {
            List<User> userList = new List<User>();
            con.Open();
            cmd = new SqlCommand("select * from loginTable", con);
            dr=cmd.ExecuteReader();

            while (dr.Read())
            {
                User user = new User();
                user.id =Convert.ToInt32(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.bolge = dr["bolge"].ToString();
                user.emialAdres = dr["emailAdres"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                userList.Add(user);
            }
            con.Close();

            return userList;
        }

        public LoginStatus kullaniciEkle(User user )
        {
            List<User> users = new List<User>();
            con.Open();
            cmd = new SqlCommand("sp_kullaniciEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi",user.kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre",user.sifre);
            cmd.Parameters.AddWithValue("@yetki",user.yetki);
            cmd.Parameters.AddWithValue("@bolge",user.bolge);
            cmd.Parameters.AddWithValue("@emailAdres",user.emialAdres);
            cmd.Parameters.AddWithValue("@guvenlikSorusu",user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabi",user.guvenlikCevabi);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }  
        }


        public LoginStatus kullaniciGuncelle(User user)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullaniciGuncelle",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre",user.sifre);
            cmd.Parameters.AddWithValue("@yetki",user.yetki);
            cmd.Parameters.AddWithValue("@bolge",user.bolge);
            cmd.Parameters.AddWithValue("@emailAdres",user.emialAdres);
            cmd.Parameters.AddWithValue("@guvenlikSorusu",user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabi",user.guvenlikCevabi);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if(returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

        public LoginStatus kullaniciSil(int id)
        {
            con.Open();
            cmd = new SqlCommand("delete from loginTable where id=@id", con);
            cmd.Parameters.AddWithValue("@id",id);
            returnvalue= cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

        public List<Urun> tumUrunleriGetir()
        {
            List<Urun> urunList = new List<Urun>();
            con.Open();
            cmd = new SqlCommand("select * from urun", con);
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Urun urun = new Urun();
                urun.id = dr["id"].ToString();
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodKod = dr["barkodKod"].ToString();
                urun.olusturulma_Tarih =Convert.ToDateTime(dr["olusturulma_Tarih"].ToString());
                if (!string.IsNullOrEmpty(dr["guncellenme_Tarih"].ToString()))
                {
                    urun.guncellenme_Tarih = Convert.ToDateTime(dr["guncellenme_Tarih"].ToString());
                }
                urun.urunIsim = dr["urunIsim"].ToString();
                urun.kilo =Convert.ToInt32(dr["kilo"].ToString());
                urun.fiyat = Convert.ToInt32(dr["fiyat"].ToString());
                urun.ciro = Convert.ToInt32(dr["ciro"].ToString());
                urunList.Add(urun);
            }
            con.Close();

            return urunList;
        }

        public LoginStatus urunEkle(Urun urun)
        {
            con.Open();
            cmd = new SqlCommand("sp_urunEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",urun.id);
            cmd.Parameters.AddWithValue("@qrkod",urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodKod",urun.barkodKod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih",urun.olusturulma_Tarih);
            cmd.Parameters.AddWithValue("@guncellenme_Tarih",urun.guncellenme_Tarih);
            cmd.Parameters.AddWithValue("@urunIsim",urun.urunIsim);
            cmd.Parameters.AddWithValue("@kilo",urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat",urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro",urun.ciro);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if(returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

        }

        public LoginStatus urunGuncelle(Urun urun)
        {
            con.Open();
            cmd = new SqlCommand("sp_urunGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodKod", urun.barkodKod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", urun.olusturulma_Tarih);
            cmd.Parameters.AddWithValue("@guncellenme_Tarih", urun.guncellenme_Tarih);
            cmd.Parameters.AddWithValue("@urunIsim", urun.urunIsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if(returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

        public LoginStatus urunSil(string id)
        {
            con.Open();
            cmd = new SqlCommand("delete from urun where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

                
        }
    }
}

