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
    public partial class AllProducts : Form
    {
        public AllProducts()
        {
            InitializeComponent();
        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            using(DoeduSamEntities1 context = new DoeduSamEntities1())
            {
                var products = context.Product;
                foreach(Product product in products)
                {
                    Panel ProductCard = new Panel
                    {
                        Width = 100,
                        Height = 100,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    Label ProductTitle = new Label
                    {
                        Text = product.Title,
                        Top = 25
                    };
                    Label ProductCoast = new Label
                    {
                        Text = product.Cost.ToString(),
                        Top = 50
                    };

                    ProductTitle.Parent = ProductCard;
                    ProductCoast.Parent = ProductCard;

                    ProductCard.Parent = AllProductsPanel;
                    ProductTitle.Click += new EventHandler(ShowProductInfo);
                }
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm();

            addProduct.isCreate = true;
            this.Hide();
            addProduct.Show();
        }

        private void ShowProductInfo(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            AddProductForm addProduct = new AddProductForm();
            addProduct.isCreate = false;
            addProduct.ProdName = label.Text;
            this.Hide();
            addProduct.Show();
        }
    }
}
