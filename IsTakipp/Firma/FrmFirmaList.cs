using IsTakipp.CO;
using IsTakipp.DTO;
using IsTakipp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IsTakipp.Firma
{
    public partial class FrmFirmaList : Form
    {
        FirmaIslemleriService firmaIslemleriService = new FirmaIslemleriService();
        List<FirmaDTO> firmaList;
        FirmaListeCO firmaCo = new FirmaListeCO();
        List<FirmaDTO.IletisimDTO> IletisimList = new List<FirmaDTO.IletisimDTO>();
        List<FirmaDTO.AdresDTO> AdresList = new List<FirmaDTO.AdresDTO>();
        public FrmFirmaList()
        {
            InitializeComponent();
        }

    

        private void FrmFirma_Load(object sender, EventArgs e)
        {
            try
            {
                
                firmaList = firmaIslemleriService.FirmaListesiGetir(firmaCo);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Firmalar Listenemedi!\r\n" + ex.Message, "İş Takip Uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bindToForm();
        }
        private void bindToForm()
        {
            try
            {
                
                firmaList = firmaIslemleriService.FirmaListesiGetir(firmaCo);

                grdFirmaList.DataSource = firmaList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Firma Listesi Getirilemedi!\r\n" + ex.Message, "İş Takip Uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (var openedFrm in this.MdiChildren)
            {
                if (openedFrm.GetType() == typeof(FrmFirmaEkle))
                {
                    openedFrm.BringToFront();
                    return;
                }
            }

            FrmFirmaEkle childForm = new FrmFirmaEkle();

            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            
            firmaCo.Kod = txtFirmaKodu.Text;
            firmaCo.Ad = txtFirmaAdi.Text;
            firmaList = firmaIslemleriService.FirmaListesiGetir(firmaCo);
            grdFirmaList.DataSource = firmaList;
        }

       
    }
}
