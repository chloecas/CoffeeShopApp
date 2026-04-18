using System; 
using System.Drawing;
using System.Windows.Forms;

namespace SweetBeanHomeScreen
{
    public partial class MenuItem : UserControl
    {
        public MenuItem()
        {
            InitializeComponent();
        }

        public void SetData(string name, decimal price, string size, Image img)
        {
            nameLabel.Text = name;
            priceLabel.Text = "$" + price.ToString();
            sizeLabel.Text = size;
            itemPictureBox.Image = img;
        }
    }
}
