namespace market
{
    partial class KasiyerPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerPanel));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_sebzemeyve = new System.Windows.Forms.Button();
            this.btn_baklagil = new System.Windows.Forms.Button();
            this.btnEt = new System.Windows.Forms.Button();
            this.btn_sut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "baklagil.jpeg");
            this.ımageList1.Images.SetKeyName(1, "et.jpeg");
            this.ımageList1.Images.SetKeyName(2, "süt.jpeg");
            this.ımageList1.Images.SetKeyName(3, "meyvesebze.jpeg");
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(465, 9);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(30, 16);
            this.lbl_saat.TabIndex = 5;
            this.lbl_saat.Text = "00 : ";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(487, 9);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(27, 16);
            this.lbl_dakika.TabIndex = 6;
            this.lbl_dakika.Text = "00 :";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(510, 9);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(21, 16);
            this.lbl_saniye.TabIndex = 7;
            this.lbl_saniye.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Honeydew;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.ForeColor = System.Drawing.Color.Green;
            this.btn_cikis.Image = global::market.Properties.Resources.exit;
            this.btn_cikis.Location = new System.Drawing.Point(468, 347);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(102, 44);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_sebzemeyve
            // 
            this.btn_sebzemeyve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sebzemeyve.ImageIndex = 3;
            this.btn_sebzemeyve.ImageList = this.ımageList1;
            this.btn_sebzemeyve.Location = new System.Drawing.Point(275, 225);
            this.btn_sebzemeyve.Name = "btn_sebzemeyve";
            this.btn_sebzemeyve.Size = new System.Drawing.Size(187, 146);
            this.btn_sebzemeyve.TabIndex = 3;
            this.btn_sebzemeyve.UseVisualStyleBackColor = true;
            this.btn_sebzemeyve.Click += new System.EventHandler(this.btn_sebzemeyve_Click);
            // 
            // btn_baklagil
            // 
            this.btn_baklagil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_baklagil.ImageIndex = 0;
            this.btn_baklagil.ImageList = this.ımageList1;
            this.btn_baklagil.Location = new System.Drawing.Point(43, 225);
            this.btn_baklagil.Name = "btn_baklagil";
            this.btn_baklagil.Size = new System.Drawing.Size(181, 146);
            this.btn_baklagil.TabIndex = 2;
            this.btn_baklagil.UseVisualStyleBackColor = true;
            this.btn_baklagil.Click += new System.EventHandler(this.btn_baklagil_Click);
            // 
            // btnEt
            // 
            this.btnEt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEt.ImageKey = "et.jpeg";
            this.btnEt.ImageList = this.ımageList1;
            this.btnEt.Location = new System.Drawing.Point(43, 43);
            this.btnEt.Name = "btnEt";
            this.btnEt.Size = new System.Drawing.Size(181, 145);
            this.btnEt.TabIndex = 0;
            this.btnEt.UseVisualStyleBackColor = true;
            this.btnEt.Click += new System.EventHandler(this.btnEt_Click);
            // 
            // btn_sut
            // 
            this.btn_sut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sut.ImageKey = "süt.jpeg";
            this.btn_sut.ImageList = this.ımageList1;
            this.btn_sut.Location = new System.Drawing.Point(278, 43);
            this.btn_sut.Name = "btn_sut";
            this.btn_sut.Size = new System.Drawing.Size(182, 145);
            this.btn_sut.TabIndex = 1;
            this.btn_sut.UseVisualStyleBackColor = true;
            this.btn_sut.Click += new System.EventHandler(this.btn_sut_Click);
            // 
            // KasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_sebzemeyve);
            this.Controls.Add(this.btn_baklagil);
            this.Controls.Add(this.btnEt);
            this.Controls.Add(this.btn_sut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KasiyerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasiyerPanel";
            this.Load += new System.EventHandler(this.KasiyerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sut;
        private System.Windows.Forms.Button btnEt;
        private System.Windows.Forms.Button btn_baklagil;
        private System.Windows.Forms.Button btn_sebzemeyve;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer1;
    }
}