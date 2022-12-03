using IsTakipp.Firma;
using IsTakipp.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (var openedFrm in this.MdiChildren)
            {
                if (openedFrm.GetType() == typeof(FrmKullanici))
                {
                    openedFrm.BringToFront();
                    return;
                }
            }

            FrmKullanici childForm = new FrmKullanici();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();

        }

       

        

        private void radMenuItem3_Click_1(object sender, EventArgs e)
        {
            foreach (var openedFrm in this.MdiChildren)
            {
                if (openedFrm.GetType() == typeof(FrmFirmaList))
                {
                    openedFrm.BringToFront();
                    return;
                }
            }

            FrmFirmaList childForm = new FrmFirmaList();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
