using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoeduSam
{
    public partial class AddProductForm : Form
    {
        public bool isCreate = true;
        private bool isActive = false;
        public string ProdName = "";
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isActive = !isActive;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            AllProducts products = new AllProducts();
            this.Close();
            products.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(ProductName.Text.Trim() == "" || ProductDescription.Text.Trim() == "")
                {
                    MessageBox.Show("Заполните все поля");
                }
                else
                {
                    using (DoeduSamEntities1 context = new DoeduSamEntities1())
                    {
                        if(isCreate)
                        {
                            Product product = new Product
                            {
                                Title = ProductName.Text,
                                Cost = decimal.Parse(ProductCoast.Text),
                                Description = ProductDescription.Text,
                                MainImagePath = "path",
                                IsActive = isActive,
                                ManufacturerID = 1
                            };

                            context.Product.Add(product);
                            context.SaveChanges();
                        } 
                        else
                        {
                            var SelectedProduct = context.Product.First((product) => product.Title == ProdName);
                            
                        }
                    }
                    MessageBox.Show("Продукт добавлен");
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Ошибка! Продукт не добавлен" + ex.ToString());
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            if(isCreate == false)
            {
                using (DoeduSamEntities1 context = new DoeduSamEntities1())
                {
                    try
                    {
                        var SelectedProduct = context.Product.First((product) => product.Title == ProdName);
                        MessageBox.Show(SelectedProduct.ID.ToString());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Товар не найден");
                    }
                }
            }
        }
    }
}
