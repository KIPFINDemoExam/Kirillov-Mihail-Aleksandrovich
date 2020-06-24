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
    public partial class Story : Form
    {
        public Story()
        {
            InitializeComponent();
        }

        private void Story_Load(object sender, EventArgs e)
        {
            StoryList.View = View.Details;

            StoryList.Columns.Add("Название", 20);
            StoryList.Columns.Add("Дата продажи", 20);
            StoryList.Columns.Add("Количество", 20);
        }

        private void ReturnToProductsList_Click(object sender, EventArgs e)
        {
            AllProducts allProducts = new AllProducts();
            this.Close();
            allProducts.Show();
        }
    }
}
