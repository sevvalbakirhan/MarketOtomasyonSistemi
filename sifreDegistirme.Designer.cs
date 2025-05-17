namespace market
{
    partial class SifreDegistirme
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
            this.grpBox_güvenliksorusu = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.cmbGuvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_güvenlikCevabi = new System.Windows.Forms.TextBox();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_sifreDegistirmeAlani = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_yeniSifreTkr = new System.Windows.Forms.TextBox();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBox_mailAlani = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_emailAdres = new System.Windows.Forms.TextBox();
            this.btn_dogrulamaKoduGönder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dogrulamaKodu = new System.Windows.Forms.TextBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.grpBox_güvenliksorusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBox_sifreDegistirmeAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grpBox_mailAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_güvenliksorusu
            // 
            this.grpBox_güvenliksorusu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpBox_güvenliksorusu.Controls.Add(this.pictureBox4);
            this.grpBox_güvenliksorusu.Controls.Add(this.pictureBox1);
            this.grpBox_güvenliksorusu.Controls.Add(this.btn_geri);
            this.grpBox_güvenliksorusu.Controls.Add(this.cmbGuvenlikSorusu);
            this.grpBox_güvenliksorusu.Controls.Add(this.label3);
            this.grpBox_güvenliksorusu.Controls.Add(this.txt_güvenlikCevabi);
            this.grpBox_güvenliksorusu.Controls.Add(this.btn_sorgula);
            this.grpBox_güvenliksorusu.Controls.Add(this.label2);
            this.grpBox_güvenliksorusu.Controls.Add(this.txt_kullaniciAdi);
            this.grpBox_güvenliksorusu.Controls.Add(this.label1);
            this.grpBox_güvenliksorusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBox_güvenliksorusu.Location = new System.Drawing.Point(0, -1);
            this.grpBox_güvenliksorusu.Name = "grpBox_güvenliksorusu";
            this.grpBox_güvenliksorusu.Size = new System.Drawing.Size(357, 273);
            this.grpBox_güvenliksorusu.TabIndex = 0;
            this.grpBox_güvenliksorusu.TabStop = false;
            this.grpBox_güvenliksorusu.Text = "Güvenlik Sorusu ile Değiştir";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::market.Properties.Resources.back;
            this.pictureBox4.Location = new System.Drawing.Point(100, 185);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::market.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(219, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_geri
            // 
            this.btn_geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geri.Location = new System.Drawing.Point(3, 185);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(104, 33);
            this.btn_geri.TabIndex = 6;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbGuvenlikSorusu
            // 
            this.cmbGuvenlikSorusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuvenlikSorusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGuvenlikSorusu.FormattingEnabled = true;
            this.cmbGuvenlikSorusu.Location = new System.Drawing.Point(113, 98);
            this.cmbGuvenlikSorusu.Name = "cmbGuvenlikSorusu";
            this.cmbGuvenlikSorusu.Size = new System.Drawing.Size(166, 24);
            this.cmbGuvenlikSorusu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik Cevabı :";
            // 
            // txt_güvenlikCevabi
            // 
            this.txt_güvenlikCevabi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_güvenlikCevabi.Location = new System.Drawing.Point(122, 150);
            this.txt_güvenlikCevabi.Name = "txt_güvenlikCevabi";
            this.txt_güvenlikCevabi.Size = new System.Drawing.Size(166, 22);
            this.txt_güvenlikCevabi.TabIndex = 2;
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_sorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sorgula.Location = new System.Drawing.Point(6, 215);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(342, 27);
            this.btn_sorgula.TabIndex = 3;
            this.btn_sorgula.Text = "Sorgula";
            this.btn_sorgula.UseVisualStyleBackColor = false;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik Sorusu :";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(113, 59);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(166, 22);
            this.txt_kullaniciAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // grpBox_sifreDegistirmeAlani
            // 
            this.grpBox_sifreDegistirmeAlani.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.pictureBox3);
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.btn_degistir);
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.label8);
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.txt_yeniSifreTkr);
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.txt_yeniSifre);
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.label7);
            this.grpBox_sifreDegistirmeAlani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBox_sifreDegistirmeAlani.Location = new System.Drawing.Point(0, 268);
            this.grpBox_sifreDegistirmeAlani.Name = "grpBox_sifreDegistirmeAlani";
            this.grpBox_sifreDegistirmeAlani.Size = new System.Drawing.Size(749, 169);
            this.grpBox_sifreDegistirmeAlani.TabIndex = 2;
            this.grpBox_sifreDegistirmeAlani.TabStop = false;
            this.grpBox_sifreDegistirmeAlani.Text = "Şifre Değiştirme Alanı";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.Image = global::market.Properties.Resources.keychange;
            this.pictureBox3.Location = new System.Drawing.Point(423, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btn_degistir
            // 
            this.btn_degistir.BackColor = System.Drawing.Color.DarkGray;
            this.btn_degistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_degistir.Location = new System.Drawing.Point(238, 119);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(285, 27);
            this.btn_degistir.TabIndex = 2;
            this.btn_degistir.Text = "Değiştir";
            this.btn_degistir.UseVisualStyleBackColor = false;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Yeni Şifre Tekrar :";
            // 
            // txt_yeniSifreTkr
            // 
            this.txt_yeniSifreTkr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yeniSifreTkr.Location = new System.Drawing.Point(357, 80);
            this.txt_yeniSifreTkr.Name = "txt_yeniSifreTkr";
            this.txt_yeniSifreTkr.Size = new System.Drawing.Size(166, 22);
            this.txt_yeniSifreTkr.TabIndex = 1;
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yeniSifre.Location = new System.Drawing.Point(357, 48);
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.Size = new System.Drawing.Size(166, 22);
            this.txt_yeniSifre.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Yeni Şifre :";
            // 
            // grpBox_mailAlani
            // 
            this.grpBox_mailAlani.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpBox_mailAlani.Controls.Add(this.pictureBox2);
            this.grpBox_mailAlani.Controls.Add(this.lbl_email);
            this.grpBox_mailAlani.Controls.Add(this.txt_emailAdres);
            this.grpBox_mailAlani.Controls.Add(this.btn_dogrulamaKoduGönder);
            this.grpBox_mailAlani.Controls.Add(this.label6);
            this.grpBox_mailAlani.Controls.Add(this.txt_dogrulamaKodu);
            this.grpBox_mailAlani.Controls.Add(this.btn_onayla);
            this.grpBox_mailAlani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBox_mailAlani.Location = new System.Drawing.Point(357, -1);
            this.grpBox_mailAlani.Name = "grpBox_mailAlani";
            this.grpBox_mailAlani.Size = new System.Drawing.Size(386, 273);
            this.grpBox_mailAlani.TabIndex = 3;
            this.grpBox_mailAlani.TabStop = false;
            this.grpBox_mailAlani.Text = "Mail Alanı";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Image = global::market.Properties.Resources.correct;
            this.pictureBox2.Location = new System.Drawing.Point(209, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(6, 59);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(108, 16);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = " Email Adresiniz :";
            // 
            // txt_emailAdres
            // 
            this.txt_emailAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_emailAdres.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_emailAdres.Location = new System.Drawing.Point(120, 56);
            this.txt_emailAdres.Name = "txt_emailAdres";
            this.txt_emailAdres.Size = new System.Drawing.Size(239, 22);
            this.txt_emailAdres.TabIndex = 0;
            // 
            // btn_dogrulamaKoduGönder
            // 
            this.btn_dogrulamaKoduGönder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_dogrulamaKoduGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dogrulamaKoduGönder.Location = new System.Drawing.Point(6, 101);
            this.btn_dogrulamaKoduGönder.Name = "btn_dogrulamaKoduGönder";
            this.btn_dogrulamaKoduGönder.Size = new System.Drawing.Size(353, 30);
            this.btn_dogrulamaKoduGönder.TabIndex = 1;
            this.btn_dogrulamaKoduGönder.Text = "Doğrulama Kodu Gönder";
            this.btn_dogrulamaKoduGönder.UseVisualStyleBackColor = false;
            this.btn_dogrulamaKoduGönder.Click += new System.EventHandler(this.btn_dogrulamaKoduGönder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doğrulama Kodu :";
            // 
            // txt_dogrulamaKodu
            // 
            this.txt_dogrulamaKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dogrulamaKodu.Location = new System.Drawing.Point(126, 170);
            this.txt_dogrulamaKodu.Name = "txt_dogrulamaKodu";
            this.txt_dogrulamaKodu.Size = new System.Drawing.Size(116, 22);
            this.txt_dogrulamaKodu.TabIndex = 2;
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onayla.Location = new System.Drawing.Point(0, 215);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(370, 27);
            this.btn_onayla.TabIndex = 3;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = false;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 498);
            this.Controls.Add(this.grpBox_mailAlani);
            this.Controls.Add(this.grpBox_sifreDegistirmeAlani);
            this.Controls.Add(this.grpBox_güvenliksorusu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştirme Ekranı";
            this.Load += new System.EventHandler(this.SifreDegistirme_Load);
            this.grpBox_güvenliksorusu.ResumeLayout(false);
            this.grpBox_güvenliksorusu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBox_sifreDegistirmeAlani.ResumeLayout(false);
            this.grpBox_sifreDegistirmeAlani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grpBox_mailAlani.ResumeLayout(false);
            this.grpBox_mailAlani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_güvenliksorusu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.TextBox txt_güvenlikCevabi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.ComboBox cmbGuvenlikSorusu;
        private System.Windows.Forms.GroupBox grpBox_sifreDegistirmeAlani;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_yeniSifreTkr;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.GroupBox grpBox_mailAlani;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_emailAdres;
        private System.Windows.Forms.Button btn_dogrulamaKoduGönder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dogrulamaKodu;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}