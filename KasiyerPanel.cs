﻿using System;
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
    public partial class KasiyerPanel : Form
    {
        public KasiyerPanel()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString() + "  :";
            lbl_dakika.Text = DateTime.Now.Minute.ToString() + "  :";
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }

        private void KasiyerPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_sebzemeyve_Click(object sender, EventArgs e)
        {
            MeyveSebzePanel meyveSebzePanel = new MeyveSebzePanel();
            meyveSebzePanel.Show();
            this.Hide();
        }

        private void btnEt_Click(object sender, EventArgs e)
        {
            KasapPanel kasapPanel = new KasapPanel();
            kasapPanel.Show();
            this.Hide();

        }

        private void btn_sut_Click(object sender, EventArgs e)
        {
            SütÜrünleriPanel sütÜrünleriPanel = new SütÜrünleriPanel();
            sütÜrünleriPanel.Show();
            this.Hide();
        }

        private void btn_baklagil_Click(object sender, EventArgs e)
        {
            BaklagilPanel baklagilPanel = new BaklagilPanel();
            baklagilPanel.Show();
            this.Hide();
        }
    }
}
