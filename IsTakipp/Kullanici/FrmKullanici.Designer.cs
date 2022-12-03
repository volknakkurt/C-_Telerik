namespace IsTakipp.Kullanici
{
    partial class FrmKullanici
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanici));
            this.grdKullanici = new Telerik.WinControls.UI.RadGridView();
            this.grdEkran = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEkran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEkran.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdKullanici
            // 
            this.grdKullanici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdKullanici.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdKullanici.Location = new System.Drawing.Point(16, 28);
            // 
            // 
            // 
            gridViewTextBoxColumn1.FieldName = "Rol";
            gridViewTextBoxColumn1.HeaderText = "Kullanıcı Adı";
            gridViewTextBoxColumn1.Name = "grdKullanicigcRol";
            gridViewTextBoxColumn1.Width = 125;
            gridViewTextBoxColumn2.FieldName = "AdSoyad";
            gridViewTextBoxColumn2.HeaderText = "Ad Soyad";
            gridViewTextBoxColumn2.Name = "grdKullanicigcAdSoyad";
            gridViewTextBoxColumn2.Width = 125;
            gridViewTextBoxColumn3.FieldName = "Sifre";
            gridViewTextBoxColumn3.FormatString = "*****";
            gridViewTextBoxColumn3.HeaderText = "Şifre";
            gridViewTextBoxColumn3.Name = "grdKullanicigcSifre";
            gridViewTextBoxColumn3.Width = 125;
            gridViewTextBoxColumn4.FieldName = "Mail";
            gridViewTextBoxColumn4.HeaderText = "Mail";
            gridViewTextBoxColumn4.Name = "grdKullanicigcMail";
            gridViewTextBoxColumn4.Width = 125;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "Aktif";
            gridViewCheckBoxColumn1.HeaderText = "Aktif";
            gridViewCheckBoxColumn1.Name = "grdKullanicigcAktif";
            gridViewCheckBoxColumn1.Width = 125;
            this.grdKullanici.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn1});
            this.grdKullanici.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdKullanici.Name = "grdKullanici";
            // 
            // 
            // 
            this.grdKullanici.RootElement.ControlBounds = new System.Drawing.Rectangle(16, 28, 240, 150);
            this.grdKullanici.Size = new System.Drawing.Size(639, 500);
            this.grdKullanici.TabIndex = 0;
            this.grdKullanici.ThemeName = "ControlDefault";
            this.grdKullanici.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.grdKullanici_CurrentRowChanged);
            this.grdKullanici.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.grdKullanici_UserAddedRow);
            this.grdKullanici.Click += new System.EventHandler(this.grdKullanici_Click);
            // 
            // grdEkran
            // 
            this.grdEkran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEkran.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdEkran.Location = new System.Drawing.Point(661, 28);
            // 
            // 
            // 
            this.grdEkran.MasterTemplate.AllowAddNewRow = false;
            gridViewCheckBoxColumn2.FieldName = "Yetkili";
            gridViewCheckBoxColumn2.HeaderText = "Yetki";
            gridViewCheckBoxColumn2.Name = "grdEkrangcYetki";
            gridViewCheckBoxColumn2.Width = 190;
            gridViewTextBoxColumn5.FieldName = "EkranAdi";
            gridViewTextBoxColumn5.HeaderText = "Ekran Adı";
            gridViewTextBoxColumn5.Name = "grdEkrangcEkranAdi";
            gridViewTextBoxColumn5.Width = 190;
            this.grdEkran.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn5});
            this.grdEkran.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grdEkran.Name = "grdEkran";
            // 
            // 
            // 
            this.grdEkran.RootElement.ControlBounds = new System.Drawing.Rectangle(661, 28, 240, 150);
            this.grdEkran.Size = new System.Drawing.Size(381, 500);
            this.grdEkran.TabIndex = 1;
            this.grdEkran.ThemeName = "ControlDefault";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Listesi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKaydet.Location = new System.Drawing.Point(931, 9);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 28);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // pnlUst
            // 
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(200, 100);
            this.pnlUst.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grdKullanici);
            this.panel1.Controls.Add(this.grdEkran);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 542);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(657, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ekran Yetki Listesi";
            // 
            // FrmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Tanımlama";
            this.Load += new System.EventHandler(this.FrmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEkran.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEkran)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdKullanici;
        private Telerik.WinControls.UI.RadGridView grdEkran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}