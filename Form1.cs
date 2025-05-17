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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

 
        }

       private void btn_girisyap_Click(object sender, EventArgs e)
        {
             Controller controller = new Controller();
             User result = controller.login(txt_kullaniciadi.Text, txt_sifre.Text);
           
                if (result!=null && result.status == LoginStatus.basarili && result.yetki == "admin")
                {
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                    this.Hide();
                }
                else if (result != null && result.status == LoginStatus.basarili && result.yetki == "kasiyer")
                {
                    KasiyerPanel kasiyer = new KasiyerPanel();
                    kasiyer.Show();
                    this.Hide();
                }
                else if (result != null && result.status == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result != null && result.status == LoginStatus.eksikParametre)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void lbl_sifremiuuttum_Click(object sender, EventArgs e)
        {
            SifreDegistirme SD = new SifreDegistirme();
            SD.Show();
            this.Hide();
        } 
    }
}
