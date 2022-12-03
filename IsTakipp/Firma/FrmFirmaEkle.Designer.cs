
namespace IsTakipp.Firma
{
    partial class FrmFirmaEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmaEkle));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridAdres = new Telerik.WinControls.UI.RadGridView();
            this.dataGridIletisim = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridFirma = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdres.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIletisim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIletisim.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirma.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(754, 9);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 29);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridAdres
            // 
            this.dataGridAdres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAdres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridAdres.Location = new System.Drawing.Point(443, 194);
            // 
            // 
            // 
            gridViewTextBoxColumn1.DataType = typeof(ulong);
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "grdAdresgcId";
            gridViewTextBoxColumn2.DataType = typeof(long);
            gridViewTextBoxColumn2.FieldName = "FirmaId";
            gridViewTextBoxColumn2.HeaderText = "FirmaId";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "grdAdresgcFirmaId";
            gridViewCheckBoxColumn1.FieldName = "Varsayilan";
            gridViewCheckBoxColumn1.HeaderText = "Aktif";
            gridViewCheckBoxColumn1.Name = "grdAdresgcVarsayilan";
            gridViewTextBoxColumn3.FieldName = "Tip";
            gridViewTextBoxColumn3.HeaderText = "Tip";
            gridViewTextBoxColumn3.Name = "grdAdresgcTip";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "Deger";
            gridViewTextBoxColumn4.HeaderText = "Değer";
            gridViewTextBoxColumn4.Name = "grdAdresgcDeger";
            gridViewTextBoxColumn4.Width = 174;
            gridViewTextBoxColumn5.FieldName = "Il";
            gridViewTextBoxColumn5.HeaderText = "Il";
            gridViewTextBoxColumn5.Name = "grdAdresgcIl";
            gridViewTextBoxColumn6.FieldName = "Ilce";
            gridViewTextBoxColumn6.HeaderText = "Ilce";
            gridViewTextBoxColumn6.Name = "grdAdresgcIlce";
            gridViewTextBoxColumn7.FieldName = "IsDeleted";
            gridViewTextBoxColumn7.HeaderText = "Silindi";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "grdAdresgcIsDeleted";
            this.dataGridAdres.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.dataGridAdres.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataGridAdres.Name = "dataGridAdres";
            // 
            // 
            // 
            this.dataGridAdres.RootElement.ControlBounds = new System.Drawing.Rectangle(443, 194, 240, 150);
            this.dataGridAdres.Size = new System.Drawing.Size(440, 199);
            this.dataGridAdres.TabIndex = 17;
            this.dataGridAdres.ThemeName = "ControlDefault";
            this.dataGridAdres.ValueChanged += new System.EventHandler(this.dataGridAdres_ValueChanged);
            // 
            // dataGridIletisim
            // 
            this.dataGridIletisim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridIletisim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridIletisim.Location = new System.Drawing.Point(443, 3);
            // 
            // 
            // 
            gridViewTextBoxColumn8.DataType = typeof(long);
            gridViewTextBoxColumn8.FieldName = "Id";
            gridViewTextBoxColumn8.HeaderText = "Id";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "grdIletisimgcId";
            gridViewTextBoxColumn9.DataType = typeof(long);
            gridViewTextBoxColumn9.FieldName = "FirmaId";
            gridViewTextBoxColumn9.HeaderText = "FirmaId";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "grdIletisimgcFirmaId";
            gridViewCheckBoxColumn2.FieldName = "Varsayilan";
            gridViewCheckBoxColumn2.HeaderText = "Aktif";
            gridViewCheckBoxColumn2.Name = "grdIletisimgcVarsayilan";
            gridViewTextBoxColumn10.FieldName = "Tip";
            gridViewTextBoxColumn10.HeaderText = "Tip";
            gridViewTextBoxColumn10.Name = "grdIletisimgcTip";
            gridViewTextBoxColumn10.Width = 185;
            gridViewTextBoxColumn11.FieldName = "Deger";
            gridViewTextBoxColumn11.HeaderText = "Değer";
            gridViewTextBoxColumn11.Name = "grdIletisimgcDeger";
            gridViewTextBoxColumn11.Width = 185;
            gridViewTextBoxColumn12.DataType = typeof(bool);
            gridViewTextBoxColumn12.FieldName = "IsDeleted";
            gridViewTextBoxColumn12.HeaderText = "Silindi";
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "grdIletisimgcIsDeleted";
            this.dataGridIletisim.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.dataGridIletisim.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dataGridIletisim.Name = "dataGridIletisim";
            // 
            // 
            // 
            this.dataGridIletisim.RootElement.ControlBounds = new System.Drawing.Rectangle(443, 3, 240, 150);
            this.dataGridIletisim.Size = new System.Drawing.Size(440, 194);
            this.dataGridIletisim.TabIndex = 18;
            this.dataGridIletisim.ThemeName = "ControlDefault";
            this.dataGridIletisim.ValueChanged += new System.EventHandler(this.dataGridIletisim_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 50);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridFirma);
            this.panel2.Controls.Add(this.dataGridAdres);
            this.panel2.Controls.Add(this.dataGridIletisim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 396);
            this.panel2.TabIndex = 4;
            // 
            // dataGridFirma
            // 
            this.dataGridFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFirma.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridFirma.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            gridViewTextBoxColumn13.DataType = typeof(long);
            gridViewTextBoxColumn13.FieldName = "Id";
            gridViewTextBoxColumn13.HeaderText = "Id";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "grdFirmagcId";
            gridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn14.FieldName = "Kod";
            gridViewTextBoxColumn14.HeaderText = "Kod";
            gridViewTextBoxColumn14.Name = "grdFirmagcKod";
            gridViewTextBoxColumn14.Width = 138;
            gridViewTextBoxColumn15.FieldName = "Ad";
            gridViewTextBoxColumn15.HeaderText = "Firma Adı";
            gridViewTextBoxColumn15.Name = "grdFirmagcAd";
            gridViewTextBoxColumn15.Width = 138;
            gridViewTextBoxColumn16.FieldName = "Yetkili";
            gridViewTextBoxColumn16.HeaderText = "Yetkili";
            gridViewTextBoxColumn16.Name = "grdFirmagcYetkili";
            gridViewTextBoxColumn16.Width = 138;
            this.dataGridFirma.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16});
            this.dataGridFirma.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.dataGridFirma.Name = "dataGridFirma";
            // 
            // 
            // 
            this.dataGridFirma.RootElement.ControlBounds = new System.Drawing.Rectangle(3, 3, 240, 150);
            this.dataGridFirma.Size = new System.Drawing.Size(434, 393);
            this.dataGridFirma.TabIndex = 19;
            this.dataGridFirma.ThemeName = "ControlDefault";
            this.dataGridFirma.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.dataGridFirma_CurrentRowChanged);
            this.dataGridFirma.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.dataGridFirma_UserAddedRow);
            // 
            // FrmFirmaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFirmaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmFirmaEkle";
            this.Load += new System.EventHandler(this.FrmFirmaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdres.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIletisim.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIletisim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirma.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        private Telerik.WinControls.UI.RadGridView dataGridAdres;
        private Telerik.WinControls.UI.RadGridView dataGridIletisim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadGridView dataGridFirma;
    }
}