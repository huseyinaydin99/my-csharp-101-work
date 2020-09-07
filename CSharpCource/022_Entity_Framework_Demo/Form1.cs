using _022_Entity_Framework_Demo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_Entity_Framework_Demo
{
    public partial class Form1 : Form
    {
        private ProductDal productDal { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.productDal = new ProductDal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = productDal.GetAll();
        }

        private void SearchProducts(string key)
        {
            //var result = productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
            var result = productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = decimal.Parse(tbxUnitPrice.Text),
                StockAmount = int.Parse(tbxStockAmount.Text)
            }))
            {
                MessageBox.Show("Kayıt işlemi başarılı");
                LoadProducts();
            }
            else
                MessageBox.Show("Kayıt işlemi başarısız");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (productDal.Update(new Product
            {
                Name = tbxNameUpdate.Text,
                UnitPrice = decimal.Parse(tbxUnitPriceUpdate.Text),
                StockAmount = int.Parse(tbxStockAmountUpdate.Text)
            }))
            {
                MessageBox.Show("Güncelleme işlemi başarılı");
                LoadProducts();
            }
            else
                MessageBox.Show("Güncelleme işlemi başarısız");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productDal.Delete(new Product
            {
                Id = int.Parse(dgwProducts.CurrentRow.Cells[0].Value.ToString())
            }))
            {
                MessageBox.Show("Silme işlemi başarılı");
                LoadProducts();
            }
            else
                MessageBox.Show("Silme işlemi başarısız");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            productDal.GetById(100);
        }
    }
}
