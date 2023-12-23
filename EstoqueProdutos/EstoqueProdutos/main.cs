using EstoqueProdutos.screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueProdutos
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnProductsScreen_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            productsScreen prodScreen = new productsScreen();
            prodScreen.TopLevel = false;
            prodScreen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(prodScreen);
            prodScreen.Show();
        }

        private void btnAddScreen_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            addProductScreen addProdScreen = new addProductScreen();
            addProdScreen.TopLevel = false;
            addProdScreen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(addProdScreen);
            addProdScreen.Show();
        }

        private void btnUpdateScreen_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            updateProductScreen updateProdScreen = new updateProductScreen();
            updateProdScreen.TopLevel = false;
            updateProdScreen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(updateProdScreen);
            updateProdScreen.Show();
        }
    }
}
