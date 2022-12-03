using IsTakipp.Services;
using java.sql;
using Microsoft.Azure.Documents.SystemFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using static IsTakipp.KullaniciDTO;


namespace IsTakipp
{
    

    public partial class FrmKullanıcı : Form
    {
        KullaniciIslemleriService kullaniciIslemleriService = new KullaniciIslemleriService();
      
        List<KullaniciDTO> kullaniciList;
       
        public FrmKullanıcı()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void FrmKullanıcı_Load(object sender, EventArgs e)
        {

            bindToForm();
            
            

        }
        private void bindToForm()
        {
    

            kullaniciList = kullaniciIslemleriService.KullaniciGetir();
            
            grdKullanici.DataSource = kullaniciList;
            
        }
        private void grdKullanici_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {

            KullaniciDTO kullanici = grdKullanici.CurrentRow.DataBoundItem as KullaniciDTO;
            if (kullanici == null )
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

            KullaniciDTO kullanici = new KullaniciDTO();
            

            kullanici.Rol = grdKullanici.CurrentRow.Cells[0].Value.ToString();
            kullanici.AdSoyad = grdKullanici.CurrentRow.Cells[1].Value.ToString();
            kullanici.Mail = grdKullanici.CurrentRow.Cells[2].Value.ToString();
            kullanici.Aktif = Convert.ToBoolean(grdKullanici.CurrentRow.Cells[3].Value);

            KullaniciDTO.EkranDTO ekranDTO = new KullaniciDTO.EkranDTO();

            grdEkran.ReadOnly = false;
            grdEkran.DataSource = null;

            kullaniciIslemleriService.Kaydet(kullanici);



        }

      

        private void btnKydt(object sender, EventArgs e)
        {
            KullaniciDTO.EkranDTO ekran = new KullaniciDTO.EkranDTO();
            KullaniciDTO.KullaniciEkranYetkiDTO ekranyetki = new KullaniciDTO.KullaniciEkranYetkiDTO();

            


            kullaniciIslemleriService.Yetkilendir(ekran, ekranyetki);
        }
    }
}
