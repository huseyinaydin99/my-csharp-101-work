using _021_Ado_Net_Demo.Data;
using _021_Ado_Net_Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_Ado_Net_Demo
{
    public partial class Form1 : Form
    {
        private ProductDal _productDal;
        public Form1()
        {
            _productDal = new ProductDal();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product(tbxName.Text, Convert.ToDecimal(tbxUnitPrice.Text), int.Parse(tbxStockAmount.Text));
            if (_productDal.Add(product)) {
                MessageBox.Show("Kayıt işlemi başarılı");
                LoadProducts();
            }
            else
                MessageBox.Show("Kayıt işlemi başarısız");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = int.Parse(dgwProducts.CurrentRow.Cells[0].Value.ToString()),
                Name = tbxNameUpdate.Text,
                StockAmount = int.Parse(tbxStockAmountUpdate.Text),
                UnitPrice = decimal.Parse(tbxUnitPriceUpdate.Text)
            };
            if (_productDal.Update(product))
            {
                MessageBox.Show("Güncelleme işlemi başarılı");
                LoadProducts();
            }
            else
                MessageBox.Show("Güncelleme işlemi başarısız");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_productDal.Delete(int.Parse(dgwProducts.CurrentRow.Cells[0].Value.ToString())))
            {
                MessageBox.Show("Silme işlemi başarılı");
                LoadProducts();
            }
            else
                MessageBox.Show("Silme işlemi başarısız");
        }
    }
}
