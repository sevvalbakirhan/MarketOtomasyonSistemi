using market.controller;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;


namespace market
{
    public partial class SifreDegistirme : Form
    {
        int dogrulamaKodu;

        public SifreDegistirme()
        {
            InitializeComponent();
        }
        private void SifreDegistirme_Load(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=SEVVALBAKIRHAN\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT guvenlikSorusu FROM loginTable", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbGuvenlikSorusu.Items.Add(dr["guvenlikSorusu"].ToString());
            }
            con.Close();

            Controller controller = new Controller();

            List<LoginTable> loginTableList = controller.getLoginTable();
            grpBox_mailAlani.Enabled = false;
            grpBox_sifreDegistirmeAlani.Enabled = false;

            foreach (LoginTable lt in loginTableList)
            {
                cmbGuvenlikSorusu.Items.Add(lt.guvenlikSorusu.ToString());
            }
            cmbGuvenlikSorusu.SelectedIndex = 0;

        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            LoginStatus result = controller.doAuthentication(txt_kullaniciAdi.Text.Trim().ToLower(), cmbGuvenlikSorusu.SelectedItem.ToString(), txt_güvenlikCevabi.Text.Trim().ToLower());

            if (result == LoginStatus.basarili)
            {
                grpBox_mailAlani.Enabled = true;
                MessageBox.Show("Doğru işlem..", "Doğru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Kullanıcı adı veya güvenlik sorusu cevabı hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_dogrulamaKoduGönder_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            string emailAdres = controller.chechkemailAddress(txt_kullaniciAdi.Text);

            if (emailAdres == txt_emailAdres.Text)
            {
                Random rdn = new Random();
                dogrulamaKodu = rdn.Next(100000, 999999);
                //TANIMLAMA
                MailAddress mailAlan = new MailAddress(txt_emailAdres.Text, txt_kullaniciAdi.Text);
                MailAddress mailGonderen = new MailAddress("sqlserveregitimim@gmail.com", "Market Sistemi");
                MailMessage mesaj = new MailMessage(mailGonderen, mailAlan);
                //ATAMA
                mesaj.To.Add(mailAlan);
                mesaj.From = mailGonderen;
                mesaj.Subject = "Şifre Değiştirme";
                mesaj.Body = "Şifre değiştirme işlemi için doğrulama kodu: " + dogrulamaKodu;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("sqlserveregitimim@gmail.com", "yausuwbppzjfulnn");
                smtp.EnableSsl = true;
                smtp.Send(mesaj);
                MessageBox.Show("Doğrulama kodu gönderildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve e-posta adresi uyuşmuyor", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_onayla_Click(object sender, EventArgs e)
        {
            if (txt_dogrulamaKodu.Text == dogrulamaKodu.ToString())
            {
                MessageBox.Show("Doğrulama kodu doğru", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpBox_sifreDegistirmeAlani.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doğrulama kodu hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            if (txt_yeniSifre.Text == txt_yeniSifreTkr.Text)
            {
                LoginStatus result = controller.changePassword(txt_kullaniciAdi.Text, txt_yeniSifre.Text);
                if (result == LoginStatus.basarili)
                {
                    MessageBox.Show("Şifre başarıyla değiştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Yeni şifreler eşleşmiyor", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
