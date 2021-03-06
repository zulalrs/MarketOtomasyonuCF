﻿using Market.BLL.HazirData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private UrunSatis urunSatis;
        public MalKabul malKabul;
        private Rapor rapor;

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urunSatis == null || urunSatis.IsDisposed)
            {
                urunSatis = new UrunSatis
                {
                    MdiParent = this,
                };
                urunSatis.Show();
            }
            else urunSatis.Activate();
        }

        private void malKabulİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (malKabul == null || malKabul.IsDisposed)
            {
                malKabul = new MalKabul
                {
                    MdiParent = this
                };
                malKabul.Show();
            }
            else malKabul.Activate();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            new HazirData().VeriUret();
        }

        private void raporİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rapor == null || rapor.IsDisposed)
            {
                rapor = new Rapor
                {
                    MdiParent = this

                };
                rapor.Show();
                //malKabul.Dispose();
            }
            else rapor.Activate();
            //else rapor.Dispose();
        }
    }
}
