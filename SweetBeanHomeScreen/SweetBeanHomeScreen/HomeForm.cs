using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SweetBeanHomeScreen
{
    public partial class HomeForm : SweetBeanBase.BaseForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productsDataSet);

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.productsDataSet.Items);

        }

        private void hotButton_Click(object sender, EventArgs e)
        {
            LoadHotDrinks();
        }

        private void LoadHotDrinks()
        {
            flowLayoutPanel1.Controls.Clear();

            itemsBindingSource.Filter = "productType = 'Hot'";

            foreach (DataRowView rowView in itemsBindingSource)
            {
                string name = rowView["productName"].ToString();
                decimal price = Convert.ToDecimal(rowView["productPrice"]);
                string size = rowView["productSize"].ToString();
                MenuItem menuItem = new MenuItem();

                menuItem.SetData(name, price, size, GetItemImage(name));
                flowLayoutPanel1.Controls.Add(menuItem);
            }
            
        }

        private void LoadColdDrinks()
        {
            flowLayoutPanel1.Controls.Clear();

            itemsBindingSource.Filter = "productType = 'Cold'";

            foreach (DataRowView rowView in itemsBindingSource)
            {
                string name = rowView["productName"].ToString();
                decimal price = Convert.ToDecimal(rowView["productPrice"]);
                string size = rowView["productSize"].ToString();
                MenuItem menuItem = new MenuItem();

                menuItem.SetData(name, price, size, GetItemImage(name));
                flowLayoutPanel1.Controls.Add(menuItem);
            }
        }

        private Image GetItemImage(string name)
        {
            switch (name)
            {
                case "Matcha":
                    return Properties.Resources.matcha;

                case "Iced Latte":
                    return Properties.Resources.iced;

                default:
                    return null;
            }
        }

        private void coldButton_Click(object sender, EventArgs e)
        {
            LoadColdDrinks();
        }
    }
}


