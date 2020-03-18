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
    public partial class FrmBenTahminEdeyim : DevExpress.XtraEditors.XtraForm
    {
        Random rastgeleSayi = new Random();
        private int TahminEt;

        private string[] mesajlar =
        {
            "Bilemedin..!", "Ben bu sayıyı tutmadım ki :)", "Gerçekten zor mu?", "Bence bilemeyeceksin.",
            "Biraz daha dene..","Yanlış cevap verdin"
        };
        public FrmBenTahminEdeyim(int min, int max)
        {
            InitializeComponent();
            TahminEt = rastgeleSayi.Next(min, max);
            lblBildirim.Text =
                $"Senin için aklımdan {min} ile {max} arasında bir sayı tuttum. Bakalım bilebilecek misin ? :)";
        }

        private void txtTahmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (Convert.ToInt32(txtTahmin.Text) == TahminEt)
                {
                    lblBildirim.Text = $"Tebrikler kazandın.\n Aklımdan tuttuğum {TahminEt} sayısıydı.";
                }
                else
                {
                    lblBildirim.Text = mesajlar[rastgeleSayi.Next(0, mesajlar.Length - 1)];
                    txtTahmin.Text = null;
                    txtTahmin.Focus();
                }
            }
        }
    }
}