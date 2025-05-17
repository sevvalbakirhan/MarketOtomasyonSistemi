namespace market
{
    partial class KullaniciPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kayitGüncelle = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.lbl_güvenlikSorusu = new System.Windows.Forms.Label();
            this.lbl_Bolge = new System.Windows.Forms.Label();
            this.lbl_Yetki = new System.Windows.Forms.Label();
            this.cmb_güvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.cmb_bölge = new System.Windows.Forms.ComboBox();
            this.cmb_yetki = new System.Windows.Forms.ComboBox();
            this.txt_güvenlikCevabi = new System.Windows.Forms.TextBox();
            this.lbl_güvenlikCevabi = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_emailAdres = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.btn_geri);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.txt_kullaniciAdi);
            this.groupBox1.Controls.Add(this.lbl_KullaniciAdi);
            this.groupBox1.Controls.Add(this.btn_kayitSil);
            this.groupBox1.Controls.Add(this.btn_kayitGüncelle);
            this.groupBox1.Controls.Add(this.btn_kayitEkle);
            this.groupBox1.Controls.Add(this.lbl_güvenlikSorusu);
            this.groupBox1.Controls.Add(this.lbl_Bolge);
            this.groupBox1.Controls.Add(this.lbl_Yetki);
            this.groupBox1.Controls.Add(this.cmb_güvenlikSorusu);
            this.groupBox1.Controls.Add(this.cmb_bölge);
            this.groupBox1.Controls.Add(this.cmb_yetki);
            this.groupBox1.Controls.Add(this.txt_güvenlikCevabi);
            this.groupBox1.Controls.Add(this.lbl_güvenlikCevabi);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.lbl_emailAdres);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.lbl_Sifre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(2, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Panel";
            // 
            // btn_kayitGüncelle
            // 
            this.btn_kayitGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitGüncelle.Location = new System.Drawing.Point(196, 208);
            this.btn_kayitGüncelle.Name = "btn_kayitGüncelle";
            this.btn_kayitGüncelle.Size = new System.Drawing.Size(160, 23);
            this.btn_kayitGüncelle.TabIndex = 9;
            this.btn_kayitGüncelle.Text = "Kayıt Güncelle ";
            this.btn_kayitGüncelle.UseVisualStyleBackColor = true;
            this.btn_kayitGüncelle.Click += new System.EventHandler(this.btn_kayitGüncelle_Click);
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitEkle.Location = new System.Drawing.Point(303, 179);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(160, 23);
            this.btn_kayitEkle.TabIndex = 8;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.UseVisualStyleBackColor = true;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // lbl_güvenlikSorusu
            // 
            this.lbl_güvenlikSorusu.AutoSize = true;
            this.lbl_güvenlikSorusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_güvenlikSorusu.Location = new System.Drawing.Point(392, 110);
            this.lbl_güvenlikSorusu.Name = "lbl_güvenlikSorusu";
            this.lbl_güvenlikSorusu.Size = new System.Drawing.Size(127, 16);
            this.lbl_güvenlikSorusu.TabIndex = 3;
            this.lbl_güvenlikSorusu.Text = "Güvenlik Sorusu :";
            // 
            // lbl_Bolge
            // 
            this.lbl_Bolge.AutoSize = true;
            this.lbl_Bolge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Bolge.Location = new System.Drawing.Point(392, 38);
            this.lbl_Bolge.Name = "lbl_Bolge";
            this.lbl_Bolge.Size = new System.Drawing.Size(60, 16);
            this.lbl_Bolge.TabIndex = 3;
            this.lbl_Bolge.Text = "Bölge : ";
            // 
            // lbl_Yetki
            // 
            this.lbl_Yetki.AutoSize = true;
            this.lbl_Yetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yetki.Location = new System.Drawing.Point(36, 153);
            this.lbl_Yetki.Name = "lbl_Yetki";
            this.lbl_Yetki.Size = new System.Drawing.Size(54, 16);
            this.lbl_Yetki.TabIndex = 3;
            this.lbl_Yetki.Text = "Yetki : ";
            // 
            // cmb_güvenlikSorusu
            // 
            this.cmb_güvenlikSorusu.FormattingEnabled = true;
            this.cmb_güvenlikSorusu.Location = new System.Drawing.Point(541, 110);
            this.cmb_güvenlikSorusu.Name = "cmb_güvenlikSorusu";
            this.cmb_güvenlikSorusu.Size = new System.Drawing.Size(215, 24);
            this.cmb_güvenlikSorusu.TabIndex = 6;
            // 
            // cmb_bölge
            // 
            this.cmb_bölge.FormattingEnabled = true;
            this.cmb_bölge.Location = new System.Drawing.Point(541, 38);
            this.cmb_bölge.Name = "cmb_bölge";
            this.cmb_bölge.Size = new System.Drawing.Size(215, 24);
            this.cmb_bölge.TabIndex = 4;
            // 
            // cmb_yetki
            // 
            this.cmb_yetki.FormattingEnabled = true;
            this.cmb_yetki.Location = new System.Drawing.Point(139, 145);
            this.cmb_yetki.Name = "cmb_yetki";
            this.cmb_yetki.Size = new System.Drawing.Size(184, 24);
            this.cmb_yetki.TabIndex = 3;
            // 
            // txt_güvenlikCevabi
            // 
            this.txt_güvenlikCevabi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_güvenlikCevabi.Location = new System.Drawing.Point(541, 147);
            this.txt_güvenlikCevabi.Name = "txt_güvenlikCevabi";
            this.txt_güvenlikCevabi.Size = new System.Drawing.Size(215, 22);
            this.txt_güvenlikCevabi.TabIndex = 7;
            // 
            // lbl_güvenlikCevabi
            // 
            this.lbl_güvenlikCevabi.AutoSize = true;
            this.lbl_güvenlikCevabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_güvenlikCevabi.Location = new System.Drawing.Point(392, 153);
            this.lbl_güvenlikCevabi.Name = "lbl_güvenlikCevabi";
            this.lbl_güvenlikCevabi.Size = new System.Drawing.Size(132, 16);
            this.lbl_güvenlikCevabi.TabIndex = 0;
            this.lbl_güvenlikCevabi.Text = "Güvenlik Cevabı : ";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(541, 72);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(215, 22);
            this.txt_email.TabIndex = 5;
            // 
            // lbl_emailAdres
            // 
            this.lbl_emailAdres.AutoSize = true;
            this.lbl_emailAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_emailAdres.Location = new System.Drawing.Point(392, 72);
            this.lbl_emailAdres.Name = "lbl_emailAdres";
            this.lbl_emailAdres.Size = new System.Drawing.Size(103, 16);
            this.lbl_emailAdres.TabIndex = 0;
            this.lbl_emailAdres.Text = "Email Adres : ";
            // 
            // txt_sifre
            // 
            this.txt_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sifre.Location = new System.Drawing.Point(139, 112);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(184, 22);
            this.txt_sifre.TabIndex = 2;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.Location = new System.Drawing.Point(36, 115);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(51, 16);
            this.lbl_Sifre.TabIndex = 0;
            this.lbl_Sifre.Text = "Şifre : ";
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitSil.Location = new System.Drawing.Point(395, 208);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(160, 23);
            this.btn_kayitSil.TabIndex = 10;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = true;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(142, 76);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(181, 22);
            this.txt_kullaniciAdi.TabIndex = 1;
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(36, 76);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(100, 16);
            this.lbl_KullaniciAdi.TabIndex = 11;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Location = new System.Drawing.Point(142, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(181, 22);
            this.txt_id.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_id.Location = new System.Drawing.Point(36, 38);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(22, 16);
            this.lbl_id.TabIndex = 13;
            this.lbl_id.Text = "İD";
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = global::market.Properties.Resources.back;
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_geri.Location = new System.Drawing.Point(10, 197);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(57, 46);
            this.btn_geri.TabIndex = 14;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // KullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullaniciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciPanel";
            this.Load += new System.EventHandler(this.KullaniciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.Label lbl_Yetki;
        private System.Windows.Forms.ComboBox cmb_yetki;
        private System.Windows.Forms.Button btn_kayitGüncelle;
        private System.Windows.Forms.Label lbl_güvenlikSorusu;
        private System.Windows.Forms.Label lbl_Bolge;
        private System.Windows.Forms.ComboBox cmb_güvenlikSorusu;
        private System.Windows.Forms.ComboBox cmb_bölge;
        private System.Windows.Forms.TextBox txt_güvenlikCevabi;
        private System.Windows.Forms.Label lbl_güvenlikCevabi;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_emailAdres;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Button btn_geri;
    }
}