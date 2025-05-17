using AForge.Video.DirectShow;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace market
{
    public partial class MeyveSebzePanel : Form
    {
        int sayi1, sayi2, islemTipi;
        public MeyveSebzePanel()
        {
            InitializeComponent();
            txt_hesapMakinesi.Text = "0";
        }
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        private void MeyveSebzePanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo camera in fic)
            {
                cmb_kamera.Items.Add(camera.Name);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString() + "  :";
            lbl_dakika.Text = DateTime.Now.Minute.ToString() + "  :";
            lbl_saniye.Text = DateTime.Now.Second.ToString();
            if (pctbox_Kamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pctbox_Kamera.Image);

                if (result != null)
                {
                    txt_barkod.Text = result.ToString();
                    timer1.Stop();
                }
                else
                {
                    txt_barkod.Text = "0";
                }
            }
            else
            {
                txt_barkod.Text = "0";
            }
      
            }
        

        private void secilenTus(object sender, EventArgs e)
        {
            if (txt_hesapMakinesi.Text == "0")
            {
                txt_hesapMakinesi.Text = "";
            }
            txt_hesapMakinesi.Text += ((Button)sender).Text; //sender bastıgımız tusu temsil ediyor button tipine çevir textini yazdır..
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (islemTipi == 1)
            {
                sayi2 = int.Parse(txt_hesapMakinesi.Text);
                txt_hesapMakinesi.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTipi == 2) 
            {
                sayi2 = int.Parse(txt_hesapMakinesi.Text);
                txt_hesapMakinesi.Text = (sayi1 - sayi2).ToString();

            }
            else if (islemTipi == 3)
            {
                sayi2 = int.Parse(txt_hesapMakinesi.Text);
                txt_hesapMakinesi.Text = (sayi1 * sayi2).ToString();
            }
            else if (islemTipi == 4)
            {
                sayi2 = int.Parse(txt_hesapMakinesi.Text);
                txt_hesapMakinesi.Text = (sayi1 / sayi2).ToString();
            }
            else if (islemTipi == 5)
            {
                sayi2 = int.Parse(txt_hesapMakinesi.Text);
                txt_hesapMakinesi.Text = (sayi1 = sayi2 = 0).ToString();
            }
        }

        private void btn_cıkarma_Click(object sender, EventArgs e)
        {
            islemTipi = 2; // çıkarma işlemi
            sayi1 = int.Parse(txt_hesapMakinesi.Text);
            txt_hesapMakinesi.Text = "0";
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            islemTipi = 3; // çarpma işlemi
            sayi1 = int.Parse(txt_hesapMakinesi.Text);
            txt_hesapMakinesi.Text = "0";
        }

        private void btn_bölme_Click(object sender, EventArgs e)
        {
            islemTipi = 4; // bölme işlemi
            sayi1 = int.Parse(txt_hesapMakinesi.Text);
            txt_hesapMakinesi.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            islemTipi = 1; // toplama işlemi
            sayi1 = int.Parse(txt_hesapMakinesi.Text);
            txt_hesapMakinesi.Text = "0";
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            islemTipi = 5; // toplama işlemi
            sayi1 = int.Parse(txt_hesapMakinesi.Text);
            txt_hesapMakinesi.Text = "0";
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            if (txt_hesapMakinesi.Text.Length != 0 )
            {
                txt_hesapMakinesi.Text = txt_hesapMakinesi.Text.Substring(0, txt_hesapMakinesi.Text.Length - 1); // son karakteri siler ,bir adım geri
            }
            else
            {
                txt_hesapMakinesi.Text = "0"; // eğer hiç bir şey yoksa 0 yazar 
            }
        }

        private void btn_kameraAç_Click(object sender, EventArgs e)
        {
            if (cmb_kamera.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kamera seçiniz.");
                return;
            }
            vcd = new VideoCaptureDevice(fic[cmb_kamera.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();

        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
                pctbox_Kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_kameraKapa_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pctbox_Kamera.Image = Image.FromFile(@"C:\Marketim\market\resimler\352259_camera_icon.png"); //camerayı kapatınca resim değişiyor
        }

        private void txt_barkod_TextChanged(object sender, EventArgs e)
        {
    
            controller.Controller controller = new controller.Controller();
         Urun tUrun = controller.urunuGetir(txt_barkod.Text);


            if (tUrun != null && tUrun.urunİsim != null)
            {
  
                lbl_Urunisim.Text = tUrun.urunİsim.ToString();
                txt_hesapMakinesi.Text = tUrun.fiyat.ToString();

            }
            else
            {
                lbl_Urunisim.Text = "Ürün bulunamadı";
                txt_hesapMakinesi.Text = "0";
            }
         txt_hesapMakinesi.Text = tUrun.fiyat.ToString();  //gelen barkodun sahip olduğu ürünün fiyatını yazdırıyoruz
           

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            KasiyerPanel kasiyer = new KasiyerPanel();
            kasiyer.Show();
            this.Hide();
        }
        private void btn_etgecis_Click(object sender, EventArgs e)
        {
            KasapPanel kasapPanel = new KasapPanel();
            kasapPanel.Show();
            this.Hide();
        }

        private void btn_sütgecis_Click(object sender, EventArgs e)
        {
            SütÜrünleriPanel sütÜrünleriPanel = new SütÜrünleriPanel();
            sütÜrünleriPanel.Show();
            this.Hide();
        }

        private void btn_elma_Click(object sender, EventArgs e)
        {
            string sadeceSayi = new string(lbl_elma.Text.Where(Char.IsDigit).ToArray());

            if (txt_hesapMakinesi.Text == "0" || islemTipi != 0)
            {
                txt_hesapMakinesi.Text = sadeceSayi;
            }
            else
                txt_hesapMakinesi.Text += sadeceSayi;
        }

        private void btn_muz_Click(object sender, EventArgs e)
        {
            string sadeceSayi = new string(lbl_muz.Text.Where(Char.IsDigit).ToArray());

            if (txt_hesapMakinesi.Text == "0" || islemTipi != 0)
            {
                txt_hesapMakinesi.Text = sadeceSayi;
            }
            else
                txt_hesapMakinesi.Text += sadeceSayi;
        }

        private void btn_karpuz_Click(object sender, EventArgs e)
        {
            string sadeceSayi = new string(lbl_karpuz.Text.Where(Char.IsDigit).ToArray());

            if (txt_hesapMakinesi.Text == "0" || islemTipi != 0)
            {
                txt_hesapMakinesi.Text = sadeceSayi;
            }
            else
                txt_hesapMakinesi.Text += sadeceSayi;
        }

        private void btn_marul_Click(object sender, EventArgs e)
        {
            string sadeceSayi = new string(lbl_marul.Text.Where(Char.IsDigit).ToArray());

            if (txt_hesapMakinesi.Text == "0" || islemTipi != 0)
            {
                txt_hesapMakinesi.Text = sadeceSayi;
            }
            else
                txt_hesapMakinesi.Text += sadeceSayi;
        }

        private void btn_brokoli_Click(object sender, EventArgs e)
        {
            string sadeceSayi = new string(lbl_brokoli.Text.Where(Char.IsDigit).ToArray());

            if (txt_hesapMakinesi.Text == "0" || islemTipi != 0)
            {
                txt_hesapMakinesi.Text = sadeceSayi;
            }
            else
                txt_hesapMakinesi.Text += sadeceSayi;
        }

        private void btn_salatalık_Click(object sender, EventArgs e)
        {
            string sadeceSayi = new string(lbl_salatalık.Text.Where(Char.IsDigit).ToArray());

            if (txt_hesapMakinesi.Text == "0" || islemTipi != 0)
            {
                txt_hesapMakinesi.Text = sadeceSayi;
            }
            else
                txt_hesapMakinesi.Text += sadeceSayi;
        }

        private void btn_avakado_Click(object sender, EventArgs e)
        {
            string sadeceSayi = new string(lbl_avakado.Text.Where(Char.IsDigit).ToArray());

            if (txt_hesapMakinesi.Text == "0" || islemTipi != 0)
            {
                txt_hesapMakinesi.Text = sadeceSayi;
            }
            else
                txt_hesapMakinesi.Text += sadeceSayi;
        }

        private void btn_meyvegecis_Click(object sender, EventArgs e)
        {
            MeyveSebzePanel meyveSebzePanel = new MeyveSebzePanel();
            meyveSebzePanel.Show();
            this.Hide();
        }

        private void btn_baklagilgecis_Click(object sender, EventArgs e)
        {
            BaklagilPanel baklagilPanel = new BaklagilPanel();
            baklagilPanel.Show();
            this.Hide();
        }


    }
}

