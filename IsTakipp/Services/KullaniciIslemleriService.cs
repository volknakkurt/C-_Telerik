using com.sun.java.swing.plaf.motif.resources;
using com.sun.tools.@internal.xjc.reader.xmlschema;
using com.sun.tools.javac.util;
using IsTakipp.DTO;
using IsTakipp.Services;
using java.sql;
using sun.security.krb5.@internal.tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IsTakipp.Services
{
    public class KullaniciIslemleriService
    {
        /// <summary>
        /// Ekran listesini getirir
        /// </summary>
        /// <returns></returns>
        public List<KullaniciDTO.EkranDTO> EkranListesiGetir()
        {
            DataResultDTO etab = Baglanti.Select("Select Id EkranId, Ad EkranAdi from Ekran"); ;

            List<KullaniciDTO.EkranDTO> ekranList = etab.ResultData.DataTableToList<KullaniciDTO.EkranDTO>();
            return ekranList;
        }

        /// <summary>
        /// Kullanıcı Listesini getiri
        /// </summary>
        /// <returns>List<KullaniciDTO> KullaniciDTO liste olarak döner</returns>
        public List<KullaniciDTO> KullaniciGetir()
        {
            //Tüm kullanıcıları Getir
            DataResultDTO ktab = Baglanti.Select("Select * from Kullanici Where SilmeTarihi IS NULL");
            List<KullaniciDTO> kullaniciList = ktab.ResultData.DataTableToList<KullaniciDTO>();

            //Tüm kullanıcıların ekran yetkilerini getir
            DataResultDTO kytab = Baglanti.Select("Select * from KullaniciEkranYetki WHERE  SilmeTarihi IS NULL");
            List<KullaniciDTO.KullaniciEkranYetkiDTO> kullaniciEkranYetkiList = kytab.ResultData.DataTableToList<KullaniciDTO.KullaniciEkranYetkiDTO>();
            //Ekran listesi getir
            List<KullaniciDTO.EkranDTO> ekranList = EkranListesiGetir();

            //Kullanıcıların ekran listelerini doldur
            foreach (KullaniciDTO kullanici in kullaniciList)
            {
                kullanici.Ekrans = ekranList.Select(e => Helper.Clone<KullaniciDTO.EkranDTO>(e)).ToList();                
            }

            //Kullanıcıların ekran yetkilerini eşleştir.
            foreach (KullaniciDTO.KullaniciEkranYetkiDTO kullaniciEkranYetki in kullaniciEkranYetkiList)
            {
                foreach (KullaniciDTO kullanici in kullaniciList)
                {
                    if (kullanici.Id == kullaniciEkranYetki.KullaniciId)
                    {
                        foreach (KullaniciDTO.EkranDTO ekran in kullanici.Ekrans)
                        {
                            if (ekran.EkranId == kullaniciEkranYetki.EkranId)
                            {
                                ekran.Yetkili = kullaniciEkranYetki.Yetki;
                                break;
                            }
                        }
                    }
                }
            }
            return kullaniciList;
        }

        /// <summary>
        /// Kullanıcı ve ekran yetkilerini kaydeder
        /// </summary>
        /// <param name="kaydedilecekKullaniciList"></param>
        public void KullaniciKaydet(List<KullaniciDTO> kaydedilecekKullaniciList)
        {
            if (kaydedilecekKullaniciList == null)
            {
                return;
            }
            string insertKullaniciStr = @"IF NOT EXISTS(Select 1 From Kullanici Where Id = @prmKullaniciId and SilenKullaniciId IS NULL) 
                                          BEGIN 
                                            INSERT INTO Kullanici (Rol, AdSoyad, Sifre, Mail, Aktif, KayitTarihi, KaydedenKullaniciId) VALUES (@prmRol, @prmAdSoyad,@prmSifre, @prmMail, @prmAktif, @prmKayitTarihi, @prmKaydedenKullaniciId)
                                            SELECT SCOPE_IDENTITY()
                                          END ELSE 
                                            UPDATE Kullanici SET Rol = @prmRol, AdSoyad = @prmAdSoyad, Sifre = @prmSifre ,Mail = @prmMail, Aktif = @prmAktif, SilmeTarihi = @prmSilmeTarihi, SilenKullaniciId = @prmSilenKullaniciId Where Id = @prmKullaniciId";

            string insertKullaniEkranYetkiStr = @"IF NOT EXISTS(Select 1 from KullaniciEkranYetki WHERE KullaniciId = @prmKullaniciId and EkranId = @prmEkranId and SilenKullaniciId IS NULL) 
                                                BEGIN
                                                    INSERT INTO KullaniciEkranYetki (KullaniciId, EkranId, Yetki, KayitTarihi, KaydedenKullaniciId) VALUES (@prmKullaniciId, @prmEkranId, @prmYetki, @prmKayitTarihi, @prmKaydedenKullaniciId)                                    
                                                END ELSE 
                                                    UPDATE KullaniciEkranYetki SET Yetki = @prmYetki, SilmeTarihi = @prmSilmeTarihi, SilenKullaniciId = @prmSilenKullaniciId WHERE KullaniciId = @prmKullaniciId and EkranId = @prmEkranId and SilenKullaniciId IS NULL";

            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            using (SqlConnection con = new SqlConnection(Baglanti.GetConnectionString()))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        //Önce kullanıcı bilgileri kaydedilir
                        foreach (KullaniciDTO kaydedilecekKullanici in kaydedilecekKullaniciList)
                        {
                            sqlParameters.Clear();
                            sqlParameters.Add(new SqlParameter("@prmKullaniciId", kaydedilecekKullanici.Id));
                            sqlParameters.Add(new SqlParameter("@prmRol", kaydedilecekKullanici.Rol));
                            sqlParameters.Add(new SqlParameter("@prmAdSoyad", kaydedilecekKullanici.AdSoyad));
                            sqlParameters.Add(new SqlParameter("@prmSifre", kaydedilecekKullanici.Sifre));
                            sqlParameters.Add(new SqlParameter("@prmMail", kaydedilecekKullanici.Mail));
                            sqlParameters.Add(new SqlParameter("@prmAktif", kaydedilecekKullanici.Aktif));
                            sqlParameters.Add(new SqlParameter("@prmKayitTarihi", DateTime.Now));
                            sqlParameters.Add(new SqlParameter("@prmKaydedenKullaniciId", 1));
                            sqlParameters.Add(new SqlParameter("@prmSilenKullaniciId", kaydedilecekKullanici.IsDeleted ? (object)1 : DBNull.Value));
                            sqlParameters.Add(new SqlParameter("@prmSilmeTarihi", kaydedilecekKullanici.IsDeleted ? (object)DateTime.Now : DBNull.Value));
                            DataResultDTO savedKullaniciRes = Baglanti.CommandScalar(insertKullaniciStr, sqlParameters.ToArray(), con, transaction);
                            if (!savedKullaniciRes.IsSuccess)
                            {
                                throw new Exception("Kullanıcı kaydedilemedi: " + savedKullaniciRes.Hata);
                            }
                            int kaydedilenKullaniciId = kaydedilecekKullanici.Id;
                            if (savedKullaniciRes.ResultObject != null && Int32.TryParse(savedKullaniciRes.ResultObject.ToString(), out int tmpInt))
                            {
                                kaydedilenKullaniciId = tmpInt;
                            }
                            //Kullanıcını Ekran Yetkileri kaydedilir.
                            foreach (KullaniciDTO.EkranDTO kaydedilecekEkranYetki in kaydedilecekKullanici.Ekrans)
                            {
                                sqlParameters.Clear();
                                sqlParameters.Add(new SqlParameter("@prmKullaniciId", kaydedilenKullaniciId));
                                sqlParameters.Add(new SqlParameter("@prmEkranId", kaydedilecekEkranYetki.EkranId));
                                sqlParameters.Add(new SqlParameter("@prmYetki", kaydedilecekEkranYetki.Yetkili));
                                sqlParameters.Add(new SqlParameter("@prmKayitTarihi", DateTime.Now));
                                sqlParameters.Add(new SqlParameter("@prmKaydedenKullaniciId", 1));
                                sqlParameters.Add(new SqlParameter("@prmSilenKullaniciId", kaydedilecekKullanici.IsDeleted ? (object)1 : DBNull.Value));
                                sqlParameters.Add(new SqlParameter("@prmSilmeTarihi", kaydedilecekKullanici.IsDeleted ? (object)DateTime.Now : DBNull.Value));
                                DataResultDTO kaydedilecekEkranYetkiRes = Baglanti.CommandScalar(insertKullaniEkranYetkiStr, sqlParameters.ToArray(), con, transaction);
                                if (!kaydedilecekEkranYetkiRes.IsSuccess)
                                {
                                    throw new Exception("Kullanıcı Ekran Yetkisi kaydedilemedi: " + kaydedilecekEkranYetkiRes.Hata);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message + (ex.InnerException != null ? "\r\n" + ex.InnerException.Message : string.Empty));
                    }
                    transaction.Commit();
                }
            }
        }
    }
}
