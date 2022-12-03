using IsTakipp.CO;
using IsTakipp.DTO;
using IsTakipp.Kullanici;
using IsTakipp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using static IsTakipp.DTO.FirmaDTO;

namespace IsTakipp.Firma
{
    public partial class FrmFirmaEkle : Form
    {
        FirmaIslemleriService firmaIslemleriService = new FirmaIslemleriService();
        List<FirmaDTO> firmaList;
        List<FirmaDTO.IletisimDTO> IletisimList = new List<IletisimDTO>();
        List<FirmaDTO.AdresDTO> AdresList = new List<AdresDTO>();
        FirmaListeCO kriter = new FirmaListeCO();
        
        public FrmFirmaEkle()
        {
            InitializeComponent();
            

            
        }          
        private void FrmFirmaEkle_Load(object sender, EventArgs e)
        {
            try
            {
                firmaList = firmaIslemleriService.FirmaListesiGetir(kriter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Firma Listesi getirilemedi!\r\n" + ex.Message, "İş Takip Uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bindToForm();
        }
        /// <summary>
        /// Firma Bilgilerini Ekrana Getirir.
        /// </summary>
        private void bindToForm()            
        {
            try
            {
                firmaList = firmaIslemleriService.FirmaListesiGetir(kriter);
                dataGridFirma.DataSource = firmaList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Firma Listesi Getirilemedi!\r\n" + ex.Message, "İş Takip Uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// İletişim Gridinde default İletişimi belirlemek için kullanılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridIletisim_ValueChanged(object sender, EventArgs e)
        {                    
            RadCheckBoxEditor editor = sender as RadCheckBoxEditor;
            if (editor != null && (Telerik.WinControls.Enumerations.ToggleState)editor.Value == Telerik.WinControls.Enumerations.ToggleState.On)
            {                
                foreach (GridViewDataRowInfo row in this.dataGridIletisim.Rows)
                {
                    if (row != this.dataGridIletisim.CurrentRow)
                    {
                        row.Cells["grdIletisimgcVarsayilan"].Value = false;
                    }
                }
            }
        }
        /// <summary>
        /// Adres Gridinde default İletişimi belirlemek için kullanılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridAdres_ValueChanged(object sender, EventArgs e)
        {
            RadCheckBoxEditor editor = sender as RadCheckBoxEditor;
            if (editor != null && (Telerik.WinControls.Enumerations.ToggleState)editor.Value == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                foreach (GridViewDataRowInfo row in this.dataGridAdres.Rows)
                {
                    if (row != this.dataGridAdres.CurrentRow)
                    {
                        row.Cells["grdAdresgcVarsayilan"].Value = false;
                    }
                }

            }
        }
        /// <summary>
        /// Firma gridinde satır değiştiğinde yapılır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridFirma_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            FirmaDTO firma = dataGridFirma.CurrentRow.DataBoundItem as FirmaDTO;
            if (firma == null)
            {
                dataGridIletisim.ReadOnly = true;
                dataGridAdres.ReadOnly = true;
                dataGridIletisim.DataSource = null;
                dataGridAdres.DataSource = null;
                return;
            }
            dataGridIletisim.ReadOnly = false;
            dataGridAdres.ReadOnly = false;
            dataGridIletisim.DataSource = firma.IletisimList;
            dataGridAdres.DataSource = firma.AdresList;

        }
        /// <summary>
        /// Firma bilgileri kaydedilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnKaydet_Click(object sender, EventArgs e)
        {           
            firmaList = dataGridFirma.DataSource as List<FirmaDTO>;            
            firmaIslemleriService.FirmaKaydet(firmaList);
        }

        private void dataGridFirma_UserAddedRow(object sender, GridViewRowEventArgs e)
         {
            FirmaDTO yeniFirma = new FirmaDTO
            {
                Kod = e.Row.Cells["grdFirmagcKod"].Value.ToString(),
                Ad = e.Row.Cells["grdFirmagcAd"].Value.ToString(),
                Yetkili = e.Row.Cells["grdFirmagcYetkili"].Value.ToString()
            };

            if (yeniFirma != null)
            {
                yeniFirma.IletisimList = IletisimList.Select(iletisim => Helper.Clone<FirmaDTO.IletisimDTO>(iletisim)).ToList();
            }
            if (yeniFirma != null)
            {
                yeniFirma.AdresList = AdresList.Select(adres => Helper.Clone<FirmaDTO.AdresDTO>(adres)).ToList();
            }
            firmaList = dataGridFirma.DataSource as List<FirmaDTO>;
            firmaList.Add(yeniFirma);




        }
    }
}
