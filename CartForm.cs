using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace SweetBeanHomeScreen
{
    public partial class CartForm : Form
    {

        public CartForm()
        {
            InitializeComponent();
       
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            RefreshCart();
        }

        private void RefreshCart()
        {
            var displayList = Cart.Items.Select(item => new
            {
                Size = item.Size,
                AddOns = string.Join(", ", item.AddOns),
                Price = item.TotalPrice,
                Quantity = item.Quantity
            }).ToList();

        }

        private int CreateOrder(int customerId, string orderType)
        {
            decimal subtotal = Cart.Items.Sum(i => i.TotalPrice * i.Quantity);
            decimal total = subtotal;

            var row = sweatBeanDbDataSet1.Orders.NewOrdersRow();

            row.CustomerId = customerId;
            row.OrderType = orderType;
            row.Subtotal = subtotal;
            row.Total = total;
            row.OrderDate = DateTime.Now;
            row.PointsEarned = (int)total;

            sweatBeanDbDataSet1.Orders.Rows.Add(row);
            ordersTableAdapter1.Update(sweatBeanDbDataSet1.Orders);
            return row.OrderId;
        }

        private void SaveOrderItems(int orderId)
        {
            foreach(var item in Cart.Items)
            {
                var row = sweatBeanDbDataSet1.OrderItems.NewOrderItemsRow();

                row.OrderId = orderId;
                row.ProductId = item.ProductID;
                row.SizeId = item.SizeId;
                row.Quantity = item.Quantity;
                row.UnitPrice = item.BasePrice;
                row.LineTotal = item.TotalPrice;

                sweatBeanDbDataSet1.OrderItems.Rows.Add(row);
            }

            orderItemsTableAdapter1.Update(sweatBeanDbDataSet1.OrderItems);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if(Cart.Items.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            string orderType = "";
            try
            {
                if (cartRendering1.delivery)
                {
                    orderType = "Delivery";
                }
                else
                {
                    orderType = "Pick Up";
                }

                int customerId = 1; //placeholder
                int orderId = CreateOrder(customerId, orderType);
                SaveOrderItems(orderId);

                Cart.Items.Clear();
                RefreshCart();

                MessageBox.Show("Order Placed Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
        }
    }
}
