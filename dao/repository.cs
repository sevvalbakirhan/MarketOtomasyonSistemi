using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using market.dao;

namespace market.dao
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
            con = new SqlConnection(@"Data Source=SEVVALBAKIRHAN\SQLEXPRESS;Initial Catalog=market;Integrated Security=True;TrustServerCertificate=True");
        }
        public void baglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
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
                    loginTable.id = int.Parse((dr["id"].ToString()));
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
            catch (Exception e)
            {
                Console.WriteLine("Hata oluştu!");
            }
            return loginTableList;
        }
        public List<string> getGuvenlikSorulari()
        {
            List<string> sorular = new List<string>();

            try
            {
                con.Open();
                cmd = new SqlCommand("guvenlikSorusuGetir_sp", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sorular.Add(dr["guvenlikSorusu"].ToString());
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            return sorular;
        }
        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from loginTable where kullaniciAdi=@kulad and guvenlikSorusu=@guvSorusu and guvenlikCevabi=@guvCevabi", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@guvSorusu", guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvCevabi", guvenlikCevabi);

            returnvalue = (int)cmd.ExecuteScalar();
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
        public User login(string kullaniciAdi, string sifre)
        {
            try
            {
                // Bağlantıyı kontrol et ve aç
                baglantiAyarla();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM loginTable WHERE kullaniciAdi=@kullaniciAdi AND sifre=@sifre", con))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            User user = new User
                            {
                                id = int.Parse(dr["id"].ToString()),
                                kullaniciAdi = dr["kullaniciAdi"].ToString(),
                                sifre = dr["sifre"].ToString(),
                                yetki = dr["yetki"].ToString(),
                                emailAdres = dr["emailAdres"].ToString(),
                                guvenlikSorusu = dr["guvenlikSorusu"].ToString(),
                                guvenlikCevabi = dr["guvenlikCevabi"].ToString(),
                                status = LoginStatus.basarili
                            };
                            return user;
                        }
                        else
                        {
                            return new User { status = LoginStatus.basarisiz };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını loglayabilir veya kullanıcıya gösterebilirsiniz
                Console.WriteLine("Hata: " + ex.Message);
                return new User { status = LoginStatus.basarisiz };
            }
            finally
            {
                // Bağlantıyı kapat
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
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
            string emailAdres = (string)cmd.ExecuteScalar();
            con.Close();

            return emailAdres;
        }
        public Urun urunuGetir(string barkod)
        {
            con.Open();
            cmd = new SqlCommand("select * from urun where barkodkod = @code", con);
            cmd.Parameters.AddWithValue("@code", barkod);
            dr = cmd.ExecuteReader();
            Urun urun = new Urun();
            while (dr.Read())
            {

                urun.fiyat = int.Parse(dr["fiyat"].ToString());
                urun.urunİsim = dr["urunİsim"].ToString();
            }
            con.Close();
            return urun;
        }
        public List<User> tumKullanicileriGetir()
        {
            List<User> userList = new List<User>();
            con.Open();
            cmd = new SqlCommand("select * from loginTable", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.bolge = dr["bolge"].ToString();
                user.emailAdres = dr["emailAdres"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                userList.Add(user);


            }
            con.Close();
            return userList;

        }
        public LoginStatus kullaniciEkle(User user)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullaniciEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);

            cmd.Parameters.AddWithValue("@bolge", user.bolge);
            cmd.Parameters.AddWithValue("@emailAdres", user.emailAdres);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", user.guvenlikCevabi);
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
        public LoginStatus kullaniciGuncelle(User user)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullaniciGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@bolge", user.bolge);
            cmd.Parameters.AddWithValue("@emailAdres", user.emailAdres);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", user.guvenlikCevabi);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            return LoginStatus.basarisiz;
        }
        public LoginStatus kullaniciSil(int id)
        {
            con.Open();
            cmd = new SqlCommand("delete from loginTable where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnValue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnValue == 1)
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
            while (dr.Read())
            {
                Urun urun = new Urun();
                urun.id = dr["id"].ToString();
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodkod = dr["barkodkod"].ToString();
                urun.olusturulma_Tarih = DateTime.Parse(dr["olusturulma_Tarih"].ToString());
                if (!string.IsNullOrEmpty(dr["guncelleme_Tarih"].ToString()))
                {
                    urun.güncelleme_Tarih = DateTime.Parse(dr["guncelleme_Tarih"].ToString());
                }
                urun.urunİsim = dr["urunİsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());
                urun.ciro = int.Parse(dr["ciro"].ToString());
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
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodkod", urun.barkodkod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", urun.olusturulma_Tarih);
            cmd.Parameters.AddWithValue("@guncelleme_Tarih", urun.güncelleme_Tarih);
            cmd.Parameters.AddWithValue("@urunİsim", urun.urunİsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            return LoginStatus.basarisiz;
        }
        public LoginStatus urunGuncelle(Urun urun)
        {
            con.Open();
            cmd = new SqlCommand("sp_urunGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodkod", urun.barkodkod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", urun.olusturulma_Tarih);
            cmd.Parameters.AddWithValue("@guncelleme_Tarih", urun.güncelleme_Tarih);
            cmd.Parameters.AddWithValue("@urunİsim", urun.urunİsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
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
            return LoginStatus.basarisiz;
        }


    }

}

