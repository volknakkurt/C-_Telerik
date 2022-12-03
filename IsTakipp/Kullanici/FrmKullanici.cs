using IsTakipp.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static IsTakipp.KullaniciDTO;

namespace IsTakipp.Kullanici

{
    public partial class FrmKullanici : Form
    {
        KullaniciIslemleriService kullaniciIslemleriService = new KullaniciIslemleriService();
        List<KullaniciDTO> kullaniciList;
        List<EkranDTO> ekranListesi = new List<EkranDTO>();

        public FrmKullanici()
        {
            InitializeComponent();
        }

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            try
            {
                ekranListesi = kullaniciIslemleriService.EkranListesiGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekran Listesi getirilemedi!\r\n" + ex.Message, "İş Takip Uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bindToForm();
        }

        /// <summary>
        /// Verileri ekrana getirir.
        /// </summary>
        private void bindToForm()
        {
            try
            {
                kullaniciList = kullaniciIslemleriService.KullaniciGetir();
                grdKullanici.DataSource = kullaniciList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Listesi Getirilemedi!\r\n" + ex.Message, "İş Takip Uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void grdKullanici_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            //Current row değiştiği zaman ekran gridi güncelliyoruz.
            KullaniciDTO kullanici = grdKullanici.CurrentRow.DataBoundItem as KullaniciDTO;
            if (kullanici == null)
            {
                grdEkran.ReadOnly = true;
                grdEkran.DataSource = null;
                return;
            }
            grdEkran.ReadOnly = false;
            grdEkran.DataSource = kullanici.Ekrans;
        }

        private void grdKullanici_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            KullaniciDTO yeniKullanici = e.Row.DataBoundItem as KullaniciDTO;
            if (yeniKullanici != null)
            {
                yeniKullanici.Ekrans = ekranListesi.Select(ekran => Helper.Clone<KullaniciDTO.EkranDTO>(ekran)).ToList();
            }
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                kullaniciIslemleriService.KullaniciKaydet(kullaniciList);
                bindToForm();
                grdEkran.ReadOnly = false;
                MessageBox.Show(this, "Kullanıcı Bilgileri kaydedildi.", "İş Takip Uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Kullanıcı Kaydedilemedi\r\n" + ex.Message, "İş Takip Uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdKullanici_Click(object sender, EventArgs e)
        {

        }
    }
}
