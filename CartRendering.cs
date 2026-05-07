using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SweetBeanHomeScreen
{
    public partial class CartRendering : UserControl
    {
        public bool delivery = false;
        public CartRendering()
        {
            InitializeComponent();
            cartItemsListView.Columns.Add("Product", 120);
            cartItemsListView.Columns.Add("Size", 50);
            cartItemsListView.Columns.Add("Add-Ons", 175);
            cartItemsListView.Columns.Add("Qty", 40);
            cartItemsListView.Columns.Add("Price", 50);
        }

        private void GenerateList()
        {
            cartItemsListView.Items.Clear();

            foreach(var item in Cart.Items)
            {
                ListViewItem row = new ListViewItem(item.ProductName);
                row.SubItems.Add(item.Size);
                row.SubItems.Add(string.Join(", ", item.AddOns));
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add(item.TotalPrice.ToString("C"));

                cartItemsListView.Items.Add(row);
                
            }

        }

        private void CartRendering_Load(object sender, EventArgs e)
        {
            GenerateList();
            GetOrderTotal();
        }

        private decimal DeliveryRate()
        {
            if (deliveryRadioButton.Checked)
            {
                feeLabel.Text = "$5.00";
                return 5.0M;
            }

            return 0.0M;
        }

        private decimal GenerateTaxesGST()
        {
            decimal gst = 0.0M;
            
            foreach(var item in Cart.Items)
            {
                gst += item.TotalPrice * 0.05M;

            }
            return gst;

        }

        private decimal GenerateTaxesQST()
        {
            decimal qst = 0.0M;
            
            foreach (var item in Cart.Items)
            {
                qst += item.TotalPrice * 0.09M;

            }
            return qst;
        }

        private decimal GetOrderTotal()
        {
            decimal gst = GenerateTaxesGST();
            decimal qst = GenerateTaxesQST();
            decimal delivery = DeliveryRate();

            decimal totalPrice = 0.0M;

            foreach(var item in Cart.Items)
            {
                totalPrice += item.TotalPrice;
            }

            totalPrice += gst + qst + delivery;

            feeLabel.Text = $"{delivery:C}";
            gstLabel.Text = $"{gst:C}";
            qstLabel.Text = $"{qst:C}";
            totalDisplayLabel.Text = $"{totalPrice:C}";

            return totalPrice;
        }

        private void deliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GetOrderTotal();
            delivery = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(cartItemsListView.SelectedItems.Count > 0)
            {
                var selected = cartItemsListView.SelectedItems[0];

                var cartItem = Cart.Items[selected.Index];
                Cart.Items.Remove(cartItem);

                cartItemsListView.Items.Remove(selected);
                GetOrderTotal();
            }
        }
    }
}
