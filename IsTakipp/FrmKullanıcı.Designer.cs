namespace IsTakipp
{
    partial class FrmKullanıcı
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grdKullanici = new Telerik.WinControls.UI.RadGridView();
            this.grdEkran = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEkran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEkran.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // grdKullanici
            // 
            this.grdKullanici.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdKullanici.Location = new System.Drawing.Point(12, 47);
            // 
            // 
            // 
            gridViewTextBoxColumn1.FieldName = "Rol";
            gridViewTextBoxColumn1.HeaderText = "Kullanıcı Rolü";
            gridViewTextBoxColumn1.Name = "grdKullanicigcRol";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "AdSoyad";
            gridViewTextBoxColumn2.HeaderText = "Ad Soyad";
            gridViewTextBoxColumn2.Name = "grdKullanicigcAdSoyad";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "Mail";
            gridViewTextBoxColumn3.HeaderText = "Mail";
            gridViewTextBoxColumn3.Name = "grdKullanicigcMail";
            gridViewTextBoxColumn3.Width = 100;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "Aktif";
            gridViewCheckBoxColumn1.HeaderText = "Aktif";
            gridViewCheckBoxColumn1.Name = "grdKullanicigcAktif";
            gridViewCheckBoxColumn1.Width = 100;
            this.grdKullanici.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCheckBoxColumn1});
            this.grdKullanici.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdKullanici.Name = "grdKullanici";
            // 
            // 
            // 
            this.grdKullanici.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 47, 240, 150);
            this.grdKullanici.Size = new System.Drawing.Size(431, 375);
            this.grdKullanici.TabIndex = 0;
            this.grdKullanici.ThemeName = "ControlDefault";
            this.grdKullanici.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.grdKullanici_CurrentRowChanged);
            this.grdKullanici.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.grdKullanici_UserAddedRow);
            // 
            // grdEkran
            // 
            this.grdEkran.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdEkran.Location = new System.Drawing.Point(449, 47);
            // 
            // 
            // 
            this.grdEkran.MasterTemplate.AllowAddNewRow = false;
            gridViewCheckBoxColumn2.FieldName = "Yetkili";
            gridViewCheckBoxColumn2.HeaderText = "Yetki";
            gridViewCheckBoxColumn2.Name = "grdEkrangcYetki";
            gridViewCheckBoxColumn2.Width = 150;
            gridViewTextBoxColumn4.FieldName = "EkranAdi";
            gridViewTextBoxColumn4.HeaderText = "Ekran Adı";
            gridViewTextBoxColumn4.Name = "grdEkrangcEkranAdi";
            gridViewTextBoxColumn4.Width = 150;
            this.grdEkran.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn4});
            this.grdEkran.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grdEkran.Name = "grdEkran";
            // 
            // 
            // 
            this.grdEkran.RootElement.ControlBounds = new System.Drawing.Rectangle(449, 47, 240, 150);
            this.grdEkran.Size = new System.Drawing.Size(330, 375);
            this.grdEkran.TabIndex = 1;
            this.grdEkran.ThemeName = "ControlDefault";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Listesi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(666, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnKydt);
            // 
            // FrmKullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdEkran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdKullanici);
            this.Name = "FrmKullanıcı";
            this.Text = "Kullanıcı Tanımlama";
            this.Load += new System.EventHandler(this.FrmKullanıcı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEkran.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEkran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdKullanici;
        private Telerik.WinControls.UI.RadGridView grdEkran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}