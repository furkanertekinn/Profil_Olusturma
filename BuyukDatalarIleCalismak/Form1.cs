using BuyukDatalarIleCalismak.Entities;
using BuyukDatalarIleCalismak.Operasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyukDatalarIleCalismak
{
    public partial class Form1 : Form
    {
        Image Img;
        BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
            List<Entities.Kisi> Kisiler = BLL.KisilerListe();
            cmb_kisilistesi.DataSource = Kisiler;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_resimekle_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
            Img = Image.FromFile(OFD.FileName);
            pic_resim.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_resim.Image = Img;

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();
            Img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
            int ReturnValue = BLL.KayitEKLE(txt_isim.Text, txt_soyisim.Text, txt_eposta.Text, txt_tel.Text, mem.ToArray());
            if (ReturnValue > 0)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void cmb_kisilistesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kisi k = (Kisi)((ComboBox)sender).SelectedItem;
            k = BLL.KisiDetayGetir(k.ID);
            txt_dg_isim.Text = k.Isim;
            txt_dg_soyisim.Text = k.Soyisim;
            txt_eposta.Text = k.EmailAdres;
            txt_tel.Text = k.Tel;

            MemoryStream mem = new MemoryStream(k.Resim);
            Image Img = Image.FromStream(mem);
            pic_dg_resim.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_dg_resim.Image = Img;
        }
    }
}
