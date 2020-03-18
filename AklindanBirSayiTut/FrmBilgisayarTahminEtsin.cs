using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AklindanBirSayiTut
{
    public partial class FrmBilgisayarTahminEtsin : DevExpress.XtraEditors.XtraForm
    {
        Random rastgeleSayi = new Random();
        private int tahmin;

        private string[] mesajlar =
            {" tuttun kesin", " olabilir mi?", " tuttuğuna eminim", " dimi hadi ama senden daha zekiyim", " buda mı değil?"};
        public FrmBilgisayarTahminEtsin(int min, int max)
        {
            InitializeComponent();
            for (int i = min; i <= max; i++)
            {
                listBoxControl1.Items.Add(i);
            }

            MessageBox.Show($"Aklından {min} ile {max} arasında bir sayı tut bakalım bulabilecekmiyim..");
            TahminEt();
        }

        private void TahminEt()
        {

            if (listBoxControl1.ItemCount == 0)
            {
                lblBildirim.Text = "Beni kandırıyorsun";
                return;
            }
            tahmin = rastgeleSayi.Next(0, listBoxControl1.ItemCount - 1);
            lblBildirim.Text = $"{listBoxControl1.Items[tahmin]}{mesajlar[rastgeleSayi.Next(0, 4)]}";
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            lblBildirim.Text = "Kazanacağıma emindim..";
        }

        private void btnHayır_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Remove(listBoxControl1.Items[tahmin]);
            TahminEt();
        }
    }
}