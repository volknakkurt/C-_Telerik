using IsTakipp.CO;
using IsTakipp.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace IsTakipp.Services
{
    class FirmaIslemleriService
    {
        /// <summary>
        /// Firma listesini getirir
        /// </summary>
        /// <returns></returns>
        public List<FirmaDTO> FirmaListesiGetir(FirmaListeCO kriter)
        {
            if (kriter == null)
            {
                throw new Exception("Kriter boş olamaz!");
            }

            //Kriterlere göre Firmaları getirir.
            string selectFirmaStr = @"Select * from Firma
                                      where SilenKullaniciId IS NULL 
                                      AND (@prmIsEmptyKod = 1 OR Kod = @prmKod) 
                                      AND (@prmIsEmptyAd = 1 OR Ad LIKE(@prmAd))";
           
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@prmIsEmptyKod", string.IsNullOrWhiteSpace(kriter.Kod) ? 1 : 0));
            sqlParameters.Add(new SqlParameter("@prmKod", kriter.Kod));
            sqlParameters.Add(new SqlParameter("@prmIsEmptyAd", string.IsNullOrWhiteSpace(kriter.Ad) ? 1 : 0));
            sqlParameters.Add(new SqlParameter("@prmAd", kriter.Ad));
           
            DataResultDTO firmaDataResult = Baglanti.Select(selectFirmaStr, sqlParameters.ToArray());
            if (!firmaDataResult.IsSuccess)
            {
                throw new Exception("Firma Getir: " + firmaDataResult.Hata);
            }
            List<FirmaDTO> firmaList = firmaDataResult.ResultData.DataTableToList<FirmaDTO>();


            int[] savedFirmaIdList = firmaList.Select(f => f.Id).ToArray();
            sqlParameters.Clear();
            sqlParameters.Add(new SqlParameter("@prmFirmaIdList[]", savedFirmaIdList));

            //Getirilen Firmaların İletişim Bilgilerini getir
            string selectFirmaIletisimStr = @"Select * from FirmaIletisimBilgileri WHERE SilmeTarihi IS NULL and FirmaId in (@prmFirmaIdList[])";
            DataResultDTO fiDataResult = Baglanti.Select(selectFirmaIletisimStr, sqlParameters.ToArray());
            if (!fiDataResult.IsSuccess)
            {
                throw new Exception("Firma İletişim Getir: " + firmaDataResult.Hata);
            }
            List<FirmaDTO.IletisimDTO> firmaIletisimList = fiDataResult.ResultData.DataTableToList<FirmaDTO.IletisimDTO>();


            //Getirilen Firmaların İletişim Bilgilerini getir             
            string selectFirmaAdresStr = @"Select * from FirmaAdresBilgileri WHERE SilmeTarihi IS NULL and FirmaId in (@prmFirmaIdList[])";
            DataResultDTO faDataResult = Baglanti.Select(selectFirmaAdresStr, sqlParameters.ToArray());
            if (!faDataResult.IsSuccess)
            {
                throw new Exception("Firma Adres Getir: " + firmaDataResult.Hata);
            }

            List<FirmaDTO.AdresDTO> firmaAdresList = faDataResult.ResultData.DataTableToList<FirmaDTO.AdresDTO>();



            //Firmalarin Tel bilgisini eşleştir.            
            foreach (FirmaDTO firma in firmaList)
            {
                foreach (FirmaDTO.IletisimDTO tel in firmaIletisimList)
                {
                    if (tel.FirmaId == firma.Id)
                    {
                        firma.IletisimList.Add(tel);
                        if (tel.Varsayilan == true)
                        {
                            firma.Iletisim = tel.Deger;
                        }
                    }                    
                }
            }

            //Firmaların Adres bilgisini eşleştir.
            foreach (FirmaDTO firma in firmaList)
            {
                foreach (FirmaDTO.AdresDTO adres in firmaAdresList)
                {
                    if (adres.FirmaId == firma.Id)
                    {
                        firma.AdresList.Add(adres);
                        if (adres.Varsayilan == true)
                        {
                            firma.Adres = adres.Deger;
                        }
                    }                   
                }
            }
            return firmaList;

        }
        /// <summary>
        /// Firma İletişim ve Adres bilgilerini kaydeder.
        /// </summary>
        /// <param name="kaydedilecekFirmaList"></param>
        public void FirmaKaydet(List<FirmaDTO> kaydedilecekFirmaList)
        {
            if (kaydedilecekFirmaList == null)
            {
                return;
            }
            string firmaStr = @"IF NOT EXISTS(Select 1 From Kullanici Where Id = @prmId and SilenKullaniciId IS NULL) 
                                          BEGIN 
                                            INSERT INTO Firma (Kod, FirmaAdi, Sorumlu, Tel, Adres, KayitTarihi, KaydedenKullaniciId) VALUES (@prmKod, @prmFirmaAdi,@prmSorumlu, @prmTel, @prmAdres, @prmKayitTarihi, @prmKaydedenKullaniciId)
                                            SELECT SCOPE_IDENTITY()
                                          END ELSE 
                                            UPDATE Firma SET Kod = @prmKod, FirmaAdi = @prmFirmaAdi, Sorumlu = @prmSorumlu ,Tel = @prmTel, Adres = @prmAdres, SilmeTarihi = @prmSilmeTarihi, SilenKullaniciId = @prmSilenKullaniciId Where Id = @prmId";

            string firmaIletisimStr = @"IF NOT EXISTS(Select 1 from FirmaIletisimBilgileri WHERE FirmaId = @FirmaId  and SilenKullaniciId IS NULL) 
                                                BEGIN
                                                    INSERT INTO FirmaIletisimBilgileri (Tip, Deger, Varsayilan, KayitTarihi, KaydedenKullaniciId) VALUES (@Tip, @Deger, @Varsayilan, @prmKayitTarihi, @prmKaydedenKullaniciId)                                    
                                                END ELSE 
                                                    UPDATE FirmaIletisimBilgileri SET Yetki = @prmYetki, SilmeTarihi = @prmSilmeTarihi, SilenKullaniciId = @prmSilenKullaniciId WHERE KullaniciId = @prmKullaniciId and EkranId = @prmEkranId and SilenKullaniciId IS NULL";

            string firmaAdresStr = @"IF NOT EXISTS(Select 1 from FirmaAdresBilgileri WHERE FirmaId = @FirmaId  and SilenKullaniciId IS NULL) 
                                                BEGIN
                                                    INSERT INTO FirmaAdresBilgileri (Tip, Deger, Varsayilan, KayitTarihi, KaydedenKullaniciId) VALUES (@Tip, @Deger, @Varsayilan, @prmKayitTarihi, @prmKaydedenKullaniciId)                                    
                                                END ELSE 
                                                    UPDATE FirmaAdresBilgileri SET Yetki = @prmYetki, SilmeTarihi = @prmSilmeTarihi, SilenKullaniciId = @prmSilenKullaniciId WHERE KullaniciId = @prmKullaniciId and EkranId = @prmEkranId and SilenKullaniciId IS NULL";


            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            using (SqlConnection con = new SqlConnection(Baglanti.GetConnectionString()))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        //Firma Bilgileri Kaydedilir.
                        foreach (FirmaDTO kaydedilecekfirma in kaydedilecekFirmaList)
                        {
                            sqlParameters.Clear();
                            sqlParameters.Add(new SqlParameter("@prmKod", kaydedilecekfirma.Kod));
                            sqlParameters.Add(new SqlParameter("@prmFirmaAdi", kaydedilecekfirma.Ad));
                            sqlParameters.Add(new SqlParameter("@prmSorumlu", kaydedilecekfirma.Yetkili));                         
                            sqlParameters.Add(new SqlParameter("@prmKayitTarihi", DateTime.Now));
                            sqlParameters.Add(new SqlParameter("@prmKaydedenKullaniciId", 1));
                            sqlParameters.Add(new SqlParameter("@prmSilenKullaniciId", kaydedilecekfirma.IsDeleted ? (object)1 : DBNull.Value));
                            sqlParameters.Add(new SqlParameter("@prmSilmeTarihi", kaydedilecekfirma.IsDeleted ? (object)DateTime.Now : DBNull.Value));
                            DataResultDTO savedFirmaRes = Baglanti.CommandScalar(firmaStr, sqlParameters.ToArray(), con, transaction);
                            if (!savedFirmaRes.IsSuccess)
                            {
                                throw new Exception("Kullanıcı kaydedilemedi: " + savedFirmaRes.Hata);
                            }
                            int kaydedilenFirmaId = kaydedilecekfirma.Id;
                            if (savedFirmaRes.ResultObject != null && Int32.TryParse(savedFirmaRes.ResultObject.ToString(), out int tmpInt))
                            {
                                kaydedilenFirmaId = tmpInt;
                            }
                            //Firmanın İletişim Bilgileri Kaydedilir.
                            foreach (FirmaDTO.IletisimDTO kaydedilecekTel in kaydedilecekfirma.IletisimList)
                            {
                                sqlParameters.Clear();
                                sqlParameters.Add(new SqlParameter("@Tip", kaydedilecekTel.Tip));
                                sqlParameters.Add(new SqlParameter("@Deger", kaydedilecekTel.Deger));
                                sqlParameters.Add(new SqlParameter("@Varsayilan", kaydedilecekTel.Varsayilan));
                                sqlParameters.Add(new SqlParameter("@prmKayitTarihi", DateTime.Now));
                                sqlParameters.Add(new SqlParameter("@prmKaydedenKullaniciId", 1));
                                sqlParameters.Add(new SqlParameter("@prmSilenKullaniciId", kaydedilecekfirma.IsDeleted ? (object)1 : DBNull.Value));
                                sqlParameters.Add(new SqlParameter("@prmSilmeTarihi", kaydedilecekfirma.IsDeleted ? (object)DateTime.Now : DBNull.Value));
                                DataResultDTO kaydedilecekTelRes = Baglanti.CommandScalar(firmaIletisimStr, sqlParameters.ToArray(), con, transaction);
                                if (!kaydedilecekTelRes.IsSuccess)
                                {
                                    throw new Exception("Firma Telefon Bilgisi kaydedilemedi: " + kaydedilecekTelRes.Hata);
                                }

                            }
                            //Firmanın Adres Bilgileri Kaydedilir.
                            foreach (FirmaDTO.AdresDTO kaydedilecekAdres in kaydedilecekfirma.AdresList)
                            {
                                sqlParameters.Clear();
                                sqlParameters.Add(new SqlParameter("@Tip", kaydedilecekAdres.Tip));
                                sqlParameters.Add(new SqlParameter("@Deger", kaydedilecekAdres.Deger));
                                sqlParameters.Add(new SqlParameter("@Varsayilan", kaydedilecekAdres.Varsayilan));
                                sqlParameters.Add(new SqlParameter("@prmKayitTarihi", DateTime.Now));
                                sqlParameters.Add(new SqlParameter("@prmKaydedenKullaniciId", 1));
                                sqlParameters.Add(new SqlParameter("@prmSilenKullaniciId", kaydedilecekfirma.IsDeleted ? (object)1 : DBNull.Value));
                                sqlParameters.Add(new SqlParameter("@prmSilmeTarihi", kaydedilecekfirma.IsDeleted ? (object)DateTime.Now : DBNull.Value));
                                DataResultDTO kaydedilecekTelRes = Baglanti.CommandScalar(firmaAdresStr, sqlParameters.ToArray(), con, transaction);
                                if (!kaydedilecekTelRes.IsSuccess)
                                {
                                    throw new Exception("Firma Telefon Bilgisi kaydedilemedi: " + kaydedilecekTelRes.Hata);
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