using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class KullaniciPanel : Form
    {
        controller.Controller controller = new controller.Controller();
        public KullaniciPanel()
        {
            InitializeComponent();
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            defaultDegerleriDoldur();
            tümKullanicilariDoldur();
        }
        private void defaultDegerleriDoldur()
        {
            cmb_yetki.Items.Add("admin");
            cmb_yetki.Items.Add("kasiyer");
            cmb_yetki.SelectedIndex = 0;

            cmb_bölge.Items.Add("Esenyurt");
            cmb_bölge.Items.Add("Avcılar");
            cmb_bölge.Items.Add("Ataköy");
            cmb_bölge.Items.Add("Hadımköy");
            cmb_bölge.Items.Add("Yenibosna");
            cmb_bölge.SelectedIndex = 0;

            cmb_güvenlikSorusu.Items.Add("En sevdiginiz renk nedir?");
            cmb_güvenlikSorusu.Items.Add("En sevdiginiz hayvan nedir?");
            cmb_güvenlikSorusu.Items.Add("Evcil hayvanınızın adı nedir ?");
            cmb_güvenlikSorusu.Items.Add("En sevdiğiniz şehir nedir ?");
            cmb_güvenlikSorusu.SelectedIndex = 0;


        }
        private void tümKullanicilariDoldur()
        {

            List<User> userList = controller.tumKullanicilariGetir();
            dataGridView1.DataSource = userList;
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = cmb_yetki.SelectedItem.ToString();
            user.bolge = cmb_bölge.SelectedItem.ToString();
            user.emailAdres = txt_email.Text;
            user.guvenlikSorusu = cmb_güvenlikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_güvenlikCevabi.Text;

            LoginStatus sonuc = controller.kullaniciEkle(user);
            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Eklendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Gerekli alanların hepsini doldurun !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmb_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmb_bölge.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmb_güvenlikSorusu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_güvenlikCevabi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_kayitGüncelle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = int.Parse(txt_id.Text);
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = cmb_yetki.SelectedItem.ToString();
            user.bolge = cmb_bölge.SelectedItem.ToString();
            user.emailAdres = txt_email.Text;
            user.guvenlikSorusu = cmb_güvenlikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_güvenlikCevabi.Text;
            LoginStatus sonuc = controller.kullaniciGuncelle(user);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Güncellendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                LoginStatus sonuc = controller.kullaniciSil(int.Parse(txt_id.Text));
                if (sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumKullanicilariGetir();

                }
                else if (sonuc == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Kayıt Silinirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz kaydın id değerini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz kaydın id değerini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }
    }
    
}
