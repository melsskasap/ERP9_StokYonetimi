using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using Sy.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sy.Forms
{
    public partial class ProductForm : Form
    {
        private readonly IRepository<Product, Guid> _productRepo;
        public ProductForm()
        {
            InitializeComponent();
            _productRepo = new Repository <Product, Guid>();
            ListeyiDoldur();
        }


        

        private void ListeyiDoldur(string search ="")
        {
            var data = _productRepo.Query(predicate: x => x.ProductName.Contains(search)).Select(x => new ProductViewModel()
            {
                Id = x.Id,
                UnitPrice = x.UnitPrice,
                CriticStock = x.CriticStock,
                ProductName = x.ProductName

            }).ToList();
            lstUrunler.DataSource = data;
            lstUrunler.DisplayMember = "Display";
        }
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            try
            {
                _productRepo.Insert(new Product()
                {
                    ProductName = txtUrunAdi.Text,
                    UnitPrice = nFiyat.Value,
                    CriticStock = Convert.ToInt32(nKritikStok.Value)
                });
                MessageBox.Show(text: "Ürün Ekleme İşlemi Başarılı..");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            ListeyiDoldur(txtAra.Text);
        }
    }
}
