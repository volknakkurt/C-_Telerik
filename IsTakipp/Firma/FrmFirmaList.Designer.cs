
namespace IsTakipp.Firma

{
    partial class FrmFirmaList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmaList));
            this.grdFirmaList = new Telerik.WinControls.UI.RadGridView();
            this.pnlTop = new Telerik.WinControls.UI.RadPanel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirmaKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.pnlListe = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmaList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFirmaList
            // 
            this.grdFirmaList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFirmaList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdFirmaList.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            gridViewTextBoxColumn1.DataType = typeof(long);
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn2.FieldName = "Kod";
            gridViewTextBoxColumn2.HeaderText = "Kod";
            gridViewTextBoxColumn2.Name = "grdFirmagcKod";
            gridViewTextBoxColumn2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            gridViewTextBoxColumn2.Width = 130;
            gridViewTextBoxColumn3.FieldName = "Ad";
            gridViewTextBoxColumn3.HeaderText = "Firma Adı";
            gridViewTextBoxColumn3.Name = "grdFirmagcAd";
            gridViewTextBoxColumn3.Width = 270;
            gridViewTextBoxColumn4.FieldName = "Yetkili";
            gridViewTextBoxColumn4.HeaderText = "Sorumlu Kişi";
            gridViewTextBoxColumn4.Name = "grdFirmagcYetkili";
            gridViewTextBoxColumn4.Width = 270;
            gridViewTextBoxColumn5.FieldName = "Iletisim";
            gridViewTextBoxColumn5.HeaderText = "Telefon";
            gridViewTextBoxColumn5.Name = "grdFirmagcIletisim";
            gridViewTextBoxColumn5.Width = 270;
            gridViewTextBoxColumn6.FieldName = "Adres";
            gridViewTextBoxColumn6.HeaderText = "Adres";
            gridViewTextBoxColumn6.Name = "grdFirmagcAdres";
            gridViewTextBoxColumn6.Width = 455;
            gridViewTextBoxColumn7.DataType = typeof(bool);
            gridViewTextBoxColumn7.FieldName = "IsDeleted";
            gridViewTextBoxColumn7.HeaderText = "Silindi";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "grdFirmagcIsDeleted";
            this.grdFirmaList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.grdFirmaList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdFirmaList.Name = "grdFirmaList";
            // 
            // 
            // 
            this.grdFirmaList.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 240, 150);
            this.grdFirmaList.Size = new System.Drawing.Size(1415, 620);
            this.grdFirmaList.TabIndex = 0;
            this.grdFirmaList.ThemeName = "ControlDefault";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTop.Controls.Add(this.btnEkle);
            this.pnlTop.Controls.Add(this.txtFirmaAdi);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.txtFirmaKodu);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnListele);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            // 
            // 
            // 
            this.pnlTop.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 100);
            this.pnlTop.Size = new System.Drawing.Size(1421, 54);
            this.pnlTop.TabIndex = 3;
            this.pnlTop.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(31, 14);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(1175, 17);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtFirmaAdi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1094, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Firma Adı";
            // 
            // txtFirmaKodu
            // 
            this.txtFirmaKodu.Location = new System.Drawing.Point(970, 17);
            this.txtFirmaKodu.Name = "txtFirmaKodu";
            this.txtFirmaKodu.Size = new System.Drawing.Size(100, 20);
            this.txtFirmaKodu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firma Kodu";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(1319, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(86, 29);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // pnlListe
            // 
            this.pnlListe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlListe.Controls.Add(this.grdFirmaList);
            this.pnlListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListe.Location = new System.Drawing.Point(0, 54);
            this.pnlListe.Name = "pnlListe";
            // 
            // 
            // 
            this.pnlListe.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 100);
            this.pnlListe.Size = new System.Drawing.Size(1421, 626);
            this.pnlListe.TabIndex = 4;
            this.pnlListe.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmFirmaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 680);
            this.Controls.Add(this.pnlListe);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFirmaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmFirma";
            this.Load += new System.EventHandler(this.FrmFirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmaList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel pnlTop;
        private System.Windows.Forms.Button btnListele;
        private Telerik.WinControls.UI.RadPanel pnlListe;
        private Telerik.WinControls.UI.RadGridView grdFirmaList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirmaKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtFirmaAdi;
    }
}