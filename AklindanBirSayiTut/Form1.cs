using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AklindanBirSayiTut
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            txtMin.Focus();
        }

        private void btnBenTahminEdeyim_Click(object sender, EventArgs e)
        {
            if (txtMin.Text.Length > 0 && txtMax.Text.Length > 0)
            {
                FrmBenTahminEdeyim form =
                              new FrmBenTahminEdeyim(Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtMax.Text));
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen sayı aralıklarını belirleyiniz.");
            }

        }

        private void btnBilgisayarTahminEtsin_Click(object sender, EventArgs e)
        {
            if (txtMin.Text.Length > 0 && txtMax.Text.Length > 0)
            {
                FrmBilgisayarTahminEtsin form =
                    new FrmBilgisayarTahminEtsin(Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtMax.Text));
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen sayı aralıklarını belirleyiniz.");
            }
        }
    }
}
