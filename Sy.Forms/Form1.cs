﻿using Sy.Forms.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Sy.Forms.Auth;
using Sy.Business.Repository;
using Sy.Core.Entities;
using Sy.Core.ComplexTypes;
using Sy.Core.Enums;

namespace Sy.Forms
{
    public partial class Form1 : Form

    {
        private Repository<Product, Guid> _productRepo;

        public Form1()
        {
            InitializeComponent();
            _productRepo = new Repository<Product, Guid>();
            gbGiris.Visible = true;
            lblGirisBilgi.Visible = false;
            menuStrip1.Visible = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            if (StockSettings.UserInfo == null)
            {
                gbGiris.Visible = true;
                lblGirisBilgi.Visible = false;

                    
            }
            else
            {
                gbGiris.Visible = false;
                lblGirisBilgi.Visible = true;
                lblGirisBilgi.Text = StockSettings.UserInfo.Display;
                menuStrip1.Visible = true;
                if (StockSettings.UserInfo.ApplicationRole == ApplicationRole.Customer)
                {

                    ürünlerToolStripMenuItem.Visible = false;
                    müşterilerToolStripMenuItem.Visible = false; // ürünler ve müşteriler kısmını customerler göremesin
                }
            }
        }
         

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();
        }

        private void siparişlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderForm frm = new OrderForm();
            frm.Show();
        }
    }
}
